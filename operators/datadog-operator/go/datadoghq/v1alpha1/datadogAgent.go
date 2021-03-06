// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// DatadogAgent Deployment with Datadog Operator
type DatadogAgent struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// DatadogAgentSpec defines the desired state of DatadogAgent
	Spec DatadogAgentSpecPtrOutput `pulumi:"spec"`
	// DatadogAgentStatus defines the observed state of DatadogAgent
	Status DatadogAgentStatusPtrOutput `pulumi:"status"`
}

// NewDatadogAgent registers a new resource with the given unique name, arguments, and options.
func NewDatadogAgent(ctx *pulumi.Context,
	name string, args *DatadogAgentArgs, opts ...pulumi.ResourceOption) (*DatadogAgent, error) {
	if args == nil {
		args = &DatadogAgentArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("datadoghq.com/v1alpha1")
	args.Kind = pulumi.StringPtr("DatadogAgent")
	var resource DatadogAgent
	err := ctx.RegisterResource("kubernetes:datadoghq.com/v1alpha1:DatadogAgent", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatadogAgent gets an existing DatadogAgent resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatadogAgent(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatadogAgentState, opts ...pulumi.ResourceOption) (*DatadogAgent, error) {
	var resource DatadogAgent
	err := ctx.ReadResource("kubernetes:datadoghq.com/v1alpha1:DatadogAgent", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DatadogAgent resources.
type datadogAgentState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// DatadogAgentSpec defines the desired state of DatadogAgent
	Spec *DatadogAgentSpec `pulumi:"spec"`
	// DatadogAgentStatus defines the observed state of DatadogAgent
	Status *DatadogAgentStatus `pulumi:"status"`
}

type DatadogAgentState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// DatadogAgentSpec defines the desired state of DatadogAgent
	Spec DatadogAgentSpecPtrInput
	// DatadogAgentStatus defines the observed state of DatadogAgent
	Status DatadogAgentStatusPtrInput
}

func (DatadogAgentState) ElementType() reflect.Type {
	return reflect.TypeOf((*datadogAgentState)(nil)).Elem()
}

type datadogAgentArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// DatadogAgentSpec defines the desired state of DatadogAgent
	Spec *DatadogAgentSpec `pulumi:"spec"`
	// DatadogAgentStatus defines the observed state of DatadogAgent
	Status *DatadogAgentStatus `pulumi:"status"`
}

// The set of arguments for constructing a DatadogAgent resource.
type DatadogAgentArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// DatadogAgentSpec defines the desired state of DatadogAgent
	Spec DatadogAgentSpecPtrInput
	// DatadogAgentStatus defines the observed state of DatadogAgent
	Status DatadogAgentStatusPtrInput
}

func (DatadogAgentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*datadogAgentArgs)(nil)).Elem()
}
