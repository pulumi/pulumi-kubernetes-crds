// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type IngressDNSRecord struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput          `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput          `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput      `pulumi:"metadata"`
	Spec       IngressDNSRecordSpecPtrOutput   `pulumi:"spec"`
	Status     IngressDNSRecordStatusPtrOutput `pulumi:"status"`
}

// NewIngressDNSRecord registers a new resource with the given unique name, arguments, and options.
func NewIngressDNSRecord(ctx *pulumi.Context,
	name string, args *IngressDNSRecordArgs, opts ...pulumi.ResourceOption) (*IngressDNSRecord, error) {
	if args == nil {
		args = &IngressDNSRecordArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("multiclusterdns.kubefed.io/v1alpha1")
	args.Kind = pulumi.StringPtr("IngressDNSRecord")
	var resource IngressDNSRecord
	err := ctx.RegisterResource("kubernetes:multiclusterdns.kubefed.io/v1alpha1:IngressDNSRecord", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIngressDNSRecord gets an existing IngressDNSRecord resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIngressDNSRecord(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IngressDNSRecordState, opts ...pulumi.ResourceOption) (*IngressDNSRecord, error) {
	var resource IngressDNSRecord
	err := ctx.ReadResource("kubernetes:multiclusterdns.kubefed.io/v1alpha1:IngressDNSRecord", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IngressDNSRecord resources.
type ingressDNSRecordState struct {
	ApiVersion *string                 `pulumi:"apiVersion"`
	Kind       *string                 `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta      `pulumi:"metadata"`
	Spec       *IngressDNSRecordSpec   `pulumi:"spec"`
	Status     *IngressDNSRecordStatus `pulumi:"status"`
}

type IngressDNSRecordState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       IngressDNSRecordSpecPtrInput
	Status     IngressDNSRecordStatusPtrInput
}

func (IngressDNSRecordState) ElementType() reflect.Type {
	return reflect.TypeOf((*ingressDNSRecordState)(nil)).Elem()
}

type ingressDNSRecordArgs struct {
	ApiVersion *string                 `pulumi:"apiVersion"`
	Kind       *string                 `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta      `pulumi:"metadata"`
	Spec       *IngressDNSRecordSpec   `pulumi:"spec"`
	Status     *IngressDNSRecordStatus `pulumi:"status"`
}

// The set of arguments for constructing a IngressDNSRecord resource.
type IngressDNSRecordArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       IngressDNSRecordSpecPtrInput
	Status     IngressDNSRecordStatusPtrInput
}

func (IngressDNSRecordArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ingressDNSRecordArgs)(nil)).Elem()
}