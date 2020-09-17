// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// KeepalivedGroup is the Schema for the keepalivedgroups API
type KeepalivedGroup struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// KeepalivedGroupSpec defines the desired state of KeepalivedGroup
	Spec KeepalivedGroupSpecPtrOutput `pulumi:"spec"`
	// KeepalivedGroupStatus defines the observed state of KeepalivedGroup
	Status KeepalivedGroupStatusPtrOutput `pulumi:"status"`
}

// NewKeepalivedGroup registers a new resource with the given unique name, arguments, and options.
func NewKeepalivedGroup(ctx *pulumi.Context,
	name string, args *KeepalivedGroupArgs, opts ...pulumi.ResourceOption) (*KeepalivedGroup, error) {
	if args == nil {
		args = &KeepalivedGroupArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("redhatcop.redhat.io/v1alpha1")
	args.Kind = pulumi.StringPtr("KeepalivedGroup")
	var resource KeepalivedGroup
	err := ctx.RegisterResource("kubernetes:redhatcop.redhat.io/v1alpha1:KeepalivedGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetKeepalivedGroup gets an existing KeepalivedGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKeepalivedGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *KeepalivedGroupState, opts ...pulumi.ResourceOption) (*KeepalivedGroup, error) {
	var resource KeepalivedGroup
	err := ctx.ReadResource("kubernetes:redhatcop.redhat.io/v1alpha1:KeepalivedGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering KeepalivedGroup resources.
type keepalivedGroupState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KeepalivedGroupSpec defines the desired state of KeepalivedGroup
	Spec *KeepalivedGroupSpec `pulumi:"spec"`
	// KeepalivedGroupStatus defines the observed state of KeepalivedGroup
	Status *KeepalivedGroupStatus `pulumi:"status"`
}

type KeepalivedGroupState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KeepalivedGroupSpec defines the desired state of KeepalivedGroup
	Spec KeepalivedGroupSpecPtrInput
	// KeepalivedGroupStatus defines the observed state of KeepalivedGroup
	Status KeepalivedGroupStatusPtrInput
}

func (KeepalivedGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*keepalivedGroupState)(nil)).Elem()
}

type keepalivedGroupArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KeepalivedGroupSpec defines the desired state of KeepalivedGroup
	Spec *KeepalivedGroupSpec `pulumi:"spec"`
	// KeepalivedGroupStatus defines the observed state of KeepalivedGroup
	Status *KeepalivedGroupStatus `pulumi:"status"`
}

// The set of arguments for constructing a KeepalivedGroup resource.
type KeepalivedGroupArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KeepalivedGroupSpec defines the desired state of KeepalivedGroup
	Spec KeepalivedGroupSpecPtrInput
	// KeepalivedGroupStatus defines the observed state of KeepalivedGroup
	Status KeepalivedGroupStatusPtrInput
}

func (KeepalivedGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*keepalivedGroupArgs)(nil)).Elem()
}