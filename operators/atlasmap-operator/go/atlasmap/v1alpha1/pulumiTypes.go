// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// AtlasMap is the Schema for the atlasmaps API
type AtlasMapType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// AtlasMapSpec defines the desired state of AtlasMap
	Spec *AtlasMapSpec `pulumi:"spec"`
	// AtlasMapStatus defines the observed state of AtlasMap
	Status *AtlasMapStatus `pulumi:"status"`
}

// AtlasMapTypeInput is an input type that accepts AtlasMapTypeArgs and AtlasMapTypeOutput values.
// You can construct a concrete instance of `AtlasMapTypeInput` via:
//
//          AtlasMapTypeArgs{...}
type AtlasMapTypeInput interface {
	pulumi.Input

	ToAtlasMapTypeOutput() AtlasMapTypeOutput
	ToAtlasMapTypeOutputWithContext(context.Context) AtlasMapTypeOutput
}

// AtlasMap is the Schema for the atlasmaps API
type AtlasMapTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
	// AtlasMapSpec defines the desired state of AtlasMap
	Spec AtlasMapSpecPtrInput `pulumi:"spec"`
	// AtlasMapStatus defines the observed state of AtlasMap
	Status AtlasMapStatusPtrInput `pulumi:"status"`
}

func (AtlasMapTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AtlasMapType)(nil)).Elem()
}

func (i AtlasMapTypeArgs) ToAtlasMapTypeOutput() AtlasMapTypeOutput {
	return i.ToAtlasMapTypeOutputWithContext(context.Background())
}

func (i AtlasMapTypeArgs) ToAtlasMapTypeOutputWithContext(ctx context.Context) AtlasMapTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AtlasMapTypeOutput)
}

// AtlasMap is the Schema for the atlasmaps API
type AtlasMapTypeOutput struct{ *pulumi.OutputState }

func (AtlasMapTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AtlasMapType)(nil)).Elem()
}

func (o AtlasMapTypeOutput) ToAtlasMapTypeOutput() AtlasMapTypeOutput {
	return o
}

func (o AtlasMapTypeOutput) ToAtlasMapTypeOutputWithContext(ctx context.Context) AtlasMapTypeOutput {
	return o
}

func (o AtlasMapTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AtlasMapType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o AtlasMapTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AtlasMapType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o AtlasMapTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v AtlasMapType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

// AtlasMapSpec defines the desired state of AtlasMap
func (o AtlasMapTypeOutput) Spec() AtlasMapSpecPtrOutput {
	return o.ApplyT(func(v AtlasMapType) *AtlasMapSpec { return v.Spec }).(AtlasMapSpecPtrOutput)
}

// AtlasMapStatus defines the observed state of AtlasMap
func (o AtlasMapTypeOutput) Status() AtlasMapStatusPtrOutput {
	return o.ApplyT(func(v AtlasMapType) *AtlasMapStatus { return v.Status }).(AtlasMapStatusPtrOutput)
}

type AtlasMapMetadata struct {
}

// AtlasMapMetadataInput is an input type that accepts AtlasMapMetadataArgs and AtlasMapMetadataOutput values.
// You can construct a concrete instance of `AtlasMapMetadataInput` via:
//
//          AtlasMapMetadataArgs{...}
type AtlasMapMetadataInput interface {
	pulumi.Input

	ToAtlasMapMetadataOutput() AtlasMapMetadataOutput
	ToAtlasMapMetadataOutputWithContext(context.Context) AtlasMapMetadataOutput
}

type AtlasMapMetadataArgs struct {
}

func (AtlasMapMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AtlasMapMetadata)(nil)).Elem()
}

func (i AtlasMapMetadataArgs) ToAtlasMapMetadataOutput() AtlasMapMetadataOutput {
	return i.ToAtlasMapMetadataOutputWithContext(context.Background())
}

func (i AtlasMapMetadataArgs) ToAtlasMapMetadataOutputWithContext(ctx context.Context) AtlasMapMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AtlasMapMetadataOutput)
}

type AtlasMapMetadataOutput struct{ *pulumi.OutputState }

func (AtlasMapMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AtlasMapMetadata)(nil)).Elem()
}

