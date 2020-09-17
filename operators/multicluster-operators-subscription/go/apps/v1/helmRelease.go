// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// HelmRelease is the Schema for the subscriptionreleases API
type HelmRelease struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// HelmReleaseRepo defines the repository of HelmRelease
	Repo   HelmReleaseRepoPtrOutput   `pulumi:"repo"`
	Spec   pulumi.AnyOutput           `pulumi:"spec"`
	Status HelmReleaseStatusPtrOutput `pulumi:"status"`
}

// NewHelmRelease registers a new resource with the given unique name, arguments, and options.
func NewHelmRelease(ctx *pulumi.Context,
	name string, args *HelmReleaseArgs, opts ...pulumi.ResourceOption) (*HelmRelease, error) {
	if args == nil {
		args = &HelmReleaseArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("apps.open-cluster-management.io/v1")
	args.Kind = pulumi.StringPtr("HelmRelease")
	var resource HelmRelease
	err := ctx.RegisterResource("kubernetes:apps.open-cluster-management.io/v1:HelmRelease", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetHelmRelease gets an existing HelmRelease resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHelmRelease(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *HelmReleaseState, opts ...pulumi.ResourceOption) (*HelmRelease, error) {
	var resource HelmRelease
	err := ctx.ReadResource("kubernetes:apps.open-cluster-management.io/v1:HelmRelease", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering HelmRelease resources.
type helmReleaseState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// HelmReleaseRepo defines the repository of HelmRelease
	Repo   *HelmReleaseRepo   `pulumi:"repo"`
	Spec   interface{}        `pulumi:"spec"`
	Status *HelmReleaseStatus `pulumi:"status"`
}

type HelmReleaseState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// HelmReleaseRepo defines the repository of HelmRelease
	Repo   HelmReleaseRepoPtrInput
	Spec   pulumi.Input
	Status HelmReleaseStatusPtrInput
}

func (HelmReleaseState) ElementType() reflect.Type {
	return reflect.TypeOf((*helmReleaseState)(nil)).Elem()
}

type helmReleaseArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// HelmReleaseRepo defines the repository of HelmRelease
	Repo   *HelmReleaseRepo   `pulumi:"repo"`
	Spec   interface{}        `pulumi:"spec"`
	Status *HelmReleaseStatus `pulumi:"status"`
}

// The set of arguments for constructing a HelmRelease resource.
type HelmReleaseArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// HelmReleaseRepo defines the repository of HelmRelease
	Repo   HelmReleaseRepoPtrInput
	Spec   pulumi.Input
	Status HelmReleaseStatusPtrInput
}

func (HelmReleaseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*helmReleaseArgs)(nil)).Elem()
}
