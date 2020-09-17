## Building `pulumi-kubernetes-crds`

To auto-generate the libraries for the Kubernetes operators, first clone the `operator-framework/community-operators` repository.

```sh
$ git clone https://github.com/operator-framework/community-operators.git
```

Next, compile and run `main.go` while passing in 2 arguments. The first argument is the path to the `operator-framework/community-operators` repository, and the second argument is the path to the `pulumi/pulumi-kuberntes-crds` repository. For example:

```sh
$ go run . ~/community-operators /Users/albert/go/src/github.com/pulumi/pulumi-kubernetes-crds
```