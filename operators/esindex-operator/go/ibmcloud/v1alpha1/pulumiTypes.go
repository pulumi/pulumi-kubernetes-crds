// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type EsIndexType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       *EsIndexSpec       `pulumi:"spec"`
	Status     *EsIndexStatus     `pulumi:"status"`
}

// EsIndexTypeInput is an input type that accepts EsIndexTypeArgs and EsIndexTypeOutput values.
// You can construct a concrete instance of `EsIndexTypeInput` via:
//
//          EsIndexTypeArgs{...}
type EsIndexTypeInput interface {
	pulumi.Input

	ToEsIndexTypeOutput() EsIndexTypeOutput
	ToEsIndexTypeOutputWithContext(context.Context) EsIndexTypeOutput
}

type EsIndexTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
	Spec       EsIndexSpecPtrInput       `pulumi:"spec"`
	Status     EsIndexStatusPtrInput     `pulumi:"status"`
}

func (EsIndexTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexType)(nil)).Elem()
}

func (i EsIndexTypeArgs) ToEsIndexTypeOutput() EsIndexTypeOutput {
	return i.ToEsIndexTypeOutputWithContext(context.Background())
}

func (i EsIndexTypeArgs) ToEsIndexTypeOutputWithContext(ctx context.Context) EsIndexTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexTypeOutput)
}

type EsIndexTypeOutput struct{ *pulumi.OutputState }

func (EsIndexTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexType)(nil)).Elem()
}

func (o EsIndexTypeOutput) ToEsIndexTypeOutput() EsIndexTypeOutput {
	return o
}

func (o EsIndexTypeOutput) ToEsIndexTypeOutputWithContext(ctx context.Context) EsIndexTypeOutput {
	return o
}

func (o EsIndexTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EsIndexType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o EsIndexTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EsIndexType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o EsIndexTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v EsIndexType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

func (o EsIndexTypeOutput) Spec() EsIndexSpecPtrOutput {
	return o.ApplyT(func(v EsIndexType) *EsIndexSpec { return v.Spec }).(EsIndexSpecPtrOutput)
}

func (o EsIndexTypeOutput) Status() EsIndexStatusPtrOutput {
	return o.ApplyT(func(v EsIndexType) *EsIndexStatus { return v.Status }).(EsIndexStatusPtrOutput)
}

type EsIndexMetadata struct {
}

// EsIndexMetadataInput is an input type that accepts EsIndexMetadataArgs and EsIndexMetadataOutput values.
// You can construct a concrete instance of `EsIndexMetadataInput` via:
//
//          EsIndexMetadataArgs{...}
type EsIndexMetadataInput interface {
	pulumi.Input

	ToEsIndexMetadataOutput() EsIndexMetadataOutput
	ToEsIndexMetadataOutputWithContext(context.Context) EsIndexMetadataOutput
}

type EsIndexMetadataArgs struct {
}

func (EsIndexMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexMetadata)(nil)).Elem()
}

func (i EsIndexMetadataArgs) ToEsIndexMetadataOutput() EsIndexMetadataOutput {
	return i.ToEsIndexMetadataOutputWithContext(context.Background())
}

func (i EsIndexMetadataArgs) ToEsIndexMetadataOutputWithContext(ctx context.Context) EsIndexMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexMetadataOutput)
}

type EsIndexMetadataOutput struct{ *pulumi.OutputState }

func (EsIndexMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexMetadata)(nil)).Elem()
}

func (o EsIndexMetadataOutput) ToEsIndexMetadataOutput() EsIndexMetadataOutput {
	return o
}

func (o EsIndexMetadataOutput) ToEsIndexMetadataOutputWithContext(ctx context.Context) EsIndexMetadataOutput {
	return o
}

type EsIndexSpec struct {
	// Bind to an existing index if true, default value false
	BindOnly *bool `pulumi:"bindOnly"`
	// Binding resource name that holds the secret for elastic search credentials
	BindingFrom *EsIndexSpecBindingFrom `pulumi:"bindingFrom"`
	// EsURIComposed is the URI of elasticesearch resource in the format https://<user>:<passwd>@hostname:port. Cannot be used if BindingFrom is not empty.
	EsURIComposed *EsIndexSpecEsURIComposed `pulumi:"esURIComposed"`
	// Name of Index to be created on elastic search
	IndexName string `pulumi:"indexName"`
	// Number of replicas, default value 1
	NumberOfReplicas *int `pulumi:"numberOfReplicas"`
	// Number of shards, default value 1
	NumberOfShards *int `pulumi:"numberOfShards"`
}

// EsIndexSpecInput is an input type that accepts EsIndexSpecArgs and EsIndexSpecOutput values.
// You can construct a concrete instance of `EsIndexSpecInput` via:
//
//          EsIndexSpecArgs{...}
type EsIndexSpecInput interface {
	pulumi.Input

	ToEsIndexSpecOutput() EsIndexSpecOutput
	ToEsIndexSpecOutputWithContext(context.Context) EsIndexSpecOutput
}

