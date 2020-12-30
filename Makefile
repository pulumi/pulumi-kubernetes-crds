PROJECT := github.com/pulumi/pulumi-kubernetes-crds

ensure::
	cd tools/gen-kubernetes-crds && go mod tidy && go mod download

build::
	cd tools/gen-kubernetes-crds && go build .

generate::
	cd tools/gen-kubernetes-crds && go run . community-operators/ ../../