func (o AtlasMapMetadataOutput) ToAtlasMapMetadataOutput() AtlasMapMetadataOutput {
	return o
}

func (o AtlasMapMetadataOutput) ToAtlasMapMetadataOutputWithContext(ctx context.Context) AtlasMapMetadataOutput {
	return o
}

// AtlasMapSpec defines the desired state of AtlasMap
type AtlasMapSpec struct {
	// The amount of CPU to limit
	LimitCPU *string `pulumi:"limitCPU"`
	// The amount of memory to request
	LimitMemory *string `pulumi:"limitMemory"`
	// Replicas determines the desired number of running AtlasMap pods
	Replicas *int `pulumi:"replicas"`
	// The amount of CPU to request
	RequestCPU *string `pulumi:"requestCPU"`
	// The amount of memory to request
	RequestMemory *string `pulumi:"requestMemory"`
	// RouteHostName sets the host name to use on the Ingress or OpenShift Route
	RouteHostName *string `pulumi:"routeHostName"`
	// Version sets the version of the container image used for AtlasMap
	Version *string `pulumi:"version"`
}

// AtlasMapSpecInput is an input type that accepts AtlasMapSpecArgs and AtlasMapSpecOutput values.
// You can construct a concrete instance of `AtlasMapSpecInput` via:
//
//          AtlasMapSpecArgs{...}
type AtlasMapSpecInput interface {
	pulumi.Input

	ToAtlasMapSpecOutput() AtlasMapSpecOutput
	ToAtlasMapSpecOutputWithContext(context.Context) AtlasMapSpecOutput
}

// AtlasMapSpec defines the desired state of AtlasMap
type AtlasMapSpecArgs struct {
	// The amount of CPU to limit
	LimitCPU pulumi.StringPtrInput `pulumi:"limitCPU"`
	// The amount of memory to request
	LimitMemory pulumi.StringPtrInput `pulumi:"limitMemory"`
	// Replicas determines the desired number of running AtlasMap pods
	Replicas pulumi.IntPtrInput `pulumi:"replicas"`
	// The amount of CPU to request
	RequestCPU pulumi.StringPtrInput `pulumi:"requestCPU"`
	// The amount of memory to request
	RequestMemory pulumi.StringPtrInput `pulumi:"requestMemory"`
	// RouteHostName sets the host name to use on the Ingress or OpenShift Route
	RouteHostName pulumi.StringPtrInput `pulumi:"routeHostName"`
	// Version sets the version of the container image used for AtlasMap
	Version pulumi.StringPtrInput `pulumi:"version"`
}

func (AtlasMapSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AtlasMapSpec)(nil)).Elem()
}

func (i AtlasMapSpecArgs) ToAtlasMapSpecOutput() AtlasMapSpecOutput {
	return i.ToAtlasMapSpecOutputWithContext(context.Background())
}

func (i AtlasMapSpecArgs) ToAtlasMapSpecOutputWithContext(ctx context.Context) AtlasMapSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AtlasMapSpecOutput)
}

func (i AtlasMapSpecArgs) ToAtlasMapSpecPtrOutput() AtlasMapSpecPtrOutput {
	return i.ToAtlasMapSpecPtrOutputWithContext(context.Background())
}

func (i AtlasMapSpecArgs) ToAtlasMapSpecPtrOutputWithContext(ctx context.Context) AtlasMapSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AtlasMapSpecOutput).ToAtlasMapSpecPtrOutputWithContext(ctx)
}

// AtlasMapSpecPtrInput is an input type that accepts AtlasMapSpecArgs, AtlasMapSpecPtr and AtlasMapSpecPtrOutput values.
// You can construct a concrete instance of `AtlasMapSpecPtrInput` via:
//
//          AtlasMapSpecArgs{...}
//
//  or:
//
//          nil
type AtlasMapSpecPtrInput interface {
	pulumi.Input

	ToAtlasMapSpecPtrOutput() AtlasMapSpecPtrOutput
	ToAtlasMapSpecPtrOutputWithContext(context.Context) AtlasMapSpecPtrOutput
}

type atlasMapSpecPtrType AtlasMapSpecArgs

func AtlasMapSpecPtr(v *AtlasMapSpecArgs) AtlasMapSpecPtrInput {
	return (*atlasMapSpecPtrType)(v)
}

