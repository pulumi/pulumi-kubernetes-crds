// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Ibmqe is the Schema for the ibmqes API
type IbmqeType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// IbmqeSpec defines the desired state of Ibmqe
	Spec map[string]interface{} `pulumi:"spec"`
	// IbmqeStatus defines the observed state of Ibmqe
	Status map[string]interface{} `pulumi:"status"`
}

// IbmqeTypeInput is an input type that accepts IbmqeTypeArgs and IbmqeTypeOutput values.
// You can construct a concrete instance of `IbmqeTypeInput` via:
//
//          IbmqeTypeArgs{...}
type IbmqeTypeInput interface {
	pulumi.Input

	ToIbmqeTypeOutput() IbmqeTypeOutput
	ToIbmqeTypeOutputWithContext(context.Context) IbmqeTypeOutput
}

// Ibmqe is the Schema for the ibmqes API
type IbmqeTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
	// IbmqeSpec defines the desired state of Ibmqe
	Spec pulumi.MapInput `pulumi:"spec"`
	// IbmqeStatus defines the observed state of Ibmqe
	Status pulumi.MapInput `pulumi:"status"`
}

func (IbmqeTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*IbmqeType)(nil)).Elem()
}

func (i IbmqeTypeArgs) ToIbmqeTypeOutput() IbmqeTypeOutput {
	return i.ToIbmqeTypeOutputWithContext(context.Background())
}

func (i IbmqeTypeArgs) ToIbmqeTypeOutputWithContext(ctx context.Context) IbmqeTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IbmqeTypeOutput)
}

// Ibmqe is the Schema for the ibmqes API
type IbmqeTypeOutput struct{ *pulumi.OutputState }

func (IbmqeTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IbmqeType)(nil)).Elem()
}

func (o IbmqeTypeOutput) ToIbmqeTypeOutput() IbmqeTypeOutput {
	return o
}

func (o IbmqeTypeOutput) ToIbmqeTypeOutputWithContext(ctx context.Context) IbmqeTypeOutput {
	return o
}

func (o IbmqeTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v IbmqeType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o IbmqeTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v IbmqeType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o IbmqeTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v IbmqeType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

// IbmqeSpec defines the desired state of Ibmqe
func (o IbmqeTypeOutput) Spec() pulumi.MapOutput {
	return o.ApplyT(func(v IbmqeType) map[string]interface{} { return v.Spec }).(pulumi.MapOutput)
}

// IbmqeStatus defines the observed state of Ibmqe
func (o IbmqeTypeOutput) Status() pulumi.MapOutput {
	return o.ApplyT(func(v IbmqeType) map[string]interface{} { return v.Status }).(pulumi.MapOutput)
}

type IbmqeMetadata struct {
}

// IbmqeMetadataInput is an input type that accepts IbmqeMetadataArgs and IbmqeMetadataOutput values.
// You can construct a concrete instance of `IbmqeMetadataInput` via:
//
//          IbmqeMetadataArgs{...}
type IbmqeMetadataInput interface {
	pulumi.Input

	ToIbmqeMetadataOutput() IbmqeMetadataOutput
	ToIbmqeMetadataOutputWithContext(context.Context) IbmqeMetadataOutput
}

type IbmqeMetadataArgs struct {
}

func (IbmqeMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*IbmqeMetadata)(nil)).Elem()
}

func (i IbmqeMetadataArgs) ToIbmqeMetadataOutput() IbmqeMetadataOutput {
	return i.ToIbmqeMetadataOutputWithContext(context.Background())
}

func (i IbmqeMetadataArgs) ToIbmqeMetadataOutputWithContext(ctx context.Context) IbmqeMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IbmqeMetadataOutput)
}

type IbmqeMetadataOutput struct{ *pulumi.OutputState }

func (IbmqeMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IbmqeMetadata)(nil)).Elem()
}

func (o IbmqeMetadataOutput) ToIbmqeMetadataOutput() IbmqeMetadataOutput {
	return o
}

func (o IbmqeMetadataOutput) ToIbmqeMetadataOutputWithContext(ctx context.Context) IbmqeMetadataOutput {
	return o
}

// IbmqeSpec defines the desired state of Ibmqe
type IbmqeSpec struct {
}

// IbmqeSpecInput is an input type that accepts IbmqeSpecArgs and IbmqeSpecOutput values.
// You can construct a concrete instance of `IbmqeSpecInput` via:
//
//          IbmqeSpecArgs{...}
type IbmqeSpecInput interface {
	pulumi.Input

	ToIbmqeSpecOutput() IbmqeSpecOutput
	ToIbmqeSpecOutputWithContext(context.Context) IbmqeSpecOutput
}

// IbmqeSpec defines the desired state of Ibmqe
type IbmqeSpecArgs struct {
}

func (IbmqeSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*IbmqeSpec)(nil)).Elem()
}

func (i IbmqeSpecArgs) ToIbmqeSpecOutput() IbmqeSpecOutput {
	return i.ToIbmqeSpecOutputWithContext(context.Background())
}

func (i IbmqeSpecArgs) ToIbmqeSpecOutputWithContext(ctx context.Context) IbmqeSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IbmqeSpecOutput)
}

// IbmqeSpec defines the desired state of Ibmqe
type IbmqeSpecOutput struct{ *pulumi.OutputState }

func (IbmqeSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IbmqeSpec)(nil)).Elem()
}

func (o IbmqeSpecOutput) ToIbmqeSpecOutput() IbmqeSpecOutput {
	return o
}

func (o IbmqeSpecOutput) ToIbmqeSpecOutputWithContext(ctx context.Context) IbmqeSpecOutput {
	return o
}

// IbmqeStatus defines the observed state of Ibmqe
type IbmqeStatus struct {
}

// IbmqeStatusInput is an input type that accepts IbmqeStatusArgs and IbmqeStatusOutput values.
// You can construct a concrete instance of `IbmqeStatusInput` via:
//
//          IbmqeStatusArgs{...}
type IbmqeStatusInput interface {
	pulumi.Input

	ToIbmqeStatusOutput() IbmqeStatusOutput
	ToIbmqeStatusOutputWithContext(context.Context) IbmqeStatusOutput
}

// IbmqeStatus defines the observed state of Ibmqe
type IbmqeStatusArgs struct {
}

func (IbmqeStatusArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*IbmqeStatus)(nil)).Elem()
}

func (i IbmqeStatusArgs) ToIbmqeStatusOutput() IbmqeStatusOutput {
	return i.ToIbmqeStatusOutputWithContext(context.Background())
}

func (i IbmqeStatusArgs) ToIbmqeStatusOutputWithContext(ctx context.Context) IbmqeStatusOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IbmqeStatusOutput)
}

// IbmqeStatus defines the observed state of Ibmqe
type IbmqeStatusOutput struct{ *pulumi.OutputState }

func (IbmqeStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IbmqeStatus)(nil)).Elem()
}

func (o IbmqeStatusOutput) ToIbmqeStatusOutput() IbmqeStatusOutput {
	return o
}

func (o IbmqeStatusOutput) ToIbmqeStatusOutputWithContext(ctx context.Context) IbmqeStatusOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(IbmqeTypeOutput{})
	pulumi.RegisterOutputType(IbmqeMetadataOutput{})
	pulumi.RegisterOutputType(IbmqeSpecOutput{})
	pulumi.RegisterOutputType(IbmqeStatusOutput{})
}
