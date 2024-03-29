// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Beat is the Schema for the Beats API.
type Beat struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// BeatSpec defines the desired state of a Beat.
	Spec BeatSpecPtrOutput `pulumi:"spec"`
	// BeatStatus defines the observed state of a Beat.
	Status BeatStatusPtrOutput `pulumi:"status"`
}

// NewBeat registers a new resource with the given unique name, arguments, and options.
func NewBeat(ctx *pulumi.Context,
	name string, args *BeatArgs, opts ...pulumi.ResourceOption) (*Beat, error) {
	if args == nil {
		args = &BeatArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("beat.k8s.elastic.co/v1beta1")
	args.Kind = pulumi.StringPtr("Beat")
	var resource Beat
	err := ctx.RegisterResource("kubernetes:beat.k8s.elastic.co/v1beta1:Beat", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBeat gets an existing Beat resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBeat(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BeatState, opts ...pulumi.ResourceOption) (*Beat, error) {
	var resource Beat
	err := ctx.ReadResource("kubernetes:beat.k8s.elastic.co/v1beta1:Beat", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Beat resources.
type beatState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// BeatSpec defines the desired state of a Beat.
	Spec *BeatSpec `pulumi:"spec"`
	// BeatStatus defines the observed state of a Beat.
	Status *BeatStatus `pulumi:"status"`
}

type BeatState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// BeatSpec defines the desired state of a Beat.
	Spec BeatSpecPtrInput
	// BeatStatus defines the observed state of a Beat.
	Status BeatStatusPtrInput
}

func (BeatState) ElementType() reflect.Type {
	return reflect.TypeOf((*beatState)(nil)).Elem()
}

type beatArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// BeatSpec defines the desired state of a Beat.
	Spec *BeatSpec `pulumi:"spec"`
	// BeatStatus defines the observed state of a Beat.
	Status *BeatStatus `pulumi:"status"`
}

// The set of arguments for constructing a Beat resource.
type BeatArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// BeatSpec defines the desired state of a Beat.
	Spec BeatSpecPtrInput
	// BeatStatus defines the observed state of a Beat.
	Status BeatStatusPtrInput
}

func (BeatArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*beatArgs)(nil)).Elem()
}
