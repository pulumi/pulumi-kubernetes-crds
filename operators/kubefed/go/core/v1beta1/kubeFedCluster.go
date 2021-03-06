// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type KubeFedCluster struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput        `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput        `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput    `pulumi:"metadata"`
	Spec       KubeFedClusterSpecOutput      `pulumi:"spec"`
	Status     KubeFedClusterStatusPtrOutput `pulumi:"status"`
}

// NewKubeFedCluster registers a new resource with the given unique name, arguments, and options.
func NewKubeFedCluster(ctx *pulumi.Context,
	name string, args *KubeFedClusterArgs, opts ...pulumi.ResourceOption) (*KubeFedCluster, error) {
	if args == nil {
		args = &KubeFedClusterArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("core.kubefed.io/v1beta1")
	args.Kind = pulumi.StringPtr("KubeFedCluster")
	var resource KubeFedCluster
	err := ctx.RegisterResource("kubernetes:core.kubefed.io/v1beta1:KubeFedCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetKubeFedCluster gets an existing KubeFedCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKubeFedCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *KubeFedClusterState, opts ...pulumi.ResourceOption) (*KubeFedCluster, error) {
	var resource KubeFedCluster
	err := ctx.ReadResource("kubernetes:core.kubefed.io/v1beta1:KubeFedCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering KubeFedCluster resources.
type kubeFedClusterState struct {
	ApiVersion *string               `pulumi:"apiVersion"`
	Kind       *string               `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta    `pulumi:"metadata"`
	Spec       *KubeFedClusterSpec   `pulumi:"spec"`
	Status     *KubeFedClusterStatus `pulumi:"status"`
}

type KubeFedClusterState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       KubeFedClusterSpecPtrInput
	Status     KubeFedClusterStatusPtrInput
}

func (KubeFedClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*kubeFedClusterState)(nil)).Elem()
}

type kubeFedClusterArgs struct {
	ApiVersion *string               `pulumi:"apiVersion"`
	Kind       *string               `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta    `pulumi:"metadata"`
	Spec       *KubeFedClusterSpec   `pulumi:"spec"`
	Status     *KubeFedClusterStatus `pulumi:"status"`
}

// The set of arguments for constructing a KubeFedCluster resource.
type KubeFedClusterArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       KubeFedClusterSpecPtrInput
	Status     KubeFedClusterStatusPtrInput
}

func (KubeFedClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*kubeFedClusterArgs)(nil)).Elem()
}
