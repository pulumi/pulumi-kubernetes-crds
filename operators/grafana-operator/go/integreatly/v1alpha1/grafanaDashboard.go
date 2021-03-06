// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type GrafanaDashboard struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	Spec       pulumi.AnyOutput           `pulumi:"spec"`
}

// NewGrafanaDashboard registers a new resource with the given unique name, arguments, and options.
func NewGrafanaDashboard(ctx *pulumi.Context,
	name string, args *GrafanaDashboardArgs, opts ...pulumi.ResourceOption) (*GrafanaDashboard, error) {
	if args == nil {
		args = &GrafanaDashboardArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("integreatly.org/v1alpha1")
	args.Kind = pulumi.StringPtr("GrafanaDashboard")
	var resource GrafanaDashboard
	err := ctx.RegisterResource("kubernetes:integreatly.org/v1alpha1:GrafanaDashboard", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGrafanaDashboard gets an existing GrafanaDashboard resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGrafanaDashboard(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GrafanaDashboardState, opts ...pulumi.ResourceOption) (*GrafanaDashboard, error) {
	var resource GrafanaDashboard
	err := ctx.ReadResource("kubernetes:integreatly.org/v1alpha1:GrafanaDashboard", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GrafanaDashboard resources.
type grafanaDashboardState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       interface{}        `pulumi:"spec"`
}

type GrafanaDashboardState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       pulumi.Input
}

func (GrafanaDashboardState) ElementType() reflect.Type {
	return reflect.TypeOf((*grafanaDashboardState)(nil)).Elem()
}

type grafanaDashboardArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       interface{}        `pulumi:"spec"`
}

// The set of arguments for constructing a GrafanaDashboard resource.
type GrafanaDashboardArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       pulumi.Input
}

func (GrafanaDashboardArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*grafanaDashboardArgs)(nil)).Elem()
}
