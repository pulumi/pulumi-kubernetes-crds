// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// GitopsService is the Schema for the gitopsservices API
type GitopsServiceType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// GitopsServiceSpec defines the desired state of GitopsService
	Spec map[string]interface{} `pulumi:"spec"`
	// GitopsServiceStatus defines the observed state of GitopsService
	Status map[string]interface{} `pulumi:"status"`
}

// GitopsServiceTypeInput is an input type that accepts GitopsServiceTypeArgs and GitopsServiceTypeOutput values.
// You can construct a concrete instance of `GitopsServiceTypeInput` via:
//
//          GitopsServiceTypeArgs{...}
type GitopsServiceTypeInput interface {
	pulumi.Input

	ToGitopsServiceTypeOutput() GitopsServiceTypeOutput
	ToGitopsServiceTypeOutputWithContext(context.Context) GitopsServiceTypeOutput
}

// GitopsService is the Schema for the gitopsservices API
type GitopsServiceTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
	// GitopsServiceSpec defines the desired state of GitopsService
	Spec pulumi.MapInput `pulumi:"spec"`
	// GitopsServiceStatus defines the observed state of GitopsService
	Status pulumi.MapInput `pulumi:"status"`
}

func (GitopsServiceTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GitopsServiceType)(nil)).Elem()
}

func (i GitopsServiceTypeArgs) ToGitopsServiceTypeOutput() GitopsServiceTypeOutput {
	return i.ToGitopsServiceTypeOutputWithContext(context.Background())
}

func (i GitopsServiceTypeArgs) ToGitopsServiceTypeOutputWithContext(ctx context.Context) GitopsServiceTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GitopsServiceTypeOutput)
}

// GitopsService is the Schema for the gitopsservices API
type GitopsServiceTypeOutput struct{ *pulumi.OutputState }

func (GitopsServiceTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GitopsServiceType)(nil)).Elem()
}

func (o GitopsServiceTypeOutput) ToGitopsServiceTypeOutput() GitopsServiceTypeOutput {
	return o
}

func (o GitopsServiceTypeOutput) ToGitopsServiceTypeOutputWithContext(ctx context.Context) GitopsServiceTypeOutput {
	return o
}

func (o GitopsServiceTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GitopsServiceType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o GitopsServiceTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GitopsServiceType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o GitopsServiceTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v GitopsServiceType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

// GitopsServiceSpec defines the desired state of GitopsService
func (o GitopsServiceTypeOutput) Spec() pulumi.MapOutput {
	return o.ApplyT(func(v GitopsServiceType) map[string]interface{} { return v.Spec }).(pulumi.MapOutput)
}

// GitopsServiceStatus defines the observed state of GitopsService
func (o GitopsServiceTypeOutput) Status() pulumi.MapOutput {
	return o.ApplyT(func(v GitopsServiceType) map[string]interface{} { return v.Status }).(pulumi.MapOutput)
}

type GitopsServiceMetadata struct {
}

// GitopsServiceMetadataInput is an input type that accepts GitopsServiceMetadataArgs and GitopsServiceMetadataOutput values.
// You can construct a concrete instance of `GitopsServiceMetadataInput` via:
//
//          GitopsServiceMetadataArgs{...}
type GitopsServiceMetadataInput interface {
	pulumi.Input

	ToGitopsServiceMetadataOutput() GitopsServiceMetadataOutput
	ToGitopsServiceMetadataOutputWithContext(context.Context) GitopsServiceMetadataOutput
}

type GitopsServiceMetadataArgs struct {
}

func (GitopsServiceMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GitopsServiceMetadata)(nil)).Elem()
}

func (i GitopsServiceMetadataArgs) ToGitopsServiceMetadataOutput() GitopsServiceMetadataOutput {
	return i.ToGitopsServiceMetadataOutputWithContext(context.Background())
}

func (i GitopsServiceMetadataArgs) ToGitopsServiceMetadataOutputWithContext(ctx context.Context) GitopsServiceMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GitopsServiceMetadataOutput)
}

type GitopsServiceMetadataOutput struct{ *pulumi.OutputState }

