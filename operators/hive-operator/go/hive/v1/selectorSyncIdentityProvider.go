// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// SelectorSyncIdentityProvider is the Schema for the SelectorSyncSet API
type SelectorSyncIdentityProvider struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// SelectorSyncIdentityProviderSpec defines the SyncIdentityProviderCommonSpec to sync to ClusterDeploymentSelector indicating which clusters the SelectorSyncIdentityProvider applies to in any namespace.
	Spec SelectorSyncIdentityProviderSpecPtrOutput `pulumi:"spec"`
	// IdentityProviderStatus defines the observed state of SyncSet
	Status pulumi.MapOutput `pulumi:"status"`
}

// NewSelectorSyncIdentityProvider registers a new resource with the given unique name, arguments, and options.
func NewSelectorSyncIdentityProvider(ctx *pulumi.Context,
	name string, args *SelectorSyncIdentityProviderArgs, opts ...pulumi.ResourceOption) (*SelectorSyncIdentityProvider, error) {
	if args == nil {
		args = &SelectorSyncIdentityProviderArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("hive.openshift.io/v1")
	args.Kind = pulumi.StringPtr("SelectorSyncIdentityProvider")
	var resource SelectorSyncIdentityProvider
	err := ctx.RegisterResource("kubernetes:hive.openshift.io/v1:SelectorSyncIdentityProvider", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSelectorSyncIdentityProvider gets an existing SelectorSyncIdentityProvider resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSelectorSyncIdentityProvider(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SelectorSyncIdentityProviderState, opts ...pulumi.ResourceOption) (*SelectorSyncIdentityProvider, error) {
	var resource SelectorSyncIdentityProvider
	err := ctx.ReadResource("kubernetes:hive.openshift.io/v1:SelectorSyncIdentityProvider", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SelectorSyncIdentityProvider resources.
type selectorSyncIdentityProviderState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// SelectorSyncIdentityProviderSpec defines the SyncIdentityProviderCommonSpec to sync to ClusterDeploymentSelector indicating which clusters the SelectorSyncIdentityProvider applies to in any namespace.
	Spec *SelectorSyncIdentityProviderSpec `pulumi:"spec"`
	// IdentityProviderStatus defines the observed state of SyncSet
	Status map[string]interface{} `pulumi:"status"`
}

type SelectorSyncIdentityProviderState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// SelectorSyncIdentityProviderSpec defines the SyncIdentityProviderCommonSpec to sync to ClusterDeploymentSelector indicating which clusters the SelectorSyncIdentityProvider applies to in any namespace.
	Spec SelectorSyncIdentityProviderSpecPtrInput
	// IdentityProviderStatus defines the observed state of SyncSet
	Status pulumi.MapInput
}

func (SelectorSyncIdentityProviderState) ElementType() reflect.Type {
	return reflect.TypeOf((*selectorSyncIdentityProviderState)(nil)).Elem()
}

type selectorSyncIdentityProviderArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// SelectorSyncIdentityProviderSpec defines the SyncIdentityProviderCommonSpec to sync to ClusterDeploymentSelector indicating which clusters the SelectorSyncIdentityProvider applies to in any namespace.
	Spec *SelectorSyncIdentityProviderSpec `pulumi:"spec"`
	// IdentityProviderStatus defines the observed state of SyncSet
	Status map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a SelectorSyncIdentityProvider resource.
type SelectorSyncIdentityProviderArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// SelectorSyncIdentityProviderSpec defines the SyncIdentityProviderCommonSpec to sync to ClusterDeploymentSelector indicating which clusters the SelectorSyncIdentityProvider applies to in any namespace.
	Spec SelectorSyncIdentityProviderSpecPtrInput
	// IdentityProviderStatus defines the observed state of SyncSet
	Status pulumi.MapInput
}

func (SelectorSyncIdentityProviderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*selectorSyncIdentityProviderArgs)(nil)).Elem()
}