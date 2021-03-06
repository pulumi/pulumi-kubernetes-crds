// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type Domain struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput `pulumi:"apiVersion"`
	// Domain is the DNS zone associated with the KubeFed control plane
	Domain   pulumi.StringOutput        `pulumi:"domain"`
	Kind     pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// NameServer is the authoritative DNS name server for the KubeFed domain
	NameServer pulumi.StringPtrOutput `pulumi:"nameServer"`
}

// NewDomain registers a new resource with the given unique name, arguments, and options.
func NewDomain(ctx *pulumi.Context,
	name string, args *DomainArgs, opts ...pulumi.ResourceOption) (*Domain, error) {
	if args == nil {
		args = &DomainArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("multiclusterdns.kubefed.io/v1alpha1")
	args.Kind = pulumi.StringPtr("Domain")
	var resource Domain
	err := ctx.RegisterResource("kubernetes:multiclusterdns.kubefed.io/v1alpha1:Domain", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDomain gets an existing Domain resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDomain(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DomainState, opts ...pulumi.ResourceOption) (*Domain, error) {
	var resource Domain
	err := ctx.ReadResource("kubernetes:multiclusterdns.kubefed.io/v1alpha1:Domain", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Domain resources.
type domainState struct {
	ApiVersion *string `pulumi:"apiVersion"`
	// Domain is the DNS zone associated with the KubeFed control plane
	Domain   *string            `pulumi:"domain"`
	Kind     *string            `pulumi:"kind"`
	Metadata *metav1.ObjectMeta `pulumi:"metadata"`
	// NameServer is the authoritative DNS name server for the KubeFed domain
	NameServer *string `pulumi:"nameServer"`
}

type DomainState struct {
	ApiVersion pulumi.StringPtrInput
	// Domain is the DNS zone associated with the KubeFed control plane
	Domain   pulumi.StringPtrInput
	Kind     pulumi.StringPtrInput
	Metadata metav1.ObjectMetaPtrInput
	// NameServer is the authoritative DNS name server for the KubeFed domain
	NameServer pulumi.StringPtrInput
}

func (DomainState) ElementType() reflect.Type {
	return reflect.TypeOf((*domainState)(nil)).Elem()
}

type domainArgs struct {
	ApiVersion *string `pulumi:"apiVersion"`
	// Domain is the DNS zone associated with the KubeFed control plane
	Domain   *string            `pulumi:"domain"`
	Kind     *string            `pulumi:"kind"`
	Metadata *metav1.ObjectMeta `pulumi:"metadata"`
	// NameServer is the authoritative DNS name server for the KubeFed domain
	NameServer *string `pulumi:"nameServer"`
}

// The set of arguments for constructing a Domain resource.
type DomainArgs struct {
	ApiVersion pulumi.StringPtrInput
	// Domain is the DNS zone associated with the KubeFed control plane
	Domain   pulumi.StringPtrInput
	Kind     pulumi.StringPtrInput
	Metadata metav1.ObjectMetaPtrInput
	// NameServer is the authoritative DNS name server for the KubeFed domain
	NameServer pulumi.StringPtrInput
}

func (DomainArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*domainArgs)(nil)).Elem()
}
