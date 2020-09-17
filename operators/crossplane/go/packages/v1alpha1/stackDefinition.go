// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type StackDefinition struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput       `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput       `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput   `pulumi:"metadata"`
	Spec       StackDefinitionSpecPtrOutput `pulumi:"spec"`
	Status     pulumi.MapOutput             `pulumi:"status"`
}

// NewStackDefinition registers a new resource with the given unique name, arguments, and options.
func NewStackDefinition(ctx *pulumi.Context,
	name string, args *StackDefinitionArgs, opts ...pulumi.ResourceOption) (*StackDefinition, error) {
	if args == nil {
		args = &StackDefinitionArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("packages.crossplane.io/v1alpha1")
	args.Kind = pulumi.StringPtr("StackDefinition")
	var resource StackDefinition
	err := ctx.RegisterResource("kubernetes:packages.crossplane.io/v1alpha1:StackDefinition", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStackDefinition gets an existing StackDefinition resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStackDefinition(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StackDefinitionState, opts ...pulumi.ResourceOption) (*StackDefinition, error) {
	var resource StackDefinition
	err := ctx.ReadResource("kubernetes:packages.crossplane.io/v1alpha1:StackDefinition", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StackDefinition resources.
type stackDefinitionState struct {
	ApiVersion *string                `pulumi:"apiVersion"`
	Kind       *string                `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta     `pulumi:"metadata"`
	Spec       *StackDefinitionSpec   `pulumi:"spec"`
	Status     map[string]interface{} `pulumi:"status"`
}

type StackDefinitionState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       StackDefinitionSpecPtrInput
	Status     pulumi.MapInput
}

func (StackDefinitionState) ElementType() reflect.Type {
	return reflect.TypeOf((*stackDefinitionState)(nil)).Elem()
}

type stackDefinitionArgs struct {
	ApiVersion *string                `pulumi:"apiVersion"`
	Kind       *string                `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta     `pulumi:"metadata"`
	Spec       *StackDefinitionSpec   `pulumi:"spec"`
	Status     map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a StackDefinition resource.
type StackDefinitionArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       StackDefinitionSpecPtrInput
	Status     pulumi.MapInput
}

func (StackDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*stackDefinitionArgs)(nil)).Elem()
}
