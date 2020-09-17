// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type Podium struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
}

// NewPodium registers a new resource with the given unique name, arguments, and options.
func NewPodium(ctx *pulumi.Context,
	name string, args *PodiumArgs, opts ...pulumi.ResourceOption) (*Podium, error) {
	if args == nil {
		args = &PodiumArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("podium.com/v1alpha1")
	args.Kind = pulumi.StringPtr("Podium")
	var resource Podium
	err := ctx.RegisterResource("kubernetes:podium.com/v1alpha1:Podium", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPodium gets an existing Podium resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPodium(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PodiumState, opts ...pulumi.ResourceOption) (*Podium, error) {
	var resource Podium
	err := ctx.ReadResource("kubernetes:podium.com/v1alpha1:Podium", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Podium resources.
type podiumState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
}

type PodiumState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
}

func (PodiumState) ElementType() reflect.Type {
	return reflect.TypeOf((*podiumState)(nil)).Elem()
}

type podiumArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
}

// The set of arguments for constructing a Podium resource.
type PodiumArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
}

func (PodiumArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*podiumArgs)(nil)).Elem()
}
