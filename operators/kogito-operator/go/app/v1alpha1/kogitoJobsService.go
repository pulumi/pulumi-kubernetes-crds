// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// KogitoJobsService deploys the Kogito Jobs Service in the given namespace.
type KogitoJobsService struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// KogitoJobsServiceSpec defines the desired state of KogitoJobsService.
	Spec KogitoJobsServiceSpecPtrOutput `pulumi:"spec"`
	// KogitoJobsServiceStatus defines the observed state of KogitoJobsService.
	Status KogitoJobsServiceStatusPtrOutput `pulumi:"status"`
}

// NewKogitoJobsService registers a new resource with the given unique name, arguments, and options.
func NewKogitoJobsService(ctx *pulumi.Context,
	name string, args *KogitoJobsServiceArgs, opts ...pulumi.ResourceOption) (*KogitoJobsService, error) {
	if args == nil {
		args = &KogitoJobsServiceArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("app.kiegroup.org/v1alpha1")
	args.Kind = pulumi.StringPtr("KogitoJobsService")
	var resource KogitoJobsService
	err := ctx.RegisterResource("kubernetes:app.kiegroup.org/v1alpha1:KogitoJobsService", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetKogitoJobsService gets an existing KogitoJobsService resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKogitoJobsService(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *KogitoJobsServiceState, opts ...pulumi.ResourceOption) (*KogitoJobsService, error) {
	var resource KogitoJobsService
	err := ctx.ReadResource("kubernetes:app.kiegroup.org/v1alpha1:KogitoJobsService", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering KogitoJobsService resources.
type kogitoJobsServiceState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KogitoJobsServiceSpec defines the desired state of KogitoJobsService.
	Spec *KogitoJobsServiceSpec `pulumi:"spec"`
	// KogitoJobsServiceStatus defines the observed state of KogitoJobsService.
	Status *KogitoJobsServiceStatus `pulumi:"status"`
}

type KogitoJobsServiceState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KogitoJobsServiceSpec defines the desired state of KogitoJobsService.
	Spec KogitoJobsServiceSpecPtrInput
	// KogitoJobsServiceStatus defines the observed state of KogitoJobsService.
	Status KogitoJobsServiceStatusPtrInput
}

func (KogitoJobsServiceState) ElementType() reflect.Type {
	return reflect.TypeOf((*kogitoJobsServiceState)(nil)).Elem()
}

type kogitoJobsServiceArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KogitoJobsServiceSpec defines the desired state of KogitoJobsService.
	Spec *KogitoJobsServiceSpec `pulumi:"spec"`
	// KogitoJobsServiceStatus defines the observed state of KogitoJobsService.
	Status *KogitoJobsServiceStatus `pulumi:"status"`
}

// The set of arguments for constructing a KogitoJobsService resource.
type KogitoJobsServiceArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KogitoJobsServiceSpec defines the desired state of KogitoJobsService.
	Spec KogitoJobsServiceSpecPtrInput
	// KogitoJobsServiceStatus defines the observed state of KogitoJobsService.
	Status KogitoJobsServiceStatusPtrInput
}

func (KogitoJobsServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*kogitoJobsServiceArgs)(nil)).Elem()
}
