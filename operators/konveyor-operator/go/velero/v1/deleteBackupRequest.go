// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// DeleteBackupRequest is a request to delete one or more backups.
type DeleteBackupRequest struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// DeleteBackupRequestSpec is the specification for which backups to delete.
	Spec DeleteBackupRequestSpecPtrOutput `pulumi:"spec"`
	// DeleteBackupRequestStatus is the current status of a DeleteBackupRequest.
	Status DeleteBackupRequestStatusPtrOutput `pulumi:"status"`
}

// NewDeleteBackupRequest registers a new resource with the given unique name, arguments, and options.
func NewDeleteBackupRequest(ctx *pulumi.Context,
	name string, args *DeleteBackupRequestArgs, opts ...pulumi.ResourceOption) (*DeleteBackupRequest, error) {
	if args == nil {
		args = &DeleteBackupRequestArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("velero.io/v1")
	args.Kind = pulumi.StringPtr("DeleteBackupRequest")
	var resource DeleteBackupRequest
	err := ctx.RegisterResource("kubernetes:velero.io/v1:DeleteBackupRequest", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDeleteBackupRequest gets an existing DeleteBackupRequest resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDeleteBackupRequest(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DeleteBackupRequestState, opts ...pulumi.ResourceOption) (*DeleteBackupRequest, error) {
	var resource DeleteBackupRequest
	err := ctx.ReadResource("kubernetes:velero.io/v1:DeleteBackupRequest", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DeleteBackupRequest resources.
type deleteBackupRequestState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// DeleteBackupRequestSpec is the specification for which backups to delete.
	Spec *DeleteBackupRequestSpec `pulumi:"spec"`
	// DeleteBackupRequestStatus is the current status of a DeleteBackupRequest.
	Status *DeleteBackupRequestStatus `pulumi:"status"`
}

type DeleteBackupRequestState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// DeleteBackupRequestSpec is the specification for which backups to delete.
	Spec DeleteBackupRequestSpecPtrInput
	// DeleteBackupRequestStatus is the current status of a DeleteBackupRequest.
	Status DeleteBackupRequestStatusPtrInput
}

func (DeleteBackupRequestState) ElementType() reflect.Type {
	return reflect.TypeOf((*deleteBackupRequestState)(nil)).Elem()
}

type deleteBackupRequestArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// DeleteBackupRequestSpec is the specification for which backups to delete.
	Spec *DeleteBackupRequestSpec `pulumi:"spec"`
	// DeleteBackupRequestStatus is the current status of a DeleteBackupRequest.
	Status *DeleteBackupRequestStatus `pulumi:"status"`
}

// The set of arguments for constructing a DeleteBackupRequest resource.
type DeleteBackupRequestArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// DeleteBackupRequestSpec is the specification for which backups to delete.
	Spec DeleteBackupRequestSpecPtrInput
	// DeleteBackupRequestStatus is the current status of a DeleteBackupRequest.
	Status DeleteBackupRequestStatusPtrInput
}

func (DeleteBackupRequestArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*deleteBackupRequestArgs)(nil)).Elem()
}
