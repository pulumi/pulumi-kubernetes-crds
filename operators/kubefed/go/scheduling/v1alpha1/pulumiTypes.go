// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ReplicaSchedulingPreferenceType struct {
	ApiVersion *string                          `pulumi:"apiVersion"`
	Kind       *string                          `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta               `pulumi:"metadata"`
	Spec       *ReplicaSchedulingPreferenceSpec `pulumi:"spec"`
	Status     map[string]interface{}           `pulumi:"status"`
}

// ReplicaSchedulingPreferenceTypeInput is an input type that accepts ReplicaSchedulingPreferenceTypeArgs and ReplicaSchedulingPreferenceTypeOutput values.
// You can construct a concrete instance of `ReplicaSchedulingPreferenceTypeInput` via:
//
//          ReplicaSchedulingPreferenceTypeArgs{...}
type ReplicaSchedulingPreferenceTypeInput interface {
	pulumi.Input

	ToReplicaSchedulingPreferenceTypeOutput() ReplicaSchedulingPreferenceTypeOutput
	ToReplicaSchedulingPreferenceTypeOutputWithContext(context.Context) ReplicaSchedulingPreferenceTypeOutput
}

type ReplicaSchedulingPreferenceTypeArgs struct {
	ApiVersion pulumi.StringPtrInput                   `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput                   `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput               `pulumi:"metadata"`
	Spec       ReplicaSchedulingPreferenceSpecPtrInput `pulumi:"spec"`
	Status     pulumi.MapInput                         `pulumi:"status"`
}

func (ReplicaSchedulingPreferenceTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicaSchedulingPreferenceType)(nil)).Elem()
}

func (i ReplicaSchedulingPreferenceTypeArgs) ToReplicaSchedulingPreferenceTypeOutput() ReplicaSchedulingPreferenceTypeOutput {
	return i.ToReplicaSchedulingPreferenceTypeOutputWithContext(context.Background())
}

func (i ReplicaSchedulingPreferenceTypeArgs) ToReplicaSchedulingPreferenceTypeOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplicaSchedulingPreferenceTypeOutput)
}

type ReplicaSchedulingPreferenceTypeOutput struct{ *pulumi.OutputState }

func (ReplicaSchedulingPreferenceTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicaSchedulingPreferenceType)(nil)).Elem()
}

func (o ReplicaSchedulingPreferenceTypeOutput) ToReplicaSchedulingPreferenceTypeOutput() ReplicaSchedulingPreferenceTypeOutput {
	return o
}

func (o ReplicaSchedulingPreferenceTypeOutput) ToReplicaSchedulingPreferenceTypeOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceTypeOutput {
	return o
}

func (o ReplicaSchedulingPreferenceTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ReplicaSchedulingPreferenceType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o ReplicaSchedulingPreferenceTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ReplicaSchedulingPreferenceType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o ReplicaSchedulingPreferenceTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v ReplicaSchedulingPreferenceType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

func (o ReplicaSchedulingPreferenceTypeOutput) Spec() ReplicaSchedulingPreferenceSpecPtrOutput {
	return o.ApplyT(func(v ReplicaSchedulingPreferenceType) *ReplicaSchedulingPreferenceSpec { return v.Spec }).(ReplicaSchedulingPreferenceSpecPtrOutput)
}

func (o ReplicaSchedulingPreferenceTypeOutput) Status() pulumi.MapOutput {
	return o.ApplyT(func(v ReplicaSchedulingPreferenceType) map[string]interface{} { return v.Status }).(pulumi.MapOutput)
}

type ReplicaSchedulingPreferenceMetadata struct {
}

// ReplicaSchedulingPreferenceMetadataInput is an input type that accepts ReplicaSchedulingPreferenceMetadataArgs and ReplicaSchedulingPreferenceMetadataOutput values.
// You can construct a concrete instance of `ReplicaSchedulingPreferenceMetadataInput` via:
//
//          ReplicaSchedulingPreferenceMetadataArgs{...}
type ReplicaSchedulingPreferenceMetadataInput interface {
	pulumi.Input

	ToReplicaSchedulingPreferenceMetadataOutput() ReplicaSchedulingPreferenceMetadataOutput
	ToReplicaSchedulingPreferenceMetadataOutputWithContext(context.Context) ReplicaSchedulingPreferenceMetadataOutput
}

type ReplicaSchedulingPreferenceMetadataArgs struct {
}

func (ReplicaSchedulingPreferenceMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicaSchedulingPreferenceMetadata)(nil)).Elem()
}

func (i ReplicaSchedulingPreferenceMetadataArgs) ToReplicaSchedulingPreferenceMetadataOutput() ReplicaSchedulingPreferenceMetadataOutput {
	return i.ToReplicaSchedulingPreferenceMetadataOutputWithContext(context.Background())
}

func (i ReplicaSchedulingPreferenceMetadataArgs) ToReplicaSchedulingPreferenceMetadataOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplicaSchedulingPreferenceMetadataOutput)
}

type ReplicaSchedulingPreferenceMetadataOutput struct{ *pulumi.OutputState }

func (ReplicaSchedulingPreferenceMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicaSchedulingPreferenceMetadata)(nil)).Elem()
}

func (o ReplicaSchedulingPreferenceMetadataOutput) ToReplicaSchedulingPreferenceMetadataOutput() ReplicaSchedulingPreferenceMetadataOutput {
	return o
}

func (o ReplicaSchedulingPreferenceMetadataOutput) ToReplicaSchedulingPreferenceMetadataOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceMetadataOutput {
	return o
}

type ReplicaSchedulingPreferenceSpec struct {
	// A mapping between cluster names and preferences regarding a local workload object (dep, rs, .. ) in these clusters. "*" (if provided) applies to all clusters if an explicit mapping is not provided. If omitted, clusters without explicit preferences should not have any replicas scheduled.
	Clusters map[string]interface{} `pulumi:"clusters"`
	// If set to true then already scheduled and running replicas may be moved to other clusters in order to match current state to the specified preferences. Otherwise, if set to false, up and running replicas will not be moved.
	Rebalance *bool `pulumi:"rebalance"`
	// TODO (@irfanurrehman); upgrade this to label selector only if need be. The idea of this API is to have a a set of preferences which can be used for a target FederatedDeployment or FederatedReplicaset. Although the set of preferences in question can be applied to multiple target objects using label selectors, but there are no clear advantages of doing that as of now. To keep the implementation and usage simple, matching ns/name of RSP resource to the target resource is sufficient and only additional information needed in RSP resource is a target kind (FederatedDeployment or FederatedReplicaset).
	TargetKind string `pulumi:"targetKind"`
	// Total number of pods desired across federated clusters. Replicas specified in the spec for target deployment template or replicaset template will be discarded/overridden when scheduling preferences are specified.
	TotalReplicas int `pulumi:"totalReplicas"`
}

// ReplicaSchedulingPreferenceSpecInput is an input type that accepts ReplicaSchedulingPreferenceSpecArgs and ReplicaSchedulingPreferenceSpecOutput values.
// You can construct a concrete instance of `ReplicaSchedulingPreferenceSpecInput` via:
//
//          ReplicaSchedulingPreferenceSpecArgs{...}
type ReplicaSchedulingPreferenceSpecInput interface {
	pulumi.Input

	ToReplicaSchedulingPreferenceSpecOutput() ReplicaSchedulingPreferenceSpecOutput
	ToReplicaSchedulingPreferenceSpecOutputWithContext(context.Context) ReplicaSchedulingPreferenceSpecOutput
}

type ReplicaSchedulingPreferenceSpecArgs struct {
	// A mapping between cluster names and preferences regarding a local workload object (dep, rs, .. ) in these clusters. "*" (if provided) applies to all clusters if an explicit mapping is not provided. If omitted, clusters without explicit preferences should not have any replicas scheduled.
	Clusters pulumi.MapInput `pulumi:"clusters"`
	// If set to true then already scheduled and running replicas may be moved to other clusters in order to match current state to the specified preferences. Otherwise, if set to false, up and running replicas will not be moved.
	Rebalance pulumi.BoolPtrInput `pulumi:"rebalance"`
	// TODO (@irfanurrehman); upgrade this to label selector only if need be. The idea of this API is to have a a set of preferences which can be used for a target FederatedDeployment or FederatedReplicaset. Although the set of preferences in question can be applied to multiple target objects using label selectors, but there are no clear advantages of doing that as of now. To keep the implementation and usage simple, matching ns/name of RSP resource to the target resource is sufficient and only additional information needed in RSP resource is a target kind (FederatedDeployment or FederatedReplicaset).
	TargetKind pulumi.StringInput `pulumi:"targetKind"`
	// Total number of pods desired across federated clusters. Replicas specified in the spec for target deployment template or replicaset template will be discarded/overridden when scheduling preferences are specified.
	TotalReplicas pulumi.IntInput `pulumi:"totalReplicas"`
}

func (ReplicaSchedulingPreferenceSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicaSchedulingPreferenceSpec)(nil)).Elem()
}

func (i ReplicaSchedulingPreferenceSpecArgs) ToReplicaSchedulingPreferenceSpecOutput() ReplicaSchedulingPreferenceSpecOutput {
	return i.ToReplicaSchedulingPreferenceSpecOutputWithContext(context.Background())
}

func (i ReplicaSchedulingPreferenceSpecArgs) ToReplicaSchedulingPreferenceSpecOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplicaSchedulingPreferenceSpecOutput)
}

func (i ReplicaSchedulingPreferenceSpecArgs) ToReplicaSchedulingPreferenceSpecPtrOutput() ReplicaSchedulingPreferenceSpecPtrOutput {
	return i.ToReplicaSchedulingPreferenceSpecPtrOutputWithContext(context.Background())
}

func (i ReplicaSchedulingPreferenceSpecArgs) ToReplicaSchedulingPreferenceSpecPtrOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplicaSchedulingPreferenceSpecOutput).ToReplicaSchedulingPreferenceSpecPtrOutputWithContext(ctx)
}

// ReplicaSchedulingPreferenceSpecPtrInput is an input type that accepts ReplicaSchedulingPreferenceSpecArgs, ReplicaSchedulingPreferenceSpecPtr and ReplicaSchedulingPreferenceSpecPtrOutput values.
// You can construct a concrete instance of `ReplicaSchedulingPreferenceSpecPtrInput` via:
//
//          ReplicaSchedulingPreferenceSpecArgs{...}
//
//  or:
//
//          nil
type ReplicaSchedulingPreferenceSpecPtrInput interface {
	pulumi.Input

	ToReplicaSchedulingPreferenceSpecPtrOutput() ReplicaSchedulingPreferenceSpecPtrOutput
	ToReplicaSchedulingPreferenceSpecPtrOutputWithContext(context.Context) ReplicaSchedulingPreferenceSpecPtrOutput
}

type replicaSchedulingPreferenceSpecPtrType ReplicaSchedulingPreferenceSpecArgs

func ReplicaSchedulingPreferenceSpecPtr(v *ReplicaSchedulingPreferenceSpecArgs) ReplicaSchedulingPreferenceSpecPtrInput {
	return (*replicaSchedulingPreferenceSpecPtrType)(v)
}

func (*replicaSchedulingPreferenceSpecPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ReplicaSchedulingPreferenceSpec)(nil)).Elem()
}

func (i *replicaSchedulingPreferenceSpecPtrType) ToReplicaSchedulingPreferenceSpecPtrOutput() ReplicaSchedulingPreferenceSpecPtrOutput {
	return i.ToReplicaSchedulingPreferenceSpecPtrOutputWithContext(context.Background())
}

func (i *replicaSchedulingPreferenceSpecPtrType) ToReplicaSchedulingPreferenceSpecPtrOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplicaSchedulingPreferenceSpecPtrOutput)
}

type ReplicaSchedulingPreferenceSpecOutput struct{ *pulumi.OutputState }

func (ReplicaSchedulingPreferenceSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicaSchedulingPreferenceSpec)(nil)).Elem()
}

func (o ReplicaSchedulingPreferenceSpecOutput) ToReplicaSchedulingPreferenceSpecOutput() ReplicaSchedulingPreferenceSpecOutput {
	return o
}

func (o ReplicaSchedulingPreferenceSpecOutput) ToReplicaSchedulingPreferenceSpecOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceSpecOutput {
	return o
}

func (o ReplicaSchedulingPreferenceSpecOutput) ToReplicaSchedulingPreferenceSpecPtrOutput() ReplicaSchedulingPreferenceSpecPtrOutput {
	return o.ToReplicaSchedulingPreferenceSpecPtrOutputWithContext(context.Background())
}

func (o ReplicaSchedulingPreferenceSpecOutput) ToReplicaSchedulingPreferenceSpecPtrOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceSpecPtrOutput {
	return o.ApplyT(func(v ReplicaSchedulingPreferenceSpec) *ReplicaSchedulingPreferenceSpec {
		return &v
	}).(ReplicaSchedulingPreferenceSpecPtrOutput)
}

// A mapping between cluster names and preferences regarding a local workload object (dep, rs, .. ) in these clusters. "*" (if provided) applies to all clusters if an explicit mapping is not provided. If omitted, clusters without explicit preferences should not have any replicas scheduled.
func (o ReplicaSchedulingPreferenceSpecOutput) Clusters() pulumi.MapOutput {
	return o.ApplyT(func(v ReplicaSchedulingPreferenceSpec) map[string]interface{} { return v.Clusters }).(pulumi.MapOutput)
}

// If set to true then already scheduled and running replicas may be moved to other clusters in order to match current state to the specified preferences. Otherwise, if set to false, up and running replicas will not be moved.
func (o ReplicaSchedulingPreferenceSpecOutput) Rebalance() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ReplicaSchedulingPreferenceSpec) *bool { return v.Rebalance }).(pulumi.BoolPtrOutput)
}

// TODO (@irfanurrehman); upgrade this to label selector only if need be. The idea of this API is to have a a set of preferences which can be used for a target FederatedDeployment or FederatedReplicaset. Although the set of preferences in question can be applied to multiple target objects using label selectors, but there are no clear advantages of doing that as of now. To keep the implementation and usage simple, matching ns/name of RSP resource to the target resource is sufficient and only additional information needed in RSP resource is a target kind (FederatedDeployment or FederatedReplicaset).
func (o ReplicaSchedulingPreferenceSpecOutput) TargetKind() pulumi.StringOutput {
	return o.ApplyT(func(v ReplicaSchedulingPreferenceSpec) string { return v.TargetKind }).(pulumi.StringOutput)
}

// Total number of pods desired across federated clusters. Replicas specified in the spec for target deployment template or replicaset template will be discarded/overridden when scheduling preferences are specified.
func (o ReplicaSchedulingPreferenceSpecOutput) TotalReplicas() pulumi.IntOutput {
	return o.ApplyT(func(v ReplicaSchedulingPreferenceSpec) int { return v.TotalReplicas }).(pulumi.IntOutput)
}

type ReplicaSchedulingPreferenceSpecPtrOutput struct{ *pulumi.OutputState }

func (ReplicaSchedulingPreferenceSpecPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ReplicaSchedulingPreferenceSpec)(nil)).Elem()
}

func (o ReplicaSchedulingPreferenceSpecPtrOutput) ToReplicaSchedulingPreferenceSpecPtrOutput() ReplicaSchedulingPreferenceSpecPtrOutput {
	return o
}

func (o ReplicaSchedulingPreferenceSpecPtrOutput) ToReplicaSchedulingPreferenceSpecPtrOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceSpecPtrOutput {
	return o
}

func (o ReplicaSchedulingPreferenceSpecPtrOutput) Elem() ReplicaSchedulingPreferenceSpecOutput {
	return o.ApplyT(func(v *ReplicaSchedulingPreferenceSpec) ReplicaSchedulingPreferenceSpec { return *v }).(ReplicaSchedulingPreferenceSpecOutput)
}

// A mapping between cluster names and preferences regarding a local workload object (dep, rs, .. ) in these clusters. "*" (if provided) applies to all clusters if an explicit mapping is not provided. If omitted, clusters without explicit preferences should not have any replicas scheduled.
func (o ReplicaSchedulingPreferenceSpecPtrOutput) Clusters() pulumi.MapOutput {
	return o.ApplyT(func(v *ReplicaSchedulingPreferenceSpec) map[string]interface{} {
		if v == nil {
			return nil
		}
		return v.Clusters
	}).(pulumi.MapOutput)
}

// If set to true then already scheduled and running replicas may be moved to other clusters in order to match current state to the specified preferences. Otherwise, if set to false, up and running replicas will not be moved.
func (o ReplicaSchedulingPreferenceSpecPtrOutput) Rebalance() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *ReplicaSchedulingPreferenceSpec) *bool {
		if v == nil {
			return nil
		}
		return v.Rebalance
	}).(pulumi.BoolPtrOutput)
}

// TODO (@irfanurrehman); upgrade this to label selector only if need be. The idea of this API is to have a a set of preferences which can be used for a target FederatedDeployment or FederatedReplicaset. Although the set of preferences in question can be applied to multiple target objects using label selectors, but there are no clear advantages of doing that as of now. To keep the implementation and usage simple, matching ns/name of RSP resource to the target resource is sufficient and only additional information needed in RSP resource is a target kind (FederatedDeployment or FederatedReplicaset).
func (o ReplicaSchedulingPreferenceSpecPtrOutput) TargetKind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReplicaSchedulingPreferenceSpec) *string {
		if v == nil {
			return nil
		}
		return &v.TargetKind
	}).(pulumi.StringPtrOutput)
}

// Total number of pods desired across federated clusters. Replicas specified in the spec for target deployment template or replicaset template will be discarded/overridden when scheduling preferences are specified.
func (o ReplicaSchedulingPreferenceSpecPtrOutput) TotalReplicas() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ReplicaSchedulingPreferenceSpec) *int {
		if v == nil {
			return nil
		}
		return &v.TotalReplicas
	}).(pulumi.IntPtrOutput)
}

// A mapping between cluster names and preferences regarding a local workload object (dep, rs, .. ) in these clusters. "*" (if provided) applies to all clusters if an explicit mapping is not provided. If omitted, clusters without explicit preferences should not have any replicas scheduled.
type ReplicaSchedulingPreferenceSpecClusters struct {
}

// ReplicaSchedulingPreferenceSpecClustersInput is an input type that accepts ReplicaSchedulingPreferenceSpecClustersArgs and ReplicaSchedulingPreferenceSpecClustersOutput values.
// You can construct a concrete instance of `ReplicaSchedulingPreferenceSpecClustersInput` via:
//
//          ReplicaSchedulingPreferenceSpecClustersArgs{...}
type ReplicaSchedulingPreferenceSpecClustersInput interface {
	pulumi.Input

	ToReplicaSchedulingPreferenceSpecClustersOutput() ReplicaSchedulingPreferenceSpecClustersOutput
	ToReplicaSchedulingPreferenceSpecClustersOutputWithContext(context.Context) ReplicaSchedulingPreferenceSpecClustersOutput
}

// A mapping between cluster names and preferences regarding a local workload object (dep, rs, .. ) in these clusters. "*" (if provided) applies to all clusters if an explicit mapping is not provided. If omitted, clusters without explicit preferences should not have any replicas scheduled.
type ReplicaSchedulingPreferenceSpecClustersArgs struct {
}

func (ReplicaSchedulingPreferenceSpecClustersArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicaSchedulingPreferenceSpecClusters)(nil)).Elem()
}

func (i ReplicaSchedulingPreferenceSpecClustersArgs) ToReplicaSchedulingPreferenceSpecClustersOutput() ReplicaSchedulingPreferenceSpecClustersOutput {
	return i.ToReplicaSchedulingPreferenceSpecClustersOutputWithContext(context.Background())
}

func (i ReplicaSchedulingPreferenceSpecClustersArgs) ToReplicaSchedulingPreferenceSpecClustersOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceSpecClustersOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplicaSchedulingPreferenceSpecClustersOutput)
}

// A mapping between cluster names and preferences regarding a local workload object (dep, rs, .. ) in these clusters. "*" (if provided) applies to all clusters if an explicit mapping is not provided. If omitted, clusters without explicit preferences should not have any replicas scheduled.
type ReplicaSchedulingPreferenceSpecClustersOutput struct{ *pulumi.OutputState }

func (ReplicaSchedulingPreferenceSpecClustersOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicaSchedulingPreferenceSpecClusters)(nil)).Elem()
}

func (o ReplicaSchedulingPreferenceSpecClustersOutput) ToReplicaSchedulingPreferenceSpecClustersOutput() ReplicaSchedulingPreferenceSpecClustersOutput {
	return o
}

func (o ReplicaSchedulingPreferenceSpecClustersOutput) ToReplicaSchedulingPreferenceSpecClustersOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceSpecClustersOutput {
	return o
}

type ReplicaSchedulingPreferenceStatus struct {
}

// ReplicaSchedulingPreferenceStatusInput is an input type that accepts ReplicaSchedulingPreferenceStatusArgs and ReplicaSchedulingPreferenceStatusOutput values.
// You can construct a concrete instance of `ReplicaSchedulingPreferenceStatusInput` via:
//
//          ReplicaSchedulingPreferenceStatusArgs{...}
type ReplicaSchedulingPreferenceStatusInput interface {
	pulumi.Input

	ToReplicaSchedulingPreferenceStatusOutput() ReplicaSchedulingPreferenceStatusOutput
	ToReplicaSchedulingPreferenceStatusOutputWithContext(context.Context) ReplicaSchedulingPreferenceStatusOutput
}

type ReplicaSchedulingPreferenceStatusArgs struct {
}

func (ReplicaSchedulingPreferenceStatusArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicaSchedulingPreferenceStatus)(nil)).Elem()
}

func (i ReplicaSchedulingPreferenceStatusArgs) ToReplicaSchedulingPreferenceStatusOutput() ReplicaSchedulingPreferenceStatusOutput {
	return i.ToReplicaSchedulingPreferenceStatusOutputWithContext(context.Background())
}

func (i ReplicaSchedulingPreferenceStatusArgs) ToReplicaSchedulingPreferenceStatusOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceStatusOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplicaSchedulingPreferenceStatusOutput)
}

type ReplicaSchedulingPreferenceStatusOutput struct{ *pulumi.OutputState }

func (ReplicaSchedulingPreferenceStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicaSchedulingPreferenceStatus)(nil)).Elem()
}

func (o ReplicaSchedulingPreferenceStatusOutput) ToReplicaSchedulingPreferenceStatusOutput() ReplicaSchedulingPreferenceStatusOutput {
	return o
}

func (o ReplicaSchedulingPreferenceStatusOutput) ToReplicaSchedulingPreferenceStatusOutputWithContext(ctx context.Context) ReplicaSchedulingPreferenceStatusOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ReplicaSchedulingPreferenceTypeOutput{})
	pulumi.RegisterOutputType(ReplicaSchedulingPreferenceMetadataOutput{})
	pulumi.RegisterOutputType(ReplicaSchedulingPreferenceSpecOutput{})
	pulumi.RegisterOutputType(ReplicaSchedulingPreferenceSpecPtrOutput{})
	pulumi.RegisterOutputType(ReplicaSchedulingPreferenceSpecClustersOutput{})
	pulumi.RegisterOutputType(ReplicaSchedulingPreferenceStatusOutput{})
}
