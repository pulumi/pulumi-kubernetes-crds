// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// StarterKit is the Schema for the starterkits API
type StarterKitType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// StarterKitSpec defines the desired state of StarterKit
	Spec *StarterKitSpec `pulumi:"spec"`
	// StarterKitStatus defines the observed state of StarterKit
	Status *StarterKitStatus `pulumi:"status"`
}

// StarterKitTypeInput is an input type that accepts StarterKitTypeArgs and StarterKitTypeOutput values.
// You can construct a concrete instance of `StarterKitTypeInput` via:
//
//          StarterKitTypeArgs{...}
type StarterKitTypeInput interface {
	pulumi.Input

	ToStarterKitTypeOutput() StarterKitTypeOutput
	ToStarterKitTypeOutputWithContext(context.Context) StarterKitTypeOutput
}

// StarterKit is the Schema for the starterkits API
type StarterKitTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
	// StarterKitSpec defines the desired state of StarterKit
	Spec StarterKitSpecPtrInput `pulumi:"spec"`
	// StarterKitStatus defines the observed state of StarterKit
	Status StarterKitStatusPtrInput `pulumi:"status"`
}

func (StarterKitTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*StarterKitType)(nil)).Elem()
}

func (i StarterKitTypeArgs) ToStarterKitTypeOutput() StarterKitTypeOutput {
	return i.ToStarterKitTypeOutputWithContext(context.Background())
}

func (i StarterKitTypeArgs) ToStarterKitTypeOutputWithContext(ctx context.Context) StarterKitTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StarterKitTypeOutput)
}

// StarterKit is the Schema for the starterkits API
type StarterKitTypeOutput struct{ *pulumi.OutputState }

func (StarterKitTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*StarterKitType)(nil)).Elem()
}

func (o StarterKitTypeOutput) ToStarterKitTypeOutput() StarterKitTypeOutput {
	return o
}

func (o StarterKitTypeOutput) ToStarterKitTypeOutputWithContext(ctx context.Context) StarterKitTypeOutput {
	return o
}

func (o StarterKitTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v StarterKitType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o StarterKitTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v StarterKitType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o StarterKitTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v StarterKitType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

// StarterKitSpec defines the desired state of StarterKit
func (o StarterKitTypeOutput) Spec() StarterKitSpecPtrOutput {
	return o.ApplyT(func(v StarterKitType) *StarterKitSpec { return v.Spec }).(StarterKitSpecPtrOutput)
}

// StarterKitStatus defines the observed state of StarterKit
func (o StarterKitTypeOutput) Status() StarterKitStatusPtrOutput {
	return o.ApplyT(func(v StarterKitType) *StarterKitStatus { return v.Status }).(StarterKitStatusPtrOutput)
}

type StarterKitMetadata struct {
}

// StarterKitMetadataInput is an input type that accepts StarterKitMetadataArgs and StarterKitMetadataOutput values.
// You can construct a concrete instance of `StarterKitMetadataInput` via:
//
//          StarterKitMetadataArgs{...}
type StarterKitMetadataInput interface {
	pulumi.Input

	ToStarterKitMetadataOutput() StarterKitMetadataOutput
	ToStarterKitMetadataOutputWithContext(context.Context) StarterKitMetadataOutput
}

type StarterKitMetadataArgs struct {
}

func (StarterKitMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*StarterKitMetadata)(nil)).Elem()
}

func (i StarterKitMetadataArgs) ToStarterKitMetadataOutput() StarterKitMetadataOutput {
	return i.ToStarterKitMetadataOutputWithContext(context.Background())
}

func (i StarterKitMetadataArgs) ToStarterKitMetadataOutputWithContext(ctx context.Context) StarterKitMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StarterKitMetadataOutput)
}

type StarterKitMetadataOutput struct{ *pulumi.OutputState }

func (StarterKitMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*StarterKitMetadata)(nil)).Elem()
}

func (o StarterKitMetadataOutput) ToStarterKitMetadataOutput() StarterKitMetadataOutput {
	return o
}

func (o StarterKitMetadataOutput) ToStarterKitMetadataOutputWithContext(ctx context.Context) StarterKitMetadataOutput {
	return o
}

// StarterKitSpec defines the desired state of StarterKit
type StarterKitSpec struct {
	Options      map[string]interface{} `pulumi:"options"`
	TemplateRepo map[string]interface{} `pulumi:"templateRepo"`
}

// StarterKitSpecInput is an input type that accepts StarterKitSpecArgs and StarterKitSpecOutput values.
// You can construct a concrete instance of `StarterKitSpecInput` via:
//
//          StarterKitSpecArgs{...}
type StarterKitSpecInput interface {
	pulumi.Input

	ToStarterKitSpecOutput() StarterKitSpecOutput
	ToStarterKitSpecOutputWithContext(context.Context) StarterKitSpecOutput
}

