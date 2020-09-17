// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Checkpoint is the Schema for the backup of Hive objects.
type Checkpoint struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// CheckpointSpec defines the metadata around the Hive objects state in the namespace at the time of the last backup.
	Spec CheckpointSpecPtrOutput `pulumi:"spec"`
	// CheckpointStatus defines the observed state of Checkpoint
	Status pulumi.MapOutput `pulumi:"status"`
}

// NewCheckpoint registers a new resource with the given unique name, arguments, and options.
func NewCheckpoint(ctx *pulumi.Context,
	name string, args *CheckpointArgs, opts ...pulumi.ResourceOption) (*Checkpoint, error) {
	if args == nil {
		args = &CheckpointArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("hive.openshift.io/v1")
	args.Kind = pulumi.StringPtr("Checkpoint")
	var resource Checkpoint
	err := ctx.RegisterResource("kubernetes:hive.openshift.io/v1:Checkpoint", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCheckpoint gets an existing Checkpoint resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCheckpoint(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CheckpointState, opts ...pulumi.ResourceOption) (*Checkpoint, error) {
	var resource Checkpoint
	err := ctx.ReadResource("kubernetes:hive.openshift.io/v1:Checkpoint", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Checkpoint resources.
type checkpointState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// CheckpointSpec defines the metadata around the Hive objects state in the namespace at the time of the last backup.
	Spec *CheckpointSpec `pulumi:"spec"`
	// CheckpointStatus defines the observed state of Checkpoint
	Status map[string]interface{} `pulumi:"status"`
}

type CheckpointState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// CheckpointSpec defines the metadata around the Hive objects state in the namespace at the time of the last backup.
	Spec CheckpointSpecPtrInput
	// CheckpointStatus defines the observed state of Checkpoint
	Status pulumi.MapInput
}

func (CheckpointState) ElementType() reflect.Type {
	return reflect.TypeOf((*checkpointState)(nil)).Elem()
}

type checkpointArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// CheckpointSpec defines the metadata around the Hive objects state in the namespace at the time of the last backup.
	Spec *CheckpointSpec `pulumi:"spec"`
	// CheckpointStatus defines the observed state of Checkpoint
	Status map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a Checkpoint resource.
type CheckpointArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// CheckpointSpec defines the metadata around the Hive objects state in the namespace at the time of the last backup.
	Spec CheckpointSpecPtrInput
	// CheckpointStatus defines the observed state of Checkpoint
	Status pulumi.MapInput
}

func (CheckpointArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*checkpointArgs)(nil)).Elem()
}