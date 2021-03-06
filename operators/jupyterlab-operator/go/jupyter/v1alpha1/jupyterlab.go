// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Jupyterlab is the Schema for the jupyterlabs API
type Jupyterlab struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// JupyterlabSpec defines the desired state of Jupyterlab
	Spec JupyterlabSpecPtrOutput `pulumi:"spec"`
	// JupyterlabStatus defines the observed state of Jupyterlab
	Status JupyterlabStatusPtrOutput `pulumi:"status"`
}

// NewJupyterlab registers a new resource with the given unique name, arguments, and options.
func NewJupyterlab(ctx *pulumi.Context,
	name string, args *JupyterlabArgs, opts ...pulumi.ResourceOption) (*Jupyterlab, error) {
	if args == nil {
		args = &JupyterlabArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("jupyter.example.com/v1alpha1")
	args.Kind = pulumi.StringPtr("Jupyterlab")
	var resource Jupyterlab
	err := ctx.RegisterResource("kubernetes:jupyter.example.com/v1alpha1:Jupyterlab", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetJupyterlab gets an existing Jupyterlab resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetJupyterlab(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *JupyterlabState, opts ...pulumi.ResourceOption) (*Jupyterlab, error) {
	var resource Jupyterlab
	err := ctx.ReadResource("kubernetes:jupyter.example.com/v1alpha1:Jupyterlab", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Jupyterlab resources.
type jupyterlabState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// JupyterlabSpec defines the desired state of Jupyterlab
	Spec *JupyterlabSpec `pulumi:"spec"`
	// JupyterlabStatus defines the observed state of Jupyterlab
	Status *JupyterlabStatus `pulumi:"status"`
}

type JupyterlabState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// JupyterlabSpec defines the desired state of Jupyterlab
	Spec JupyterlabSpecPtrInput
	// JupyterlabStatus defines the observed state of Jupyterlab
	Status JupyterlabStatusPtrInput
}

func (JupyterlabState) ElementType() reflect.Type {
	return reflect.TypeOf((*jupyterlabState)(nil)).Elem()
}

type jupyterlabArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// JupyterlabSpec defines the desired state of Jupyterlab
	Spec *JupyterlabSpec `pulumi:"spec"`
	// JupyterlabStatus defines the observed state of Jupyterlab
	Status *JupyterlabStatus `pulumi:"status"`
}

// The set of arguments for constructing a Jupyterlab resource.
type JupyterlabArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// JupyterlabSpec defines the desired state of Jupyterlab
	Spec JupyterlabSpecPtrInput
	// JupyterlabStatus defines the observed state of Jupyterlab
	Status JupyterlabStatusPtrInput
}

func (JupyterlabArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*jupyterlabArgs)(nil)).Elem()
}