type EsIndexSpecArgs struct {
	// Bind to an existing index if true, default value false
	BindOnly pulumi.BoolPtrInput `pulumi:"bindOnly"`
	// Binding resource name that holds the secret for elastic search credentials
	BindingFrom EsIndexSpecBindingFromPtrInput `pulumi:"bindingFrom"`
	// EsURIComposed is the URI of elasticesearch resource in the format https://<user>:<passwd>@hostname:port. Cannot be used if BindingFrom is not empty.
	EsURIComposed EsIndexSpecEsURIComposedPtrInput `pulumi:"esURIComposed"`
	// Name of Index to be created on elastic search
	IndexName pulumi.StringInput `pulumi:"indexName"`
	// Number of replicas, default value 1
	NumberOfReplicas pulumi.IntPtrInput `pulumi:"numberOfReplicas"`
	// Number of shards, default value 1
	NumberOfShards pulumi.IntPtrInput `pulumi:"numberOfShards"`
}

func (EsIndexSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexSpec)(nil)).Elem()
}

func (i EsIndexSpecArgs) ToEsIndexSpecOutput() EsIndexSpecOutput {
	return i.ToEsIndexSpecOutputWithContext(context.Background())
}

func (i EsIndexSpecArgs) ToEsIndexSpecOutputWithContext(ctx context.Context) EsIndexSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexSpecOutput)
}

func (i EsIndexSpecArgs) ToEsIndexSpecPtrOutput() EsIndexSpecPtrOutput {
	return i.ToEsIndexSpecPtrOutputWithContext(context.Background())
}

func (i EsIndexSpecArgs) ToEsIndexSpecPtrOutputWithContext(ctx context.Context) EsIndexSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexSpecOutput).ToEsIndexSpecPtrOutputWithContext(ctx)
}

// EsIndexSpecPtrInput is an input type that accepts EsIndexSpecArgs, EsIndexSpecPtr and EsIndexSpecPtrOutput values.
// You can construct a concrete instance of `EsIndexSpecPtrInput` via:
//
//          EsIndexSpecArgs{...}
//
//  or:
//
//          nil
type EsIndexSpecPtrInput interface {
	pulumi.Input

	ToEsIndexSpecPtrOutput() EsIndexSpecPtrOutput
	ToEsIndexSpecPtrOutputWithContext(context.Context) EsIndexSpecPtrOutput
}

type esIndexSpecPtrType EsIndexSpecArgs

func EsIndexSpecPtr(v *EsIndexSpecArgs) EsIndexSpecPtrInput {
	return (*esIndexSpecPtrType)(v)
}

func (*esIndexSpecPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**EsIndexSpec)(nil)).Elem()
}

func (i *esIndexSpecPtrType) ToEsIndexSpecPtrOutput() EsIndexSpecPtrOutput {
	return i.ToEsIndexSpecPtrOutputWithContext(context.Background())
}

func (i *esIndexSpecPtrType) ToEsIndexSpecPtrOutputWithContext(ctx context.Context) EsIndexSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexSpecPtrOutput)
}

type EsIndexSpecOutput struct{ *pulumi.OutputState }

func (EsIndexSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexSpec)(nil)).Elem()
}

func (o EsIndexSpecOutput) ToEsIndexSpecOutput() EsIndexSpecOutput {
	return o
}

func (o EsIndexSpecOutput) ToEsIndexSpecOutputWithContext(ctx context.Context) EsIndexSpecOutput {
	return o
}

func (o EsIndexSpecOutput) ToEsIndexSpecPtrOutput() EsIndexSpecPtrOutput {
	return o.ToEsIndexSpecPtrOutputWithContext(context.Background())
}

func (o EsIndexSpecOutput) ToEsIndexSpecPtrOutputWithContext(ctx context.Context) EsIndexSpecPtrOutput {
	return o.ApplyT(func(v EsIndexSpec) *EsIndexSpec {
		return &v
	}).(EsIndexSpecPtrOutput)
}

// Bind to an existing index if true, default value false
func (o EsIndexSpecOutput) BindOnly() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v EsIndexSpec) *bool { return v.BindOnly }).(pulumi.BoolPtrOutput)
}

// Binding resource name that holds the secret for elastic search credentials
func (o EsIndexSpecOutput) BindingFrom() EsIndexSpecBindingFromPtrOutput {
	return o.ApplyT(func(v EsIndexSpec) *EsIndexSpecBindingFrom { return v.BindingFrom }).(EsIndexSpecBindingFromPtrOutput)
}

// EsURIComposed is the URI of elasticesearch resource in the format https://<user>:<passwd>@hostname:port. Cannot be used if BindingFrom is not empty.
func (o EsIndexSpecOutput) EsURIComposed() EsIndexSpecEsURIComposedPtrOutput {
	return o.ApplyT(func(v EsIndexSpec) *EsIndexSpecEsURIComposed { return v.EsURIComposed }).(EsIndexSpecEsURIComposedPtrOutput)
}

