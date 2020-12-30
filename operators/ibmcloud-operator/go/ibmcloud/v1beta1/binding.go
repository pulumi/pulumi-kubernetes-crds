// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Binding is an instance of a service binding resource on IBM Cloud. A Binding creates a secret with the service instance credentials.
type Binding struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// BindingSpec defines the desired state of Binding
	Spec BindingSpecPtrOutput `pulumi:"spec"`
	// BindingStatus defines the observed state of Binding
	Status BindingStatusPtrOutput `pulumi:"status"`
}

// NewBinding registers a new resource with the given unique name, arguments, and options.
func NewBinding(ctx *pulumi.Context,
	name string, args *BindingArgs, opts ...pulumi.ResourceOption) (*Binding, error) {
	if args == nil {
		args = &BindingArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("ibmcloud.ibm.com/v1beta1")
	args.Kind = pulumi.StringPtr("Binding")
	var resource Binding
	err := ctx.RegisterResource("kubernetes:ibmcloud.ibm.com/v1beta1:Binding", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBinding gets an existing Binding resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBinding(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BindingState, opts ...pulumi.ResourceOption) (*Binding, error) {
	var resource Binding
	err := ctx.ReadResource("kubernetes:ibmcloud.ibm.com/v1beta1:Binding", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Binding resources.
type bindingState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// BindingSpec defines the desired state of Binding
	Spec *BindingSpec `pulumi:"spec"`
	// BindingStatus defines the observed state of Binding
	Status *BindingStatus `pulumi:"status"`
}

type BindingState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// BindingSpec defines the desired state of Binding
	Spec BindingSpecPtrInput
	// BindingStatus defines the observed state of Binding
	Status BindingStatusPtrInput
}

func (BindingState) ElementType() reflect.Type {
	return reflect.TypeOf((*bindingState)(nil)).Elem()
}

type bindingArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// BindingSpec defines the desired state of Binding
	Spec *BindingSpec `pulumi:"spec"`
	// BindingStatus defines the observed state of Binding
	Status *BindingStatus `pulumi:"status"`
}

// The set of arguments for constructing a Binding resource.
type BindingArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// BindingSpec defines the desired state of Binding
	Spec BindingSpecPtrInput
	// BindingStatus defines the observed state of Binding
	Status BindingStatusPtrInput
}

func (BindingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*bindingArgs)(nil)).Elem()
}
