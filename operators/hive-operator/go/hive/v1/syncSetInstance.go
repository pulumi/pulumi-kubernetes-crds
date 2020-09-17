// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// SyncSetInstance is the Schema for the syncsetinstances API
type SyncSetInstance struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// SyncSetInstanceSpec defines the desired state of SyncSetInstance
	Spec SyncSetInstanceSpecPtrOutput `pulumi:"spec"`
	// SyncSetInstanceStatus defines the observed state of SyncSetInstance
	Status SyncSetInstanceStatusPtrOutput `pulumi:"status"`
}

// NewSyncSetInstance registers a new resource with the given unique name, arguments, and options.
func NewSyncSetInstance(ctx *pulumi.Context,
	name string, args *SyncSetInstanceArgs, opts ...pulumi.ResourceOption) (*SyncSetInstance, error) {
	if args == nil {
		args = &SyncSetInstanceArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("hive.openshift.io/v1")
	args.Kind = pulumi.StringPtr("SyncSetInstance")
	var resource SyncSetInstance
	err := ctx.RegisterResource("kubernetes:hive.openshift.io/v1:SyncSetInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSyncSetInstance gets an existing SyncSetInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSyncSetInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SyncSetInstanceState, opts ...pulumi.ResourceOption) (*SyncSetInstance, error) {
	var resource SyncSetInstance
	err := ctx.ReadResource("kubernetes:hive.openshift.io/v1:SyncSetInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SyncSetInstance resources.
type syncSetInstanceState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// SyncSetInstanceSpec defines the desired state of SyncSetInstance
	Spec *SyncSetInstanceSpec `pulumi:"spec"`
	// SyncSetInstanceStatus defines the observed state of SyncSetInstance
	Status *SyncSetInstanceStatus `pulumi:"status"`
}

type SyncSetInstanceState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// SyncSetInstanceSpec defines the desired state of SyncSetInstance
	Spec SyncSetInstanceSpecPtrInput
	// SyncSetInstanceStatus defines the observed state of SyncSetInstance
	Status SyncSetInstanceStatusPtrInput
}

func (SyncSetInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*syncSetInstanceState)(nil)).Elem()
}

type syncSetInstanceArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// SyncSetInstanceSpec defines the desired state of SyncSetInstance
	Spec *SyncSetInstanceSpec `pulumi:"spec"`
	// SyncSetInstanceStatus defines the observed state of SyncSetInstance
	Status *SyncSetInstanceStatus `pulumi:"status"`
}

// The set of arguments for constructing a SyncSetInstance resource.
type SyncSetInstanceArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// SyncSetInstanceSpec defines the desired state of SyncSetInstance
	Spec SyncSetInstanceSpecPtrInput
	// SyncSetInstanceStatus defines the observed state of SyncSetInstance
	Status SyncSetInstanceStatusPtrInput
}

func (SyncSetInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*syncSetInstanceArgs)(nil)).Elem()
}
