// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A KubernetesCluster is a portable resource claim that may be satisfied by binding to a Kubernetes cluster managed resource such as an AWS EKS cluster or an Azure AKS cluster.
type KubernetesCluster struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// KubernetesClusterSpec specifies the desired state of a KubernetesCluster.
	Spec KubernetesClusterSpecPtrOutput `pulumi:"spec"`
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status KubernetesClusterStatusPtrOutput `pulumi:"status"`
}

// NewKubernetesCluster registers a new resource with the given unique name, arguments, and options.
func NewKubernetesCluster(ctx *pulumi.Context,
	name string, args *KubernetesClusterArgs, opts ...pulumi.ResourceOption) (*KubernetesCluster, error) {
	if args == nil {
		args = &KubernetesClusterArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("compute.crossplane.io/v1alpha1")
	args.Kind = pulumi.StringPtr("KubernetesCluster")
	var resource KubernetesCluster
	err := ctx.RegisterResource("kubernetes:compute.crossplane.io/v1alpha1:KubernetesCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetKubernetesCluster gets an existing KubernetesCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKubernetesCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *KubernetesClusterState, opts ...pulumi.ResourceOption) (*KubernetesCluster, error) {
	var resource KubernetesCluster
	err := ctx.ReadResource("kubernetes:compute.crossplane.io/v1alpha1:KubernetesCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering KubernetesCluster resources.
type kubernetesClusterState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KubernetesClusterSpec specifies the desired state of a KubernetesCluster.
	Spec *KubernetesClusterSpec `pulumi:"spec"`
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status *KubernetesClusterStatus `pulumi:"status"`
}

type KubernetesClusterState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KubernetesClusterSpec specifies the desired state of a KubernetesCluster.
	Spec KubernetesClusterSpecPtrInput
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status KubernetesClusterStatusPtrInput
}

func (KubernetesClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*kubernetesClusterState)(nil)).Elem()
}

type kubernetesClusterArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KubernetesClusterSpec specifies the desired state of a KubernetesCluster.
	Spec *KubernetesClusterSpec `pulumi:"spec"`
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status *KubernetesClusterStatus `pulumi:"status"`
}

// The set of arguments for constructing a KubernetesCluster resource.
type KubernetesClusterArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KubernetesClusterSpec specifies the desired state of a KubernetesCluster.
	Spec KubernetesClusterSpecPtrInput
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status KubernetesClusterStatusPtrInput
}

func (KubernetesClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*kubernetesClusterArgs)(nil)).Elem()
}