// Name of Index to be created on elastic search
func (o EsIndexSpecOutput) IndexName() pulumi.StringOutput {
	return o.ApplyT(func(v EsIndexSpec) string { return v.IndexName }).(pulumi.StringOutput)
}

// Number of replicas, default value 1
func (o EsIndexSpecOutput) NumberOfReplicas() pulumi.IntPtrOutput {
	return o.ApplyT(func(v EsIndexSpec) *int { return v.NumberOfReplicas }).(pulumi.IntPtrOutput)
}

// Number of shards, default value 1
func (o EsIndexSpecOutput) NumberOfShards() pulumi.IntPtrOutput {
	return o.ApplyT(func(v EsIndexSpec) *int { return v.NumberOfShards }).(pulumi.IntPtrOutput)
}

type EsIndexSpecPtrOutput struct{ *pulumi.OutputState }

func (EsIndexSpecPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**EsIndexSpec)(nil)).Elem()
}

func (o EsIndexSpecPtrOutput) ToEsIndexSpecPtrOutput() EsIndexSpecPtrOutput {
	return o
}

func (o EsIndexSpecPtrOutput) ToEsIndexSpecPtrOutputWithContext(ctx context.Context) EsIndexSpecPtrOutput {
	return o
}

func (o EsIndexSpecPtrOutput) Elem() EsIndexSpecOutput {
	return o.ApplyT(func(v *EsIndexSpec) EsIndexSpec { return *v }).(EsIndexSpecOutput)
}

// Bind to an existing index if true, default value false
func (o EsIndexSpecPtrOutput) BindOnly() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *EsIndexSpec) *bool {
		if v == nil {
			return nil
		}
		return v.BindOnly
	}).(pulumi.BoolPtrOutput)
}

// Binding resource name that holds the secret for elastic search credentials
func (o EsIndexSpecPtrOutput) BindingFrom() EsIndexSpecBindingFromPtrOutput {
	return o.ApplyT(func(v *EsIndexSpec) *EsIndexSpecBindingFrom {
		if v == nil {
			return nil
		}
		return v.BindingFrom
	}).(EsIndexSpecBindingFromPtrOutput)
}

// EsURIComposed is the URI of elasticesearch resource in the format https://<user>:<passwd>@hostname:port. Cannot be used if BindingFrom is not empty.
func (o EsIndexSpecPtrOutput) EsURIComposed() EsIndexSpecEsURIComposedPtrOutput {
	return o.ApplyT(func(v *EsIndexSpec) *EsIndexSpecEsURIComposed {
		if v == nil {
			return nil
		}
		return v.EsURIComposed
	}).(EsIndexSpecEsURIComposedPtrOutput)
}

// Name of Index to be created on elastic search
func (o EsIndexSpecPtrOutput) IndexName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *EsIndexSpec) *string {
		if v == nil {
			return nil
		}
		return &v.IndexName
	}).(pulumi.StringPtrOutput)
}

// Number of replicas, default value 1
func (o EsIndexSpecPtrOutput) NumberOfReplicas() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *EsIndexSpec) *int {
		if v == nil {
			return nil
		}
		return v.NumberOfReplicas
	}).(pulumi.IntPtrOutput)
}

// Number of shards, default value 1
func (o EsIndexSpecPtrOutput) NumberOfShards() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *EsIndexSpec) *int {
		if v == nil {
			return nil
		}
		return v.NumberOfShards
	}).(pulumi.IntPtrOutput)
}

// Binding resource name that holds the secret for elastic search credentials
type EsIndexSpecBindingFrom struct {
	// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
	Name *string `pulumi:"name"`
}

// EsIndexSpecBindingFromInput is an input type that accepts EsIndexSpecBindingFromArgs and EsIndexSpecBindingFromOutput values.
// You can construct a concrete instance of `EsIndexSpecBindingFromInput` via:
//
//          EsIndexSpecBindingFromArgs{...}
type EsIndexSpecBindingFromInput interface {
	pulumi.Input

	ToEsIndexSpecBindingFromOutput() EsIndexSpecBindingFromOutput
	ToEsIndexSpecBindingFromOutputWithContext(context.Context) EsIndexSpecBindingFromOutput
}

// Binding resource name that holds the secret for elastic search credentials
type EsIndexSpecBindingFromArgs struct {
	// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (EsIndexSpecBindingFromArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexSpecBindingFrom)(nil)).Elem()
}

func (i EsIndexSpecBindingFromArgs) ToEsIndexSpecBindingFromOutput() EsIndexSpecBindingFromOutput {
	return i.ToEsIndexSpecBindingFromOutputWithContext(context.Background())
}

func (i EsIndexSpecBindingFromArgs) ToEsIndexSpecBindingFromOutputWithContext(ctx context.Context) EsIndexSpecBindingFromOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexSpecBindingFromOutput)
}

func (i EsIndexSpecBindingFromArgs) ToEsIndexSpecBindingFromPtrOutput() EsIndexSpecBindingFromPtrOutput {
	return i.ToEsIndexSpecBindingFromPtrOutputWithContext(context.Background())
}

