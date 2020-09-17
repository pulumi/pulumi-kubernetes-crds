// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type TektonInstallation struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
}

// NewTektonInstallation registers a new resource with the given unique name, arguments, and options.
func NewTektonInstallation(ctx *pulumi.Context,
	name string, args *TektonInstallationArgs, opts ...pulumi.ResourceOption) (*TektonInstallation, error) {
	if args == nil {
		args = &TektonInstallationArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("toolchain.openshift.dev/v1alpha1")
	args.Kind = pulumi.StringPtr("TektonInstallation")
	var resource TektonInstallation
	err := ctx.RegisterResource("kubernetes:toolchain.openshift.dev/v1alpha1:TektonInstallation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTektonInstallation gets an existing TektonInstallation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTektonInstallation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TektonInstallationState, opts ...pulumi.ResourceOption) (*TektonInstallation, error) {
	var resource TektonInstallation
	err := ctx.ReadResource("kubernetes:toolchain.openshift.dev/v1alpha1:TektonInstallation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TektonInstallation resources.
type tektonInstallationState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
}

type TektonInstallationState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
}

func (TektonInstallationState) ElementType() reflect.Type {
	return reflect.TypeOf((*tektonInstallationState)(nil)).Elem()
}

type tektonInstallationArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
}

// The set of arguments for constructing a TektonInstallation resource.
type TektonInstallationArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
}

func (TektonInstallationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*tektonInstallationArgs)(nil)).Elem()
}
