// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ClusterClaim represents a claim to a cluster from a cluster pool.
type ClusterClaim struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ClusterClaimSpec defines the desired state of the ClusterClaim.
	Spec ClusterClaimSpecOutput `pulumi:"spec"`
	// ClusterClaimStatus defines the observed state of ClusterClaim.
	Status ClusterClaimStatusPtrOutput `pulumi:"status"`
}

// NewClusterClaim registers a new resource with the given unique name, arguments, and options.
func NewClusterClaim(ctx *pulumi.Context,
	name string, args *ClusterClaimArgs, opts ...pulumi.ResourceOption) (*ClusterClaim, error) {
	if args == nil {
		args = &ClusterClaimArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("hive.openshift.io/v1")
	args.Kind = pulumi.StringPtr("ClusterClaim")
	var resource ClusterClaim
	err := ctx.RegisterResource("kubernetes:hive.openshift.io/v1:ClusterClaim", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetClusterClaim gets an existing ClusterClaim resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetClusterClaim(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterClaimState, opts ...pulumi.ResourceOption) (*ClusterClaim, error) {
	var resource ClusterClaim
	err := ctx.ReadResource("kubernetes:hive.openshift.io/v1:ClusterClaim", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ClusterClaim resources.
type clusterClaimState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ClusterClaimSpec defines the desired state of the ClusterClaim.
	Spec *ClusterClaimSpec `pulumi:"spec"`
	// ClusterClaimStatus defines the observed state of ClusterClaim.
	Status *ClusterClaimStatus `pulumi:"status"`
}

type ClusterClaimState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ClusterClaimSpec defines the desired state of the ClusterClaim.
	Spec ClusterClaimSpecPtrInput
	// ClusterClaimStatus defines the observed state of ClusterClaim.
	Status ClusterClaimStatusPtrInput
}

func (ClusterClaimState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterClaimState)(nil)).Elem()
}

type clusterClaimArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ClusterClaimSpec defines the desired state of the ClusterClaim.
	Spec *ClusterClaimSpec `pulumi:"spec"`
	// ClusterClaimStatus defines the observed state of ClusterClaim.
	Status *ClusterClaimStatus `pulumi:"status"`
}

// The set of arguments for constructing a ClusterClaim resource.
type ClusterClaimArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ClusterClaimSpec defines the desired state of the ClusterClaim.
	Spec ClusterClaimSpecPtrInput
	// ClusterClaimStatus defines the observed state of ClusterClaim.
	Status ClusterClaimStatusPtrInput
}

func (ClusterClaimArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterClaimArgs)(nil)).Elem()
}