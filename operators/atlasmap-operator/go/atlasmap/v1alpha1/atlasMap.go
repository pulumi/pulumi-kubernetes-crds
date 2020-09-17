// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// AtlasMap is the Schema for the atlasmaps API
type AtlasMap struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// AtlasMapSpec defines the desired state of AtlasMap
	Spec AtlasMapSpecPtrOutput `pulumi:"spec"`
	// AtlasMapStatus defines the observed state of AtlasMap
	Status AtlasMapStatusPtrOutput `pulumi:"status"`
}

// NewAtlasMap registers a new resource with the given unique name, arguments, and options.
func NewAtlasMap(ctx *pulumi.Context,
	name string, args *AtlasMapArgs, opts ...pulumi.ResourceOption) (*AtlasMap, error) {
	if args == nil {
		args = &AtlasMapArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("atlasmap.io/v1alpha1")
	args.Kind = pulumi.StringPtr("AtlasMap")
	var resource AtlasMap
	err := ctx.RegisterResource("kubernetes:atlasmap.io/v1alpha1:AtlasMap", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAtlasMap gets an existing AtlasMap resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAtlasMap(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AtlasMapState, opts ...pulumi.ResourceOption) (*AtlasMap, error) {
	var resource AtlasMap
	err := ctx.ReadResource("kubernetes:atlasmap.io/v1alpha1:AtlasMap", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AtlasMap resources.
type atlasMapState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// AtlasMapSpec defines the desired state of AtlasMap
	Spec *AtlasMapSpec `pulumi:"spec"`
	// AtlasMapStatus defines the observed state of AtlasMap
	Status *AtlasMapStatus `pulumi:"status"`
}

type AtlasMapState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// AtlasMapSpec defines the desired state of AtlasMap
	Spec AtlasMapSpecPtrInput
	// AtlasMapStatus defines the observed state of AtlasMap
	Status AtlasMapStatusPtrInput
}

func (AtlasMapState) ElementType() reflect.Type {
	return reflect.TypeOf((*atlasMapState)(nil)).Elem()
}

type atlasMapArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// AtlasMapSpec defines the desired state of AtlasMap
	Spec *AtlasMapSpec `pulumi:"spec"`
	// AtlasMapStatus defines the observed state of AtlasMap
	Status *AtlasMapStatus `pulumi:"status"`
}

// The set of arguments for constructing a AtlasMap resource.
type AtlasMapArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// AtlasMapSpec defines the desired state of AtlasMap
	Spec AtlasMapSpecPtrInput
	// AtlasMapStatus defines the observed state of AtlasMap
	Status AtlasMapStatusPtrInput
}

func (AtlasMapArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*atlasMapArgs)(nil)).Elem()
}
