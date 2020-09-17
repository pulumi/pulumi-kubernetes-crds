package main

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/common/util/contract"
	"github.com/pulumi/pulumi/pkg/v2/codegen"
	"gopkg.in/yaml.v2"
	"io/ioutil"
	"path/filepath"
	"strings"
)

// Contains a set of the names of packages that follow a 'v#.#.#' structure of version path names, instead of the
// '#.#.#' structure of most other packages.
var packagesWithV = codegen.NewStringSet(
	"konveyor-operator",
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

// Returns the version of the default channel if the default is specified; otherwise returns the version of the first
// channel. Assumes that 'pi' follows a '#.#.#' structure of version path names.
func (pi PackageInfo) DefaultVersion() string {
	// Extracts the version folder name from a currentCSV string
	getVersion := func(currentCSV string) string {
		parts := strings.SplitN(currentCSV, ".", 2)
		version := strings.Replace(parts[1], "v", "", 1)
		return version
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

// Returns the version of the default channel if the default is specified; otherwise returns the version of the first
// channel. Assumes that 'pi' follows a 'v#.#.#' structure of version path names.
func (pi PackageInfo) DefaultVersionWithV() string {
	getVersionSpecial := func(currentCSV string) string {
		parts := strings.SplitN(currentCSV, ".", 2)
		return parts[1]
	}
	if pi.DefaultChannel != "" {
		for _, channel := range pi.Channels {
			if channel.Name == pi.DefaultChannel {
				return getVersionSpecial(channel.CurrentCSV)
			}
		}
	}
	contract.Assertf(len(pi.Channels) > 0, "package.yaml must contain at least 1 channel")
	return getVersionSpecial(pi.Channels[0].CurrentCSV)
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

// Returns a map from package names to a slice of corresponding YAML CRD paths, given the path to the
// operator-framework/community-operators repository and a slice of package names.
func getPackageToYamlPaths(communityOperatorsPath string, packageNames []string) (map[string][]string, error) {
	communityOperatorsPath = filepath.Join(communityOperatorsPath, "community-operators")

	packageToYamlPaths := map[string][]string{}
	for _, packageName := range packageNames {
		operatorPath := filepath.Join(communityOperatorsPath, packageName)
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

		var version string
		if packagesWithV.Has(pi.PackageName) {
			version = pi.DefaultVersionWithV()
		} else {
			version = pi.DefaultVersion()
		}

		defaultCRDSPath := filepath.Join(operatorPath, version)
		defaultCRDS, err := ioutil.ReadDir(defaultCRDSPath)
		if err != nil {
			return nil, err
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

// Returns a map from every operator's package name to a slice of its YAML CRD paths, given the path to the
// operator-framework/community-operators repository
func getAllPackageToYAMLPaths(communityOperatorsPath string) (map[string][]string, error) {
	communityOperatorsPath = filepath.Join(communityOperatorsPath, "community-operators")
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

		var version string
		if packagesWithV.Has(pi.PackageName) {
			version = pi.DefaultVersionWithV()
		} else {
			version = pi.DefaultVersion()
		}

		defaultCRDSPath := filepath.Join(operatorPath, version)
		defaultCRDS, err := ioutil.ReadDir(defaultCRDSPath)
		if err != nil {
			return nil, err
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
