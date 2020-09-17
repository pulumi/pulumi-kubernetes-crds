// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type MigMigration struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput      `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput      `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput  `pulumi:"metadata"`
	Spec       MigMigrationSpecPtrOutput   `pulumi:"spec"`
	Status     MigMigrationStatusPtrOutput `pulumi:"status"`
}

// NewMigMigration registers a new resource with the given unique name, arguments, and options.
func NewMigMigration(ctx *pulumi.Context,
	name string, args *MigMigrationArgs, opts ...pulumi.ResourceOption) (*MigMigration, error) {
	if args == nil {
		args = &MigMigrationArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("migration.openshift.io/v1alpha1")
	args.Kind = pulumi.StringPtr("MigMigration")
	var resource MigMigration
	err := ctx.RegisterResource("kubernetes:migration.openshift.io/v1alpha1:MigMigration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMigMigration gets an existing MigMigration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMigMigration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MigMigrationState, opts ...pulumi.ResourceOption) (*MigMigration, error) {
	var resource MigMigration
	err := ctx.ReadResource("kubernetes:migration.openshift.io/v1alpha1:MigMigration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MigMigration resources.
type migMigrationState struct {
	ApiVersion *string             `pulumi:"apiVersion"`
	Kind       *string             `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta  `pulumi:"metadata"`
	Spec       *MigMigrationSpec   `pulumi:"spec"`
	Status     *MigMigrationStatus `pulumi:"status"`
}

type MigMigrationState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       MigMigrationSpecPtrInput
	Status     MigMigrationStatusPtrInput
}

func (MigMigrationState) ElementType() reflect.Type {
	return reflect.TypeOf((*migMigrationState)(nil)).Elem()
}

type migMigrationArgs struct {
	ApiVersion *string             `pulumi:"apiVersion"`
	Kind       *string             `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta  `pulumi:"metadata"`
	Spec       *MigMigrationSpec   `pulumi:"spec"`
	Status     *MigMigrationStatus `pulumi:"status"`
}

// The set of arguments for constructing a MigMigration resource.
type MigMigrationArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       MigMigrationSpecPtrInput
	Status     MigMigrationStatusPtrInput
}

func (MigMigrationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*migMigrationArgs)(nil)).Elem()
}