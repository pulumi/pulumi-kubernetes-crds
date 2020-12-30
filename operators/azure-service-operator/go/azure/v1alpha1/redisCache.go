// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// RedisCache is the Schema for the rediscaches API
type RedisCache struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// RedisCacheSpec defines the desired state of RedisCache
	Spec RedisCacheSpecPtrOutput `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status RedisCacheStatusPtrOutput `pulumi:"status"`
}

// NewRedisCache registers a new resource with the given unique name, arguments, and options.
func NewRedisCache(ctx *pulumi.Context,
	name string, args *RedisCacheArgs, opts ...pulumi.ResourceOption) (*RedisCache, error) {
	if args == nil {
		args = &RedisCacheArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("azure.microsoft.com/v1alpha1")
	args.Kind = pulumi.StringPtr("RedisCache")
	var resource RedisCache
	err := ctx.RegisterResource("kubernetes:azure.microsoft.com/v1alpha1:RedisCache", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRedisCache gets an existing RedisCache resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRedisCache(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RedisCacheState, opts ...pulumi.ResourceOption) (*RedisCache, error) {
	var resource RedisCache
	err := ctx.ReadResource("kubernetes:azure.microsoft.com/v1alpha1:RedisCache", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RedisCache resources.
type redisCacheState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// RedisCacheSpec defines the desired state of RedisCache
	Spec *RedisCacheSpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *RedisCacheStatus `pulumi:"status"`
}

type RedisCacheState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// RedisCacheSpec defines the desired state of RedisCache
	Spec RedisCacheSpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status RedisCacheStatusPtrInput
}

func (RedisCacheState) ElementType() reflect.Type {
	return reflect.TypeOf((*redisCacheState)(nil)).Elem()
}

type redisCacheArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// RedisCacheSpec defines the desired state of RedisCache
	Spec *RedisCacheSpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *RedisCacheStatus `pulumi:"status"`
}

// The set of arguments for constructing a RedisCache resource.
type RedisCacheArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// RedisCacheSpec defines the desired state of RedisCache
	Spec RedisCacheSpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status RedisCacheStatusPtrInput
}

func (RedisCacheArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*redisCacheArgs)(nil)).Elem()
}
