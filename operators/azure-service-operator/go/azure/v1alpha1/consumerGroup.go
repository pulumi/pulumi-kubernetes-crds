// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ConsumerGroup is the Schema for the consumergroups API
type ConsumerGroup struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ConsumerGroupSpec defines the desired state of ConsumerGroup
	Spec ConsumerGroupSpecPtrOutput `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status ConsumerGroupStatusPtrOutput `pulumi:"status"`
}

// NewConsumerGroup registers a new resource with the given unique name, arguments, and options.
func NewConsumerGroup(ctx *pulumi.Context,
	name string, args *ConsumerGroupArgs, opts ...pulumi.ResourceOption) (*ConsumerGroup, error) {
	if args == nil {
		args = &ConsumerGroupArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("azure.microsoft.com/v1alpha1")
	args.Kind = pulumi.StringPtr("ConsumerGroup")
	var resource ConsumerGroup
	err := ctx.RegisterResource("kubernetes:azure.microsoft.com/v1alpha1:ConsumerGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConsumerGroup gets an existing ConsumerGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConsumerGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConsumerGroupState, opts ...pulumi.ResourceOption) (*ConsumerGroup, error) {
	var resource ConsumerGroup
	err := ctx.ReadResource("kubernetes:azure.microsoft.com/v1alpha1:ConsumerGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConsumerGroup resources.
type consumerGroupState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ConsumerGroupSpec defines the desired state of ConsumerGroup
	Spec *ConsumerGroupSpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *ConsumerGroupStatus `pulumi:"status"`
}

type ConsumerGroupState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ConsumerGroupSpec defines the desired state of ConsumerGroup
	Spec ConsumerGroupSpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status ConsumerGroupStatusPtrInput
}

func (ConsumerGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*consumerGroupState)(nil)).Elem()
}

type consumerGroupArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ConsumerGroupSpec defines the desired state of ConsumerGroup
	Spec *ConsumerGroupSpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *ConsumerGroupStatus `pulumi:"status"`
}

// The set of arguments for constructing a ConsumerGroup resource.
type ConsumerGroupArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ConsumerGroupSpec defines the desired state of ConsumerGroup
	Spec ConsumerGroupSpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status ConsumerGroupStatusPtrInput
}

func (ConsumerGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*consumerGroupArgs)(nil)).Elem()
}