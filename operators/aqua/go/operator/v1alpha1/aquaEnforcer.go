// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// AquaEnforcer is the Schema for the aquaenforcers API
type AquaEnforcer struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// AquaEnforcerSpec defines the desired state of AquaEnforcer
	Spec pulumi.MapOutput `pulumi:"spec"`
	// AquaEnforcerStatus defines the observed state of AquaEnforcer
	Status pulumi.MapOutput `pulumi:"status"`
}

// NewAquaEnforcer registers a new resource with the given unique name, arguments, and options.
func NewAquaEnforcer(ctx *pulumi.Context,
	name string, args *AquaEnforcerArgs, opts ...pulumi.ResourceOption) (*AquaEnforcer, error) {
	if args == nil {
		args = &AquaEnforcerArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("operator.aquasec.com/v1alpha1")
	args.Kind = pulumi.StringPtr("AquaEnforcer")
	var resource AquaEnforcer
	err := ctx.RegisterResource("kubernetes:operator.aquasec.com/v1alpha1:AquaEnforcer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAquaEnforcer gets an existing AquaEnforcer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAquaEnforcer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AquaEnforcerState, opts ...pulumi.ResourceOption) (*AquaEnforcer, error) {
	var resource AquaEnforcer
	err := ctx.ReadResource("kubernetes:operator.aquasec.com/v1alpha1:AquaEnforcer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AquaEnforcer resources.
type aquaEnforcerState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// AquaEnforcerSpec defines the desired state of AquaEnforcer
	Spec map[string]interface{} `pulumi:"spec"`
	// AquaEnforcerStatus defines the observed state of AquaEnforcer
	Status map[string]interface{} `pulumi:"status"`
}

type AquaEnforcerState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// AquaEnforcerSpec defines the desired state of AquaEnforcer
	Spec pulumi.MapInput
	// AquaEnforcerStatus defines the observed state of AquaEnforcer
	Status pulumi.MapInput
}

func (AquaEnforcerState) ElementType() reflect.Type {
	return reflect.TypeOf((*aquaEnforcerState)(nil)).Elem()
}

type aquaEnforcerArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// AquaEnforcerSpec defines the desired state of AquaEnforcer
	Spec map[string]interface{} `pulumi:"spec"`
	// AquaEnforcerStatus defines the observed state of AquaEnforcer
	Status map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a AquaEnforcer resource.
type AquaEnforcerArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// AquaEnforcerSpec defines the desired state of AquaEnforcer
	Spec pulumi.MapInput
	// AquaEnforcerStatus defines the observed state of AquaEnforcer
	Status pulumi.MapInput
}

func (AquaEnforcerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*aquaEnforcerArgs)(nil)).Elem()
}
