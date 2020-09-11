package main

import (
	"fmt"
	"os"
)

const usage = `must specify 2 arguments: the path of the operator-framework/community-operators repo and the path to 
the pulumi/pulumi-kubernetes-crds repo
`

func main() {
	if len(os.Args) < 3 {
		fmt.Fprintf(os.Stderr, usage)
		os.Exit(-1)
	}
	repoBasePath := os.Args[1]
	outputPath := os.Args[2]

	err := generate(repoBasePath, outputPath)
	if err != nil {
		fmt.Fprintf(os.Stderr, "error: %v", err)
	}
}
