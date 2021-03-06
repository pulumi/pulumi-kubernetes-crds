// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type CockroachdbType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
}

// CockroachdbTypeInput is an input type that accepts CockroachdbTypeArgs and CockroachdbTypeOutput values.
// You can construct a concrete instance of `CockroachdbTypeInput` via:
//
//          CockroachdbTypeArgs{...}
type CockroachdbTypeInput interface {
	pulumi.Input

	ToCockroachdbTypeOutput() CockroachdbTypeOutput
	ToCockroachdbTypeOutputWithContext(context.Context) CockroachdbTypeOutput
}

type CockroachdbTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
}

func (CockroachdbTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*CockroachdbType)(nil)).Elem()
}

func (i CockroachdbTypeArgs) ToCockroachdbTypeOutput() CockroachdbTypeOutput {
	return i.ToCockroachdbTypeOutputWithContext(context.Background())
}

func (i CockroachdbTypeArgs) ToCockroachdbTypeOutputWithContext(ctx context.Context) CockroachdbTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CockroachdbTypeOutput)
}

type CockroachdbTypeOutput struct{ *pulumi.OutputState }

func (CockroachdbTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CockroachdbType)(nil)).Elem()
}

func (o CockroachdbTypeOutput) ToCockroachdbTypeOutput() CockroachdbTypeOutput {
	return o
}

func (o CockroachdbTypeOutput) ToCockroachdbTypeOutputWithContext(ctx context.Context) CockroachdbTypeOutput {
	return o
}

func (o CockroachdbTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v CockroachdbType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o CockroachdbTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v CockroachdbType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o CockroachdbTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v CockroachdbType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(CockroachdbTypeOutput{})
}
