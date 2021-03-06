// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha2

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A WorkloadDefinition registers a kind of Kubernetes custom resource as a valid OAM workload kind by referencing its CustomResourceDefinition. The CRD is used to validate the schema of the workload when it is embedded in an OAM Component.
type WorkloadDefinition struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// A WorkloadDefinitionSpec defines the desired state of a WorkloadDefinition.
	Spec WorkloadDefinitionSpecPtrOutput `pulumi:"spec"`
}

// NewWorkloadDefinition registers a new resource with the given unique name, arguments, and options.
func NewWorkloadDefinition(ctx *pulumi.Context,
	name string, args *WorkloadDefinitionArgs, opts ...pulumi.ResourceOption) (*WorkloadDefinition, error) {
	if args == nil {
		args = &WorkloadDefinitionArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("core.oam.dev/v1alpha2")
	args.Kind = pulumi.StringPtr("WorkloadDefinition")
	var resource WorkloadDefinition
	err := ctx.RegisterResource("kubernetes:core.oam.dev/v1alpha2:WorkloadDefinition", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWorkloadDefinition gets an existing WorkloadDefinition resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWorkloadDefinition(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WorkloadDefinitionState, opts ...pulumi.ResourceOption) (*WorkloadDefinition, error) {
	var resource WorkloadDefinition
	err := ctx.ReadResource("kubernetes:core.oam.dev/v1alpha2:WorkloadDefinition", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WorkloadDefinition resources.
type workloadDefinitionState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// A WorkloadDefinitionSpec defines the desired state of a WorkloadDefinition.
	Spec *WorkloadDefinitionSpec `pulumi:"spec"`
}

type WorkloadDefinitionState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// A WorkloadDefinitionSpec defines the desired state of a WorkloadDefinition.
	Spec WorkloadDefinitionSpecPtrInput
}

func (WorkloadDefinitionState) ElementType() reflect.Type {
	return reflect.TypeOf((*workloadDefinitionState)(nil)).Elem()
}

type workloadDefinitionArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// A WorkloadDefinitionSpec defines the desired state of a WorkloadDefinition.
	Spec *WorkloadDefinitionSpec `pulumi:"spec"`
}

// The set of arguments for constructing a WorkloadDefinition resource.
type WorkloadDefinitionArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// A WorkloadDefinitionSpec defines the desired state of a WorkloadDefinition.
	Spec WorkloadDefinitionSpecPtrInput
}

func (WorkloadDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*workloadDefinitionArgs)(nil)).Elem()
}
