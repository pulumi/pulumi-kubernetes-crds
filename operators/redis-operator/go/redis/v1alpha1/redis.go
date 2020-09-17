// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Redis is the Schema for the redis API
type Redis struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// RedisSpec defines the desired state of Redis
	Spec pulumi.MapOutput `pulumi:"spec"`
	// RedisStatus defines the observed state of Redis
	Status pulumi.MapOutput `pulumi:"status"`
}

// NewRedis registers a new resource with the given unique name, arguments, and options.
func NewRedis(ctx *pulumi.Context,
	name string, args *RedisArgs, opts ...pulumi.ResourceOption) (*Redis, error) {
	if args == nil {
		args = &RedisArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("redis.opstreelabs.in/v1alpha1")
	args.Kind = pulumi.StringPtr("Redis")
	var resource Redis
	err := ctx.RegisterResource("kubernetes:redis.opstreelabs.in/v1alpha1:Redis", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRedis gets an existing Redis resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRedis(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RedisState, opts ...pulumi.ResourceOption) (*Redis, error) {
	var resource Redis
	err := ctx.ReadResource("kubernetes:redis.opstreelabs.in/v1alpha1:Redis", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Redis resources.
type redisState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// RedisSpec defines the desired state of Redis
	Spec map[string]interface{} `pulumi:"spec"`
	// RedisStatus defines the observed state of Redis
	Status map[string]interface{} `pulumi:"status"`
}

type RedisState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// RedisSpec defines the desired state of Redis
	Spec pulumi.MapInput
	// RedisStatus defines the observed state of Redis
	Status pulumi.MapInput
}

func (RedisState) ElementType() reflect.Type {
	return reflect.TypeOf((*redisState)(nil)).Elem()
}

type redisArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// RedisSpec defines the desired state of Redis
	Spec map[string]interface{} `pulumi:"spec"`
	// RedisStatus defines the observed state of Redis
	Status map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a Redis resource.
type RedisArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// RedisSpec defines the desired state of Redis
	Spec pulumi.MapInput
	// RedisStatus defines the observed state of Redis
	Status pulumi.MapInput
}

func (RedisArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*redisArgs)(nil)).Elem()
}