func (*atlasMapSpecPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**AtlasMapSpec)(nil)).Elem()
}

func (i *atlasMapSpecPtrType) ToAtlasMapSpecPtrOutput() AtlasMapSpecPtrOutput {
	return i.ToAtlasMapSpecPtrOutputWithContext(context.Background())
}

func (i *atlasMapSpecPtrType) ToAtlasMapSpecPtrOutputWithContext(ctx context.Context) AtlasMapSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AtlasMapSpecPtrOutput)
}

// AtlasMapSpec defines the desired state of AtlasMap
type AtlasMapSpecOutput struct{ *pulumi.OutputState }

func (AtlasMapSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AtlasMapSpec)(nil)).Elem()
}

func (o AtlasMapSpecOutput) ToAtlasMapSpecOutput() AtlasMapSpecOutput {
	return o
}

func (o AtlasMapSpecOutput) ToAtlasMapSpecOutputWithContext(ctx context.Context) AtlasMapSpecOutput {
	return o
}

func (o AtlasMapSpecOutput) ToAtlasMapSpecPtrOutput() AtlasMapSpecPtrOutput {
	return o.ToAtlasMapSpecPtrOutputWithContext(context.Background())
}

func (o AtlasMapSpecOutput) ToAtlasMapSpecPtrOutputWithContext(ctx context.Context) AtlasMapSpecPtrOutput {
	return o.ApplyT(func(v AtlasMapSpec) *AtlasMapSpec {
		return &v
	}).(AtlasMapSpecPtrOutput)
}

// The amount of CPU to limit
func (o AtlasMapSpecOutput) LimitCPU() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AtlasMapSpec) *string { return v.LimitCPU }).(pulumi.StringPtrOutput)
}

// The amount of memory to request
func (o AtlasMapSpecOutput) LimitMemory() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AtlasMapSpec) *string { return v.LimitMemory }).(pulumi.StringPtrOutput)
}

// Replicas determines the desired number of running AtlasMap pods
func (o AtlasMapSpecOutput) Replicas() pulumi.IntPtrOutput {
	return o.ApplyT(func(v AtlasMapSpec) *int { return v.Replicas }).(pulumi.IntPtrOutput)
}

// The amount of CPU to request
func (o AtlasMapSpecOutput) RequestCPU() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AtlasMapSpec) *string { return v.RequestCPU }).(pulumi.StringPtrOutput)
}

// The amount of memory to request
func (o AtlasMapSpecOutput) RequestMemory() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AtlasMapSpec) *string { return v.RequestMemory }).(pulumi.StringPtrOutput)
}

// RouteHostName sets the host name to use on the Ingress or OpenShift Route
func (o AtlasMapSpecOutput) RouteHostName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AtlasMapSpec) *string { return v.RouteHostName }).(pulumi.StringPtrOutput)
}

// Version sets the version of the container image used for AtlasMap
func (o AtlasMapSpecOutput) Version() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AtlasMapSpec) *string { return v.Version }).(pulumi.StringPtrOutput)
}

type AtlasMapSpecPtrOutput struct{ *pulumi.OutputState }

func (AtlasMapSpecPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AtlasMapSpec)(nil)).Elem()
}

func (o AtlasMapSpecPtrOutput) ToAtlasMapSpecPtrOutput() AtlasMapSpecPtrOutput {
	return o
}

func (o AtlasMapSpecPtrOutput) ToAtlasMapSpecPtrOutputWithContext(ctx context.Context) AtlasMapSpecPtrOutput {
	return o
}

func (o AtlasMapSpecPtrOutput) Elem() AtlasMapSpecOutput {
	return o.ApplyT(func(v *AtlasMapSpec) AtlasMapSpec { return *v }).(AtlasMapSpecOutput)
}

// The amount of CPU to limit
func (o AtlasMapSpecPtrOutput) LimitCPU() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AtlasMapSpec) *string {
		if v == nil {
			return nil
		}
		return v.LimitCPU
	}).(pulumi.StringPtrOutput)
}

// The amount of memory to request
func (o AtlasMapSpecPtrOutput) LimitMemory() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AtlasMapSpec) *string {
		if v == nil {
			return nil
		}
		return v.LimitMemory
	}).(pulumi.StringPtrOutput)
}

