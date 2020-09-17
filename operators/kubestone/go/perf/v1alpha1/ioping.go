// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Ioping is the Schema for the iopings API
type Ioping struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// IopingSpec defines the ioping benchmark run
	Spec IopingSpecPtrOutput `pulumi:"spec"`
	// BenchmarkStatus describes the current state of the benchmark
	Status IopingStatusPtrOutput `pulumi:"status"`
}

// NewIoping registers a new resource with the given unique name, arguments, and options.
func NewIoping(ctx *pulumi.Context,
	name string, args *IopingArgs, opts ...pulumi.ResourceOption) (*Ioping, error) {
	if args == nil {
		args = &IopingArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("perf.kubestone.xridge.io/v1alpha1")
	args.Kind = pulumi.StringPtr("Ioping")
	var resource Ioping
	err := ctx.RegisterResource("kubernetes:perf.kubestone.xridge.io/v1alpha1:Ioping", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIoping gets an existing Ioping resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIoping(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IopingState, opts ...pulumi.ResourceOption) (*Ioping, error) {
	var resource Ioping
	err := ctx.ReadResource("kubernetes:perf.kubestone.xridge.io/v1alpha1:Ioping", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Ioping resources.
type iopingState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// IopingSpec defines the ioping benchmark run
	Spec *IopingSpec `pulumi:"spec"`
	// BenchmarkStatus describes the current state of the benchmark
	Status *IopingStatus `pulumi:"status"`
}

type IopingState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// IopingSpec defines the ioping benchmark run
	Spec IopingSpecPtrInput
	// BenchmarkStatus describes the current state of the benchmark
	Status IopingStatusPtrInput
}

func (IopingState) ElementType() reflect.Type {
	return reflect.TypeOf((*iopingState)(nil)).Elem()
}

type iopingArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// IopingSpec defines the ioping benchmark run
	Spec *IopingSpec `pulumi:"spec"`
	// BenchmarkStatus describes the current state of the benchmark
	Status *IopingStatus `pulumi:"status"`
}

// The set of arguments for constructing a Ioping resource.
type IopingArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// IopingSpec defines the ioping benchmark run
	Spec IopingSpecPtrInput
	// BenchmarkStatus describes the current state of the benchmark
	Status IopingStatusPtrInput
}

func (IopingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*iopingArgs)(nil)).Elem()
}