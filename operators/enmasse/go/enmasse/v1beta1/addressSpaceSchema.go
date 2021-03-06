// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type AddressSpaceSchema struct {
	pulumi.CustomResourceState
}

// NewAddressSpaceSchema registers a new resource with the given unique name, arguments, and options.
func NewAddressSpaceSchema(ctx *pulumi.Context,
	name string, args *AddressSpaceSchemaArgs, opts ...pulumi.ResourceOption) (*AddressSpaceSchema, error) {
	if args == nil {
		args = &AddressSpaceSchemaArgs{}
	}
	var resource AddressSpaceSchema
	err := ctx.RegisterResource("kubernetes:enmasse.io/v1beta1:AddressSpaceSchema", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAddressSpaceSchema gets an existing AddressSpaceSchema resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAddressSpaceSchema(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AddressSpaceSchemaState, opts ...pulumi.ResourceOption) (*AddressSpaceSchema, error) {
	var resource AddressSpaceSchema
	err := ctx.ReadResource("kubernetes:enmasse.io/v1beta1:AddressSpaceSchema", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AddressSpaceSchema resources.
type addressSpaceSchemaState struct {
}

type AddressSpaceSchemaState struct {
}

func (AddressSpaceSchemaState) ElementType() reflect.Type {
	return reflect.TypeOf((*addressSpaceSchemaState)(nil)).Elem()
}

type addressSpaceSchemaArgs struct {
}

// The set of arguments for constructing a AddressSpaceSchema resource.
type AddressSpaceSchemaArgs struct {
}

func (AddressSpaceSchemaArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*addressSpaceSchemaArgs)(nil)).Elem()
}
