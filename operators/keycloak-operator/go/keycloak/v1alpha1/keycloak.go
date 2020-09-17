// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Keycloak is the Schema for the keycloaks API.
type Keycloak struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// KeycloakSpec defines the desired state of Keycloak.
	Spec KeycloakSpecPtrOutput `pulumi:"spec"`
	// KeycloakStatus defines the observed state of Keycloak.
	Status KeycloakStatusPtrOutput `pulumi:"status"`
}

// NewKeycloak registers a new resource with the given unique name, arguments, and options.
func NewKeycloak(ctx *pulumi.Context,
	name string, args *KeycloakArgs, opts ...pulumi.ResourceOption) (*Keycloak, error) {
	if args == nil {
		args = &KeycloakArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("keycloak.org/v1alpha1")
	args.Kind = pulumi.StringPtr("Keycloak")
	var resource Keycloak
	err := ctx.RegisterResource("kubernetes:keycloak.org/v1alpha1:Keycloak", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetKeycloak gets an existing Keycloak resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKeycloak(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *KeycloakState, opts ...pulumi.ResourceOption) (*Keycloak, error) {
	var resource Keycloak
	err := ctx.ReadResource("kubernetes:keycloak.org/v1alpha1:Keycloak", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Keycloak resources.
type keycloakState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KeycloakSpec defines the desired state of Keycloak.
	Spec *KeycloakSpec `pulumi:"spec"`
	// KeycloakStatus defines the observed state of Keycloak.
	Status *KeycloakStatus `pulumi:"status"`
}

type KeycloakState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KeycloakSpec defines the desired state of Keycloak.
	Spec KeycloakSpecPtrInput
	// KeycloakStatus defines the observed state of Keycloak.
	Status KeycloakStatusPtrInput
}

func (KeycloakState) ElementType() reflect.Type {
	return reflect.TypeOf((*keycloakState)(nil)).Elem()
}

type keycloakArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KeycloakSpec defines the desired state of Keycloak.
	Spec *KeycloakSpec `pulumi:"spec"`
	// KeycloakStatus defines the observed state of Keycloak.
	Status *KeycloakStatus `pulumi:"status"`
}

// The set of arguments for constructing a Keycloak resource.
type KeycloakArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KeycloakSpec defines the desired state of Keycloak.
	Spec KeycloakSpecPtrInput
	// KeycloakStatus defines the observed state of Keycloak.
	Status KeycloakStatusPtrInput
}

func (KeycloakArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*keycloakArgs)(nil)).Elem()
}