// Replicas determines the desired number of running AtlasMap pods
func (o AtlasMapSpecPtrOutput) Replicas() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *AtlasMapSpec) *int {
		if v == nil {
			return nil
		}
		return v.Replicas
	}).(pulumi.IntPtrOutput)
}

// The amount of CPU to request
func (o AtlasMapSpecPtrOutput) RequestCPU() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AtlasMapSpec) *string {
		if v == nil {
			return nil
		}
		return v.RequestCPU
	}).(pulumi.StringPtrOutput)
}

// The amount of memory to request
func (o AtlasMapSpecPtrOutput) RequestMemory() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AtlasMapSpec) *string {
		if v == nil {
			return nil
		}
		return v.RequestMemory
	}).(pulumi.StringPtrOutput)
}

// RouteHostName sets the host name to use on the Ingress or OpenShift Route
func (o AtlasMapSpecPtrOutput) RouteHostName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AtlasMapSpec) *string {
		if v == nil {
			return nil
		}
		return v.RouteHostName
	}).(pulumi.StringPtrOutput)
}

// Version sets the version of the container image used for AtlasMap
func (o AtlasMapSpecPtrOutput) Version() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AtlasMapSpec) *string {
		if v == nil {
			return nil
		}
		return v.Version
	}).(pulumi.StringPtrOutput)
}

// AtlasMapStatus defines the observed state of AtlasMap
type AtlasMapStatus struct {
	// The URL where AtlasMap can be accessed
	URL *string `pulumi:"URL"`
	// The container image that AtlasMap is using
	Image *string `pulumi:"image"`
	// The current phase that the AtlasMap resource is in
	Phase *string `pulumi:"phase"`
}

// AtlasMapStatusInput is an input type that accepts AtlasMapStatusArgs and AtlasMapStatusOutput values.
// You can construct a concrete instance of `AtlasMapStatusInput` via:
//
//          AtlasMapStatusArgs{...}
type AtlasMapStatusInput interface {
	pulumi.Input

	ToAtlasMapStatusOutput() AtlasMapStatusOutput
	ToAtlasMapStatusOutputWithContext(context.Context) AtlasMapStatusOutput
}

// AtlasMapStatus defines the observed state of AtlasMap
type AtlasMapStatusArgs struct {
	// The URL where AtlasMap can be accessed
	URL pulumi.StringPtrInput `pulumi:"URL"`
	// The container image that AtlasMap is using
	Image pulumi.StringPtrInput `pulumi:"image"`
	// The current phase that the AtlasMap resource is in
	Phase pulumi.StringPtrInput `pulumi:"phase"`
}

func (AtlasMapStatusArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AtlasMapStatus)(nil)).Elem()
}

func (i AtlasMapStatusArgs) ToAtlasMapStatusOutput() AtlasMapStatusOutput {
	return i.ToAtlasMapStatusOutputWithContext(context.Background())
}

func (i AtlasMapStatusArgs) ToAtlasMapStatusOutputWithContext(ctx context.Context) AtlasMapStatusOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AtlasMapStatusOutput)
}

func (i AtlasMapStatusArgs) ToAtlasMapStatusPtrOutput() AtlasMapStatusPtrOutput {
	return i.ToAtlasMapStatusPtrOutputWithContext(context.Background())
}

func (i AtlasMapStatusArgs) ToAtlasMapStatusPtrOutputWithContext(ctx context.Context) AtlasMapStatusPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AtlasMapStatusOutput).ToAtlasMapStatusPtrOutputWithContext(ctx)
}

// AtlasMapStatusPtrInput is an input type that accepts AtlasMapStatusArgs, AtlasMapStatusPtr and AtlasMapStatusPtrOutput values.
// You can construct a concrete instance of `AtlasMapStatusPtrInput` via:
//
//          AtlasMapStatusArgs{...}
//
//  or:
//
//          nil
type AtlasMapStatusPtrInput interface {
	pulumi.Input

	ToAtlasMapStatusPtrOutput() AtlasMapStatusPtrOutput
	ToAtlasMapStatusPtrOutputWithContext(context.Context) AtlasMapStatusPtrOutput
}