func (i EsIndexSpecBindingFromArgs) ToEsIndexSpecBindingFromPtrOutputWithContext(ctx context.Context) EsIndexSpecBindingFromPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexSpecBindingFromOutput).ToEsIndexSpecBindingFromPtrOutputWithContext(ctx)
}

// EsIndexSpecBindingFromPtrInput is an input type that accepts EsIndexSpecBindingFromArgs, EsIndexSpecBindingFromPtr and EsIndexSpecBindingFromPtrOutput values.
// You can construct a concrete instance of `EsIndexSpecBindingFromPtrInput` via:
//
//          EsIndexSpecBindingFromArgs{...}
//
//  or:
//
//          nil
type EsIndexSpecBindingFromPtrInput interface {
	pulumi.Input

	ToEsIndexSpecBindingFromPtrOutput() EsIndexSpecBindingFromPtrOutput
	ToEsIndexSpecBindingFromPtrOutputWithContext(context.Context) EsIndexSpecBindingFromPtrOutput
}

type esIndexSpecBindingFromPtrType EsIndexSpecBindingFromArgs

func EsIndexSpecBindingFromPtr(v *EsIndexSpecBindingFromArgs) EsIndexSpecBindingFromPtrInput {
	return (*esIndexSpecBindingFromPtrType)(v)
}

func (*esIndexSpecBindingFromPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**EsIndexSpecBindingFrom)(nil)).Elem()
}

func (i *esIndexSpecBindingFromPtrType) ToEsIndexSpecBindingFromPtrOutput() EsIndexSpecBindingFromPtrOutput {
	return i.ToEsIndexSpecBindingFromPtrOutputWithContext(context.Background())
}

func (i *esIndexSpecBindingFromPtrType) ToEsIndexSpecBindingFromPtrOutputWithContext(ctx context.Context) EsIndexSpecBindingFromPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexSpecBindingFromPtrOutput)
}

// Binding resource name that holds the secret for elastic search credentials
type EsIndexSpecBindingFromOutput struct{ *pulumi.OutputState }

func (EsIndexSpecBindingFromOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexSpecBindingFrom)(nil)).Elem()
}

func (o EsIndexSpecBindingFromOutput) ToEsIndexSpecBindingFromOutput() EsIndexSpecBindingFromOutput {
	return o
}

func (o EsIndexSpecBindingFromOutput) ToEsIndexSpecBindingFromOutputWithContext(ctx context.Context) EsIndexSpecBindingFromOutput {
	return o
}

func (o EsIndexSpecBindingFromOutput) ToEsIndexSpecBindingFromPtrOutput() EsIndexSpecBindingFromPtrOutput {
	return o.ToEsIndexSpecBindingFromPtrOutputWithContext(context.Background())
}

func (o EsIndexSpecBindingFromOutput) ToEsIndexSpecBindingFromPtrOutputWithContext(ctx context.Context) EsIndexSpecBindingFromPtrOutput {
	return o.ApplyT(func(v EsIndexSpecBindingFrom) *EsIndexSpecBindingFrom {
		return &v
	}).(EsIndexSpecBindingFromPtrOutput)
}

// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
func (o EsIndexSpecBindingFromOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EsIndexSpecBindingFrom) *string { return v.Name }).(pulumi.StringPtrOutput)
}

type EsIndexSpecBindingFromPtrOutput struct{ *pulumi.OutputState }

func (EsIndexSpecBindingFromPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**EsIndexSpecBindingFrom)(nil)).Elem()
}

func (o EsIndexSpecBindingFromPtrOutput) ToEsIndexSpecBindingFromPtrOutput() EsIndexSpecBindingFromPtrOutput {
	return o
}

func (o EsIndexSpecBindingFromPtrOutput) ToEsIndexSpecBindingFromPtrOutputWithContext(ctx context.Context) EsIndexSpecBindingFromPtrOutput {
	return o
}

func (o EsIndexSpecBindingFromPtrOutput) Elem() EsIndexSpecBindingFromOutput {
	return o.ApplyT(func(v *EsIndexSpecBindingFrom) EsIndexSpecBindingFrom { return *v }).(EsIndexSpecBindingFromOutput)
}

// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
func (o EsIndexSpecBindingFromPtrOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *EsIndexSpecBindingFrom) *string {
		if v == nil {
			return nil
		}
		return v.Name
	}).(pulumi.StringPtrOutput)
}

// EsURIComposed is the URI of elasticesearch resource in the format https://<user>:<passwd>@hostname:port. Cannot be used if BindingFrom is not empty.
type EsIndexSpecEsURIComposed struct {
	// Selects a key of a ConfigMap in the local namespace.
	ConfigMapKeyRef map[string]interface{} `pulumi:"configMapKeyRef"`
	// Selects a key of a secret in the local namespace
	SecretKeyRef map[string]interface{} `pulumi:"secretKeyRef"`
}

