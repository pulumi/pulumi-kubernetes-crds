// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Channel is the Schema for the channels API
type Channel struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ChannelSpec defines the desired state of Channel
	Spec ChannelSpecPtrOutput `pulumi:"spec"`
	// The most recent observed status of the Channel.
	Status pulumi.MapOutput `pulumi:"status"`
}

// NewChannel registers a new resource with the given unique name, arguments, and options.
func NewChannel(ctx *pulumi.Context,
	name string, args *ChannelArgs, opts ...pulumi.ResourceOption) (*Channel, error) {
	if args == nil {
		args = &ChannelArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("apps.open-cluster-management.io/v1")
	args.Kind = pulumi.StringPtr("Channel")
	var resource Channel
	err := ctx.RegisterResource("kubernetes:apps.open-cluster-management.io/v1:Channel", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetChannel gets an existing Channel resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetChannel(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ChannelState, opts ...pulumi.ResourceOption) (*Channel, error) {
	var resource Channel
	err := ctx.ReadResource("kubernetes:apps.open-cluster-management.io/v1:Channel", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Channel resources.
type channelState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ChannelSpec defines the desired state of Channel
	Spec *ChannelSpec `pulumi:"spec"`
	// The most recent observed status of the Channel.
	Status map[string]interface{} `pulumi:"status"`
}

type ChannelState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ChannelSpec defines the desired state of Channel
	Spec ChannelSpecPtrInput
	// The most recent observed status of the Channel.
	Status pulumi.MapInput
}

func (ChannelState) ElementType() reflect.Type {
	return reflect.TypeOf((*channelState)(nil)).Elem()
}

type channelArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ChannelSpec defines the desired state of Channel
	Spec *ChannelSpec `pulumi:"spec"`
	// The most recent observed status of the Channel.
	Status map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a Channel resource.
type ChannelArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ChannelSpec defines the desired state of Channel
	Spec ChannelSpecPtrInput
	// The most recent observed status of the Channel.
	Status pulumi.MapInput
}

func (ChannelArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*channelArgs)(nil)).Elem()
}
