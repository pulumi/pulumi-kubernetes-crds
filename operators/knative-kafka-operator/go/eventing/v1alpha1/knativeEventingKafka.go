// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type KnativeEventingKafka struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput              `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput              `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput          `pulumi:"metadata"`
	Spec       KnativeEventingKafkaSpecPtrOutput   `pulumi:"spec"`
	Status     KnativeEventingKafkaStatusPtrOutput `pulumi:"status"`
}

// NewKnativeEventingKafka registers a new resource with the given unique name, arguments, and options.
func NewKnativeEventingKafka(ctx *pulumi.Context,
	name string, args *KnativeEventingKafkaArgs, opts ...pulumi.ResourceOption) (*KnativeEventingKafka, error) {
	if args == nil {
		args = &KnativeEventingKafkaArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("eventing.knative.dev/v1alpha1")
	args.Kind = pulumi.StringPtr("KnativeEventingKafka")
	var resource KnativeEventingKafka
	err := ctx.RegisterResource("kubernetes:eventing.knative.dev/v1alpha1:KnativeEventingKafka", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetKnativeEventingKafka gets an existing KnativeEventingKafka resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKnativeEventingKafka(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *KnativeEventingKafkaState, opts ...pulumi.ResourceOption) (*KnativeEventingKafka, error) {
	var resource KnativeEventingKafka
	err := ctx.ReadResource("kubernetes:eventing.knative.dev/v1alpha1:KnativeEventingKafka", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering KnativeEventingKafka resources.
type knativeEventingKafkaState struct {
	ApiVersion *string                     `pulumi:"apiVersion"`
	Kind       *string                     `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta          `pulumi:"metadata"`
	Spec       *KnativeEventingKafkaSpec   `pulumi:"spec"`
	Status     *KnativeEventingKafkaStatus `pulumi:"status"`
}

type KnativeEventingKafkaState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       KnativeEventingKafkaSpecPtrInput
	Status     KnativeEventingKafkaStatusPtrInput
}

func (KnativeEventingKafkaState) ElementType() reflect.Type {
	return reflect.TypeOf((*knativeEventingKafkaState)(nil)).Elem()
}

type knativeEventingKafkaArgs struct {
	ApiVersion *string                     `pulumi:"apiVersion"`
	Kind       *string                     `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta          `pulumi:"metadata"`
	Spec       *KnativeEventingKafkaSpec   `pulumi:"spec"`
	Status     *KnativeEventingKafkaStatus `pulumi:"status"`
}

// The set of arguments for constructing a KnativeEventingKafka resource.
type KnativeEventingKafkaArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       KnativeEventingKafkaSpecPtrInput
	Status     KnativeEventingKafkaStatusPtrInput
}

func (KnativeEventingKafkaArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*knativeEventingKafkaArgs)(nil)).Elem()
}
