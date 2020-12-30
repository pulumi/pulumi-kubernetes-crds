// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v2alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Restore is the Schema for the restores API
type Restore struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// BackupSpec defines the desired state of Backup
	Spec RestoreSpecPtrOutput `pulumi:"spec"`
	// RestoreStatus defines the observed state of Restore
	Status RestoreStatusPtrOutput `pulumi:"status"`
}

// NewRestore registers a new resource with the given unique name, arguments, and options.
func NewRestore(ctx *pulumi.Context,
	name string, args *RestoreArgs, opts ...pulumi.ResourceOption) (*Restore, error) {
	if args == nil {
		args = &RestoreArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("infinispan.org/v2alpha1")
	args.Kind = pulumi.StringPtr("Restore")
	var resource Restore
	err := ctx.RegisterResource("kubernetes:infinispan.org/v2alpha1:Restore", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRestore gets an existing Restore resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRestore(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RestoreState, opts ...pulumi.ResourceOption) (*Restore, error) {
	var resource Restore
	err := ctx.ReadResource("kubernetes:infinispan.org/v2alpha1:Restore", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Restore resources.
type restoreState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// BackupSpec defines the desired state of Backup
	Spec *RestoreSpec `pulumi:"spec"`
	// RestoreStatus defines the observed state of Restore
	Status *RestoreStatus `pulumi:"status"`
}

type RestoreState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// BackupSpec defines the desired state of Backup
	Spec RestoreSpecPtrInput
	// RestoreStatus defines the observed state of Restore
	Status RestoreStatusPtrInput
}

func (RestoreState) ElementType() reflect.Type {
	return reflect.TypeOf((*restoreState)(nil)).Elem()
}

type restoreArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// BackupSpec defines the desired state of Backup
	Spec *RestoreSpec `pulumi:"spec"`
	// RestoreStatus defines the observed state of Restore
	Status *RestoreStatus `pulumi:"status"`
}

// The set of arguments for constructing a Restore resource.
type RestoreArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// BackupSpec defines the desired state of Backup
	Spec RestoreSpecPtrInput
	// RestoreStatus defines the observed state of Restore
	Status RestoreStatusPtrInput
}

func (RestoreArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*restoreArgs)(nil)).Elem()
}