// EsIndexSpecEsURIComposedInput is an input type that accepts EsIndexSpecEsURIComposedArgs and EsIndexSpecEsURIComposedOutput values.
// You can construct a concrete instance of `EsIndexSpecEsURIComposedInput` via:
//
//          EsIndexSpecEsURIComposedArgs{...}
type EsIndexSpecEsURIComposedInput interface {
	pulumi.Input

	ToEsIndexSpecEsURIComposedOutput() EsIndexSpecEsURIComposedOutput
	ToEsIndexSpecEsURIComposedOutputWithContext(context.Context) EsIndexSpecEsURIComposedOutput
}

// EsURIComposed is the URI of elasticesearch resource in the format https://<user>:<passwd>@hostname:port. Cannot be used if BindingFrom is not empty.
type EsIndexSpecEsURIComposedArgs struct {
	// Selects a key of a ConfigMap in the local namespace.
	ConfigMapKeyRef pulumi.MapInput `pulumi:"configMapKeyRef"`
	// Selects a key of a secret in the local namespace
	SecretKeyRef pulumi.MapInput `pulumi:"secretKeyRef"`
}

func (EsIndexSpecEsURIComposedArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexSpecEsURIComposed)(nil)).Elem()
}

func (i EsIndexSpecEsURIComposedArgs) ToEsIndexSpecEsURIComposedOutput() EsIndexSpecEsURIComposedOutput {
	return i.ToEsIndexSpecEsURIComposedOutputWithContext(context.Background())
}

func (i EsIndexSpecEsURIComposedArgs) ToEsIndexSpecEsURIComposedOutputWithContext(ctx context.Context) EsIndexSpecEsURIComposedOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexSpecEsURIComposedOutput)
}

func (i EsIndexSpecEsURIComposedArgs) ToEsIndexSpecEsURIComposedPtrOutput() EsIndexSpecEsURIComposedPtrOutput {
	return i.ToEsIndexSpecEsURIComposedPtrOutputWithContext(context.Background())
}

func (i EsIndexSpecEsURIComposedArgs) ToEsIndexSpecEsURIComposedPtrOutputWithContext(ctx context.Context) EsIndexSpecEsURIComposedPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexSpecEsURIComposedOutput).ToEsIndexSpecEsURIComposedPtrOutputWithContext(ctx)
}

// EsIndexSpecEsURIComposedPtrInput is an input type that accepts EsIndexSpecEsURIComposedArgs, EsIndexSpecEsURIComposedPtr and EsIndexSpecEsURIComposedPtrOutput values.
// You can construct a concrete instance of `EsIndexSpecEsURIComposedPtrInput` via:
//
//          EsIndexSpecEsURIComposedArgs{...}
//
//  or:
//
//          nil
type EsIndexSpecEsURIComposedPtrInput interface {
	pulumi.Input

	ToEsIndexSpecEsURIComposedPtrOutput() EsIndexSpecEsURIComposedPtrOutput
	ToEsIndexSpecEsURIComposedPtrOutputWithContext(context.Context) EsIndexSpecEsURIComposedPtrOutput
}

type esIndexSpecEsURIComposedPtrType EsIndexSpecEsURIComposedArgs

func EsIndexSpecEsURIComposedPtr(v *EsIndexSpecEsURIComposedArgs) EsIndexSpecEsURIComposedPtrInput {
	return (*esIndexSpecEsURIComposedPtrType)(v)
}

func (*esIndexSpecEsURIComposedPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**EsIndexSpecEsURIComposed)(nil)).Elem()
}

func (i *esIndexSpecEsURIComposedPtrType) ToEsIndexSpecEsURIComposedPtrOutput() EsIndexSpecEsURIComposedPtrOutput {
	return i.ToEsIndexSpecEsURIComposedPtrOutputWithContext(context.Background())
}

func (i *esIndexSpecEsURIComposedPtrType) ToEsIndexSpecEsURIComposedPtrOutputWithContext(ctx context.Context) EsIndexSpecEsURIComposedPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexSpecEsURIComposedPtrOutput)
}

// EsURIComposed is the URI of elasticesearch resource in the format https://<user>:<passwd>@hostname:port. Cannot be used if BindingFrom is not empty.
type EsIndexSpecEsURIComposedOutput struct{ *pulumi.OutputState }

func (EsIndexSpecEsURIComposedOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexSpecEsURIComposed)(nil)).Elem()
}

func (o EsIndexSpecEsURIComposedOutput) ToEsIndexSpecEsURIComposedOutput() EsIndexSpecEsURIComposedOutput {
	return o
}

func (o EsIndexSpecEsURIComposedOutput) ToEsIndexSpecEsURIComposedOutputWithContext(ctx context.Context) EsIndexSpecEsURIComposedOutput {
	return o
}

func (o EsIndexSpecEsURIComposedOutput) ToEsIndexSpecEsURIComposedPtrOutput() EsIndexSpecEsURIComposedPtrOutput {
	return o.ToEsIndexSpecEsURIComposedPtrOutputWithContext(context.Background())
}

