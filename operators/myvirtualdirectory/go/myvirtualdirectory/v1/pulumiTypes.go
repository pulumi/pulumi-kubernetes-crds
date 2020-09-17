// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type MyVirtualDirectoryType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       interface{}        `pulumi:"spec"`
}

// MyVirtualDirectoryTypeInput is an input type that accepts MyVirtualDirectoryTypeArgs and MyVirtualDirectoryTypeOutput values.
// You can construct a concrete instance of `MyVirtualDirectoryTypeInput` via:
//
//          MyVirtualDirectoryTypeArgs{...}
type MyVirtualDirectoryTypeInput interface {
	pulumi.Input

	ToMyVirtualDirectoryTypeOutput() MyVirtualDirectoryTypeOutput
	ToMyVirtualDirectoryTypeOutputWithContext(context.Context) MyVirtualDirectoryTypeOutput
}

type MyVirtualDirectoryTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
	Spec       pulumi.Input              `pulumi:"spec"`
}

func (MyVirtualDirectoryTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*MyVirtualDirectoryType)(nil)).Elem()
}

func (i MyVirtualDirectoryTypeArgs) ToMyVirtualDirectoryTypeOutput() MyVirtualDirectoryTypeOutput {
	return i.ToMyVirtualDirectoryTypeOutputWithContext(context.Background())
}

func (i MyVirtualDirectoryTypeArgs) ToMyVirtualDirectoryTypeOutputWithContext(ctx context.Context) MyVirtualDirectoryTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MyVirtualDirectoryTypeOutput)
}

type MyVirtualDirectoryTypeOutput struct{ *pulumi.OutputState }

func (MyVirtualDirectoryTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*MyVirtualDirectoryType)(nil)).Elem()
}

func (o MyVirtualDirectoryTypeOutput) ToMyVirtualDirectoryTypeOutput() MyVirtualDirectoryTypeOutput {
	return o
}

func (o MyVirtualDirectoryTypeOutput) ToMyVirtualDirectoryTypeOutputWithContext(ctx context.Context) MyVirtualDirectoryTypeOutput {
	return o
}

func (o MyVirtualDirectoryTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v MyVirtualDirectoryType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o MyVirtualDirectoryTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v MyVirtualDirectoryType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o MyVirtualDirectoryTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v MyVirtualDirectoryType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

func (o MyVirtualDirectoryTypeOutput) Spec() pulumi.AnyOutput {
	return o.ApplyT(func(v MyVirtualDirectoryType) interface{} { return v.Spec }).(pulumi.AnyOutput)
}

func init() {
	pulumi.RegisterOutputType(MyVirtualDirectoryTypeOutput{})
}
