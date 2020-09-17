// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type API struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	Spec       APISpecPtrOutput           `pulumi:"spec"`
	Status     pulumi.MapOutput           `pulumi:"status"`
}

// NewAPI registers a new resource with the given unique name, arguments, and options.
func NewAPI(ctx *pulumi.Context,
	name string, args *APIArgs, opts ...pulumi.ResourceOption) (*API, error) {
	if args == nil {
		args = &APIArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("wso2.com/v1alpha1")
	args.Kind = pulumi.StringPtr("API")
	var resource API
	err := ctx.RegisterResource("kubernetes:wso2.com/v1alpha1:API", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAPI gets an existing API resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAPI(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *APIState, opts ...pulumi.ResourceOption) (*API, error) {
	var resource API
	err := ctx.ReadResource("kubernetes:wso2.com/v1alpha1:API", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering API resources.
type apiState struct {
	ApiVersion *string                `pulumi:"apiVersion"`
	Kind       *string                `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta     `pulumi:"metadata"`
	Spec       *APISpec               `pulumi:"spec"`
	Status     map[string]interface{} `pulumi:"status"`
}

type APIState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       APISpecPtrInput
	Status     pulumi.MapInput
}

func (APIState) ElementType() reflect.Type {
	return reflect.TypeOf((*apiState)(nil)).Elem()
}

type apiArgs struct {
	ApiVersion *string                `pulumi:"apiVersion"`
	Kind       *string                `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta     `pulumi:"metadata"`
	Spec       *APISpec               `pulumi:"spec"`
	Status     map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a API resource.
type APIArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       APISpecPtrInput
	Status     pulumi.MapInput
}

func (APIArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*apiArgs)(nil)).Elem()
}
