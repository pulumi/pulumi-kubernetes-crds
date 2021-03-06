// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ArgoCDExport is the Schema for the argocdexports API
type ArgoCDExport struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ArgoCDExportSpec defines the desired state of ArgoCDExport
	Spec ArgoCDExportSpecPtrOutput `pulumi:"spec"`
	// ArgoCDExportStatus defines the observed state of ArgoCDExport
	Status ArgoCDExportStatusPtrOutput `pulumi:"status"`
}

// NewArgoCDExport registers a new resource with the given unique name, arguments, and options.
func NewArgoCDExport(ctx *pulumi.Context,
	name string, args *ArgoCDExportArgs, opts ...pulumi.ResourceOption) (*ArgoCDExport, error) {
	if args == nil {
		args = &ArgoCDExportArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("argoproj.io/v1alpha1")
	args.Kind = pulumi.StringPtr("ArgoCDExport")
	var resource ArgoCDExport
	err := ctx.RegisterResource("kubernetes:argoproj.io/v1alpha1:ArgoCDExport", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetArgoCDExport gets an existing ArgoCDExport resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetArgoCDExport(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ArgoCDExportState, opts ...pulumi.ResourceOption) (*ArgoCDExport, error) {
	var resource ArgoCDExport
	err := ctx.ReadResource("kubernetes:argoproj.io/v1alpha1:ArgoCDExport", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ArgoCDExport resources.
type argoCDExportState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ArgoCDExportSpec defines the desired state of ArgoCDExport
	Spec *ArgoCDExportSpec `pulumi:"spec"`
	// ArgoCDExportStatus defines the observed state of ArgoCDExport
	Status *ArgoCDExportStatus `pulumi:"status"`
}

type ArgoCDExportState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ArgoCDExportSpec defines the desired state of ArgoCDExport
	Spec ArgoCDExportSpecPtrInput
	// ArgoCDExportStatus defines the observed state of ArgoCDExport
	Status ArgoCDExportStatusPtrInput
}

func (ArgoCDExportState) ElementType() reflect.Type {
	return reflect.TypeOf((*argoCDExportState)(nil)).Elem()
}

type argoCDExportArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ArgoCDExportSpec defines the desired state of ArgoCDExport
	Spec *ArgoCDExportSpec `pulumi:"spec"`
	// ArgoCDExportStatus defines the observed state of ArgoCDExport
	Status *ArgoCDExportStatus `pulumi:"status"`
}

// The set of arguments for constructing a ArgoCDExport resource.
type ArgoCDExportArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ArgoCDExportSpec defines the desired state of ArgoCDExport
	Spec ArgoCDExportSpecPtrInput
	// ArgoCDExportStatus defines the observed state of ArgoCDExport
	Status ArgoCDExportStatusPtrInput
}

func (ArgoCDExportArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*argoCDExportArgs)(nil)).Elem()
}
