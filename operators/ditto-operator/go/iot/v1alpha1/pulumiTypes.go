// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type DittoType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       *DittoSpec         `pulumi:"spec"`
}

// DittoTypeInput is an input type that accepts DittoTypeArgs and DittoTypeOutput values.
// You can construct a concrete instance of `DittoTypeInput` via:
//
//          DittoTypeArgs{...}
type DittoTypeInput interface {
	pulumi.Input

	ToDittoTypeOutput() DittoTypeOutput
	ToDittoTypeOutputWithContext(context.Context) DittoTypeOutput
}

type DittoTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
	Spec       DittoSpecPtrInput         `pulumi:"spec"`
}

func (DittoTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*DittoType)(nil)).Elem()
}

func (i DittoTypeArgs) ToDittoTypeOutput() DittoTypeOutput {
	return i.ToDittoTypeOutputWithContext(context.Background())
}

func (i DittoTypeArgs) ToDittoTypeOutputWithContext(ctx context.Context) DittoTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DittoTypeOutput)
}

type DittoTypeOutput struct{ *pulumi.OutputState }

func (DittoTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DittoType)(nil)).Elem()
}

func (o DittoTypeOutput) ToDittoTypeOutput() DittoTypeOutput {
	return o
}

func (o DittoTypeOutput) ToDittoTypeOutputWithContext(ctx context.Context) DittoTypeOutput {
	return o
}

func (o DittoTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v DittoType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o DittoTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v DittoType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o DittoTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v DittoType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

func (o DittoTypeOutput) Spec() DittoSpecPtrOutput {
	return o.ApplyT(func(v DittoType) *DittoSpec { return v.Spec }).(DittoSpecPtrOutput)
}

type DittoSpec struct {
	// Create the default "ditto" user when initially deploying.
	CreateDefaultUser *bool `pulumi:"createDefaultUser"`
	// Secure the devops status information.
	DevopsSecureStatus *bool `pulumi:"devopsSecureStatus"`
	// Enable the "dummy authentication" mode.
	EnableDummyAuth *bool `pulumi:"enableDummyAuth"`
	// Override the image version of the Ditto images.
	Version *string `pulumi:"version"`
}

// DittoSpecInput is an input type that accepts DittoSpecArgs and DittoSpecOutput values.
// You can construct a concrete instance of `DittoSpecInput` via:
//
//          DittoSpecArgs{...}
type DittoSpecInput interface {
	pulumi.Input

	ToDittoSpecOutput() DittoSpecOutput
	ToDittoSpecOutputWithContext(context.Context) DittoSpecOutput
}

type DittoSpecArgs struct {
	// Create the default "ditto" user when initially deploying.
	CreateDefaultUser pulumi.BoolPtrInput `pulumi:"createDefaultUser"`
	// Secure the devops status information.
	DevopsSecureStatus pulumi.BoolPtrInput `pulumi:"devopsSecureStatus"`
	// Enable the "dummy authentication" mode.
	EnableDummyAuth pulumi.BoolPtrInput `pulumi:"enableDummyAuth"`
	// Override the image version of the Ditto images.
	Version pulumi.StringPtrInput `pulumi:"version"`
}

func (DittoSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*DittoSpec)(nil)).Elem()
}

func (i DittoSpecArgs) ToDittoSpecOutput() DittoSpecOutput {
	return i.ToDittoSpecOutputWithContext(context.Background())
}

func (i DittoSpecArgs) ToDittoSpecOutputWithContext(ctx context.Context) DittoSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DittoSpecOutput)
}

func (i DittoSpecArgs) ToDittoSpecPtrOutput() DittoSpecPtrOutput {
	return i.ToDittoSpecPtrOutputWithContext(context.Background())
}

func (i DittoSpecArgs) ToDittoSpecPtrOutputWithContext(ctx context.Context) DittoSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DittoSpecOutput).ToDittoSpecPtrOutputWithContext(ctx)
}

// DittoSpecPtrInput is an input type that accepts DittoSpecArgs, DittoSpecPtr and DittoSpecPtrOutput values.
// You can construct a concrete instance of `DittoSpecPtrInput` via:
//
//          DittoSpecArgs{...}
//
//  or:
//
//          nil
type DittoSpecPtrInput interface {
	pulumi.Input

	ToDittoSpecPtrOutput() DittoSpecPtrOutput
	ToDittoSpecPtrOutputWithContext(context.Context) DittoSpecPtrOutput
}

