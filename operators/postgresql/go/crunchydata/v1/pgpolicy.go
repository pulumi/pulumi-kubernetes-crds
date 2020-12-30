// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type Pgpolicy struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	Status     pulumi.AnyOutput           `pulumi:"status"`
}

// NewPgpolicy registers a new resource with the given unique name, arguments, and options.
func NewPgpolicy(ctx *pulumi.Context,
	name string, args *PgpolicyArgs, opts ...pulumi.ResourceOption) (*Pgpolicy, error) {
	if args == nil {
		args = &PgpolicyArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("crunchydata.com/v1")
	args.Kind = pulumi.StringPtr("Pgpolicy")
	var resource Pgpolicy
	err := ctx.RegisterResource("kubernetes:crunchydata.com/v1:Pgpolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPgpolicy gets an existing Pgpolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPgpolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PgpolicyState, opts ...pulumi.ResourceOption) (*Pgpolicy, error) {
	var resource Pgpolicy
	err := ctx.ReadResource("kubernetes:crunchydata.com/v1:Pgpolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Pgpolicy resources.
type pgpolicyState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Status     interface{}        `pulumi:"status"`
}

type PgpolicyState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Status     pulumi.Input
}

func (PgpolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*pgpolicyState)(nil)).Elem()
}

type pgpolicyArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Status     interface{}        `pulumi:"status"`
}

// The set of arguments for constructing a Pgpolicy resource.
type PgpolicyArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Status     pulumi.Input
}

func (PgpolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*pgpolicyArgs)(nil)).Elem()
}
