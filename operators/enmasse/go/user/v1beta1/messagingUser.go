// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// MessagingUser is a user that can be used to authenticate and authorize a messaging application. This resource is created by messaging tenants.
type MessagingUser struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput       `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput       `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput   `pulumi:"metadata"`
	Spec       MessagingUserSpecPtrOutput   `pulumi:"spec"`
	Status     MessagingUserStatusPtrOutput `pulumi:"status"`
}

// NewMessagingUser registers a new resource with the given unique name, arguments, and options.
func NewMessagingUser(ctx *pulumi.Context,
	name string, args *MessagingUserArgs, opts ...pulumi.ResourceOption) (*MessagingUser, error) {
	if args == nil {
		args = &MessagingUserArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("user.enmasse.io/v1beta1")
	args.Kind = pulumi.StringPtr("MessagingUser")
	var resource MessagingUser
	err := ctx.RegisterResource("kubernetes:user.enmasse.io/v1beta1:MessagingUser", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMessagingUser gets an existing MessagingUser resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMessagingUser(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MessagingUserState, opts ...pulumi.ResourceOption) (*MessagingUser, error) {
	var resource MessagingUser
	err := ctx.ReadResource("kubernetes:user.enmasse.io/v1beta1:MessagingUser", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MessagingUser resources.
type messagingUserState struct {
	ApiVersion *string              `pulumi:"apiVersion"`
	Kind       *string              `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta   `pulumi:"metadata"`
	Spec       *MessagingUserSpec   `pulumi:"spec"`
	Status     *MessagingUserStatus `pulumi:"status"`
}

type MessagingUserState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       MessagingUserSpecPtrInput
	Status     MessagingUserStatusPtrInput
}

func (MessagingUserState) ElementType() reflect.Type {
	return reflect.TypeOf((*messagingUserState)(nil)).Elem()
}

type messagingUserArgs struct {
	ApiVersion *string              `pulumi:"apiVersion"`
	Kind       *string              `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta   `pulumi:"metadata"`
	Spec       *MessagingUserSpec   `pulumi:"spec"`
	Status     *MessagingUserStatus `pulumi:"status"`
}

// The set of arguments for constructing a MessagingUser resource.
type MessagingUserArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       MessagingUserSpecPtrInput
	Status     MessagingUserStatusPtrInput
}

func (MessagingUserArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*messagingUserArgs)(nil)).Elem()
}
