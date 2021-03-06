// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type Apicurito struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	Spec       pulumi.MapOutput           `pulumi:"spec"`
	Status     pulumi.MapOutput           `pulumi:"status"`
}

// NewApicurito registers a new resource with the given unique name, arguments, and options.
func NewApicurito(ctx *pulumi.Context,
	name string, args *ApicuritoArgs, opts ...pulumi.ResourceOption) (*Apicurito, error) {
	if args == nil {
		args = &ApicuritoArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("apicur.io/v1alpha1")
	args.Kind = pulumi.StringPtr("Apicurito")
	var resource Apicurito
	err := ctx.RegisterResource("kubernetes:apicur.io/v1alpha1:Apicurito", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApicurito gets an existing Apicurito resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApicurito(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApicuritoState, opts ...pulumi.ResourceOption) (*Apicurito, error) {
	var resource Apicurito
	err := ctx.ReadResource("kubernetes:apicur.io/v1alpha1:Apicurito", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Apicurito resources.
type apicuritoState struct {
	ApiVersion *string                `pulumi:"apiVersion"`
	Kind       *string                `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta     `pulumi:"metadata"`
	Spec       map[string]interface{} `pulumi:"spec"`
	Status     map[string]interface{} `pulumi:"status"`
}

type ApicuritoState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       pulumi.MapInput
	Status     pulumi.MapInput
}

func (ApicuritoState) ElementType() reflect.Type {
	return reflect.TypeOf((*apicuritoState)(nil)).Elem()
}

type apicuritoArgs struct {
	ApiVersion *string                `pulumi:"apiVersion"`
	Kind       *string                `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta     `pulumi:"metadata"`
	Spec       map[string]interface{} `pulumi:"spec"`
	Status     map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a Apicurito resource.
type ApicuritoArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       pulumi.MapInput
	Status     pulumi.MapInput
}

func (ApicuritoArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*apicuritoArgs)(nil)).Elem()
}
