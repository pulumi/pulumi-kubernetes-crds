// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// DatadogMetric is the Schema for the datadogmetrics API
type DatadogMetric struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// DatadogMetricSpec defines the desired state of DatadogMetric
	Spec DatadogMetricSpecPtrOutput `pulumi:"spec"`
	// DatadogMetricStatus defines the observed state of DatadogMetric
	Status DatadogMetricStatusPtrOutput `pulumi:"status"`
}

// NewDatadogMetric registers a new resource with the given unique name, arguments, and options.
func NewDatadogMetric(ctx *pulumi.Context,
	name string, args *DatadogMetricArgs, opts ...pulumi.ResourceOption) (*DatadogMetric, error) {
	if args == nil {
		args = &DatadogMetricArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("datadoghq.com/v1alpha1")
	args.Kind = pulumi.StringPtr("DatadogMetric")
	var resource DatadogMetric
	err := ctx.RegisterResource("kubernetes:datadoghq.com/v1alpha1:DatadogMetric", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatadogMetric gets an existing DatadogMetric resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatadogMetric(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatadogMetricState, opts ...pulumi.ResourceOption) (*DatadogMetric, error) {
	var resource DatadogMetric
	err := ctx.ReadResource("kubernetes:datadoghq.com/v1alpha1:DatadogMetric", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DatadogMetric resources.
type datadogMetricState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// DatadogMetricSpec defines the desired state of DatadogMetric
	Spec *DatadogMetricSpec `pulumi:"spec"`
	// DatadogMetricStatus defines the observed state of DatadogMetric
	Status *DatadogMetricStatus `pulumi:"status"`
}

type DatadogMetricState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// DatadogMetricSpec defines the desired state of DatadogMetric
	Spec DatadogMetricSpecPtrInput
	// DatadogMetricStatus defines the observed state of DatadogMetric
	Status DatadogMetricStatusPtrInput
}

func (DatadogMetricState) ElementType() reflect.Type {
	return reflect.TypeOf((*datadogMetricState)(nil)).Elem()
}

type datadogMetricArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// DatadogMetricSpec defines the desired state of DatadogMetric
	Spec *DatadogMetricSpec `pulumi:"spec"`
	// DatadogMetricStatus defines the observed state of DatadogMetric
	Status *DatadogMetricStatus `pulumi:"status"`
}

// The set of arguments for constructing a DatadogMetric resource.
type DatadogMetricArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// DatadogMetricSpec defines the desired state of DatadogMetric
	Spec DatadogMetricSpecPtrInput
	// DatadogMetricStatus defines the observed state of DatadogMetric
	Status DatadogMetricStatusPtrInput
}

func (DatadogMetricArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*datadogMetricArgs)(nil)).Elem()
}