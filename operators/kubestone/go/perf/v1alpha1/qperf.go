// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Qperf is the Schema for the qperves API
type Qperf struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// QperfSpec defines the Qperf Benchmark Stone which consist of server deployment with service definition and client pod.
	Spec QperfSpecPtrOutput `pulumi:"spec"`
	// BenchmarkStatus describes the current state of the benchmark
	Status QperfStatusPtrOutput `pulumi:"status"`
}

// NewQperf registers a new resource with the given unique name, arguments, and options.
func NewQperf(ctx *pulumi.Context,
	name string, args *QperfArgs, opts ...pulumi.ResourceOption) (*Qperf, error) {
	if args == nil {
		args = &QperfArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("perf.kubestone.xridge.io/v1alpha1")
	args.Kind = pulumi.StringPtr("Qperf")
	var resource Qperf
	err := ctx.RegisterResource("kubernetes:perf.kubestone.xridge.io/v1alpha1:Qperf", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetQperf gets an existing Qperf resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetQperf(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *QperfState, opts ...pulumi.ResourceOption) (*Qperf, error) {
	var resource Qperf
	err := ctx.ReadResource("kubernetes:perf.kubestone.xridge.io/v1alpha1:Qperf", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Qperf resources.
type qperfState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// QperfSpec defines the Qperf Benchmark Stone which consist of server deployment with service definition and client pod.
	Spec *QperfSpec `pulumi:"spec"`
	// BenchmarkStatus describes the current state of the benchmark
	Status *QperfStatus `pulumi:"status"`
}

type QperfState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// QperfSpec defines the Qperf Benchmark Stone which consist of server deployment with service definition and client pod.
	Spec QperfSpecPtrInput
	// BenchmarkStatus describes the current state of the benchmark
	Status QperfStatusPtrInput
}

func (QperfState) ElementType() reflect.Type {
	return reflect.TypeOf((*qperfState)(nil)).Elem()
}

type qperfArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// QperfSpec defines the Qperf Benchmark Stone which consist of server deployment with service definition and client pod.
	Spec *QperfSpec `pulumi:"spec"`
	// BenchmarkStatus describes the current state of the benchmark
	Status *QperfStatus `pulumi:"status"`
}

// The set of arguments for constructing a Qperf resource.
type QperfArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// QperfSpec defines the Qperf Benchmark Stone which consist of server deployment with service definition and client pod.
	Spec QperfSpecPtrInput
	// BenchmarkStatus describes the current state of the benchmark
	Status QperfStatusPtrInput
}

func (QperfArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*qperfArgs)(nil)).Elem()
}