func (o EsIndexSpecEsURIComposedOutput) ToEsIndexSpecEsURIComposedPtrOutputWithContext(ctx context.Context) EsIndexSpecEsURIComposedPtrOutput {
	return o.ApplyT(func(v EsIndexSpecEsURIComposed) *EsIndexSpecEsURIComposed {
		return &v
	}).(EsIndexSpecEsURIComposedPtrOutput)
}

// Selects a key of a ConfigMap in the local namespace.
func (o EsIndexSpecEsURIComposedOutput) ConfigMapKeyRef() pulumi.MapOutput {
	return o.ApplyT(func(v EsIndexSpecEsURIComposed) map[string]interface{} { return v.ConfigMapKeyRef }).(pulumi.MapOutput)
}

// Selects a key of a secret in the local namespace
func (o EsIndexSpecEsURIComposedOutput) SecretKeyRef() pulumi.MapOutput {
	return o.ApplyT(func(v EsIndexSpecEsURIComposed) map[string]interface{} { return v.SecretKeyRef }).(pulumi.MapOutput)
}

type EsIndexSpecEsURIComposedPtrOutput struct{ *pulumi.OutputState }

func (EsIndexSpecEsURIComposedPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**EsIndexSpecEsURIComposed)(nil)).Elem()
}

func (o EsIndexSpecEsURIComposedPtrOutput) ToEsIndexSpecEsURIComposedPtrOutput() EsIndexSpecEsURIComposedPtrOutput {
	return o
}

func (o EsIndexSpecEsURIComposedPtrOutput) ToEsIndexSpecEsURIComposedPtrOutputWithContext(ctx context.Context) EsIndexSpecEsURIComposedPtrOutput {
	return o
}

func (o EsIndexSpecEsURIComposedPtrOutput) Elem() EsIndexSpecEsURIComposedOutput {
	return o.ApplyT(func(v *EsIndexSpecEsURIComposed) EsIndexSpecEsURIComposed { return *v }).(EsIndexSpecEsURIComposedOutput)
}

// Selects a key of a ConfigMap in the local namespace.
func (o EsIndexSpecEsURIComposedPtrOutput) ConfigMapKeyRef() pulumi.MapOutput {
	return o.ApplyT(func(v *EsIndexSpecEsURIComposed) map[string]interface{} {
		if v == nil {
			return nil
		}
		return v.ConfigMapKeyRef
	}).(pulumi.MapOutput)
}

// Selects a key of a secret in the local namespace
func (o EsIndexSpecEsURIComposedPtrOutput) SecretKeyRef() pulumi.MapOutput {
	return o.ApplyT(func(v *EsIndexSpecEsURIComposed) map[string]interface{} {
		if v == nil {
			return nil
		}
		return v.SecretKeyRef
	}).(pulumi.MapOutput)
}

// Selects a key of a ConfigMap in the local namespace.
type EsIndexSpecEsURIComposedConfigMapKeyRef struct {
}

// EsIndexSpecEsURIComposedConfigMapKeyRefInput is an input type that accepts EsIndexSpecEsURIComposedConfigMapKeyRefArgs and EsIndexSpecEsURIComposedConfigMapKeyRefOutput values.
// You can construct a concrete instance of `EsIndexSpecEsURIComposedConfigMapKeyRefInput` via:
//
//          EsIndexSpecEsURIComposedConfigMapKeyRefArgs{...}
type EsIndexSpecEsURIComposedConfigMapKeyRefInput interface {
	pulumi.Input

	ToEsIndexSpecEsURIComposedConfigMapKeyRefOutput() EsIndexSpecEsURIComposedConfigMapKeyRefOutput
	ToEsIndexSpecEsURIComposedConfigMapKeyRefOutputWithContext(context.Context) EsIndexSpecEsURIComposedConfigMapKeyRefOutput
}

// Selects a key of a ConfigMap in the local namespace.
type EsIndexSpecEsURIComposedConfigMapKeyRefArgs struct {
}

func (EsIndexSpecEsURIComposedConfigMapKeyRefArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexSpecEsURIComposedConfigMapKeyRef)(nil)).Elem()
}

func (i EsIndexSpecEsURIComposedConfigMapKeyRefArgs) ToEsIndexSpecEsURIComposedConfigMapKeyRefOutput() EsIndexSpecEsURIComposedConfigMapKeyRefOutput {
	return i.ToEsIndexSpecEsURIComposedConfigMapKeyRefOutputWithContext(context.Background())
}

func (i EsIndexSpecEsURIComposedConfigMapKeyRefArgs) ToEsIndexSpecEsURIComposedConfigMapKeyRefOutputWithContext(ctx context.Context) EsIndexSpecEsURIComposedConfigMapKeyRefOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexSpecEsURIComposedConfigMapKeyRefOutput)
}

// Selects a key of a ConfigMap in the local namespace.
type EsIndexSpecEsURIComposedConfigMapKeyRefOutput struct{ *pulumi.OutputState }

func (EsIndexSpecEsURIComposedConfigMapKeyRefOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexSpecEsURIComposedConfigMapKeyRef)(nil)).Elem()
}

