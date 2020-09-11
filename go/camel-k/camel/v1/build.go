// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Build is the Schema for the builds API
type Build struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// BuildSpec defines the desired state of Build
	Spec BuildSpecPtrOutput `pulumi:"spec"`
	// BuildStatus defines the observed state of Build
	Status BuildStatusPtrOutput `pulumi:"status"`
}

// NewBuild registers a new resource with the given unique name, arguments, and options.
func NewBuild(ctx *pulumi.Context,
	name string, args *BuildArgs, opts ...pulumi.ResourceOption) (*Build, error) {
	if args == nil {
		args = &BuildArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("camel.apache.org/v1")
	args.Kind = pulumi.StringPtr("Build")
	var resource Build
	err := ctx.RegisterResource("kubernetes:camel.apache.org/v1:Build", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBuild gets an existing Build resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBuild(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BuildState, opts ...pulumi.ResourceOption) (*Build, error) {
	var resource Build
	err := ctx.ReadResource("kubernetes:camel.apache.org/v1:Build", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Build resources.
type buildState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// BuildSpec defines the desired state of Build
	Spec *BuildSpec `pulumi:"spec"`
	// BuildStatus defines the observed state of Build
	Status *BuildStatus `pulumi:"status"`
}

type BuildState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// BuildSpec defines the desired state of Build
	Spec BuildSpecPtrInput
	// BuildStatus defines the observed state of Build
	Status BuildStatusPtrInput
}

func (BuildState) ElementType() reflect.Type {
	return reflect.TypeOf((*buildState)(nil)).Elem()
}

type buildArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// BuildSpec defines the desired state of Build
	Spec *BuildSpec `pulumi:"spec"`
	// BuildStatus defines the observed state of Build
	Status *BuildStatus `pulumi:"status"`
}

// The set of arguments for constructing a Build resource.
type BuildArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// BuildSpec defines the desired state of Build
	Spec BuildSpecPtrInput
	// BuildStatus defines the observed state of Build
	Status BuildStatusPtrInput
}

func (BuildArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*buildArgs)(nil)).Elem()
}
