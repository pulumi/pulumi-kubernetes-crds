// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// KfDef is the Schema for the kfdefs API
type KfDefType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KfDefSpec defines the desired state of KfDef
	Spec map[string]interface{} `pulumi:"spec"`
	// KfDefStatus defines the observed state of KfDef
	Status map[string]interface{} `pulumi:"status"`
}

// KfDefTypeInput is an input type that accepts KfDefTypeArgs and KfDefTypeOutput values.
// You can construct a concrete instance of `KfDefTypeInput` via:
//
//          KfDefTypeArgs{...}
type KfDefTypeInput interface {
	pulumi.Input

	ToKfDefTypeOutput() KfDefTypeOutput
	ToKfDefTypeOutputWithContext(context.Context) KfDefTypeOutput
}

// KfDef is the Schema for the kfdefs API
type KfDefTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
	// KfDefSpec defines the desired state of KfDef
	Spec pulumi.MapInput `pulumi:"spec"`
	// KfDefStatus defines the observed state of KfDef
	Status pulumi.MapInput `pulumi:"status"`
}

func (KfDefTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KfDefType)(nil)).Elem()
}

func (i KfDefTypeArgs) ToKfDefTypeOutput() KfDefTypeOutput {
	return i.ToKfDefTypeOutputWithContext(context.Background())
}

func (i KfDefTypeArgs) ToKfDefTypeOutputWithContext(ctx context.Context) KfDefTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KfDefTypeOutput)
}

// KfDef is the Schema for the kfdefs API
type KfDefTypeOutput struct{ *pulumi.OutputState }

func (KfDefTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KfDefType)(nil)).Elem()
}

func (o KfDefTypeOutput) ToKfDefTypeOutput() KfDefTypeOutput {
	return o
}

func (o KfDefTypeOutput) ToKfDefTypeOutputWithContext(ctx context.Context) KfDefTypeOutput {
	return o
}

func (o KfDefTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v KfDefType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o KfDefTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v KfDefType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o KfDefTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v KfDefType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

// KfDefSpec defines the desired state of KfDef
func (o KfDefTypeOutput) Spec() pulumi.MapOutput {
	return o.ApplyT(func(v KfDefType) map[string]interface{} { return v.Spec }).(pulumi.MapOutput)
}

// KfDefStatus defines the observed state of KfDef
func (o KfDefTypeOutput) Status() pulumi.MapOutput {
	return o.ApplyT(func(v KfDefType) map[string]interface{} { return v.Status }).(pulumi.MapOutput)
}

type KfDefMetadata struct {
}

// KfDefMetadataInput is an input type that accepts KfDefMetadataArgs and KfDefMetadataOutput values.
// You can construct a concrete instance of `KfDefMetadataInput` via:
//
//          KfDefMetadataArgs{...}
type KfDefMetadataInput interface {
	pulumi.Input

	ToKfDefMetadataOutput() KfDefMetadataOutput
	ToKfDefMetadataOutputWithContext(context.Context) KfDefMetadataOutput
}

type KfDefMetadataArgs struct {
}

func (KfDefMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KfDefMetadata)(nil)).Elem()
}

func (i KfDefMetadataArgs) ToKfDefMetadataOutput() KfDefMetadataOutput {
	return i.ToKfDefMetadataOutputWithContext(context.Background())
}

func (i KfDefMetadataArgs) ToKfDefMetadataOutputWithContext(ctx context.Context) KfDefMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KfDefMetadataOutput)
}

type KfDefMetadataOutput struct{ *pulumi.OutputState }

func (KfDefMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KfDefMetadata)(nil)).Elem()
}

func (o KfDefMetadataOutput) ToKfDefMetadataOutput() KfDefMetadataOutput {
	return o
}

func (o KfDefMetadataOutput) ToKfDefMetadataOutputWithContext(ctx context.Context) KfDefMetadataOutput {
	return o
}

// KfDefSpec defines the desired state of KfDef
type KfDefSpec struct {
}

// KfDefSpecInput is an input type that accepts KfDefSpecArgs and KfDefSpecOutput values.
// You can construct a concrete instance of `KfDefSpecInput` via:
//
//          KfDefSpecArgs{...}
type KfDefSpecInput interface {
	pulumi.Input

	ToKfDefSpecOutput() KfDefSpecOutput
	ToKfDefSpecOutputWithContext(context.Context) KfDefSpecOutput
}

// KfDefSpec defines the desired state of KfDef
type KfDefSpecArgs struct {
}

func (KfDefSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KfDefSpec)(nil)).Elem()
}

func (i KfDefSpecArgs) ToKfDefSpecOutput() KfDefSpecOutput {
	return i.ToKfDefSpecOutputWithContext(context.Background())
}

func (i KfDefSpecArgs) ToKfDefSpecOutputWithContext(ctx context.Context) KfDefSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KfDefSpecOutput)
}

// KfDefSpec defines the desired state of KfDef
type KfDefSpecOutput struct{ *pulumi.OutputState }

func (KfDefSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KfDefSpec)(nil)).Elem()
}

func (o KfDefSpecOutput) ToKfDefSpecOutput() KfDefSpecOutput {
	return o
}

func (o KfDefSpecOutput) ToKfDefSpecOutputWithContext(ctx context.Context) KfDefSpecOutput {
	return o
}

// KfDefStatus defines the observed state of KfDef
type KfDefStatus struct {
}

// KfDefStatusInput is an input type that accepts KfDefStatusArgs and KfDefStatusOutput values.
// You can construct a concrete instance of `KfDefStatusInput` via:
//
//          KfDefStatusArgs{...}
type KfDefStatusInput interface {
	pulumi.Input

	ToKfDefStatusOutput() KfDefStatusOutput
	ToKfDefStatusOutputWithContext(context.Context) KfDefStatusOutput
}

// KfDefStatus defines the observed state of KfDef
type KfDefStatusArgs struct {
}

func (KfDefStatusArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KfDefStatus)(nil)).Elem()
}

func (i KfDefStatusArgs) ToKfDefStatusOutput() KfDefStatusOutput {
	return i.ToKfDefStatusOutputWithContext(context.Background())
}

func (i KfDefStatusArgs) ToKfDefStatusOutputWithContext(ctx context.Context) KfDefStatusOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KfDefStatusOutput)
}

// KfDefStatus defines the observed state of KfDef
type KfDefStatusOutput struct{ *pulumi.OutputState }

func (KfDefStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KfDefStatus)(nil)).Elem()
}

func (o KfDefStatusOutput) ToKfDefStatusOutput() KfDefStatusOutput {
	return o
}

func (o KfDefStatusOutput) ToKfDefStatusOutputWithContext(ctx context.Context) KfDefStatusOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(KfDefTypeOutput{})
	pulumi.RegisterOutputType(KfDefMetadataOutput{})
	pulumi.RegisterOutputType(KfDefSpecOutput{})
	pulumi.RegisterOutputType(KfDefStatusOutput{})
}
