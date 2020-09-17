// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ClusterDeprovision is the Schema for the clusterdeprovisions API
type ClusterDeprovision struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ClusterDeprovisionSpec defines the desired state of ClusterDeprovision
	Spec ClusterDeprovisionSpecPtrOutput `pulumi:"spec"`
	// ClusterDeprovisionStatus defines the observed state of ClusterDeprovision
	Status ClusterDeprovisionStatusPtrOutput `pulumi:"status"`
}

// NewClusterDeprovision registers a new resource with the given unique name, arguments, and options.
func NewClusterDeprovision(ctx *pulumi.Context,
	name string, args *ClusterDeprovisionArgs, opts ...pulumi.ResourceOption) (*ClusterDeprovision, error) {
	if args == nil {
		args = &ClusterDeprovisionArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("hive.openshift.io/v1")
	args.Kind = pulumi.StringPtr("ClusterDeprovision")
	var resource ClusterDeprovision
	err := ctx.RegisterResource("kubernetes:hive.openshift.io/v1:ClusterDeprovision", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetClusterDeprovision gets an existing ClusterDeprovision resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetClusterDeprovision(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterDeprovisionState, opts ...pulumi.ResourceOption) (*ClusterDeprovision, error) {
	var resource ClusterDeprovision
	err := ctx.ReadResource("kubernetes:hive.openshift.io/v1:ClusterDeprovision", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ClusterDeprovision resources.
type clusterDeprovisionState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ClusterDeprovisionSpec defines the desired state of ClusterDeprovision
	Spec *ClusterDeprovisionSpec `pulumi:"spec"`
	// ClusterDeprovisionStatus defines the observed state of ClusterDeprovision
	Status *ClusterDeprovisionStatus `pulumi:"status"`
}

type ClusterDeprovisionState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ClusterDeprovisionSpec defines the desired state of ClusterDeprovision
	Spec ClusterDeprovisionSpecPtrInput
	// ClusterDeprovisionStatus defines the observed state of ClusterDeprovision
	Status ClusterDeprovisionStatusPtrInput
}

func (ClusterDeprovisionState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterDeprovisionState)(nil)).Elem()
}

type clusterDeprovisionArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ClusterDeprovisionSpec defines the desired state of ClusterDeprovision
	Spec *ClusterDeprovisionSpec `pulumi:"spec"`
	// ClusterDeprovisionStatus defines the observed state of ClusterDeprovision
	Status *ClusterDeprovisionStatus `pulumi:"status"`
}

// The set of arguments for constructing a ClusterDeprovision resource.
type ClusterDeprovisionArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ClusterDeprovisionSpec defines the desired state of ClusterDeprovision
	Spec ClusterDeprovisionSpecPtrInput
	// ClusterDeprovisionStatus defines the observed state of ClusterDeprovision
	Status ClusterDeprovisionStatusPtrInput
}

func (ClusterDeprovisionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterDeprovisionArgs)(nil)).Elem()
}