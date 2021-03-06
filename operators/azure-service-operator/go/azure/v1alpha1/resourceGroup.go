// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ResourceGroup is the Schema for the resourcegroups API
type ResourceGroup struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ResourceGroupSpec defines the desired state of ResourceGroup
	Spec ResourceGroupSpecPtrOutput `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status ResourceGroupStatusPtrOutput `pulumi:"status"`
}

// NewResourceGroup registers a new resource with the given unique name, arguments, and options.
func NewResourceGroup(ctx *pulumi.Context,
	name string, args *ResourceGroupArgs, opts ...pulumi.ResourceOption) (*ResourceGroup, error) {
	if args == nil {
		args = &ResourceGroupArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("azure.microsoft.com/v1alpha1")
	args.Kind = pulumi.StringPtr("ResourceGroup")
	var resource ResourceGroup
	err := ctx.RegisterResource("kubernetes:azure.microsoft.com/v1alpha1:ResourceGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetResourceGroup gets an existing ResourceGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetResourceGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ResourceGroupState, opts ...pulumi.ResourceOption) (*ResourceGroup, error) {
	var resource ResourceGroup
	err := ctx.ReadResource("kubernetes:azure.microsoft.com/v1alpha1:ResourceGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ResourceGroup resources.
type resourceGroupState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ResourceGroupSpec defines the desired state of ResourceGroup
	Spec *ResourceGroupSpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *ResourceGroupStatus `pulumi:"status"`
}

type ResourceGroupState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ResourceGroupSpec defines the desired state of ResourceGroup
	Spec ResourceGroupSpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status ResourceGroupStatusPtrInput
}

func (ResourceGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*resourceGroupState)(nil)).Elem()
}

type resourceGroupArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ResourceGroupSpec defines the desired state of ResourceGroup
	Spec *ResourceGroupSpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *ResourceGroupStatus `pulumi:"status"`
}

// The set of arguments for constructing a ResourceGroup resource.
type ResourceGroupArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ResourceGroupSpec defines the desired state of ResourceGroup
	Spec ResourceGroupSpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status ResourceGroupStatusPtrInput
}

func (ResourceGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*resourceGroupArgs)(nil)).Elem()
}
