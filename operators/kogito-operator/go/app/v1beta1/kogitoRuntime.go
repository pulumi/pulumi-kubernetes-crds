// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// KogitoRuntime is a custom Kogito service.
type KogitoRuntime struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// KogitoRuntimeSpec defines the desired state of KogitoRuntime.
	Spec KogitoRuntimeSpecPtrOutput `pulumi:"spec"`
	// KogitoRuntimeStatus defines the observed state of KogitoRuntime.
	Status KogitoRuntimeStatusPtrOutput `pulumi:"status"`
}

// NewKogitoRuntime registers a new resource with the given unique name, arguments, and options.
func NewKogitoRuntime(ctx *pulumi.Context,
	name string, args *KogitoRuntimeArgs, opts ...pulumi.ResourceOption) (*KogitoRuntime, error) {
	if args == nil {
		args = &KogitoRuntimeArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("app.kiegroup.org/v1beta1")
	args.Kind = pulumi.StringPtr("KogitoRuntime")
	var resource KogitoRuntime
	err := ctx.RegisterResource("kubernetes:app.kiegroup.org/v1beta1:KogitoRuntime", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetKogitoRuntime gets an existing KogitoRuntime resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKogitoRuntime(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *KogitoRuntimeState, opts ...pulumi.ResourceOption) (*KogitoRuntime, error) {
	var resource KogitoRuntime
	err := ctx.ReadResource("kubernetes:app.kiegroup.org/v1beta1:KogitoRuntime", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering KogitoRuntime resources.
type kogitoRuntimeState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KogitoRuntimeSpec defines the desired state of KogitoRuntime.
	Spec *KogitoRuntimeSpec `pulumi:"spec"`
	// KogitoRuntimeStatus defines the observed state of KogitoRuntime.
	Status *KogitoRuntimeStatus `pulumi:"status"`
}

type KogitoRuntimeState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KogitoRuntimeSpec defines the desired state of KogitoRuntime.
	Spec KogitoRuntimeSpecPtrInput
	// KogitoRuntimeStatus defines the observed state of KogitoRuntime.
	Status KogitoRuntimeStatusPtrInput
}

func (KogitoRuntimeState) ElementType() reflect.Type {
	return reflect.TypeOf((*kogitoRuntimeState)(nil)).Elem()
}

type kogitoRuntimeArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KogitoRuntimeSpec defines the desired state of KogitoRuntime.
	Spec *KogitoRuntimeSpec `pulumi:"spec"`
	// KogitoRuntimeStatus defines the observed state of KogitoRuntime.
	Status *KogitoRuntimeStatus `pulumi:"status"`
}

// The set of arguments for constructing a KogitoRuntime resource.
type KogitoRuntimeArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KogitoRuntimeSpec defines the desired state of KogitoRuntime.
	Spec KogitoRuntimeSpecPtrInput
	// KogitoRuntimeStatus defines the observed state of KogitoRuntime.
	Status KogitoRuntimeStatusPtrInput
}

func (KogitoRuntimeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*kogitoRuntimeArgs)(nil)).Elem()
}