func (o EsIndexSpecEsURIComposedConfigMapKeyRefOutput) ToEsIndexSpecEsURIComposedConfigMapKeyRefOutput() EsIndexSpecEsURIComposedConfigMapKeyRefOutput {
	return o
}

func (o EsIndexSpecEsURIComposedConfigMapKeyRefOutput) ToEsIndexSpecEsURIComposedConfigMapKeyRefOutputWithContext(ctx context.Context) EsIndexSpecEsURIComposedConfigMapKeyRefOutput {
	return o
}

// Selects a key of a secret in the local namespace
type EsIndexSpecEsURIComposedSecretKeyRef struct {
}

// EsIndexSpecEsURIComposedSecretKeyRefInput is an input type that accepts EsIndexSpecEsURIComposedSecretKeyRefArgs and EsIndexSpecEsURIComposedSecretKeyRefOutput values.
// You can construct a concrete instance of `EsIndexSpecEsURIComposedSecretKeyRefInput` via:
//
//          EsIndexSpecEsURIComposedSecretKeyRefArgs{...}
type EsIndexSpecEsURIComposedSecretKeyRefInput interface {
	pulumi.Input

	ToEsIndexSpecEsURIComposedSecretKeyRefOutput() EsIndexSpecEsURIComposedSecretKeyRefOutput
	ToEsIndexSpecEsURIComposedSecretKeyRefOutputWithContext(context.Context) EsIndexSpecEsURIComposedSecretKeyRefOutput
}

// Selects a key of a secret in the local namespace
type EsIndexSpecEsURIComposedSecretKeyRefArgs struct {
}

func (EsIndexSpecEsURIComposedSecretKeyRefArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexSpecEsURIComposedSecretKeyRef)(nil)).Elem()
}

func (i EsIndexSpecEsURIComposedSecretKeyRefArgs) ToEsIndexSpecEsURIComposedSecretKeyRefOutput() EsIndexSpecEsURIComposedSecretKeyRefOutput {
	return i.ToEsIndexSpecEsURIComposedSecretKeyRefOutputWithContext(context.Background())
}

func (i EsIndexSpecEsURIComposedSecretKeyRefArgs) ToEsIndexSpecEsURIComposedSecretKeyRefOutputWithContext(ctx context.Context) EsIndexSpecEsURIComposedSecretKeyRefOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexSpecEsURIComposedSecretKeyRefOutput)
}

// Selects a key of a secret in the local namespace
type EsIndexSpecEsURIComposedSecretKeyRefOutput struct{ *pulumi.OutputState }

func (EsIndexSpecEsURIComposedSecretKeyRefOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexSpecEsURIComposedSecretKeyRef)(nil)).Elem()
}

func (o EsIndexSpecEsURIComposedSecretKeyRefOutput) ToEsIndexSpecEsURIComposedSecretKeyRefOutput() EsIndexSpecEsURIComposedSecretKeyRefOutput {
	return o
}

func (o EsIndexSpecEsURIComposedSecretKeyRefOutput) ToEsIndexSpecEsURIComposedSecretKeyRefOutputWithContext(ctx context.Context) EsIndexSpecEsURIComposedSecretKeyRefOutput {
	return o
}

type EsIndexStatus struct {
	// Generation of the implemented spec
	Generation int `pulumi:"generation"`
	// Message
	Message *string `pulumi:"message"`
	// State of the resource instance
	State *string `pulumi:"state"`
}

// EsIndexStatusInput is an input type that accepts EsIndexStatusArgs and EsIndexStatusOutput values.
// You can construct a concrete instance of `EsIndexStatusInput` via:
//
//          EsIndexStatusArgs{...}
type EsIndexStatusInput interface {
	pulumi.Input

	ToEsIndexStatusOutput() EsIndexStatusOutput
	ToEsIndexStatusOutputWithContext(context.Context) EsIndexStatusOutput
}

type EsIndexStatusArgs struct {
	// Generation of the implemented spec
	Generation pulumi.IntInput `pulumi:"generation"`
	// Message
	Message pulumi.StringPtrInput `pulumi:"message"`
	// State of the resource instance
	State pulumi.StringPtrInput `pulumi:"state"`
}

func (EsIndexStatusArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexStatus)(nil)).Elem()
}

func (i EsIndexStatusArgs) ToEsIndexStatusOutput() EsIndexStatusOutput {
	return i.ToEsIndexStatusOutputWithContext(context.Background())
}

func (i EsIndexStatusArgs) ToEsIndexStatusOutputWithContext(ctx context.Context) EsIndexStatusOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexStatusOutput)
}

func (i EsIndexStatusArgs) ToEsIndexStatusPtrOutput() EsIndexStatusPtrOutput {
	return i.ToEsIndexStatusPtrOutputWithContext(context.Background())
}

func (i EsIndexStatusArgs) ToEsIndexStatusPtrOutputWithContext(ctx context.Context) EsIndexStatusPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexStatusOutput).ToEsIndexStatusPtrOutputWithContext(ctx)
}

