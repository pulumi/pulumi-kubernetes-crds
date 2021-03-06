// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// StarterKit is the Schema for the starterkits API
type StarterKit struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// StarterKitSpec defines the desired state of StarterKit
	Spec StarterKitSpecPtrOutput `pulumi:"spec"`
	// StarterKitStatus defines the observed state of StarterKit
	Status StarterKitStatusPtrOutput `pulumi:"status"`
}

// NewStarterKit registers a new resource with the given unique name, arguments, and options.
func NewStarterKit(ctx *pulumi.Context,
	name string, args *StarterKitArgs, opts ...pulumi.ResourceOption) (*StarterKit, error) {
	if args == nil {
		args = &StarterKitArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("devx.ibm.com/v1alpha1")
	args.Kind = pulumi.StringPtr("StarterKit")
	var resource StarterKit
	err := ctx.RegisterResource("kubernetes:devx.ibm.com/v1alpha1:StarterKit", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStarterKit gets an existing StarterKit resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStarterKit(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StarterKitState, opts ...pulumi.ResourceOption) (*StarterKit, error) {
	var resource StarterKit
	err := ctx.ReadResource("kubernetes:devx.ibm.com/v1alpha1:StarterKit", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StarterKit resources.
type starterKitState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// StarterKitSpec defines the desired state of StarterKit
	Spec *StarterKitSpec `pulumi:"spec"`
	// StarterKitStatus defines the observed state of StarterKit
	Status *StarterKitStatus `pulumi:"status"`
}

type StarterKitState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// StarterKitSpec defines the desired state of StarterKit
	Spec StarterKitSpecPtrInput
	// StarterKitStatus defines the observed state of StarterKit
	Status StarterKitStatusPtrInput
}

func (StarterKitState) ElementType() reflect.Type {
	return reflect.TypeOf((*starterKitState)(nil)).Elem()
}

type starterKitArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// StarterKitSpec defines the desired state of StarterKit
	Spec *StarterKitSpec `pulumi:"spec"`
	// StarterKitStatus defines the observed state of StarterKit
	Status *StarterKitStatus `pulumi:"status"`
}

// The set of arguments for constructing a StarterKit resource.
type StarterKitArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// StarterKitSpec defines the desired state of StarterKit
	Spec StarterKitSpecPtrInput
	// StarterKitStatus defines the observed state of StarterKit
	Status StarterKitStatusPtrInput
}

func (StarterKitArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*starterKitArgs)(nil)).Elem()
}