type atlasMapStatusPtrType AtlasMapStatusArgs

func AtlasMapStatusPtr(v *AtlasMapStatusArgs) AtlasMapStatusPtrInput {
	return (*atlasMapStatusPtrType)(v)
}

func (*atlasMapStatusPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**AtlasMapStatus)(nil)).Elem()
}

func (i *atlasMapStatusPtrType) ToAtlasMapStatusPtrOutput() AtlasMapStatusPtrOutput {
	return i.ToAtlasMapStatusPtrOutputWithContext(context.Background())
}

func (i *atlasMapStatusPtrType) ToAtlasMapStatusPtrOutputWithContext(ctx context.Context) AtlasMapStatusPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AtlasMapStatusPtrOutput)
}

// AtlasMapStatus defines the observed state of AtlasMap
type AtlasMapStatusOutput struct{ *pulumi.OutputState }

func (AtlasMapStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AtlasMapStatus)(nil)).Elem()
}

func (o AtlasMapStatusOutput) ToAtlasMapStatusOutput() AtlasMapStatusOutput {
	return o
}

func (o AtlasMapStatusOutput) ToAtlasMapStatusOutputWithContext(ctx context.Context) AtlasMapStatusOutput {
	return o
}

func (o AtlasMapStatusOutput) ToAtlasMapStatusPtrOutput() AtlasMapStatusPtrOutput {
	return o.ToAtlasMapStatusPtrOutputWithContext(context.Background())
}

func (o AtlasMapStatusOutput) ToAtlasMapStatusPtrOutputWithContext(ctx context.Context) AtlasMapStatusPtrOutput {
	return o.ApplyT(func(v AtlasMapStatus) *AtlasMapStatus {
		return &v
	}).(AtlasMapStatusPtrOutput)
}

// The URL where AtlasMap can be accessed
func (o AtlasMapStatusOutput) URL() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AtlasMapStatus) *string { return v.URL }).(pulumi.StringPtrOutput)
}

// The container image that AtlasMap is using
func (o AtlasMapStatusOutput) Image() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AtlasMapStatus) *string { return v.Image }).(pulumi.StringPtrOutput)
}

// The current phase that the AtlasMap resource is in
func (o AtlasMapStatusOutput) Phase() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AtlasMapStatus) *string { return v.Phase }).(pulumi.StringPtrOutput)
}

type AtlasMapStatusPtrOutput struct{ *pulumi.OutputState }

func (AtlasMapStatusPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AtlasMapStatus)(nil)).Elem()
}

func (o AtlasMapStatusPtrOutput) ToAtlasMapStatusPtrOutput() AtlasMapStatusPtrOutput {
	return o
}

func (o AtlasMapStatusPtrOutput) ToAtlasMapStatusPtrOutputWithContext(ctx context.Context) AtlasMapStatusPtrOutput {
	return o
}

func (o AtlasMapStatusPtrOutput) Elem() AtlasMapStatusOutput {
	return o.ApplyT(func(v *AtlasMapStatus) AtlasMapStatus { return *v }).(AtlasMapStatusOutput)
}

// The URL where AtlasMap can be accessed
func (o AtlasMapStatusPtrOutput) URL() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AtlasMapStatus) *string {
		if v == nil {
			return nil
		}
		return v.URL
	}).(pulumi.StringPtrOutput)
}

// The container image that AtlasMap is using
func (o AtlasMapStatusPtrOutput) Image() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AtlasMapStatus) *string {
		if v == nil {
			return nil
		}
		return v.Image
	}).(pulumi.StringPtrOutput)
}

// The current phase that the AtlasMap resource is in
func (o AtlasMapStatusPtrOutput) Phase() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AtlasMapStatus) *string {
		if v == nil {
			return nil
		}
		return v.Phase
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(AtlasMapTypeOutput{})
	pulumi.RegisterOutputType(AtlasMapMetadataOutput{})
	pulumi.RegisterOutputType(AtlasMapSpecOutput{})
	pulumi.RegisterOutputType(AtlasMapSpecPtrOutput{})
	pulumi.RegisterOutputType(AtlasMapStatusOutput{})
	pulumi.RegisterOutputType(AtlasMapStatusPtrOutput{})
}