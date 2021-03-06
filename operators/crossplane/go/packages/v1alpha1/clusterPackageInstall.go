// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ClusterPackageInstall struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput               `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput               `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput           `pulumi:"metadata"`
	Spec       ClusterPackageInstallSpecPtrOutput   `pulumi:"spec"`
	Status     ClusterPackageInstallStatusPtrOutput `pulumi:"status"`
}

// NewClusterPackageInstall registers a new resource with the given unique name, arguments, and options.
func NewClusterPackageInstall(ctx *pulumi.Context,
	name string, args *ClusterPackageInstallArgs, opts ...pulumi.ResourceOption) (*ClusterPackageInstall, error) {
	if args == nil {
		args = &ClusterPackageInstallArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("packages.crossplane.io/v1alpha1")
	args.Kind = pulumi.StringPtr("ClusterPackageInstall")
	var resource ClusterPackageInstall
	err := ctx.RegisterResource("kubernetes:packages.crossplane.io/v1alpha1:ClusterPackageInstall", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetClusterPackageInstall gets an existing ClusterPackageInstall resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetClusterPackageInstall(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterPackageInstallState, opts ...pulumi.ResourceOption) (*ClusterPackageInstall, error) {
	var resource ClusterPackageInstall
	err := ctx.ReadResource("kubernetes:packages.crossplane.io/v1alpha1:ClusterPackageInstall", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ClusterPackageInstall resources.
type clusterPackageInstallState struct {
	ApiVersion *string                      `pulumi:"apiVersion"`
	Kind       *string                      `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta           `pulumi:"metadata"`
	Spec       *ClusterPackageInstallSpec   `pulumi:"spec"`
	Status     *ClusterPackageInstallStatus `pulumi:"status"`
}

type ClusterPackageInstallState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       ClusterPackageInstallSpecPtrInput
	Status     ClusterPackageInstallStatusPtrInput
}

func (ClusterPackageInstallState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterPackageInstallState)(nil)).Elem()
}

type clusterPackageInstallArgs struct {
	ApiVersion *string                      `pulumi:"apiVersion"`
	Kind       *string                      `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta           `pulumi:"metadata"`
	Spec       *ClusterPackageInstallSpec   `pulumi:"spec"`
	Status     *ClusterPackageInstallStatus `pulumi:"status"`
}

// The set of arguments for constructing a ClusterPackageInstall resource.
type ClusterPackageInstallArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       ClusterPackageInstallSpecPtrInput
	Status     ClusterPackageInstallStatusPtrInput
}

func (ClusterPackageInstallArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterPackageInstallArgs)(nil)).Elem()
}
