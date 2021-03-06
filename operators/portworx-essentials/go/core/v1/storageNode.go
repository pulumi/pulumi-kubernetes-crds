// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type StorageNode struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// The desired behavior of the storage node. Currently changing the spec does not affect the actual storage node in the cluster. Eventually spec in StorageNode will override the spec from StorageCluster so that configuration can be overridden at node level.
	Spec StorageNodeSpecPtrOutput `pulumi:"spec"`
	// Most recently observed status of the storage node. The data may not be up to date.
	Status StorageNodeStatusPtrOutput `pulumi:"status"`
}

// NewStorageNode registers a new resource with the given unique name, arguments, and options.
func NewStorageNode(ctx *pulumi.Context,
	name string, args *StorageNodeArgs, opts ...pulumi.ResourceOption) (*StorageNode, error) {
	if args == nil {
		args = &StorageNodeArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("core.libopenstorage.org/v1")
	args.Kind = pulumi.StringPtr("StorageNode")
	var resource StorageNode
	err := ctx.RegisterResource("kubernetes:core.libopenstorage.org/v1:StorageNode", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStorageNode gets an existing StorageNode resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStorageNode(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StorageNodeState, opts ...pulumi.ResourceOption) (*StorageNode, error) {
	var resource StorageNode
	err := ctx.ReadResource("kubernetes:core.libopenstorage.org/v1:StorageNode", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StorageNode resources.
type storageNodeState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// The desired behavior of the storage node. Currently changing the spec does not affect the actual storage node in the cluster. Eventually spec in StorageNode will override the spec from StorageCluster so that configuration can be overridden at node level.
	Spec *StorageNodeSpec `pulumi:"spec"`
	// Most recently observed status of the storage node. The data may not be up to date.
	Status *StorageNodeStatus `pulumi:"status"`
}

type StorageNodeState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// The desired behavior of the storage node. Currently changing the spec does not affect the actual storage node in the cluster. Eventually spec in StorageNode will override the spec from StorageCluster so that configuration can be overridden at node level.
	Spec StorageNodeSpecPtrInput
	// Most recently observed status of the storage node. The data may not be up to date.
	Status StorageNodeStatusPtrInput
}

func (StorageNodeState) ElementType() reflect.Type {
	return reflect.TypeOf((*storageNodeState)(nil)).Elem()
}

type storageNodeArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// The desired behavior of the storage node. Currently changing the spec does not affect the actual storage node in the cluster. Eventually spec in StorageNode will override the spec from StorageCluster so that configuration can be overridden at node level.
	Spec *StorageNodeSpec `pulumi:"spec"`
	// Most recently observed status of the storage node. The data may not be up to date.
	Status *StorageNodeStatus `pulumi:"status"`
}

// The set of arguments for constructing a StorageNode resource.
type StorageNodeArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// The desired behavior of the storage node. Currently changing the spec does not affect the actual storage node in the cluster. Eventually spec in StorageNode will override the spec from StorageCluster so that configuration can be overridden at node level.
	Spec StorageNodeSpecPtrInput
	// Most recently observed status of the storage node. The data may not be up to date.
	Status StorageNodeStatusPtrInput
}

func (StorageNodeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*storageNodeArgs)(nil)).Elem()
}
