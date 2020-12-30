// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Security is the Schema for the securities API
type Security struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// SecuritySpec defines the desired state of Security
	Spec SecuritySpecPtrOutput `pulumi:"spec"`
	// SecurityStatus defines the observed state of Security
	Status pulumi.MapOutput `pulumi:"status"`
}

// NewSecurity registers a new resource with the given unique name, arguments, and options.
func NewSecurity(ctx *pulumi.Context,
	name string, args *SecurityArgs, opts ...pulumi.ResourceOption) (*Security, error) {
	if args == nil {
		args = &SecurityArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("wso2.com/v1alpha1")
	args.Kind = pulumi.StringPtr("Security")
	var resource Security
	err := ctx.RegisterResource("kubernetes:wso2.com/v1alpha1:Security", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecurity gets an existing Security resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecurity(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecurityState, opts ...pulumi.ResourceOption) (*Security, error) {
	var resource Security
	err := ctx.ReadResource("kubernetes:wso2.com/v1alpha1:Security", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Security resources.
type securityState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// SecuritySpec defines the desired state of Security
	Spec *SecuritySpec `pulumi:"spec"`
	// SecurityStatus defines the observed state of Security
	Status map[string]interface{} `pulumi:"status"`
}

type SecurityState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// SecuritySpec defines the desired state of Security
	Spec SecuritySpecPtrInput
	// SecurityStatus defines the observed state of Security
	Status pulumi.MapInput
}

func (SecurityState) ElementType() reflect.Type {
	return reflect.TypeOf((*securityState)(nil)).Elem()
}

type securityArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// SecuritySpec defines the desired state of Security
	Spec *SecuritySpec `pulumi:"spec"`
	// SecurityStatus defines the observed state of Security
	Status map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a Security resource.
type SecurityArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// SecuritySpec defines the desired state of Security
	Spec SecuritySpecPtrInput
	// SecurityStatus defines the observed state of Security
	Status pulumi.MapInput
}

func (SecurityArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*securityArgs)(nil)).Elem()
}