func (GitopsServiceMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GitopsServiceMetadata)(nil)).Elem()
}

func (o GitopsServiceMetadataOutput) ToGitopsServiceMetadataOutput() GitopsServiceMetadataOutput {
	return o
}

func (o GitopsServiceMetadataOutput) ToGitopsServiceMetadataOutputWithContext(ctx context.Context) GitopsServiceMetadataOutput {
	return o
}

// GitopsServiceSpec defines the desired state of GitopsService
type GitopsServiceSpec struct {
}

// GitopsServiceSpecInput is an input type that accepts GitopsServiceSpecArgs and GitopsServiceSpecOutput values.
// You can construct a concrete instance of `GitopsServiceSpecInput` via:
//
//          GitopsServiceSpecArgs{...}
type GitopsServiceSpecInput interface {
	pulumi.Input

	ToGitopsServiceSpecOutput() GitopsServiceSpecOutput
	ToGitopsServiceSpecOutputWithContext(context.Context) GitopsServiceSpecOutput
}

// GitopsServiceSpec defines the desired state of GitopsService
type GitopsServiceSpecArgs struct {
}

func (GitopsServiceSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GitopsServiceSpec)(nil)).Elem()
}

func (i GitopsServiceSpecArgs) ToGitopsServiceSpecOutput() GitopsServiceSpecOutput {
	return i.ToGitopsServiceSpecOutputWithContext(context.Background())
}

func (i GitopsServiceSpecArgs) ToGitopsServiceSpecOutputWithContext(ctx context.Context) GitopsServiceSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GitopsServiceSpecOutput)
}

// GitopsServiceSpec defines the desired state of GitopsService
type GitopsServiceSpecOutput struct{ *pulumi.OutputState }

func (GitopsServiceSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GitopsServiceSpec)(nil)).Elem()
}

func (o GitopsServiceSpecOutput) ToGitopsServiceSpecOutput() GitopsServiceSpecOutput {
	return o
}

func (o GitopsServiceSpecOutput) ToGitopsServiceSpecOutputWithContext(ctx context.Context) GitopsServiceSpecOutput {
	return o
}

// GitopsServiceStatus defines the observed state of GitopsService
type GitopsServiceStatus struct {
}

// GitopsServiceStatusInput is an input type that accepts GitopsServiceStatusArgs and GitopsServiceStatusOutput values.
// You can construct a concrete instance of `GitopsServiceStatusInput` via:
//
//          GitopsServiceStatusArgs{...}
type GitopsServiceStatusInput interface {
	pulumi.Input

	ToGitopsServiceStatusOutput() GitopsServiceStatusOutput
	ToGitopsServiceStatusOutputWithContext(context.Context) GitopsServiceStatusOutput
}

// GitopsServiceStatus defines the observed state of GitopsService
type GitopsServiceStatusArgs struct {
}

func (GitopsServiceStatusArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GitopsServiceStatus)(nil)).Elem()
}

func (i GitopsServiceStatusArgs) ToGitopsServiceStatusOutput() GitopsServiceStatusOutput {
	return i.ToGitopsServiceStatusOutputWithContext(context.Background())
}

func (i GitopsServiceStatusArgs) ToGitopsServiceStatusOutputWithContext(ctx context.Context) GitopsServiceStatusOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GitopsServiceStatusOutput)
}

// GitopsServiceStatus defines the observed state of GitopsService
type GitopsServiceStatusOutput struct{ *pulumi.OutputState }

func (GitopsServiceStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GitopsServiceStatus)(nil)).Elem()
}

func (o GitopsServiceStatusOutput) ToGitopsServiceStatusOutput() GitopsServiceStatusOutput {
	return o
}

func (o GitopsServiceStatusOutput) ToGitopsServiceStatusOutputWithContext(ctx context.Context) GitopsServiceStatusOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(GitopsServiceTypeOutput{})
	pulumi.RegisterOutputType(GitopsServiceMetadataOutput{})
	pulumi.RegisterOutputType(GitopsServiceSpecOutput{})
	pulumi.RegisterOutputType(GitopsServiceStatusOutput{})
}