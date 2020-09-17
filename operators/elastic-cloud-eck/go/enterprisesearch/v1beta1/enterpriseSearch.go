// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// EnterpriseSearch is a Kubernetes CRD to represent Enterprise Search.
type EnterpriseSearch struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// EnterpriseSearchSpec holds the specification of an Enterprise Search resource.
	Spec EnterpriseSearchSpecPtrOutput `pulumi:"spec"`
	// EnterpriseSearchStatus defines the observed state of EnterpriseSearch
	Status EnterpriseSearchStatusPtrOutput `pulumi:"status"`
}

// NewEnterpriseSearch registers a new resource with the given unique name, arguments, and options.
func NewEnterpriseSearch(ctx *pulumi.Context,
	name string, args *EnterpriseSearchArgs, opts ...pulumi.ResourceOption) (*EnterpriseSearch, error) {
	if args == nil {
		args = &EnterpriseSearchArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("enterprisesearch.k8s.elastic.co/v1beta1")
	args.Kind = pulumi.StringPtr("EnterpriseSearch")
	var resource EnterpriseSearch
	err := ctx.RegisterResource("kubernetes:enterprisesearch.k8s.elastic.co/v1beta1:EnterpriseSearch", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEnterpriseSearch gets an existing EnterpriseSearch resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEnterpriseSearch(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EnterpriseSearchState, opts ...pulumi.ResourceOption) (*EnterpriseSearch, error) {
	var resource EnterpriseSearch
	err := ctx.ReadResource("kubernetes:enterprisesearch.k8s.elastic.co/v1beta1:EnterpriseSearch", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EnterpriseSearch resources.
type enterpriseSearchState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// EnterpriseSearchSpec holds the specification of an Enterprise Search resource.
	Spec *EnterpriseSearchSpec `pulumi:"spec"`
	// EnterpriseSearchStatus defines the observed state of EnterpriseSearch
	Status *EnterpriseSearchStatus `pulumi:"status"`
}

type EnterpriseSearchState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// EnterpriseSearchSpec holds the specification of an Enterprise Search resource.
	Spec EnterpriseSearchSpecPtrInput
	// EnterpriseSearchStatus defines the observed state of EnterpriseSearch
	Status EnterpriseSearchStatusPtrInput
}

func (EnterpriseSearchState) ElementType() reflect.Type {
	return reflect.TypeOf((*enterpriseSearchState)(nil)).Elem()
}

type enterpriseSearchArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// EnterpriseSearchSpec holds the specification of an Enterprise Search resource.
	Spec *EnterpriseSearchSpec `pulumi:"spec"`
	// EnterpriseSearchStatus defines the observed state of EnterpriseSearch
	Status *EnterpriseSearchStatus `pulumi:"status"`
}

// The set of arguments for constructing a EnterpriseSearch resource.
type EnterpriseSearchArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// EnterpriseSearchSpec holds the specification of an Enterprise Search resource.
	Spec EnterpriseSearchSpecPtrInput
	// EnterpriseSearchStatus defines the observed state of EnterpriseSearch
	Status EnterpriseSearchStatusPtrInput
}

func (EnterpriseSearchArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*enterpriseSearchArgs)(nil)).Elem()
}