// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// DNSZone is the Schema for the dnszones API
type DNSZone struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// DNSZoneSpec defines the desired state of DNSZone
	Spec DNSZoneSpecPtrOutput `pulumi:"spec"`
	// DNSZoneStatus defines the observed state of DNSZone
	Status DNSZoneStatusPtrOutput `pulumi:"status"`
}

// NewDNSZone registers a new resource with the given unique name, arguments, and options.
func NewDNSZone(ctx *pulumi.Context,
	name string, args *DNSZoneArgs, opts ...pulumi.ResourceOption) (*DNSZone, error) {
	if args == nil {
		args = &DNSZoneArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("hive.openshift.io/v1")
	args.Kind = pulumi.StringPtr("DNSZone")
	var resource DNSZone
	err := ctx.RegisterResource("kubernetes:hive.openshift.io/v1:DNSZone", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDNSZone gets an existing DNSZone resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDNSZone(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DNSZoneState, opts ...pulumi.ResourceOption) (*DNSZone, error) {
	var resource DNSZone
	err := ctx.ReadResource("kubernetes:hive.openshift.io/v1:DNSZone", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DNSZone resources.
type dnszoneState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// DNSZoneSpec defines the desired state of DNSZone
	Spec *DNSZoneSpec `pulumi:"spec"`
	// DNSZoneStatus defines the observed state of DNSZone
	Status *DNSZoneStatus `pulumi:"status"`
}

type DNSZoneState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// DNSZoneSpec defines the desired state of DNSZone
	Spec DNSZoneSpecPtrInput
	// DNSZoneStatus defines the observed state of DNSZone
	Status DNSZoneStatusPtrInput
}

func (DNSZoneState) ElementType() reflect.Type {
	return reflect.TypeOf((*dnszoneState)(nil)).Elem()
}

type dnszoneArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// DNSZoneSpec defines the desired state of DNSZone
	Spec *DNSZoneSpec `pulumi:"spec"`
	// DNSZoneStatus defines the observed state of DNSZone
	Status *DNSZoneStatus `pulumi:"status"`
}

// The set of arguments for constructing a DNSZone resource.
type DNSZoneArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// DNSZoneSpec defines the desired state of DNSZone
	Spec DNSZoneSpecPtrInput
	// DNSZoneStatus defines the observed state of DNSZone
	Status DNSZoneStatusPtrInput
}

func (DNSZoneArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dnszoneArgs)(nil)).Elem()
}
