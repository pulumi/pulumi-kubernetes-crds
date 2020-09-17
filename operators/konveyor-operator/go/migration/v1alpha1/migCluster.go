// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type MigCluster struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	Spec       MigClusterSpecPtrOutput    `pulumi:"spec"`
	Status     MigClusterStatusPtrOutput  `pulumi:"status"`
}

// NewMigCluster registers a new resource with the given unique name, arguments, and options.
func NewMigCluster(ctx *pulumi.Context,
	name string, args *MigClusterArgs, opts ...pulumi.ResourceOption) (*MigCluster, error) {
	if args == nil {
		args = &MigClusterArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("migration.openshift.io/v1alpha1")
	args.Kind = pulumi.StringPtr("MigCluster")
	var resource MigCluster
	err := ctx.RegisterResource("kubernetes:migration.openshift.io/v1alpha1:MigCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMigCluster gets an existing MigCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMigCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MigClusterState, opts ...pulumi.ResourceOption) (*MigCluster, error) {
	var resource MigCluster
	err := ctx.ReadResource("kubernetes:migration.openshift.io/v1alpha1:MigCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MigCluster resources.
type migClusterState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       *MigClusterSpec    `pulumi:"spec"`
	Status     *MigClusterStatus  `pulumi:"status"`
}

type MigClusterState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       MigClusterSpecPtrInput
	Status     MigClusterStatusPtrInput
}

func (MigClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*migClusterState)(nil)).Elem()
}

type migClusterArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       *MigClusterSpec    `pulumi:"spec"`
	Status     *MigClusterStatus  `pulumi:"status"`
}

// The set of arguments for constructing a MigCluster resource.
type MigClusterArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       MigClusterSpecPtrInput
	Status     MigClusterStatusPtrInput
}

func (MigClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*migClusterArgs)(nil)).Elem()
}