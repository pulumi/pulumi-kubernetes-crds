// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Fio is the Schema for the fios API
type Fio struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// FioSpec defines the desired state of Fio
	Spec FioSpecPtrOutput `pulumi:"spec"`
	// BenchmarkStatus describes the current state of the benchmark
	Status FioStatusPtrOutput `pulumi:"status"`
}

// NewFio registers a new resource with the given unique name, arguments, and options.
func NewFio(ctx *pulumi.Context,
	name string, args *FioArgs, opts ...pulumi.ResourceOption) (*Fio, error) {
	if args == nil {
		args = &FioArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("perf.kubestone.xridge.io/v1alpha1")
	args.Kind = pulumi.StringPtr("Fio")
	var resource Fio
	err := ctx.RegisterResource("kubernetes:perf.kubestone.xridge.io/v1alpha1:Fio", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFio gets an existing Fio resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFio(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FioState, opts ...pulumi.ResourceOption) (*Fio, error) {
	var resource Fio
	err := ctx.ReadResource("kubernetes:perf.kubestone.xridge.io/v1alpha1:Fio", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Fio resources.
type fioState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// FioSpec defines the desired state of Fio
	Spec *FioSpec `pulumi:"spec"`
	// BenchmarkStatus describes the current state of the benchmark
	Status *FioStatus `pulumi:"status"`
}

type FioState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// FioSpec defines the desired state of Fio
	Spec FioSpecPtrInput
	// BenchmarkStatus describes the current state of the benchmark
	Status FioStatusPtrInput
}

func (FioState) ElementType() reflect.Type {
	return reflect.TypeOf((*fioState)(nil)).Elem()
}

type fioArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// FioSpec defines the desired state of Fio
	Spec *FioSpec `pulumi:"spec"`
	// BenchmarkStatus describes the current state of the benchmark
	Status *FioStatus `pulumi:"status"`
}

// The set of arguments for constructing a Fio resource.
type FioArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// FioSpec defines the desired state of Fio
	Spec FioSpecPtrInput
	// BenchmarkStatus describes the current state of the benchmark
	Status FioStatusPtrInput
}

func (FioArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*fioArgs)(nil)).Elem()
}
