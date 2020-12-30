// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// KeyVaultKey is the Schema for the keyvaultkeys API
type KeyVaultKey struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// KeyVaultKeySpec defines the desired state of KeyVaultKey
	Spec KeyVaultKeySpecPtrOutput `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status KeyVaultKeyStatusPtrOutput `pulumi:"status"`
}

// NewKeyVaultKey registers a new resource with the given unique name, arguments, and options.
func NewKeyVaultKey(ctx *pulumi.Context,
	name string, args *KeyVaultKeyArgs, opts ...pulumi.ResourceOption) (*KeyVaultKey, error) {
	if args == nil {
		args = &KeyVaultKeyArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("azure.microsoft.com/v1alpha1")
	args.Kind = pulumi.StringPtr("KeyVaultKey")
	var resource KeyVaultKey
	err := ctx.RegisterResource("kubernetes:azure.microsoft.com/v1alpha1:KeyVaultKey", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetKeyVaultKey gets an existing KeyVaultKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKeyVaultKey(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *KeyVaultKeyState, opts ...pulumi.ResourceOption) (*KeyVaultKey, error) {
	var resource KeyVaultKey
	err := ctx.ReadResource("kubernetes:azure.microsoft.com/v1alpha1:KeyVaultKey", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering KeyVaultKey resources.
type keyVaultKeyState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KeyVaultKeySpec defines the desired state of KeyVaultKey
	Spec *KeyVaultKeySpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *KeyVaultKeyStatus `pulumi:"status"`
}

type KeyVaultKeyState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KeyVaultKeySpec defines the desired state of KeyVaultKey
	Spec KeyVaultKeySpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status KeyVaultKeyStatusPtrInput
}

func (KeyVaultKeyState) ElementType() reflect.Type {
	return reflect.TypeOf((*keyVaultKeyState)(nil)).Elem()
}

type keyVaultKeyArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KeyVaultKeySpec defines the desired state of KeyVaultKey
	Spec *KeyVaultKeySpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *KeyVaultKeyStatus `pulumi:"status"`
}

// The set of arguments for constructing a KeyVaultKey resource.
type KeyVaultKeyArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KeyVaultKeySpec defines the desired state of KeyVaultKey
	Spec KeyVaultKeySpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status KeyVaultKeyStatusPtrInput
}

func (KeyVaultKeyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*keyVaultKeyArgs)(nil)).Elem()
}
