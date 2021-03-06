// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type CamelSource struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	Spec       CamelSourceSpecPtrOutput   `pulumi:"spec"`
	Status     CamelSourceStatusPtrOutput `pulumi:"status"`
}

// NewCamelSource registers a new resource with the given unique name, arguments, and options.
func NewCamelSource(ctx *pulumi.Context,
	name string, args *CamelSourceArgs, opts ...pulumi.ResourceOption) (*CamelSource, error) {
	if args == nil {
		args = &CamelSourceArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("sources.knative.dev/v1alpha1")
	args.Kind = pulumi.StringPtr("CamelSource")
	var resource CamelSource
	err := ctx.RegisterResource("kubernetes:sources.knative.dev/v1alpha1:CamelSource", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCamelSource gets an existing CamelSource resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCamelSource(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CamelSourceState, opts ...pulumi.ResourceOption) (*CamelSource, error) {
	var resource CamelSource
	err := ctx.ReadResource("kubernetes:sources.knative.dev/v1alpha1:CamelSource", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CamelSource resources.
type camelSourceState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       *CamelSourceSpec   `pulumi:"spec"`
	Status     *CamelSourceStatus `pulumi:"status"`
}

type CamelSourceState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       CamelSourceSpecPtrInput
	Status     CamelSourceStatusPtrInput
}

func (CamelSourceState) ElementType() reflect.Type {
	return reflect.TypeOf((*camelSourceState)(nil)).Elem()
}

type camelSourceArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       *CamelSourceSpec   `pulumi:"spec"`
	Status     *CamelSourceStatus `pulumi:"status"`
}

// The set of arguments for constructing a CamelSource resource.
type CamelSourceArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       CamelSourceSpecPtrInput
	Status     CamelSourceStatusPtrInput
}

func (CamelSourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*camelSourceArgs)(nil)).Elem()
}