// EsIndexStatusPtrInput is an input type that accepts EsIndexStatusArgs, EsIndexStatusPtr and EsIndexStatusPtrOutput values.
// You can construct a concrete instance of `EsIndexStatusPtrInput` via:
//
//          EsIndexStatusArgs{...}
//
//  or:
//
//          nil
type EsIndexStatusPtrInput interface {
	pulumi.Input

	ToEsIndexStatusPtrOutput() EsIndexStatusPtrOutput
	ToEsIndexStatusPtrOutputWithContext(context.Context) EsIndexStatusPtrOutput
}

type esIndexStatusPtrType EsIndexStatusArgs

func EsIndexStatusPtr(v *EsIndexStatusArgs) EsIndexStatusPtrInput {
	return (*esIndexStatusPtrType)(v)
}

func (*esIndexStatusPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**EsIndexStatus)(nil)).Elem()
}

func (i *esIndexStatusPtrType) ToEsIndexStatusPtrOutput() EsIndexStatusPtrOutput {
	return i.ToEsIndexStatusPtrOutputWithContext(context.Background())
}

func (i *esIndexStatusPtrType) ToEsIndexStatusPtrOutputWithContext(ctx context.Context) EsIndexStatusPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EsIndexStatusPtrOutput)
}

type EsIndexStatusOutput struct{ *pulumi.OutputState }

func (EsIndexStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EsIndexStatus)(nil)).Elem()
}

func (o EsIndexStatusOutput) ToEsIndexStatusOutput() EsIndexStatusOutput {
	return o
}

func (o EsIndexStatusOutput) ToEsIndexStatusOutputWithContext(ctx context.Context) EsIndexStatusOutput {
	return o
}

func (o EsIndexStatusOutput) ToEsIndexStatusPtrOutput() EsIndexStatusPtrOutput {
	return o.ToEsIndexStatusPtrOutputWithContext(context.Background())
}

func (o EsIndexStatusOutput) ToEsIndexStatusPtrOutputWithContext(ctx context.Context) EsIndexStatusPtrOutput {
	return o.ApplyT(func(v EsIndexStatus) *EsIndexStatus {
		return &v
	}).(EsIndexStatusPtrOutput)
}

// Generation of the implemented spec
func (o EsIndexStatusOutput) Generation() pulumi.IntOutput {
	return o.ApplyT(func(v EsIndexStatus) int { return v.Generation }).(pulumi.IntOutput)
}

// Message
func (o EsIndexStatusOutput) Message() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EsIndexStatus) *string { return v.Message }).(pulumi.StringPtrOutput)
}

// State of the resource instance
func (o EsIndexStatusOutput) State() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EsIndexStatus) *string { return v.State }).(pulumi.StringPtrOutput)
}

type EsIndexStatusPtrOutput struct{ *pulumi.OutputState }

func (EsIndexStatusPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**EsIndexStatus)(nil)).Elem()
}

func (o EsIndexStatusPtrOutput) ToEsIndexStatusPtrOutput() EsIndexStatusPtrOutput {
	return o
}

func (o EsIndexStatusPtrOutput) ToEsIndexStatusPtrOutputWithContext(ctx context.Context) EsIndexStatusPtrOutput {
	return o
}

func (o EsIndexStatusPtrOutput) Elem() EsIndexStatusOutput {
	return o.ApplyT(func(v *EsIndexStatus) EsIndexStatus { return *v }).(EsIndexStatusOutput)
}

// Generation of the implemented spec
func (o EsIndexStatusPtrOutput) Generation() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *EsIndexStatus) *int {
		if v == nil {
			return nil
		}
		return &v.Generation
	}).(pulumi.IntPtrOutput)
}

// Message
func (o EsIndexStatusPtrOutput) Message() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *EsIndexStatus) *string {
		if v == nil {
			return nil
		}
		return v.Message
	}).(pulumi.StringPtrOutput)
}

// State of the resource instance
func (o EsIndexStatusPtrOutput) State() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *EsIndexStatus) *string {
		if v == nil {
			return nil
		}
		return v.State
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(EsIndexTypeOutput{})
	pulumi.RegisterOutputType(EsIndexMetadataOutput{})
	pulumi.RegisterOutputType(EsIndexSpecOutput{})
	pulumi.RegisterOutputType(EsIndexSpecPtrOutput{})
	pulumi.RegisterOutputType(EsIndexSpecBindingFromOutput{})
	pulumi.RegisterOutputType(EsIndexSpecBindingFromPtrOutput{})
	pulumi.RegisterOutputType(EsIndexSpecEsURIComposedOutput{})
	pulumi.RegisterOutputType(EsIndexSpecEsURIComposedPtrOutput{})
	pulumi.RegisterOutputType(EsIndexSpecEsURIComposedConfigMapKeyRefOutput{})
	pulumi.RegisterOutputType(EsIndexSpecEsURIComposedSecretKeyRefOutput{})
	pulumi.RegisterOutputType(EsIndexStatusOutput{})
	pulumi.RegisterOutputType(EsIndexStatusPtrOutput{})
}
