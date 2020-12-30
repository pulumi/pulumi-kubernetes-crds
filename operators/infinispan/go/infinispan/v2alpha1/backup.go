// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v2alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Backup is the Schema for the backups API
type Backup struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// BackupSpec defines the desired state of Backup
	Spec BackupSpecPtrOutput `pulumi:"spec"`
	// BackupStatus defines the observed state of Backup
	Status BackupStatusPtrOutput `pulumi:"status"`
}

// NewBackup registers a new resource with the given unique name, arguments, and options.
func NewBackup(ctx *pulumi.Context,
	name string, args *BackupArgs, opts ...pulumi.ResourceOption) (*Backup, error) {
	if args == nil {
		args = &BackupArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("infinispan.org/v2alpha1")
	args.Kind = pulumi.StringPtr("Backup")
	var resource Backup
	err := ctx.RegisterResource("kubernetes:infinispan.org/v2alpha1:Backup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBackup gets an existing Backup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBackup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BackupState, opts ...pulumi.ResourceOption) (*Backup, error) {
	var resource Backup
	err := ctx.ReadResource("kubernetes:infinispan.org/v2alpha1:Backup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Backup resources.
type backupState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// BackupSpec defines the desired state of Backup
	Spec *BackupSpec `pulumi:"spec"`
	// BackupStatus defines the observed state of Backup
	Status *BackupStatus `pulumi:"status"`
}

type BackupState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// BackupSpec defines the desired state of Backup
	Spec BackupSpecPtrInput
	// BackupStatus defines the observed state of Backup
	Status BackupStatusPtrInput
}

func (BackupState) ElementType() reflect.Type {
	return reflect.TypeOf((*backupState)(nil)).Elem()
}

type backupArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// BackupSpec defines the desired state of Backup
	Spec *BackupSpec `pulumi:"spec"`
	// BackupStatus defines the observed state of Backup
	Status *BackupStatus `pulumi:"status"`
}

// The set of arguments for constructing a Backup resource.
type BackupArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// BackupSpec defines the desired state of Backup
	Spec BackupSpecPtrInput
	// BackupStatus defines the observed state of Backup
	Status BackupStatusPtrInput
}

func (BackupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*backupArgs)(nil)).Elem()
}
