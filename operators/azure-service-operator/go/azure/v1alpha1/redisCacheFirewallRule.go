// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// RedisCacheFirewallRule is the Schema for the rediscachefirewallrules API
type RedisCacheFirewallRule struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// RedisCacheFirewallRuleSpec defines the desired state of RedisCacheFirewallRule
	Spec RedisCacheFirewallRuleSpecPtrOutput `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status RedisCacheFirewallRuleStatusPtrOutput `pulumi:"status"`
}

// NewRedisCacheFirewallRule registers a new resource with the given unique name, arguments, and options.
func NewRedisCacheFirewallRule(ctx *pulumi.Context,
	name string, args *RedisCacheFirewallRuleArgs, opts ...pulumi.ResourceOption) (*RedisCacheFirewallRule, error) {
	if args == nil {
		args = &RedisCacheFirewallRuleArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("azure.microsoft.com/v1alpha1")
	args.Kind = pulumi.StringPtr("RedisCacheFirewallRule")
	var resource RedisCacheFirewallRule
	err := ctx.RegisterResource("kubernetes:azure.microsoft.com/v1alpha1:RedisCacheFirewallRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRedisCacheFirewallRule gets an existing RedisCacheFirewallRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRedisCacheFirewallRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RedisCacheFirewallRuleState, opts ...pulumi.ResourceOption) (*RedisCacheFirewallRule, error) {
	var resource RedisCacheFirewallRule
	err := ctx.ReadResource("kubernetes:azure.microsoft.com/v1alpha1:RedisCacheFirewallRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RedisCacheFirewallRule resources.
type redisCacheFirewallRuleState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// RedisCacheFirewallRuleSpec defines the desired state of RedisCacheFirewallRule
	Spec *RedisCacheFirewallRuleSpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *RedisCacheFirewallRuleStatus `pulumi:"status"`
}

type RedisCacheFirewallRuleState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// RedisCacheFirewallRuleSpec defines the desired state of RedisCacheFirewallRule
	Spec RedisCacheFirewallRuleSpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status RedisCacheFirewallRuleStatusPtrInput
}

func (RedisCacheFirewallRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*redisCacheFirewallRuleState)(nil)).Elem()
}

type redisCacheFirewallRuleArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// RedisCacheFirewallRuleSpec defines the desired state of RedisCacheFirewallRule
	Spec *RedisCacheFirewallRuleSpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *RedisCacheFirewallRuleStatus `pulumi:"status"`
}

// The set of arguments for constructing a RedisCacheFirewallRule resource.
type RedisCacheFirewallRuleArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// RedisCacheFirewallRuleSpec defines the desired state of RedisCacheFirewallRule
	Spec RedisCacheFirewallRuleSpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status RedisCacheFirewallRuleStatusPtrInput
}

func (RedisCacheFirewallRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*redisCacheFirewallRuleArgs)(nil)).Elem()
}
