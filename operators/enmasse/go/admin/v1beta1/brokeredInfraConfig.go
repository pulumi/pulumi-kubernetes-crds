// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// BrokeredInfraConfig defines configuration applied to brokers for an instance of the brokered address space type. This resource is created by the service administrator.
type BrokeredInfraConfig struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput           `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput           `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput       `pulumi:"metadata"`
	Spec       BrokeredInfraConfigSpecPtrOutput `pulumi:"spec"`
}

// NewBrokeredInfraConfig registers a new resource with the given unique name, arguments, and options.
func NewBrokeredInfraConfig(ctx *pulumi.Context,
	name string, args *BrokeredInfraConfigArgs, opts ...pulumi.ResourceOption) (*BrokeredInfraConfig, error) {
	if args == nil {
		args = &BrokeredInfraConfigArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("admin.enmasse.io/v1beta1")
	args.Kind = pulumi.StringPtr("BrokeredInfraConfig")
	var resource BrokeredInfraConfig
	err := ctx.RegisterResource("kubernetes:admin.enmasse.io/v1beta1:BrokeredInfraConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBrokeredInfraConfig gets an existing BrokeredInfraConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBrokeredInfraConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BrokeredInfraConfigState, opts ...pulumi.ResourceOption) (*BrokeredInfraConfig, error) {
	var resource BrokeredInfraConfig
	err := ctx.ReadResource("kubernetes:admin.enmasse.io/v1beta1:BrokeredInfraConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BrokeredInfraConfig resources.
type brokeredInfraConfigState struct {
	ApiVersion *string                  `pulumi:"apiVersion"`
	Kind       *string                  `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta       `pulumi:"metadata"`
	Spec       *BrokeredInfraConfigSpec `pulumi:"spec"`
}

type BrokeredInfraConfigState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       BrokeredInfraConfigSpecPtrInput
}

func (BrokeredInfraConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*brokeredInfraConfigState)(nil)).Elem()
}

type brokeredInfraConfigArgs struct {
	ApiVersion *string                  `pulumi:"apiVersion"`
	Kind       *string                  `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta       `pulumi:"metadata"`
	Spec       *BrokeredInfraConfigSpec `pulumi:"spec"`
}

// The set of arguments for constructing a BrokeredInfraConfig resource.
type BrokeredInfraConfigArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       BrokeredInfraConfigSpecPtrInput
}

func (BrokeredInfraConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*brokeredInfraConfigArgs)(nil)).Elem()
}
