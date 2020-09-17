// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ServerStatusRequest is a request to access current status information about the Velero server.
type ServerStatusRequest struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ServerStatusRequestSpec is the specification for a ServerStatusRequest.
	Spec pulumi.MapOutput `pulumi:"spec"`
	// ServerStatusRequestStatus is the current status of a ServerStatusRequest.
	Status ServerStatusRequestStatusPtrOutput `pulumi:"status"`
}

// NewServerStatusRequest registers a new resource with the given unique name, arguments, and options.
func NewServerStatusRequest(ctx *pulumi.Context,
	name string, args *ServerStatusRequestArgs, opts ...pulumi.ResourceOption) (*ServerStatusRequest, error) {
	if args == nil {
		args = &ServerStatusRequestArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("velero.io/v1")
	args.Kind = pulumi.StringPtr("ServerStatusRequest")
	var resource ServerStatusRequest
	err := ctx.RegisterResource("kubernetes:velero.io/v1:ServerStatusRequest", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServerStatusRequest gets an existing ServerStatusRequest resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServerStatusRequest(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServerStatusRequestState, opts ...pulumi.ResourceOption) (*ServerStatusRequest, error) {
	var resource ServerStatusRequest
	err := ctx.ReadResource("kubernetes:velero.io/v1:ServerStatusRequest", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServerStatusRequest resources.
type serverStatusRequestState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ServerStatusRequestSpec is the specification for a ServerStatusRequest.
	Spec map[string]interface{} `pulumi:"spec"`
	// ServerStatusRequestStatus is the current status of a ServerStatusRequest.
	Status *ServerStatusRequestStatus `pulumi:"status"`
}

type ServerStatusRequestState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ServerStatusRequestSpec is the specification for a ServerStatusRequest.
	Spec pulumi.MapInput
	// ServerStatusRequestStatus is the current status of a ServerStatusRequest.
	Status ServerStatusRequestStatusPtrInput
}

func (ServerStatusRequestState) ElementType() reflect.Type {
	return reflect.TypeOf((*serverStatusRequestState)(nil)).Elem()
}

type serverStatusRequestArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ServerStatusRequestSpec is the specification for a ServerStatusRequest.
	Spec map[string]interface{} `pulumi:"spec"`
	// ServerStatusRequestStatus is the current status of a ServerStatusRequest.
	Status *ServerStatusRequestStatus `pulumi:"status"`
}

// The set of arguments for constructing a ServerStatusRequest resource.
type ServerStatusRequestArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ServerStatusRequestSpec is the specification for a ServerStatusRequest.
	Spec pulumi.MapInput
	// ServerStatusRequestStatus is the current status of a ServerStatusRequest.
	Status ServerStatusRequestStatusPtrInput
}

func (ServerStatusRequestArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serverStatusRequestArgs)(nil)).Elem()
}
