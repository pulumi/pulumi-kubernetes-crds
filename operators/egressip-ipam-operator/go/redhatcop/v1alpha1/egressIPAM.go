// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// EgressIPAM is the Schema for the egressipams API
type EgressIPAM struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// EgressIPAMSpec defines the desired state of EgressIPAM
	Spec EgressIPAMSpecPtrOutput `pulumi:"spec"`
	// EgressIPAMStatus defines the observed state of EgressIPAM
	Status EgressIPAMStatusPtrOutput `pulumi:"status"`
}

// NewEgressIPAM registers a new resource with the given unique name, arguments, and options.
func NewEgressIPAM(ctx *pulumi.Context,
	name string, args *EgressIPAMArgs, opts ...pulumi.ResourceOption) (*EgressIPAM, error) {
	if args == nil {
		args = &EgressIPAMArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("redhatcop.redhat.io/v1alpha1")
	args.Kind = pulumi.StringPtr("EgressIPAM")
	var resource EgressIPAM
	err := ctx.RegisterResource("kubernetes:redhatcop.redhat.io/v1alpha1:EgressIPAM", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEgressIPAM gets an existing EgressIPAM resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEgressIPAM(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EgressIPAMState, opts ...pulumi.ResourceOption) (*EgressIPAM, error) {
	var resource EgressIPAM
	err := ctx.ReadResource("kubernetes:redhatcop.redhat.io/v1alpha1:EgressIPAM", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EgressIPAM resources.
type egressIPAMState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// EgressIPAMSpec defines the desired state of EgressIPAM
	Spec *EgressIPAMSpec `pulumi:"spec"`
	// EgressIPAMStatus defines the observed state of EgressIPAM
	Status *EgressIPAMStatus `pulumi:"status"`
}

type EgressIPAMState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// EgressIPAMSpec defines the desired state of EgressIPAM
	Spec EgressIPAMSpecPtrInput
	// EgressIPAMStatus defines the observed state of EgressIPAM
	Status EgressIPAMStatusPtrInput
}

func (EgressIPAMState) ElementType() reflect.Type {
	return reflect.TypeOf((*egressIPAMState)(nil)).Elem()
}

type egressIPAMArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// EgressIPAMSpec defines the desired state of EgressIPAM
	Spec *EgressIPAMSpec `pulumi:"spec"`
	// EgressIPAMStatus defines the observed state of EgressIPAM
	Status *EgressIPAMStatus `pulumi:"status"`
}

// The set of arguments for constructing a EgressIPAM resource.
type EgressIPAMArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// EgressIPAMSpec defines the desired state of EgressIPAM
	Spec EgressIPAMSpecPtrInput
	// EgressIPAMStatus defines the observed state of EgressIPAM
	Status EgressIPAMStatusPtrInput
}

func (EgressIPAMArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*egressIPAMArgs)(nil)).Elem()
}
