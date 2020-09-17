// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// AuthorizationPolicy is the Schema for the authorizationpolicies API
type AuthorizationPolicy struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// AuthorizationPolicySpec defines the desired state of AuthorizationPolicy
	Spec AuthorizationPolicySpecPtrOutput `pulumi:"spec"`
	// AuthorizationPolicyStatus defines the observed state of AuthorizationPolicy
	Status AuthorizationPolicyStatusPtrOutput `pulumi:"status"`
}

// NewAuthorizationPolicy registers a new resource with the given unique name, arguments, and options.
func NewAuthorizationPolicy(ctx *pulumi.Context,
	name string, args *AuthorizationPolicyArgs, opts ...pulumi.ResourceOption) (*AuthorizationPolicy, error) {
	if args == nil {
		args = &AuthorizationPolicyArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("ibmcloud.ibm.com/v1alpha1")
	args.Kind = pulumi.StringPtr("AuthorizationPolicy")
	var resource AuthorizationPolicy
	err := ctx.RegisterResource("kubernetes:ibmcloud.ibm.com/v1alpha1:AuthorizationPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAuthorizationPolicy gets an existing AuthorizationPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAuthorizationPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AuthorizationPolicyState, opts ...pulumi.ResourceOption) (*AuthorizationPolicy, error) {
	var resource AuthorizationPolicy
	err := ctx.ReadResource("kubernetes:ibmcloud.ibm.com/v1alpha1:AuthorizationPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AuthorizationPolicy resources.
type authorizationPolicyState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// AuthorizationPolicySpec defines the desired state of AuthorizationPolicy
	Spec *AuthorizationPolicySpec `pulumi:"spec"`
	// AuthorizationPolicyStatus defines the observed state of AuthorizationPolicy
	Status *AuthorizationPolicyStatus `pulumi:"status"`
}

type AuthorizationPolicyState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// AuthorizationPolicySpec defines the desired state of AuthorizationPolicy
	Spec AuthorizationPolicySpecPtrInput
	// AuthorizationPolicyStatus defines the observed state of AuthorizationPolicy
	Status AuthorizationPolicyStatusPtrInput
}

func (AuthorizationPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*authorizationPolicyState)(nil)).Elem()
}

type authorizationPolicyArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// AuthorizationPolicySpec defines the desired state of AuthorizationPolicy
	Spec *AuthorizationPolicySpec `pulumi:"spec"`
	// AuthorizationPolicyStatus defines the observed state of AuthorizationPolicy
	Status *AuthorizationPolicyStatus `pulumi:"status"`
}

// The set of arguments for constructing a AuthorizationPolicy resource.
type AuthorizationPolicyArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// AuthorizationPolicySpec defines the desired state of AuthorizationPolicy
	Spec AuthorizationPolicySpecPtrInput
	// AuthorizationPolicyStatus defines the observed state of AuthorizationPolicy
	Status AuthorizationPolicyStatusPtrInput
}

func (AuthorizationPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*authorizationPolicyArgs)(nil)).Elem()
}
