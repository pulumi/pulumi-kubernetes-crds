// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ServiceBindingRequest expresses intent to bind an operator-backed service with an application workload.
type ServiceBindingRequest struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ServiceBindingRequestSpec defines the desired state of ServiceBindingRequest
	Spec ServiceBindingRequestSpecPtrOutput `pulumi:"spec"`
	// ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
	Status ServiceBindingRequestStatusPtrOutput `pulumi:"status"`
}

// NewServiceBindingRequest registers a new resource with the given unique name, arguments, and options.
func NewServiceBindingRequest(ctx *pulumi.Context,
	name string, args *ServiceBindingRequestArgs, opts ...pulumi.ResourceOption) (*ServiceBindingRequest, error) {
	if args == nil {
		args = &ServiceBindingRequestArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("apps.openshift.io/v1alpha1")
	args.Kind = pulumi.StringPtr("ServiceBindingRequest")
	var resource ServiceBindingRequest
	err := ctx.RegisterResource("kubernetes:apps.openshift.io/v1alpha1:ServiceBindingRequest", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceBindingRequest gets an existing ServiceBindingRequest resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceBindingRequest(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceBindingRequestState, opts ...pulumi.ResourceOption) (*ServiceBindingRequest, error) {
	var resource ServiceBindingRequest
	err := ctx.ReadResource("kubernetes:apps.openshift.io/v1alpha1:ServiceBindingRequest", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceBindingRequest resources.
type serviceBindingRequestState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ServiceBindingRequestSpec defines the desired state of ServiceBindingRequest
	Spec *ServiceBindingRequestSpec `pulumi:"spec"`
	// ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
	Status *ServiceBindingRequestStatus `pulumi:"status"`
}

type ServiceBindingRequestState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ServiceBindingRequestSpec defines the desired state of ServiceBindingRequest
	Spec ServiceBindingRequestSpecPtrInput
	// ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
	Status ServiceBindingRequestStatusPtrInput
}

func (ServiceBindingRequestState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceBindingRequestState)(nil)).Elem()
}

type serviceBindingRequestArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ServiceBindingRequestSpec defines the desired state of ServiceBindingRequest
	Spec *ServiceBindingRequestSpec `pulumi:"spec"`
	// ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
	Status *ServiceBindingRequestStatus `pulumi:"status"`
}

// The set of arguments for constructing a ServiceBindingRequest resource.
type ServiceBindingRequestArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ServiceBindingRequestSpec defines the desired state of ServiceBindingRequest
	Spec ServiceBindingRequestSpecPtrInput
	// ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
	Status ServiceBindingRequestStatusPtrInput
}

func (ServiceBindingRequestArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceBindingRequestArgs)(nil)).Elem()
}
