package main

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/common/util/contract"
	"gopkg.in/yaml.v2"
	"io/ioutil"
	"path/filepath"
	"strings"
)

type PackageInfo struct {
	PackageName string `yaml:"packageName"`
	DefaultChannel string `yaml:"defaultChannel"`
	Channels []Channel `yaml:"channels"`
}

type Channel struct {
	CurrentCSV string `yaml:"currentCSV"`
	Name string `yaml:"name"`
}

// Returns the version strings of the default channel if the default is specified; otherwise returns the version strings
// of the first channel. The first version string removes the first occurrence of "v", and the second version string
// keeps it. Most operators follow a file structure that use the first version string; for example, "api-operator" has
// the channel field currentCSV: api-operator.v1.1.0 and a folder "1.1.0". However, some operator(s) such as
// "konveyor-operator" have the field currentCSV: konveyor-operator.v1.2.1, but only the folder "v1.2.1".
// For example, if we had the following PackageInfo pi:
// packageName: konveyor-operator
// channels:
// - name: release-v1.2
//   currentCSV: konveyor-operator.v1.2.1
// - name: release-v1.1
//   currentCSV: konveyor-operator.v1.1.2
// defaultChannel: release-v1.2
// Then, pi.DefaultInfo() returns "1.2.1", "v1.2.1"
func (pi PackageInfo) DefaultVersion() (string, string) {
	// Extracts the version folder name from a currentCSV string
	getVersion := func(currentCSV string) (string, string) {
		parts := strings.SplitN(currentCSV, ".", 2)
		version1 := strings.Replace(parts[1], "v", "", 1)
		version2 := parts[1]
		return version1, version2
	}

	// Return the version of the default channel, if the default channel is specified
	if pi.DefaultChannel != "" {
		for _, channel := range pi.Channels {
			if channel.Name == pi.DefaultChannel {
				return getVersion(channel.CurrentCSV)
			}
		}
	}

	// If the default channel is not specified, return the version of the first channel
	contract.Assertf(len(pi.Channels) > 0, "package.yaml must contain at least 1 channel")
	return getVersion(pi.Channels[0].CurrentCSV)
}

// Returns the path of the first YAML file found within the given folder path.
func findFirstYAML(path string) (string, error) {
	dir, err := ioutil.ReadDir(path)
	if err != nil {
		return "", err
	}

	for _, file := range dir {
		if extension := filepath.Ext(file.Name()); extension == ".yaml" || extension == ".yml" {
			return filepath.Join(path, file.Name()), nil
		}
	}

	return "", errors.Errorf("could not find any YAML files in %s", path)
}

// Returns a map from every operator's package name to a slice of its YAML CRD paths
func getPackageToYAMLPaths(repoBasePath string) (map[string][]string, error) {
	communityOperatorsPath := filepath.Join(repoBasePath, "community-operators")
	communityOperators, err := ioutil.ReadDir(communityOperatorsPath)
	if err != nil {
		return nil, err
	}

	packageToYamlPaths := map[string][]string{}

	for _, operator := range communityOperators {
		if !operator.IsDir() {
			continue
		}

		operatorPath := filepath.Join(communityOperatorsPath, operator.Name())
		packageInfoPath, err := findFirstYAML(operatorPath)
		if err != nil {
			return nil, err
		}
		packageInfoFile, err := ioutil.ReadFile(packageInfoPath)
		if err != nil {
			return nil, errors.Wrapf(err, "could not read file %s", packageInfoPath)
		}

		var pi PackageInfo
		err = yaml.Unmarshal(packageInfoFile, &pi)
		if err != nil {
			return nil, errors.Wrapf(err, "could not unmarshal file %s", packageInfoPath)
		}

		version1, version2 := pi.DefaultVersion()
		defaultCRDSPath := filepath.Join(operatorPath, version1)
		defaultCRDS, err := ioutil.ReadDir(defaultCRDSPath)
		if err != nil {
			defaultCRDSPath = filepath.Join(operatorPath, version2)
			defaultCRDS, err = ioutil.ReadDir(defaultCRDSPath)
			if err != nil {
				return nil, err
			}
		}

		var yamlPaths []string
		for _, crd := range defaultCRDS {
			yamlPath := filepath.Join(defaultCRDSPath, crd.Name())
			yamlPaths = append(yamlPaths, yamlPath)
		}
		packageToYamlPaths[pi.PackageName] = yamlPaths
	}

	return packageToYamlPaths, nil
}
