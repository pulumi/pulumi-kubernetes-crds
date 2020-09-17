// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// AquaCsp is the Schema for the aquacsps API
type AquaCsp struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// AquaCspSpec defines the desired state of AquaCsp
	Spec pulumi.MapOutput `pulumi:"spec"`
	// AquaCspStatus defines the observed state of AquaCsp
	Status pulumi.MapOutput `pulumi:"status"`
}

// NewAquaCsp registers a new resource with the given unique name, arguments, and options.
func NewAquaCsp(ctx *pulumi.Context,
	name string, args *AquaCspArgs, opts ...pulumi.ResourceOption) (*AquaCsp, error) {
	if args == nil {
		args = &AquaCspArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("operator.aquasec.com/v1alpha1")
	args.Kind = pulumi.StringPtr("AquaCsp")
	var resource AquaCsp
	err := ctx.RegisterResource("kubernetes:operator.aquasec.com/v1alpha1:AquaCsp", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAquaCsp gets an existing AquaCsp resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAquaCsp(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AquaCspState, opts ...pulumi.ResourceOption) (*AquaCsp, error) {
	var resource AquaCsp
	err := ctx.ReadResource("kubernetes:operator.aquasec.com/v1alpha1:AquaCsp", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AquaCsp resources.
type aquaCspState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// AquaCspSpec defines the desired state of AquaCsp
	Spec map[string]interface{} `pulumi:"spec"`
	// AquaCspStatus defines the observed state of AquaCsp
	Status map[string]interface{} `pulumi:"status"`
}

type AquaCspState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// AquaCspSpec defines the desired state of AquaCsp
	Spec pulumi.MapInput
	// AquaCspStatus defines the observed state of AquaCsp
	Status pulumi.MapInput
}

func (AquaCspState) ElementType() reflect.Type {
	return reflect.TypeOf((*aquaCspState)(nil)).Elem()
}

type aquaCspArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// AquaCspSpec defines the desired state of AquaCsp
	Spec map[string]interface{} `pulumi:"spec"`
	// AquaCspStatus defines the observed state of AquaCsp
	Status map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a AquaCsp resource.
type AquaCspArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// AquaCspSpec defines the desired state of AquaCsp
	Spec pulumi.MapInput
	// AquaCspStatus defines the observed state of AquaCsp
	Status pulumi.MapInput
}

func (AquaCspArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*aquaCspArgs)(nil)).Elem()
}