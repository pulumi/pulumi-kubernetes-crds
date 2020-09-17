// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// AquaServer is the Schema for the aquaservers API
type AquaServer struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// AquaServerSpec defines the desired state of AquaServer
	Spec pulumi.MapOutput `pulumi:"spec"`
	// AquaServerStatus defines the observed state of AquaServer
	Status pulumi.MapOutput `pulumi:"status"`
}

// NewAquaServer registers a new resource with the given unique name, arguments, and options.
func NewAquaServer(ctx *pulumi.Context,
	name string, args *AquaServerArgs, opts ...pulumi.ResourceOption) (*AquaServer, error) {
	if args == nil {
		args = &AquaServerArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("operator.aquasec.com/v1alpha1")
	args.Kind = pulumi.StringPtr("AquaServer")
	var resource AquaServer
	err := ctx.RegisterResource("kubernetes:operator.aquasec.com/v1alpha1:AquaServer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAquaServer gets an existing AquaServer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAquaServer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AquaServerState, opts ...pulumi.ResourceOption) (*AquaServer, error) {
	var resource AquaServer
	err := ctx.ReadResource("kubernetes:operator.aquasec.com/v1alpha1:AquaServer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AquaServer resources.
type aquaServerState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// AquaServerSpec defines the desired state of AquaServer
	Spec map[string]interface{} `pulumi:"spec"`
	// AquaServerStatus defines the observed state of AquaServer
	Status map[string]interface{} `pulumi:"status"`
}

type AquaServerState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// AquaServerSpec defines the desired state of AquaServer
	Spec pulumi.MapInput
	// AquaServerStatus defines the observed state of AquaServer
	Status pulumi.MapInput
}

func (AquaServerState) ElementType() reflect.Type {
	return reflect.TypeOf((*aquaServerState)(nil)).Elem()
}

type aquaServerArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// AquaServerSpec defines the desired state of AquaServer
	Spec map[string]interface{} `pulumi:"spec"`
	// AquaServerStatus defines the observed state of AquaServer
	Status map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a AquaServer resource.
type AquaServerArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// AquaServerSpec defines the desired state of AquaServer
	Spec pulumi.MapInput
	// AquaServerStatus defines the observed state of AquaServer
	Status pulumi.MapInput
}

func (AquaServerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*aquaServerArgs)(nil)).Elem()
}
