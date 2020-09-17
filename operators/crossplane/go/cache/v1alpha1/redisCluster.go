// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A RedisCluster is a portable resource claim that may be satisfied by binding to a Redis managed resource such as a GCP CloudMemorystore instance or an AWS ReplicationGroup. Despite the name RedisCluster claims may bind to Redis managed resources that are a single node, or not in cluster mode.
type RedisCluster struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// RedisClusterSpec specifies the desired state of a RedisCluster.
	Spec RedisClusterSpecPtrOutput `pulumi:"spec"`
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status RedisClusterStatusPtrOutput `pulumi:"status"`
}

// NewRedisCluster registers a new resource with the given unique name, arguments, and options.
func NewRedisCluster(ctx *pulumi.Context,
	name string, args *RedisClusterArgs, opts ...pulumi.ResourceOption) (*RedisCluster, error) {
	if args == nil {
		args = &RedisClusterArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("cache.crossplane.io/v1alpha1")
	args.Kind = pulumi.StringPtr("RedisCluster")
	var resource RedisCluster
	err := ctx.RegisterResource("kubernetes:cache.crossplane.io/v1alpha1:RedisCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRedisCluster gets an existing RedisCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRedisCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RedisClusterState, opts ...pulumi.ResourceOption) (*RedisCluster, error) {
	var resource RedisCluster
	err := ctx.ReadResource("kubernetes:cache.crossplane.io/v1alpha1:RedisCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RedisCluster resources.
type redisClusterState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// RedisClusterSpec specifies the desired state of a RedisCluster.
	Spec *RedisClusterSpec `pulumi:"spec"`
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status *RedisClusterStatus `pulumi:"status"`
}

type RedisClusterState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// RedisClusterSpec specifies the desired state of a RedisCluster.
	Spec RedisClusterSpecPtrInput
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status RedisClusterStatusPtrInput
}

func (RedisClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*redisClusterState)(nil)).Elem()
}

type redisClusterArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// RedisClusterSpec specifies the desired state of a RedisCluster.
	Spec *RedisClusterSpec `pulumi:"spec"`
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status *RedisClusterStatus `pulumi:"status"`
}

// The set of arguments for constructing a RedisCluster resource.
type RedisClusterArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// RedisClusterSpec specifies the desired state of a RedisCluster.
	Spec RedisClusterSpecPtrInput
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status RedisClusterStatusPtrInput
}

func (RedisClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*redisClusterArgs)(nil)).Elem()
}
