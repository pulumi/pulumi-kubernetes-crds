// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The Cluster Node Feature Discovery operator manages detection of hardware features and configuration in a Openshift cluster. The operator orchestrates all resources needed to run the NFD DaemonSet (Upstream: https://github.com/kubernetes-sigs/node-feature-discovery)
type NodeFeatureDiscoveryType struct {
	ApiVersion *string                `pulumi:"apiVersion"`
	Kind       *string                `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta     `pulumi:"metadata"`
	Spec       map[string]interface{} `pulumi:"spec"`
	Status     map[string]interface{} `pulumi:"status"`
}

// NodeFeatureDiscoveryTypeInput is an input type that accepts NodeFeatureDiscoveryTypeArgs and NodeFeatureDiscoveryTypeOutput values.
// You can construct a concrete instance of `NodeFeatureDiscoveryTypeInput` via:
//
//          NodeFeatureDiscoveryTypeArgs{...}
type NodeFeatureDiscoveryTypeInput interface {
	pulumi.Input

	ToNodeFeatureDiscoveryTypeOutput() NodeFeatureDiscoveryTypeOutput
	ToNodeFeatureDiscoveryTypeOutputWithContext(context.Context) NodeFeatureDiscoveryTypeOutput
}

// The Cluster Node Feature Discovery operator manages detection of hardware features and configuration in a Openshift cluster. The operator orchestrates all resources needed to run the NFD DaemonSet (Upstream: https://github.com/kubernetes-sigs/node-feature-discovery)
type NodeFeatureDiscoveryTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
	Spec       pulumi.MapInput           `pulumi:"spec"`
	Status     pulumi.MapInput           `pulumi:"status"`
}

func (NodeFeatureDiscoveryTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*NodeFeatureDiscoveryType)(nil)).Elem()
}

func (i NodeFeatureDiscoveryTypeArgs) ToNodeFeatureDiscoveryTypeOutput() NodeFeatureDiscoveryTypeOutput {
	return i.ToNodeFeatureDiscoveryTypeOutputWithContext(context.Background())
}

func (i NodeFeatureDiscoveryTypeArgs) ToNodeFeatureDiscoveryTypeOutputWithContext(ctx context.Context) NodeFeatureDiscoveryTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NodeFeatureDiscoveryTypeOutput)
}

// The Cluster Node Feature Discovery operator manages detection of hardware features and configuration in a Openshift cluster. The operator orchestrates all resources needed to run the NFD DaemonSet (Upstream: https://github.com/kubernetes-sigs/node-feature-discovery)
type NodeFeatureDiscoveryTypeOutput struct{ *pulumi.OutputState }

func (NodeFeatureDiscoveryTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NodeFeatureDiscoveryType)(nil)).Elem()
}

func (o NodeFeatureDiscoveryTypeOutput) ToNodeFeatureDiscoveryTypeOutput() NodeFeatureDiscoveryTypeOutput {
	return o
}

func (o NodeFeatureDiscoveryTypeOutput) ToNodeFeatureDiscoveryTypeOutputWithContext(ctx context.Context) NodeFeatureDiscoveryTypeOutput {
	return o
}

func (o NodeFeatureDiscoveryTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v NodeFeatureDiscoveryType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o NodeFeatureDiscoveryTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v NodeFeatureDiscoveryType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o NodeFeatureDiscoveryTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v NodeFeatureDiscoveryType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

func (o NodeFeatureDiscoveryTypeOutput) Spec() pulumi.MapOutput {
	return o.ApplyT(func(v NodeFeatureDiscoveryType) map[string]interface{} { return v.Spec }).(pulumi.MapOutput)
}

func (o NodeFeatureDiscoveryTypeOutput) Status() pulumi.MapOutput {
	return o.ApplyT(func(v NodeFeatureDiscoveryType) map[string]interface{} { return v.Status }).(pulumi.MapOutput)
}

type NodeFeatureDiscoveryMetadata struct {
}

// NodeFeatureDiscoveryMetadataInput is an input type that accepts NodeFeatureDiscoveryMetadataArgs and NodeFeatureDiscoveryMetadataOutput values.
// You can construct a concrete instance of `NodeFeatureDiscoveryMetadataInput` via:
//
//          NodeFeatureDiscoveryMetadataArgs{...}
type NodeFeatureDiscoveryMetadataInput interface {
	pulumi.Input

	ToNodeFeatureDiscoveryMetadataOutput() NodeFeatureDiscoveryMetadataOutput
	ToNodeFeatureDiscoveryMetadataOutputWithContext(context.Context) NodeFeatureDiscoveryMetadataOutput
}

type NodeFeatureDiscoveryMetadataArgs struct {
}

func (NodeFeatureDiscoveryMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*NodeFeatureDiscoveryMetadata)(nil)).Elem()
}

func (i NodeFeatureDiscoveryMetadataArgs) ToNodeFeatureDiscoveryMetadataOutput() NodeFeatureDiscoveryMetadataOutput {
	return i.ToNodeFeatureDiscoveryMetadataOutputWithContext(context.Background())
}

func (i NodeFeatureDiscoveryMetadataArgs) ToNodeFeatureDiscoveryMetadataOutputWithContext(ctx context.Context) NodeFeatureDiscoveryMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NodeFeatureDiscoveryMetadataOutput)
}

type NodeFeatureDiscoveryMetadataOutput struct{ *pulumi.OutputState }

func (NodeFeatureDiscoveryMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NodeFeatureDiscoveryMetadata)(nil)).Elem()
}

func (o NodeFeatureDiscoveryMetadataOutput) ToNodeFeatureDiscoveryMetadataOutput() NodeFeatureDiscoveryMetadataOutput {
	return o
}

func (o NodeFeatureDiscoveryMetadataOutput) ToNodeFeatureDiscoveryMetadataOutputWithContext(ctx context.Context) NodeFeatureDiscoveryMetadataOutput {
	return o
}

type NodeFeatureDiscoverySpec struct {
}

// NodeFeatureDiscoverySpecInput is an input type that accepts NodeFeatureDiscoverySpecArgs and NodeFeatureDiscoverySpecOutput values.
// You can construct a concrete instance of `NodeFeatureDiscoverySpecInput` via:
//
//          NodeFeatureDiscoverySpecArgs{...}
type NodeFeatureDiscoverySpecInput interface {
	pulumi.Input

	ToNodeFeatureDiscoverySpecOutput() NodeFeatureDiscoverySpecOutput
	ToNodeFeatureDiscoverySpecOutputWithContext(context.Context) NodeFeatureDiscoverySpecOutput
}

type NodeFeatureDiscoverySpecArgs struct {
}

func (NodeFeatureDiscoverySpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*NodeFeatureDiscoverySpec)(nil)).Elem()
}

func (i NodeFeatureDiscoverySpecArgs) ToNodeFeatureDiscoverySpecOutput() NodeFeatureDiscoverySpecOutput {
	return i.ToNodeFeatureDiscoverySpecOutputWithContext(context.Background())
}

func (i NodeFeatureDiscoverySpecArgs) ToNodeFeatureDiscoverySpecOutputWithContext(ctx context.Context) NodeFeatureDiscoverySpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NodeFeatureDiscoverySpecOutput)
}

type NodeFeatureDiscoverySpecOutput struct{ *pulumi.OutputState }

func (NodeFeatureDiscoverySpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NodeFeatureDiscoverySpec)(nil)).Elem()
}

func (o NodeFeatureDiscoverySpecOutput) ToNodeFeatureDiscoverySpecOutput() NodeFeatureDiscoverySpecOutput {
	return o
}

func (o NodeFeatureDiscoverySpecOutput) ToNodeFeatureDiscoverySpecOutputWithContext(ctx context.Context) NodeFeatureDiscoverySpecOutput {
	return o
}

type NodeFeatureDiscoveryStatus struct {
}

// NodeFeatureDiscoveryStatusInput is an input type that accepts NodeFeatureDiscoveryStatusArgs and NodeFeatureDiscoveryStatusOutput values.
// You can construct a concrete instance of `NodeFeatureDiscoveryStatusInput` via:
//
//          NodeFeatureDiscoveryStatusArgs{...}
type NodeFeatureDiscoveryStatusInput interface {
	pulumi.Input

	ToNodeFeatureDiscoveryStatusOutput() NodeFeatureDiscoveryStatusOutput
	ToNodeFeatureDiscoveryStatusOutputWithContext(context.Context) NodeFeatureDiscoveryStatusOutput
}

type NodeFeatureDiscoveryStatusArgs struct {
}

func (NodeFeatureDiscoveryStatusArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*NodeFeatureDiscoveryStatus)(nil)).Elem()
}

func (i NodeFeatureDiscoveryStatusArgs) ToNodeFeatureDiscoveryStatusOutput() NodeFeatureDiscoveryStatusOutput {
	return i.ToNodeFeatureDiscoveryStatusOutputWithContext(context.Background())
}

func (i NodeFeatureDiscoveryStatusArgs) ToNodeFeatureDiscoveryStatusOutputWithContext(ctx context.Context) NodeFeatureDiscoveryStatusOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NodeFeatureDiscoveryStatusOutput)
}

type NodeFeatureDiscoveryStatusOutput struct{ *pulumi.OutputState }

func (NodeFeatureDiscoveryStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NodeFeatureDiscoveryStatus)(nil)).Elem()
}

func (o NodeFeatureDiscoveryStatusOutput) ToNodeFeatureDiscoveryStatusOutput() NodeFeatureDiscoveryStatusOutput {
	return o
}

func (o NodeFeatureDiscoveryStatusOutput) ToNodeFeatureDiscoveryStatusOutputWithContext(ctx context.Context) NodeFeatureDiscoveryStatusOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(NodeFeatureDiscoveryTypeOutput{})
	pulumi.RegisterOutputType(NodeFeatureDiscoveryMetadataOutput{})
	pulumi.RegisterOutputType(NodeFeatureDiscoverySpecOutput{})
	pulumi.RegisterOutputType(NodeFeatureDiscoveryStatusOutput{})
}
