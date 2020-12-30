package main

import (
	"fmt"
	"github.com/pkg/errors"
	"github.com/pulumi/crd2pulumi/gen"
	"path/filepath"
	"strings"
)

// Contains a map from operator package names and the specific languages in which to not generate code for.
var ignorePackages = map[string][]string{
	// Contains hyphened property names, which the Go codegen can't currently handle
	"tidb-operator":            {"go"},
	"strimzi-kafka-operator":   {"go"},
	"victoriametrics-operator": {"go", "dotnet", "nodejs", "python"},
	"t8c":                      {"go"},
	"camel-k":                  {"go"},
	"maistraoperator":          {"go"},
}

// Contains a map from operator package names to language-specific names for the package.
var specialPackageNames = map[string]map[string]string{
	"3scale-community-operator": {
		"go": "three_scale_community_operator", // Go package names cannot start with numbers
	},
}

func applySpecialPackageNames(ls *gen.LanguageSettings, languageToSpecialPackageNames map[string]string) {
	if goName, ok := languageToSpecialPackageNames["go"]; ok {
		ls.GoName = goName
	}
	if dotNetName, ok := languageToSpecialPackageNames["dotnet"]; ok {
		ls.DotNetName = dotNetName
	}
	if pythonName, ok := languageToSpecialPackageNames["python"]; ok {
		ls.PythonName = pythonName
	}
	if nodeJSName, ok := languageToSpecialPackageNames["nodejs"]; ok {
		ls.NodeJSName = nodeJSName
	}
}

func ignoreLanguages(ls *gen.LanguageSettings, languages []string) {
	ignoreLanguage := func(language string) {
		switch language {
		case "go":
			ls.GoPath = nil
			ls.GoName = ""
		case "dotnet":
			ls.DotNetPath = nil
			ls.DotNetName = ""
		case "python":
			ls.PythonPath = nil
			ls.PythonName = ""
		case "nodejs":
			ls.NodeJSPath = nil
			ls.NodeJSName = ""
		}
	}
	for _, language := range languages {
		ignoreLanguage(language)
	}
}

func generateSome(communityOperatorsPath string, pulumiKubernetesCRDSPath string, packageNames []string) error {
	if len(packageNames) == 0 {
		return errors.New("must include at least 1 package name in packageNames")
	}
	packageToYamlPaths, err := getPackageToYamlPaths(communityOperatorsPath, packageNames)
	if err != nil {
		return err
	}
	if err := generate(pulumiKubernetesCRDSPath, packageToYamlPaths); err != nil {
		return err
	}
	return nil
}

func generateAll(communityOperatorsPath string, pulumiKubernetesCRDSPath string) error {
	packageToYamlPaths, err := getAllPackageToYAMLPaths(communityOperatorsPath)
	if err != nil {
		return err
	}
	if err := generate(pulumiKubernetesCRDSPath, packageToYamlPaths); err != nil {
		return err
	}
	return nil
}

// Generates code across all languages (TypeScript, Python, C#, Go) for the given operators. 'packageToYamlPaths' should
// be a mapping from package names to a slice of their corresponding paths of CRD YAML files.
func generate(pulumiKubernetesCRDSPath string, packageToYamlPaths map[string][]string) error {
	gen.Version = "0.0.0"

	for packageName, yamlPaths := range packageToYamlPaths {
		basePath := filepath.Join(pulumiKubernetesCRDSPath, "operators", packageName)
		nodeJSPath := filepath.Join(basePath, "nodejs")
		pythonPath := filepath.Join(basePath, "python")
		dotnetPath := filepath.Join(basePath, "dotnet")
		goPath := filepath.Join(basePath, "go")

		nodeJSName := "@pulumi/kubernetes-crds-operators-" + packageName
		pythonName := "pulumi_kubernetes_crds_operators_" + strings.ReplaceAll(packageName, "-", "_")
		dotNetName := "Pulumi.Kubernetes.Crds.Operators." + getDotNetName(packageName)
		goName := strings.ReplaceAll(packageName, "-", "_")

		ls := gen.LanguageSettings{
			NodeJSPath: &nodeJSPath,
			NodeJSName: nodeJSName,
			PythonPath: &pythonPath,
			PythonName: pythonName,
			DotNetPath: &dotnetPath,
			DotNetName: dotNetName,
			GoPath:     &goPath,
			GoName:     goName,
		}

		if languagesToIgnore, ok := ignorePackages[packageName]; ok {
			ignoreLanguages(&ls, languagesToIgnore)
		}

		if languageToSpecialPackageNames, ok := specialPackageNames[packageName]; ok {
			applySpecialPackageNames(&ls, languageToSpecialPackageNames)
		}

		if err := gen.Generate(ls, yamlPaths, true); err == nil {
		} else {
			fmt.Println("Failed to generate " + packageName + ".")
		}
	}

	return nil
}

// Returns the .NET equivalent of a hyphened package name. For example, getDotNetName("apicast-community-operator")
// returns "ApicastCommunityOperator".
func getDotNetName(name string) string {
	parts := strings.Split(name, "-")
	for i := range parts {
		parts[i] = strings.Title(parts[i])
	}
	return strings.Join(parts, "")
}
