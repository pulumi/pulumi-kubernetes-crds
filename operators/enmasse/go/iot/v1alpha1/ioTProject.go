// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// IoTProject creates a new isolated space for IoT related messsaging. This resource is created by the messaging tenant and is also sometimes called an "IoT Tenant".
type IoTProject struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	Spec       IoTProjectSpecPtrOutput    `pulumi:"spec"`
	Status     IoTProjectStatusPtrOutput  `pulumi:"status"`
}

// NewIoTProject registers a new resource with the given unique name, arguments, and options.
func NewIoTProject(ctx *pulumi.Context,
	name string, args *IoTProjectArgs, opts ...pulumi.ResourceOption) (*IoTProject, error) {
	if args == nil {
		args = &IoTProjectArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("iot.enmasse.io/v1alpha1")
	args.Kind = pulumi.StringPtr("IoTProject")
	var resource IoTProject
	err := ctx.RegisterResource("kubernetes:iot.enmasse.io/v1alpha1:IoTProject", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIoTProject gets an existing IoTProject resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIoTProject(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IoTProjectState, opts ...pulumi.ResourceOption) (*IoTProject, error) {
	var resource IoTProject
	err := ctx.ReadResource("kubernetes:iot.enmasse.io/v1alpha1:IoTProject", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IoTProject resources.
type ioTProjectState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       *IoTProjectSpec    `pulumi:"spec"`
	Status     *IoTProjectStatus  `pulumi:"status"`
}

type IoTProjectState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       IoTProjectSpecPtrInput
	Status     IoTProjectStatusPtrInput
}

func (IoTProjectState) ElementType() reflect.Type {
	return reflect.TypeOf((*ioTProjectState)(nil)).Elem()
}

type ioTProjectArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       *IoTProjectSpec    `pulumi:"spec"`
	Status     *IoTProjectStatus  `pulumi:"status"`
}

// The set of arguments for constructing a IoTProject resource.
type IoTProjectArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       IoTProjectSpecPtrInput
	Status     IoTProjectStatusPtrInput
}

func (IoTProjectArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ioTProjectArgs)(nil)).Elem()
}
