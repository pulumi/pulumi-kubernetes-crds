// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha2

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// BlobContainer is the Schema for the blobcontainers API
type BlobContainer struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// BlobContainerSpec defines the desired state of BlobContainer
	Spec BlobContainerSpecPtrOutput `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status BlobContainerStatusPtrOutput `pulumi:"status"`
}

// NewBlobContainer registers a new resource with the given unique name, arguments, and options.
func NewBlobContainer(ctx *pulumi.Context,
	name string, args *BlobContainerArgs, opts ...pulumi.ResourceOption) (*BlobContainer, error) {
	if args == nil {
		args = &BlobContainerArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("azure.microsoft.com/v1alpha2")
	args.Kind = pulumi.StringPtr("BlobContainer")
	var resource BlobContainer
	err := ctx.RegisterResource("kubernetes:azure.microsoft.com/v1alpha2:BlobContainer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBlobContainer gets an existing BlobContainer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBlobContainer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BlobContainerState, opts ...pulumi.ResourceOption) (*BlobContainer, error) {
	var resource BlobContainer
	err := ctx.ReadResource("kubernetes:azure.microsoft.com/v1alpha2:BlobContainer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BlobContainer resources.
type blobContainerState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// BlobContainerSpec defines the desired state of BlobContainer
	Spec *BlobContainerSpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *BlobContainerStatus `pulumi:"status"`
}

type BlobContainerState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// BlobContainerSpec defines the desired state of BlobContainer
	Spec BlobContainerSpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status BlobContainerStatusPtrInput
}

func (BlobContainerState) ElementType() reflect.Type {
	return reflect.TypeOf((*blobContainerState)(nil)).Elem()
}

type blobContainerArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// BlobContainerSpec defines the desired state of BlobContainer
	Spec *BlobContainerSpec `pulumi:"spec"`
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status *BlobContainerStatus `pulumi:"status"`
}

// The set of arguments for constructing a BlobContainer resource.
type BlobContainerArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// BlobContainerSpec defines the desired state of BlobContainer
	Spec BlobContainerSpecPtrInput
	// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
	Status BlobContainerStatusPtrInput
}

func (BlobContainerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*blobContainerArgs)(nil)).Elem()
}