type dittoSpecPtrType DittoSpecArgs

func DittoSpecPtr(v *DittoSpecArgs) DittoSpecPtrInput {
	return (*dittoSpecPtrType)(v)
}

func (*dittoSpecPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**DittoSpec)(nil)).Elem()
}

func (i *dittoSpecPtrType) ToDittoSpecPtrOutput() DittoSpecPtrOutput {
	return i.ToDittoSpecPtrOutputWithContext(context.Background())
}

func (i *dittoSpecPtrType) ToDittoSpecPtrOutputWithContext(ctx context.Context) DittoSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DittoSpecPtrOutput)
}

type DittoSpecOutput struct{ *pulumi.OutputState }

func (DittoSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DittoSpec)(nil)).Elem()
}

func (o DittoSpecOutput) ToDittoSpecOutput() DittoSpecOutput {
	return o
}

func (o DittoSpecOutput) ToDittoSpecOutputWithContext(ctx context.Context) DittoSpecOutput {
	return o
}

func (o DittoSpecOutput) ToDittoSpecPtrOutput() DittoSpecPtrOutput {
	return o.ToDittoSpecPtrOutputWithContext(context.Background())
}

func (o DittoSpecOutput) ToDittoSpecPtrOutputWithContext(ctx context.Context) DittoSpecPtrOutput {
	return o.ApplyT(func(v DittoSpec) *DittoSpec {
		return &v
	}).(DittoSpecPtrOutput)
}

// Create the default "ditto" user when initially deploying.
func (o DittoSpecOutput) CreateDefaultUser() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DittoSpec) *bool { return v.CreateDefaultUser }).(pulumi.BoolPtrOutput)
}

// Secure the devops status information.
func (o DittoSpecOutput) DevopsSecureStatus() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DittoSpec) *bool { return v.DevopsSecureStatus }).(pulumi.BoolPtrOutput)
}

// Enable the "dummy authentication" mode.
func (o DittoSpecOutput) EnableDummyAuth() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DittoSpec) *bool { return v.EnableDummyAuth }).(pulumi.BoolPtrOutput)
}

// Override the image version of the Ditto images.
func (o DittoSpecOutput) Version() pulumi.StringPtrOutput {
	return o.ApplyT(func(v DittoSpec) *string { return v.Version }).(pulumi.StringPtrOutput)
}

type DittoSpecPtrOutput struct{ *pulumi.OutputState }

func (DittoSpecPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DittoSpec)(nil)).Elem()
}

func (o DittoSpecPtrOutput) ToDittoSpecPtrOutput() DittoSpecPtrOutput {
	return o
}

func (o DittoSpecPtrOutput) ToDittoSpecPtrOutputWithContext(ctx context.Context) DittoSpecPtrOutput {
	return o
}

func (o DittoSpecPtrOutput) Elem() DittoSpecOutput {
	return o.ApplyT(func(v *DittoSpec) DittoSpec { return *v }).(DittoSpecOutput)
}

// Create the default "ditto" user when initially deploying.
func (o DittoSpecPtrOutput) CreateDefaultUser() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DittoSpec) *bool {
		if v == nil {
			return nil
		}
		return v.CreateDefaultUser
	}).(pulumi.BoolPtrOutput)
}

// Secure the devops status information.
func (o DittoSpecPtrOutput) DevopsSecureStatus() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DittoSpec) *bool {
		if v == nil {
			return nil
		}
		return v.DevopsSecureStatus
	}).(pulumi.BoolPtrOutput)
}

// Enable the "dummy authentication" mode.
func (o DittoSpecPtrOutput) EnableDummyAuth() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DittoSpec) *bool {
		if v == nil {
			return nil
		}
		return v.EnableDummyAuth
	}).(pulumi.BoolPtrOutput)
}

// Override the image version of the Ditto images.
func (o DittoSpecPtrOutput) Version() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DittoSpec) *string {
		if v == nil {
			return nil
		}
		return v.Version
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(DittoTypeOutput{})
	pulumi.RegisterOutputType(DittoSpecOutput{})
	pulumi.RegisterOutputType(DittoSpecPtrOutput{})
}
