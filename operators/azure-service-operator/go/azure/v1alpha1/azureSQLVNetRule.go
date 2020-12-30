// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// AzureSQLVNetRule is the Schema for the azuresqlvnetrules API
type AzureSQLVNetRule struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// NOTE: json tags are required.  Any new fields you add must have json tags for the fields to be serialized. AzureSQLVNetRuleSpec defines the desired state of AzureSQLVNetRule
	Spec AzureSQLVNetRuleSpecPtrOutput `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status AzureSQLVNetRuleStatusPtrOutput `pulumi:"status"`
}

// NewAzureSQLVNetRule registers a new resource with the given unique name, arguments, and options.
func NewAzureSQLVNetRule(ctx *pulumi.Context,
	name string, args *AzureSQLVNetRuleArgs, opts ...pulumi.ResourceOption) (*AzureSQLVNetRule, error) {
	if args == nil {
		args = &AzureSQLVNetRuleArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("azure.microsoft.com/v1alpha1")
	args.Kind = pulumi.StringPtr("AzureSQLVNetRule")
	var resource AzureSQLVNetRule
	err := ctx.RegisterResource("kubernetes:azure.microsoft.com/v1alpha1:AzureSQLVNetRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAzureSQLVNetRule gets an existing AzureSQLVNetRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAzureSQLVNetRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AzureSQLVNetRuleState, opts ...pulumi.ResourceOption) (*AzureSQLVNetRule, error) {
	var resource AzureSQLVNetRule
	err := ctx.ReadResource("kubernetes:azure.microsoft.com/v1alpha1:AzureSQLVNetRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AzureSQLVNetRule resources.
type azureSQLVNetRuleState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// NOTE: json tags are required.  Any new fields you add must have json tags for the fields to be serialized. AzureSQLVNetRuleSpec defines the desired state of AzureSQLVNetRule
	Spec *AzureSQLVNetRuleSpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *AzureSQLVNetRuleStatus `pulumi:"status"`
}

type AzureSQLVNetRuleState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// NOTE: json tags are required.  Any new fields you add must have json tags for the fields to be serialized. AzureSQLVNetRuleSpec defines the desired state of AzureSQLVNetRule
	Spec AzureSQLVNetRuleSpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status AzureSQLVNetRuleStatusPtrInput
}

func (AzureSQLVNetRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*azureSQLVNetRuleState)(nil)).Elem()
}

type azureSQLVNetRuleArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// NOTE: json tags are required.  Any new fields you add must have json tags for the fields to be serialized. AzureSQLVNetRuleSpec defines the desired state of AzureSQLVNetRule
	Spec *AzureSQLVNetRuleSpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *AzureSQLVNetRuleStatus `pulumi:"status"`
}

// The set of arguments for constructing a AzureSQLVNetRule resource.
type AzureSQLVNetRuleArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// NOTE: json tags are required.  Any new fields you add must have json tags for the fields to be serialized. AzureSQLVNetRuleSpec defines the desired state of AzureSQLVNetRule
	Spec AzureSQLVNetRuleSpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status AzureSQLVNetRuleStatusPtrInput
}

func (AzureSQLVNetRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*azureSQLVNetRuleArgs)(nil)).Elem()
}
