package main

import (
	"fmt"
	"os"
)

const usage = `must specify at least 2 arguments: the path of the operator-framework/community-operators repo and the
path to the pulumi/pulumi-kubernetes-crds repo. By default all operators will be generated. To generate only specific
operators, pass in the operator package names as additional arguments.
`

func main() {
	if len(os.Args) < 3 {
		fmt.Fprintf(os.Stderr, usage)
		os.Exit(-1)
	}
	communityOperatorsPath := os.Args[1]
	pulumiKubernetesCRDSPath := os.Args[2]

	if len(os.Args) == 3 {
		err := generateAll(communityOperatorsPath, pulumiKubernetesCRDSPath)
		if err != nil {
			fmt.Fprintf(os.Stderr, "error: %v", err)
		}
	}

	packageNames := os.Args[3:]
	err := generateSome(communityOperatorsPath, pulumiKubernetesCRDSPath, packageNames)
	if err != nil {
		fmt.Fprintf(os.Stderr, "error: %v", err)
	}
}
