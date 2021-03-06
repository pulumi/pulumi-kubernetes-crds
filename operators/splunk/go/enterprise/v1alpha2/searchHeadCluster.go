// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha2

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// SearchHeadCluster is the Schema for a Splunk Enterprise search head cluster
type SearchHeadCluster struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// SearchHeadClusterSpec defines the desired state of a Splunk Enterprise search head cluster
	Spec SearchHeadClusterSpecPtrOutput `pulumi:"spec"`
	// SearchHeadClusterStatus defines the observed state of a Splunk Enterprise search head cluster
	Status SearchHeadClusterStatusPtrOutput `pulumi:"status"`
}

// NewSearchHeadCluster registers a new resource with the given unique name, arguments, and options.
func NewSearchHeadCluster(ctx *pulumi.Context,
	name string, args *SearchHeadClusterArgs, opts ...pulumi.ResourceOption) (*SearchHeadCluster, error) {
	if args == nil {
		args = &SearchHeadClusterArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("enterprise.splunk.com/v1alpha2")
	args.Kind = pulumi.StringPtr("SearchHeadCluster")
	var resource SearchHeadCluster
	err := ctx.RegisterResource("kubernetes:enterprise.splunk.com/v1alpha2:SearchHeadCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSearchHeadCluster gets an existing SearchHeadCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSearchHeadCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SearchHeadClusterState, opts ...pulumi.ResourceOption) (*SearchHeadCluster, error) {
	var resource SearchHeadCluster
	err := ctx.ReadResource("kubernetes:enterprise.splunk.com/v1alpha2:SearchHeadCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SearchHeadCluster resources.
type searchHeadClusterState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// SearchHeadClusterSpec defines the desired state of a Splunk Enterprise search head cluster
	Spec *SearchHeadClusterSpec `pulumi:"spec"`
	// SearchHeadClusterStatus defines the observed state of a Splunk Enterprise search head cluster
	Status *SearchHeadClusterStatus `pulumi:"status"`
}

type SearchHeadClusterState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// SearchHeadClusterSpec defines the desired state of a Splunk Enterprise search head cluster
	Spec SearchHeadClusterSpecPtrInput
	// SearchHeadClusterStatus defines the observed state of a Splunk Enterprise search head cluster
	Status SearchHeadClusterStatusPtrInput
}

func (SearchHeadClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*searchHeadClusterState)(nil)).Elem()
}

type searchHeadClusterArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// SearchHeadClusterSpec defines the desired state of a Splunk Enterprise search head cluster
	Spec *SearchHeadClusterSpec `pulumi:"spec"`
	// SearchHeadClusterStatus defines the observed state of a Splunk Enterprise search head cluster
	Status *SearchHeadClusterStatus `pulumi:"status"`
}

// The set of arguments for constructing a SearchHeadCluster resource.
type SearchHeadClusterArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// SearchHeadClusterSpec defines the desired state of a Splunk Enterprise search head cluster
	Spec SearchHeadClusterSpecPtrInput
	// SearchHeadClusterStatus defines the observed state of a Splunk Enterprise search head cluster
	Status SearchHeadClusterStatusPtrInput
}

func (SearchHeadClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*searchHeadClusterArgs)(nil)).Elem()
}
