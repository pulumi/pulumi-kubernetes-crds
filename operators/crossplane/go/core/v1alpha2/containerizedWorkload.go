// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha2

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A ContainerizedWorkload is a workload that runs OCI containers.
type ContainerizedWorkload struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// A ContainerizedWorkloadSpec defines the desired state of a ContainerizedWorkload.
	Spec ContainerizedWorkloadSpecPtrOutput `pulumi:"spec"`
	// A ContainerizedWorkloadStatus represents the observed state of a ContainerizedWorkload.
	Status ContainerizedWorkloadStatusPtrOutput `pulumi:"status"`
}

// NewContainerizedWorkload registers a new resource with the given unique name, arguments, and options.
func NewContainerizedWorkload(ctx *pulumi.Context,
	name string, args *ContainerizedWorkloadArgs, opts ...pulumi.ResourceOption) (*ContainerizedWorkload, error) {
	if args == nil {
		args = &ContainerizedWorkloadArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("core.oam.dev/v1alpha2")
	args.Kind = pulumi.StringPtr("ContainerizedWorkload")
	var resource ContainerizedWorkload
	err := ctx.RegisterResource("kubernetes:core.oam.dev/v1alpha2:ContainerizedWorkload", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetContainerizedWorkload gets an existing ContainerizedWorkload resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetContainerizedWorkload(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ContainerizedWorkloadState, opts ...pulumi.ResourceOption) (*ContainerizedWorkload, error) {
	var resource ContainerizedWorkload
	err := ctx.ReadResource("kubernetes:core.oam.dev/v1alpha2:ContainerizedWorkload", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ContainerizedWorkload resources.
type containerizedWorkloadState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// A ContainerizedWorkloadSpec defines the desired state of a ContainerizedWorkload.
	Spec *ContainerizedWorkloadSpec `pulumi:"spec"`
	// A ContainerizedWorkloadStatus represents the observed state of a ContainerizedWorkload.
	Status *ContainerizedWorkloadStatus `pulumi:"status"`
}

type ContainerizedWorkloadState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// A ContainerizedWorkloadSpec defines the desired state of a ContainerizedWorkload.
	Spec ContainerizedWorkloadSpecPtrInput
	// A ContainerizedWorkloadStatus represents the observed state of a ContainerizedWorkload.
	Status ContainerizedWorkloadStatusPtrInput
}

func (ContainerizedWorkloadState) ElementType() reflect.Type {
	return reflect.TypeOf((*containerizedWorkloadState)(nil)).Elem()
}

type containerizedWorkloadArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// A ContainerizedWorkloadSpec defines the desired state of a ContainerizedWorkload.
	Spec *ContainerizedWorkloadSpec `pulumi:"spec"`
	// A ContainerizedWorkloadStatus represents the observed state of a ContainerizedWorkload.
	Status *ContainerizedWorkloadStatus `pulumi:"status"`
}

// The set of arguments for constructing a ContainerizedWorkload resource.
type ContainerizedWorkloadArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// A ContainerizedWorkloadSpec defines the desired state of a ContainerizedWorkload.
	Spec ContainerizedWorkloadSpecPtrInput
	// A ContainerizedWorkloadStatus represents the observed state of a ContainerizedWorkload.
	Status ContainerizedWorkloadStatusPtrInput
}

func (ContainerizedWorkloadArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*containerizedWorkloadArgs)(nil)).Elem()
}
