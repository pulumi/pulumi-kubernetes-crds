// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The Cluster Node Feature Discovery operator manages detection of hardware features and configuration in a Openshift cluster. The operator orchestrates all resources needed to run the NFD DaemonSet (Upstream: https://github.com/kubernetes-sigs/node-feature-discovery)
type NodeFeatureDiscovery struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	Spec       pulumi.MapOutput           `pulumi:"spec"`
	Status     pulumi.MapOutput           `pulumi:"status"`
}

// NewNodeFeatureDiscovery registers a new resource with the given unique name, arguments, and options.
func NewNodeFeatureDiscovery(ctx *pulumi.Context,
	name string, args *NodeFeatureDiscoveryArgs, opts ...pulumi.ResourceOption) (*NodeFeatureDiscovery, error) {
	if args == nil {
		args = &NodeFeatureDiscoveryArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("nfd.openshift.io/v1alpha1")
	args.Kind = pulumi.StringPtr("NodeFeatureDiscovery")
	var resource NodeFeatureDiscovery
	err := ctx.RegisterResource("kubernetes:nfd.openshift.io/v1alpha1:NodeFeatureDiscovery", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNodeFeatureDiscovery gets an existing NodeFeatureDiscovery resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNodeFeatureDiscovery(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NodeFeatureDiscoveryState, opts ...pulumi.ResourceOption) (*NodeFeatureDiscovery, error) {
	var resource NodeFeatureDiscovery
	err := ctx.ReadResource("kubernetes:nfd.openshift.io/v1alpha1:NodeFeatureDiscovery", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NodeFeatureDiscovery resources.
type nodeFeatureDiscoveryState struct {
	ApiVersion *string                `pulumi:"apiVersion"`
	Kind       *string                `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta     `pulumi:"metadata"`
	Spec       map[string]interface{} `pulumi:"spec"`
	Status     map[string]interface{} `pulumi:"status"`
}

type NodeFeatureDiscoveryState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       pulumi.MapInput
	Status     pulumi.MapInput
}

func (NodeFeatureDiscoveryState) ElementType() reflect.Type {
	return reflect.TypeOf((*nodeFeatureDiscoveryState)(nil)).Elem()
}

type nodeFeatureDiscoveryArgs struct {
	ApiVersion *string                `pulumi:"apiVersion"`
	Kind       *string                `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta     `pulumi:"metadata"`
	Spec       map[string]interface{} `pulumi:"spec"`
	Status     map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a NodeFeatureDiscovery resource.
type NodeFeatureDiscoveryArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       pulumi.MapInput
	Status     pulumi.MapInput
}

func (NodeFeatureDiscoveryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*nodeFeatureDiscoveryArgs)(nil)).Elem()
}