// StarterKitSpec defines the desired state of StarterKit
type StarterKitSpecArgs struct {
	Options      pulumi.MapInput `pulumi:"options"`
	TemplateRepo pulumi.MapInput `pulumi:"templateRepo"`
}

func (StarterKitSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*StarterKitSpec)(nil)).Elem()
}

func (i StarterKitSpecArgs) ToStarterKitSpecOutput() StarterKitSpecOutput {
	return i.ToStarterKitSpecOutputWithContext(context.Background())
}

func (i StarterKitSpecArgs) ToStarterKitSpecOutputWithContext(ctx context.Context) StarterKitSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StarterKitSpecOutput)
}

func (i StarterKitSpecArgs) ToStarterKitSpecPtrOutput() StarterKitSpecPtrOutput {
	return i.ToStarterKitSpecPtrOutputWithContext(context.Background())
}

func (i StarterKitSpecArgs) ToStarterKitSpecPtrOutputWithContext(ctx context.Context) StarterKitSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StarterKitSpecOutput).ToStarterKitSpecPtrOutputWithContext(ctx)
}

// StarterKitSpecPtrInput is an input type that accepts StarterKitSpecArgs, StarterKitSpecPtr and StarterKitSpecPtrOutput values.
// You can construct a concrete instance of `StarterKitSpecPtrInput` via:
//
//          StarterKitSpecArgs{...}
//
//  or:
//
//          nil
type StarterKitSpecPtrInput interface {
	pulumi.Input

	ToStarterKitSpecPtrOutput() StarterKitSpecPtrOutput
	ToStarterKitSpecPtrOutputWithContext(context.Context) StarterKitSpecPtrOutput
}

type starterKitSpecPtrType StarterKitSpecArgs

func StarterKitSpecPtr(v *StarterKitSpecArgs) StarterKitSpecPtrInput {
	return (*starterKitSpecPtrType)(v)
}

func (*starterKitSpecPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**StarterKitSpec)(nil)).Elem()
}

func (i *starterKitSpecPtrType) ToStarterKitSpecPtrOutput() StarterKitSpecPtrOutput {
	return i.ToStarterKitSpecPtrOutputWithContext(context.Background())
}

func (i *starterKitSpecPtrType) ToStarterKitSpecPtrOutputWithContext(ctx context.Context) StarterKitSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StarterKitSpecPtrOutput)
}

// StarterKitSpec defines the desired state of StarterKit
type StarterKitSpecOutput struct{ *pulumi.OutputState }

func (StarterKitSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*StarterKitSpec)(nil)).Elem()
}

func (o StarterKitSpecOutput) ToStarterKitSpecOutput() StarterKitSpecOutput {
	return o
}

func (o StarterKitSpecOutput) ToStarterKitSpecOutputWithContext(ctx context.Context) StarterKitSpecOutput {
	return o
}

func (o StarterKitSpecOutput) ToStarterKitSpecPtrOutput() StarterKitSpecPtrOutput {
	return o.ToStarterKitSpecPtrOutputWithContext(context.Background())
}

func (o StarterKitSpecOutput) ToStarterKitSpecPtrOutputWithContext(ctx context.Context) StarterKitSpecPtrOutput {
	return o.ApplyT(func(v StarterKitSpec) *StarterKitSpec {
		return &v
	}).(StarterKitSpecPtrOutput)
}
func (o StarterKitSpecOutput) Options() pulumi.MapOutput {
	return o.ApplyT(func(v StarterKitSpec) map[string]interface{} { return v.Options }).(pulumi.MapOutput)
}

func (o StarterKitSpecOutput) TemplateRepo() pulumi.MapOutput {
	return o.ApplyT(func(v StarterKitSpec) map[string]interface{} { return v.TemplateRepo }).(pulumi.MapOutput)
}

type StarterKitSpecPtrOutput struct{ *pulumi.OutputState }

func (StarterKitSpecPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**StarterKitSpec)(nil)).Elem()
}

func (o StarterKitSpecPtrOutput) ToStarterKitSpecPtrOutput() StarterKitSpecPtrOutput {
	return o
}

func (o StarterKitSpecPtrOutput) ToStarterKitSpecPtrOutputWithContext(ctx context.Context) StarterKitSpecPtrOutput {
	return o
}

func (o StarterKitSpecPtrOutput) Elem() StarterKitSpecOutput {
	return o.ApplyT(func(v *StarterKitSpec) StarterKitSpec { return *v }).(StarterKitSpecOutput)
}

func (o StarterKitSpecPtrOutput) Options() pulumi.MapOutput {
	return o.ApplyT(func(v *StarterKitSpec) map[string]interface{} {
		if v == nil {
			return nil
		}
		return v.Options
	}).(pulumi.MapOutput)
}

