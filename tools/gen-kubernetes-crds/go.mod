module github.com/pulumi/pulumi-kubernetes-crds/tools/gen-kubernetes-crds

go 1.14

require (
	github.com/pkg/errors v0.9.1
	github.com/pulumi/crd2pulumi v1.0.4-0.20200909233616-0c9ba6e54fac
	github.com/pulumi/pulumi/pkg/v2 v2.10.1
	github.com/pulumi/pulumi/sdk/v2 v2.9.2
	gopkg.in/yaml.v2 v2.3.0
)

replace github.com/pulumi/crd2pulumi => ../../../crd2pulumi
