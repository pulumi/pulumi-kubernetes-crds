// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type MigHook struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	Spec       MigHookSpecPtrOutput       `pulumi:"spec"`
	Status     MigHookStatusPtrOutput     `pulumi:"status"`
}

// NewMigHook registers a new resource with the given unique name, arguments, and options.
func NewMigHook(ctx *pulumi.Context,
	name string, args *MigHookArgs, opts ...pulumi.ResourceOption) (*MigHook, error) {
	if args == nil {
		args = &MigHookArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("migration.openshift.io/v1alpha1")
	args.Kind = pulumi.StringPtr("MigHook")
	var resource MigHook
	err := ctx.RegisterResource("kubernetes:migration.openshift.io/v1alpha1:MigHook", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMigHook gets an existing MigHook resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMigHook(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MigHookState, opts ...pulumi.ResourceOption) (*MigHook, error) {
	var resource MigHook
	err := ctx.ReadResource("kubernetes:migration.openshift.io/v1alpha1:MigHook", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MigHook resources.
type migHookState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       *MigHookSpec       `pulumi:"spec"`
	Status     *MigHookStatus     `pulumi:"status"`
}

type MigHookState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       MigHookSpecPtrInput
	Status     MigHookStatusPtrInput
}

func (MigHookState) ElementType() reflect.Type {
	return reflect.TypeOf((*migHookState)(nil)).Elem()
}

type migHookArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       *MigHookSpec       `pulumi:"spec"`
	Status     *MigHookStatus     `pulumi:"status"`
}

// The set of arguments for constructing a MigHook resource.
type MigHookArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       MigHookSpecPtrInput
	Status     MigHookStatusPtrInput
}

func (MigHookArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*migHookArgs)(nil)).Elem()
}