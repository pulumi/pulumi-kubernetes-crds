package main

import (
	"fmt"
	"github.com/pulumi/crd2pulumi/gen"
	"path/filepath"
)

// Generates code for all operators across all languages
func generate(repoBasePath string, outputPath string) error {
	gen.Version = "0.0.0"

	packageToYamlPaths, err := getPackageToYAMLPaths(repoBasePath)
	if err != nil {
		return err
	}

	for packageName, yamlPaths := range packageToYamlPaths {
		nodeJSPath := filepath.Join(outputPath, "nodejs", packageName)
		pythonPath := filepath.Join(outputPath, "python", packageName)
		dotnetPath := filepath.Join(outputPath, "dotnet", packageName)
		goPath := filepath.Join(outputPath, "go", packageName)

		ls := gen.LanguageSettings{
			NodeJSPath: &nodeJSPath,
			PythonPath: &pythonPath,
			DotNetPath: &dotnetPath,
			GoPath:     &goPath,
		}

		if err = gen.Generate(ls, yamlPaths, true); err != nil {
			fmt.Println("Successfully generated " + packageName)
		} else {
			fmt.Println("Failed to generate " + packageName)
		}
	}

	return nil
}
