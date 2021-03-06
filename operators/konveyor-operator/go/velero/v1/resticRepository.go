// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ResticRepository struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ResticRepositorySpec is the specification for a ResticRepository.
	Spec ResticRepositorySpecPtrOutput `pulumi:"spec"`
	// ResticRepositoryStatus is the current status of a ResticRepository.
	Status ResticRepositoryStatusPtrOutput `pulumi:"status"`
}

// NewResticRepository registers a new resource with the given unique name, arguments, and options.
func NewResticRepository(ctx *pulumi.Context,
	name string, args *ResticRepositoryArgs, opts ...pulumi.ResourceOption) (*ResticRepository, error) {
	if args == nil {
		args = &ResticRepositoryArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("velero.io/v1")
	args.Kind = pulumi.StringPtr("ResticRepository")
	var resource ResticRepository
	err := ctx.RegisterResource("kubernetes:velero.io/v1:ResticRepository", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetResticRepository gets an existing ResticRepository resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetResticRepository(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ResticRepositoryState, opts ...pulumi.ResourceOption) (*ResticRepository, error) {
	var resource ResticRepository
	err := ctx.ReadResource("kubernetes:velero.io/v1:ResticRepository", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ResticRepository resources.
type resticRepositoryState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ResticRepositorySpec is the specification for a ResticRepository.
	Spec *ResticRepositorySpec `pulumi:"spec"`
	// ResticRepositoryStatus is the current status of a ResticRepository.
	Status *ResticRepositoryStatus `pulumi:"status"`
}

type ResticRepositoryState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ResticRepositorySpec is the specification for a ResticRepository.
	Spec ResticRepositorySpecPtrInput
	// ResticRepositoryStatus is the current status of a ResticRepository.
	Status ResticRepositoryStatusPtrInput
}

func (ResticRepositoryState) ElementType() reflect.Type {
	return reflect.TypeOf((*resticRepositoryState)(nil)).Elem()
}

type resticRepositoryArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ResticRepositorySpec is the specification for a ResticRepository.
	Spec *ResticRepositorySpec `pulumi:"spec"`
	// ResticRepositoryStatus is the current status of a ResticRepository.
	Status *ResticRepositoryStatus `pulumi:"status"`
}

// The set of arguments for constructing a ResticRepository resource.
type ResticRepositoryArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ResticRepositorySpec is the specification for a ResticRepository.
	Spec ResticRepositorySpecPtrInput
	// ResticRepositoryStatus is the current status of a ResticRepository.
	Status ResticRepositoryStatusPtrInput
}

func (ResticRepositoryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*resticRepositoryArgs)(nil)).Elem()
}
