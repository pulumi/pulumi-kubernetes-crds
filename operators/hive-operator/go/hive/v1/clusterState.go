// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ClusterState is the Schema for the clusterstates API
type ClusterState struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ClusterStateSpec defines the desired state of ClusterState
	Spec pulumi.MapOutput `pulumi:"spec"`
	// ClusterStateStatus defines the observed state of ClusterState
	Status ClusterStateStatusPtrOutput `pulumi:"status"`
}

// NewClusterState registers a new resource with the given unique name, arguments, and options.
func NewClusterState(ctx *pulumi.Context,
	name string, args *ClusterStateArgs, opts ...pulumi.ResourceOption) (*ClusterState, error) {
	if args == nil {
		args = &ClusterStateArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("hive.openshift.io/v1")
	args.Kind = pulumi.StringPtr("ClusterState")
	var resource ClusterState
	err := ctx.RegisterResource("kubernetes:hive.openshift.io/v1:ClusterState", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetClusterState gets an existing ClusterState resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetClusterState(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterStateState, opts ...pulumi.ResourceOption) (*ClusterState, error) {
	var resource ClusterState
	err := ctx.ReadResource("kubernetes:hive.openshift.io/v1:ClusterState", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ClusterState resources.
type clusterStateState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ClusterStateSpec defines the desired state of ClusterState
	Spec map[string]interface{} `pulumi:"spec"`
	// ClusterStateStatus defines the observed state of ClusterState
	Status *ClusterStateStatus `pulumi:"status"`
}

type ClusterStateState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ClusterStateSpec defines the desired state of ClusterState
	Spec pulumi.MapInput
	// ClusterStateStatus defines the observed state of ClusterState
	Status ClusterStateStatusPtrInput
}

func (ClusterStateState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterStateState)(nil)).Elem()
}

type clusterStateArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ClusterStateSpec defines the desired state of ClusterState
	Spec map[string]interface{} `pulumi:"spec"`
	// ClusterStateStatus defines the observed state of ClusterState
	Status *ClusterStateStatus `pulumi:"status"`
}

// The set of arguments for constructing a ClusterState resource.
type ClusterStateArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ClusterStateSpec defines the desired state of ClusterState
	Spec pulumi.MapInput
	// ClusterStateStatus defines the observed state of ClusterState
	Status ClusterStateStatusPtrInput
}

func (ClusterStateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterStateArgs)(nil)).Elem()
}