func (o StarterKitSpecPtrOutput) TemplateRepo() pulumi.MapOutput {
	return o.ApplyT(func(v *StarterKitSpec) map[string]interface{} {
		if v == nil {
			return nil
		}
		return v.TemplateRepo
	}).(pulumi.MapOutput)
}

type StarterKitSpecOptions struct {
}

// StarterKitSpecOptionsInput is an input type that accepts StarterKitSpecOptionsArgs and StarterKitSpecOptionsOutput values.
// You can construct a concrete instance of `StarterKitSpecOptionsInput` via:
//
//          StarterKitSpecOptionsArgs{...}
type StarterKitSpecOptionsInput interface {
	pulumi.Input

	ToStarterKitSpecOptionsOutput() StarterKitSpecOptionsOutput
	ToStarterKitSpecOptionsOutputWithContext(context.Context) StarterKitSpecOptionsOutput
}

type StarterKitSpecOptionsArgs struct {
}

func (StarterKitSpecOptionsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*StarterKitSpecOptions)(nil)).Elem()
}

func (i StarterKitSpecOptionsArgs) ToStarterKitSpecOptionsOutput() StarterKitSpecOptionsOutput {
	return i.ToStarterKitSpecOptionsOutputWithContext(context.Background())
}

func (i StarterKitSpecOptionsArgs) ToStarterKitSpecOptionsOutputWithContext(ctx context.Context) StarterKitSpecOptionsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StarterKitSpecOptionsOutput)
}

type StarterKitSpecOptionsOutput struct{ *pulumi.OutputState }

func (StarterKitSpecOptionsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*StarterKitSpecOptions)(nil)).Elem()
}

func (o StarterKitSpecOptionsOutput) ToStarterKitSpecOptionsOutput() StarterKitSpecOptionsOutput {
	return o
}

func (o StarterKitSpecOptionsOutput) ToStarterKitSpecOptionsOutputWithContext(ctx context.Context) StarterKitSpecOptionsOutput {
	return o
}

type StarterKitSpecTemplateRepo struct {
}

// StarterKitSpecTemplateRepoInput is an input type that accepts StarterKitSpecTemplateRepoArgs and StarterKitSpecTemplateRepoOutput values.
// You can construct a concrete instance of `StarterKitSpecTemplateRepoInput` via:
//
//          StarterKitSpecTemplateRepoArgs{...}
type StarterKitSpecTemplateRepoInput interface {
	pulumi.Input

	ToStarterKitSpecTemplateRepoOutput() StarterKitSpecTemplateRepoOutput
	ToStarterKitSpecTemplateRepoOutputWithContext(context.Context) StarterKitSpecTemplateRepoOutput
}

type StarterKitSpecTemplateRepoArgs struct {
}

func (StarterKitSpecTemplateRepoArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*StarterKitSpecTemplateRepo)(nil)).Elem()
}

func (i StarterKitSpecTemplateRepoArgs) ToStarterKitSpecTemplateRepoOutput() StarterKitSpecTemplateRepoOutput {
	return i.ToStarterKitSpecTemplateRepoOutputWithContext(context.Background())
}

func (i StarterKitSpecTemplateRepoArgs) ToStarterKitSpecTemplateRepoOutputWithContext(ctx context.Context) StarterKitSpecTemplateRepoOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StarterKitSpecTemplateRepoOutput)
}

type StarterKitSpecTemplateRepoOutput struct{ *pulumi.OutputState }

func (StarterKitSpecTemplateRepoOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*StarterKitSpecTemplateRepo)(nil)).Elem()
}

func (o StarterKitSpecTemplateRepoOutput) ToStarterKitSpecTemplateRepoOutput() StarterKitSpecTemplateRepoOutput {
	return o
}

func (o StarterKitSpecTemplateRepoOutput) ToStarterKitSpecTemplateRepoOutputWithContext(ctx context.Context) StarterKitSpecTemplateRepoOutput {
	return o
}

// StarterKitStatus defines the observed state of StarterKit
type StarterKitStatus struct {
	// INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
	TargetRepo string `pulumi:"targetRepo"`
}

// StarterKitStatusInput is an input type that accepts StarterKitStatusArgs and StarterKitStatusOutput values.
// You can construct a concrete instance of `StarterKitStatusInput` via:
//
//          StarterKitStatusArgs{...}
type StarterKitStatusInput interface {
	pulumi.Input

	ToStarterKitStatusOutput() StarterKitStatusOutput
	ToStarterKitStatusOutputWithContext(context.Context) StarterKitStatusOutput
}

// StarterKitStatus defines the observed state of StarterKit
type StarterKitStatusArgs struct {
	// INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
	TargetRepo pulumi.StringInput `pulumi:"targetRepo"`
}

func (StarterKitStatusArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*StarterKitStatus)(nil)).Elem()
}

