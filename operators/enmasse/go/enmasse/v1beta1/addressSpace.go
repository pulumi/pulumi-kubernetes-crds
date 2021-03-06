// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// AddressSpace is a group of addresses that can be accessed through a single connection (per protocol). An AddressSpace can support multiple protocols, as defined by the type. This resource is created by messaging tenants.
type AddressSpace struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput      `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput      `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput  `pulumi:"metadata"`
	Spec       AddressSpaceSpecPtrOutput   `pulumi:"spec"`
	Status     AddressSpaceStatusPtrOutput `pulumi:"status"`
}

// NewAddressSpace registers a new resource with the given unique name, arguments, and options.
func NewAddressSpace(ctx *pulumi.Context,
	name string, args *AddressSpaceArgs, opts ...pulumi.ResourceOption) (*AddressSpace, error) {
	if args == nil {
		args = &AddressSpaceArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("enmasse.io/v1beta1")
	args.Kind = pulumi.StringPtr("AddressSpace")
	var resource AddressSpace
	err := ctx.RegisterResource("kubernetes:enmasse.io/v1beta1:AddressSpace", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAddressSpace gets an existing AddressSpace resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAddressSpace(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AddressSpaceState, opts ...pulumi.ResourceOption) (*AddressSpace, error) {
	var resource AddressSpace
	err := ctx.ReadResource("kubernetes:enmasse.io/v1beta1:AddressSpace", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AddressSpace resources.
type addressSpaceState struct {
	ApiVersion *string             `pulumi:"apiVersion"`
	Kind       *string             `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta  `pulumi:"metadata"`
	Spec       *AddressSpaceSpec   `pulumi:"spec"`
	Status     *AddressSpaceStatus `pulumi:"status"`
}

type AddressSpaceState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       AddressSpaceSpecPtrInput
	Status     AddressSpaceStatusPtrInput
}

func (AddressSpaceState) ElementType() reflect.Type {
	return reflect.TypeOf((*addressSpaceState)(nil)).Elem()
}

type addressSpaceArgs struct {
	ApiVersion *string             `pulumi:"apiVersion"`
	Kind       *string             `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta  `pulumi:"metadata"`
	Spec       *AddressSpaceSpec   `pulumi:"spec"`
	Status     *AddressSpaceStatus `pulumi:"status"`
}

// The set of arguments for constructing a AddressSpace resource.
type AddressSpaceArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       AddressSpaceSpecPtrInput
	Status     AddressSpaceStatusPtrInput
}

func (AddressSpaceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*addressSpaceArgs)(nil)).Elem()
}
