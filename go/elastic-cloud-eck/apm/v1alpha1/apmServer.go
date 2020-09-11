// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ApmServer represents an APM Server resource in a Kubernetes cluster.
type ApmServer struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// ApmServerSpec holds the specification of an APM Server.
	Spec ApmServerSpecPtrOutput `pulumi:"spec"`
	// ApmServerStatus defines the observed state of ApmServer
	Status ApmServerStatusPtrOutput `pulumi:"status"`
}

// NewApmServer registers a new resource with the given unique name, arguments, and options.
func NewApmServer(ctx *pulumi.Context,
	name string, args *ApmServerArgs, opts ...pulumi.ResourceOption) (*ApmServer, error) {
	if args == nil {
		args = &ApmServerArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("apm.k8s.elastic.co/v1alpha1")
	args.Kind = pulumi.StringPtr("ApmServer")
	var resource ApmServer
	err := ctx.RegisterResource("kubernetes:apm.k8s.elastic.co/v1alpha1:ApmServer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApmServer gets an existing ApmServer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApmServer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApmServerState, opts ...pulumi.ResourceOption) (*ApmServer, error) {
	var resource ApmServer
	err := ctx.ReadResource("kubernetes:apm.k8s.elastic.co/v1alpha1:ApmServer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApmServer resources.
type apmServerState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ApmServerSpec holds the specification of an APM Server.
	Spec *ApmServerSpec `pulumi:"spec"`
	// ApmServerStatus defines the observed state of ApmServer
	Status *ApmServerStatus `pulumi:"status"`
}

type ApmServerState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ApmServerSpec holds the specification of an APM Server.
	Spec ApmServerSpecPtrInput
	// ApmServerStatus defines the observed state of ApmServer
	Status ApmServerStatusPtrInput
}

func (ApmServerState) ElementType() reflect.Type {
	return reflect.TypeOf((*apmServerState)(nil)).Elem()
}

type apmServerArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// ApmServerSpec holds the specification of an APM Server.
	Spec *ApmServerSpec `pulumi:"spec"`
	// ApmServerStatus defines the observed state of ApmServer
	Status *ApmServerStatus `pulumi:"status"`
}

// The set of arguments for constructing a ApmServer resource.
type ApmServerArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// ApmServerSpec holds the specification of an APM Server.
	Spec ApmServerSpecPtrInput
	// ApmServerStatus defines the observed state of ApmServer
	Status ApmServerStatusPtrInput
}

func (ApmServerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*apmServerArgs)(nil)).Elem()
}