func (i StarterKitStatusArgs) ToStarterKitStatusOutput() StarterKitStatusOutput {
	return i.ToStarterKitStatusOutputWithContext(context.Background())
}

func (i StarterKitStatusArgs) ToStarterKitStatusOutputWithContext(ctx context.Context) StarterKitStatusOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StarterKitStatusOutput)
}

func (i StarterKitStatusArgs) ToStarterKitStatusPtrOutput() StarterKitStatusPtrOutput {
	return i.ToStarterKitStatusPtrOutputWithContext(context.Background())
}

func (i StarterKitStatusArgs) ToStarterKitStatusPtrOutputWithContext(ctx context.Context) StarterKitStatusPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StarterKitStatusOutput).ToStarterKitStatusPtrOutputWithContext(ctx)
}

// StarterKitStatusPtrInput is an input type that accepts StarterKitStatusArgs, StarterKitStatusPtr and StarterKitStatusPtrOutput values.
// You can construct a concrete instance of `StarterKitStatusPtrInput` via:
//
//          StarterKitStatusArgs{...}
//
//  or:
//
//          nil
type StarterKitStatusPtrInput interface {
	pulumi.Input

	ToStarterKitStatusPtrOutput() StarterKitStatusPtrOutput
	ToStarterKitStatusPtrOutputWithContext(context.Context) StarterKitStatusPtrOutput
}

type starterKitStatusPtrType StarterKitStatusArgs

func StarterKitStatusPtr(v *StarterKitStatusArgs) StarterKitStatusPtrInput {
	return (*starterKitStatusPtrType)(v)
}

func (*starterKitStatusPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**StarterKitStatus)(nil)).Elem()
}

func (i *starterKitStatusPtrType) ToStarterKitStatusPtrOutput() StarterKitStatusPtrOutput {
	return i.ToStarterKitStatusPtrOutputWithContext(context.Background())
}

func (i *starterKitStatusPtrType) ToStarterKitStatusPtrOutputWithContext(ctx context.Context) StarterKitStatusPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StarterKitStatusPtrOutput)
}

// StarterKitStatus defines the observed state of StarterKit
type StarterKitStatusOutput struct{ *pulumi.OutputState }

func (StarterKitStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*StarterKitStatus)(nil)).Elem()
}

func (o StarterKitStatusOutput) ToStarterKitStatusOutput() StarterKitStatusOutput {
	return o
}

func (o StarterKitStatusOutput) ToStarterKitStatusOutputWithContext(ctx context.Context) StarterKitStatusOutput {
	return o
}

func (o StarterKitStatusOutput) ToStarterKitStatusPtrOutput() StarterKitStatusPtrOutput {
	return o.ToStarterKitStatusPtrOutputWithContext(context.Background())
}

func (o StarterKitStatusOutput) ToStarterKitStatusPtrOutputWithContext(ctx context.Context) StarterKitStatusPtrOutput {
	return o.ApplyT(func(v StarterKitStatus) *StarterKitStatus {
		return &v
	}).(StarterKitStatusPtrOutput)
}

// INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
func (o StarterKitStatusOutput) TargetRepo() pulumi.StringOutput {
	return o.ApplyT(func(v StarterKitStatus) string { return v.TargetRepo }).(pulumi.StringOutput)
}

type StarterKitStatusPtrOutput struct{ *pulumi.OutputState }

func (StarterKitStatusPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**StarterKitStatus)(nil)).Elem()
}

func (o StarterKitStatusPtrOutput) ToStarterKitStatusPtrOutput() StarterKitStatusPtrOutput {
	return o
}

func (o StarterKitStatusPtrOutput) ToStarterKitStatusPtrOutputWithContext(ctx context.Context) StarterKitStatusPtrOutput {
	return o
}

func (o StarterKitStatusPtrOutput) Elem() StarterKitStatusOutput {
	return o.ApplyT(func(v *StarterKitStatus) StarterKitStatus { return *v }).(StarterKitStatusOutput)
}

// INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
func (o StarterKitStatusPtrOutput) TargetRepo() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *StarterKitStatus) *string {
		if v == nil {
			return nil
		}
		return &v.TargetRepo
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(StarterKitTypeOutput{})
	pulumi.RegisterOutputType(StarterKitMetadataOutput{})
	pulumi.RegisterOutputType(StarterKitSpecOutput{})
	pulumi.RegisterOutputType(StarterKitSpecPtrOutput{})
	pulumi.RegisterOutputType(StarterKitSpecOptionsOutput{})
	pulumi.RegisterOutputType(StarterKitSpecTemplateRepoOutput{})
	pulumi.RegisterOutputType(StarterKitStatusOutput{})
	pulumi.RegisterOutputType(StarterKitStatusPtrOutput{})
}
