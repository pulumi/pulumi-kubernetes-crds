// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ApicurioRegistry is the Schema for the apicurioregistries API
type ApicurioRegistry struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ApicurioRegistrySpec defines the desired state of ApicurioRegistry
	Spec ApicurioRegistrySpecPtrOutput `pulumi:"spec"`
	// ApicurioRegistryStatus defines the observed state of ApicurioRegistry
	Status ApicurioRegistryStatusPtrOutput `pulumi:"status"`
}

// NewApicurioRegistry registers a new resource with the given unique name, arguments, and options.
func NewApicurioRegistry(ctx *pulumi.Context,
	name string, args *ApicurioRegistryArgs, opts ...pulumi.ResourceOption) (*ApicurioRegistry, error) {
	if args == nil {
		args = &ApicurioRegistryArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("apicur.io/v1alpha1")
	args.Kind = pulumi.StringPtr("ApicurioRegistry")
	var resource ApicurioRegistry
	err := ctx.RegisterResource("kubernetes:apicur.io/v1alpha1:ApicurioRegistry", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApicurioRegistry gets an existing ApicurioRegistry resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApicurioRegistry(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApicurioRegistryState, opts ...pulumi.ResourceOption) (*ApicurioRegistry, error) {
	var resource ApicurioRegistry
	err := ctx.ReadResource("kubernetes:apicur.io/v1alpha1:ApicurioRegistry", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApicurioRegistry resources.
type apicurioRegistryState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ApicurioRegistrySpec defines the desired state of ApicurioRegistry
	Spec *ApicurioRegistrySpec `pulumi:"spec"`
	// ApicurioRegistryStatus defines the observed state of ApicurioRegistry
	Status *ApicurioRegistryStatus `pulumi:"status"`
}

type ApicurioRegistryState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ApicurioRegistrySpec defines the desired state of ApicurioRegistry
	Spec ApicurioRegistrySpecPtrInput
	// ApicurioRegistryStatus defines the observed state of ApicurioRegistry
	Status ApicurioRegistryStatusPtrInput
}

func (ApicurioRegistryState) ElementType() reflect.Type {
	return reflect.TypeOf((*apicurioRegistryState)(nil)).Elem()
}

type apicurioRegistryArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ApicurioRegistrySpec defines the desired state of ApicurioRegistry
	Spec *ApicurioRegistrySpec `pulumi:"spec"`
	// ApicurioRegistryStatus defines the observed state of ApicurioRegistry
	Status *ApicurioRegistryStatus `pulumi:"status"`
}

// The set of arguments for constructing a ApicurioRegistry resource.
type ApicurioRegistryArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ApicurioRegistrySpec defines the desired state of ApicurioRegistry
	Spec ApicurioRegistrySpecPtrInput
	// ApicurioRegistryStatus defines the observed state of ApicurioRegistry
	Status ApicurioRegistryStatusPtrInput
}

func (ApicurioRegistryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*apicurioRegistryArgs)(nil)).Elem()
}
