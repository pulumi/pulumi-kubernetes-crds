package main

import (
	"fmt"
	"github.com/pkg/errors"
	"github.com/pulumi/crd2pulumi/gen"
	"path/filepath"
	"strings"
)

// List of community-operators for which to not generate the code due to issues with the crd generation
var ignorePackages = []string{
	"3scale-community-operator",
	"camel-k",
	"hive-operator",
	"maistraoperator",
	"strimzi-kafka-operator",
	"t8c",
	"tidb-operator",
	"victoriametrics-operator",
}

// Contains a map from operator package names to language-specific names for the package.
// e.g
// "3scale-community-operator": {
//	 "go": "three_scale_community_operator", // Go package names cannot start with numbers
// },
var specialPackageNames = map[string]map[string]string{}

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
	var successCounter int
	var failureCounter int

	for packageName, yamlPaths := range packageToYamlPaths {
		if isIgnoredPackage(packageName) {
			fmt.Println("Skipping generation of " + packageName)
			continue
		}

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

		if languageToSpecialPackageNames, ok := specialPackageNames[packageName]; ok {
			applySpecialPackageNames(&ls, languageToSpecialPackageNames)
		}

		if err := gen.Generate(ls, yamlPaths, true); err == nil {
			successCounter++
		} else {
			fmt.Println("Failed to generate " + packageName + ".")
			failureCounter++
		}
	}

	fmt.Println("--------------")
	fmt.Println(fmt.Sprintf("Found %d operators to convert", len(packageToYamlPaths)))
	fmt.Println(fmt.Sprintf("Successfully converted %d operators", successCounter))
	fmt.Println(fmt.Sprintf("Unable to convert %d operators", failureCounter))
	fmt.Println(fmt.Sprintf("Skipped conversion %d operators", len(ignorePackages)))

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

func isIgnoredPackage(str string) bool {
	for _, a := range ignorePackages {
		if a == str {
			return true
		}
	}
	return false
}
