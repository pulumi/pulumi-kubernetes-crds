// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Schedule is a Velero resource that represents a pre-scheduled or periodic Backup that should be run.
type Schedule struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ScheduleSpec defines the specification for a Velero schedule
	Spec ScheduleSpecPtrOutput `pulumi:"spec"`
	// ScheduleStatus captures the current state of a Velero schedule
	Status ScheduleStatusPtrOutput `pulumi:"status"`
}

// NewSchedule registers a new resource with the given unique name, arguments, and options.
func NewSchedule(ctx *pulumi.Context,
	name string, args *ScheduleArgs, opts ...pulumi.ResourceOption) (*Schedule, error) {
	if args == nil {
		args = &ScheduleArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("velero.io/v1")
	args.Kind = pulumi.StringPtr("Schedule")
	var resource Schedule
	err := ctx.RegisterResource("kubernetes:velero.io/v1:Schedule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSchedule gets an existing Schedule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSchedule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ScheduleState, opts ...pulumi.ResourceOption) (*Schedule, error) {
	var resource Schedule
	err := ctx.ReadResource("kubernetes:velero.io/v1:Schedule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Schedule resources.
type scheduleState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ScheduleSpec defines the specification for a Velero schedule
	Spec *ScheduleSpec `pulumi:"spec"`
	// ScheduleStatus captures the current state of a Velero schedule
	Status *ScheduleStatus `pulumi:"status"`
}

type ScheduleState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ScheduleSpec defines the specification for a Velero schedule
	Spec ScheduleSpecPtrInput
	// ScheduleStatus captures the current state of a Velero schedule
	Status ScheduleStatusPtrInput
}

func (ScheduleState) ElementType() reflect.Type {
	return reflect.TypeOf((*scheduleState)(nil)).Elem()
}

type scheduleArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ScheduleSpec defines the specification for a Velero schedule
	Spec *ScheduleSpec `pulumi:"spec"`
	// ScheduleStatus captures the current state of a Velero schedule
	Status *ScheduleStatus `pulumi:"status"`
}

// The set of arguments for constructing a Schedule resource.
type ScheduleArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ScheduleSpec defines the specification for a Velero schedule
	Spec ScheduleSpecPtrInput
	// ScheduleStatus captures the current state of a Velero schedule
	Status ScheduleStatusPtrInput
}

func (ScheduleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*scheduleArgs)(nil)).Elem()
}
