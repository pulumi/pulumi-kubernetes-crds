// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// KeepalivedGroup is the Schema for the keepalivedgroups API
type KeepalivedGroupType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KeepalivedGroupSpec defines the desired state of KeepalivedGroup
	Spec *KeepalivedGroupSpec `pulumi:"spec"`
	// KeepalivedGroupStatus defines the observed state of KeepalivedGroup
	Status *KeepalivedGroupStatus `pulumi:"status"`
}

// KeepalivedGroupTypeInput is an input type that accepts KeepalivedGroupTypeArgs and KeepalivedGroupTypeOutput values.
// You can construct a concrete instance of `KeepalivedGroupTypeInput` via:
//
//          KeepalivedGroupTypeArgs{...}
type KeepalivedGroupTypeInput interface {
	pulumi.Input

	ToKeepalivedGroupTypeOutput() KeepalivedGroupTypeOutput
	ToKeepalivedGroupTypeOutputWithContext(context.Context) KeepalivedGroupTypeOutput
}

// KeepalivedGroup is the Schema for the keepalivedgroups API
type KeepalivedGroupTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
	// KeepalivedGroupSpec defines the desired state of KeepalivedGroup
	Spec KeepalivedGroupSpecPtrInput `pulumi:"spec"`
	// KeepalivedGroupStatus defines the observed state of KeepalivedGroup
	Status KeepalivedGroupStatusPtrInput `pulumi:"status"`
}

func (KeepalivedGroupTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupType)(nil)).Elem()
}

func (i KeepalivedGroupTypeArgs) ToKeepalivedGroupTypeOutput() KeepalivedGroupTypeOutput {
	return i.ToKeepalivedGroupTypeOutputWithContext(context.Background())
}

func (i KeepalivedGroupTypeArgs) ToKeepalivedGroupTypeOutputWithContext(ctx context.Context) KeepalivedGroupTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupTypeOutput)
}

// KeepalivedGroup is the Schema for the keepalivedgroups API
type KeepalivedGroupTypeOutput struct{ *pulumi.OutputState }

func (KeepalivedGroupTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupType)(nil)).Elem()
}

func (o KeepalivedGroupTypeOutput) ToKeepalivedGroupTypeOutput() KeepalivedGroupTypeOutput {
	return o
}

func (o KeepalivedGroupTypeOutput) ToKeepalivedGroupTypeOutputWithContext(ctx context.Context) KeepalivedGroupTypeOutput {
	return o
}

func (o KeepalivedGroupTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v KeepalivedGroupType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o KeepalivedGroupTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v KeepalivedGroupType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o KeepalivedGroupTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v KeepalivedGroupType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

// KeepalivedGroupSpec defines the desired state of KeepalivedGroup
func (o KeepalivedGroupTypeOutput) Spec() KeepalivedGroupSpecPtrOutput {
	return o.ApplyT(func(v KeepalivedGroupType) *KeepalivedGroupSpec { return v.Spec }).(KeepalivedGroupSpecPtrOutput)
}

// KeepalivedGroupStatus defines the observed state of KeepalivedGroup
func (o KeepalivedGroupTypeOutput) Status() KeepalivedGroupStatusPtrOutput {
	return o.ApplyT(func(v KeepalivedGroupType) *KeepalivedGroupStatus { return v.Status }).(KeepalivedGroupStatusPtrOutput)
}

type KeepalivedGroupMetadata struct {
}

// KeepalivedGroupMetadataInput is an input type that accepts KeepalivedGroupMetadataArgs and KeepalivedGroupMetadataOutput values.
// You can construct a concrete instance of `KeepalivedGroupMetadataInput` via:
//
//          KeepalivedGroupMetadataArgs{...}
type KeepalivedGroupMetadataInput interface {
	pulumi.Input

	ToKeepalivedGroupMetadataOutput() KeepalivedGroupMetadataOutput
	ToKeepalivedGroupMetadataOutputWithContext(context.Context) KeepalivedGroupMetadataOutput
}

type KeepalivedGroupMetadataArgs struct {
}

func (KeepalivedGroupMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupMetadata)(nil)).Elem()
}

func (i KeepalivedGroupMetadataArgs) ToKeepalivedGroupMetadataOutput() KeepalivedGroupMetadataOutput {
	return i.ToKeepalivedGroupMetadataOutputWithContext(context.Background())
}

func (i KeepalivedGroupMetadataArgs) ToKeepalivedGroupMetadataOutputWithContext(ctx context.Context) KeepalivedGroupMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupMetadataOutput)
}

type KeepalivedGroupMetadataOutput struct{ *pulumi.OutputState }

func (KeepalivedGroupMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupMetadata)(nil)).Elem()
}

func (o KeepalivedGroupMetadataOutput) ToKeepalivedGroupMetadataOutput() KeepalivedGroupMetadataOutput {
	return o
}

func (o KeepalivedGroupMetadataOutput) ToKeepalivedGroupMetadataOutputWithContext(ctx context.Context) KeepalivedGroupMetadataOutput {
	return o
}

// KeepalivedGroupSpec defines the desired state of KeepalivedGroup
type KeepalivedGroupSpec struct {
	Image          *string           `pulumi:"image"`
	Interface      string            `pulumi:"interface"`
	NodeSelector   map[string]string `pulumi:"nodeSelector"`
	VerbatimConfig map[string]string `pulumi:"verbatimConfig"`
}

// KeepalivedGroupSpecInput is an input type that accepts KeepalivedGroupSpecArgs and KeepalivedGroupSpecOutput values.
// You can construct a concrete instance of `KeepalivedGroupSpecInput` via:
//
//          KeepalivedGroupSpecArgs{...}
type KeepalivedGroupSpecInput interface {
	pulumi.Input

	ToKeepalivedGroupSpecOutput() KeepalivedGroupSpecOutput
	ToKeepalivedGroupSpecOutputWithContext(context.Context) KeepalivedGroupSpecOutput
}

// KeepalivedGroupSpec defines the desired state of KeepalivedGroup
type KeepalivedGroupSpecArgs struct {
	Image          pulumi.StringPtrInput `pulumi:"image"`
	Interface      pulumi.StringInput    `pulumi:"interface"`
	NodeSelector   pulumi.StringMapInput `pulumi:"nodeSelector"`
	VerbatimConfig pulumi.StringMapInput `pulumi:"verbatimConfig"`
}

func (KeepalivedGroupSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupSpec)(nil)).Elem()
}

func (i KeepalivedGroupSpecArgs) ToKeepalivedGroupSpecOutput() KeepalivedGroupSpecOutput {
	return i.ToKeepalivedGroupSpecOutputWithContext(context.Background())
}

func (i KeepalivedGroupSpecArgs) ToKeepalivedGroupSpecOutputWithContext(ctx context.Context) KeepalivedGroupSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupSpecOutput)
}

func (i KeepalivedGroupSpecArgs) ToKeepalivedGroupSpecPtrOutput() KeepalivedGroupSpecPtrOutput {
	return i.ToKeepalivedGroupSpecPtrOutputWithContext(context.Background())
}

func (i KeepalivedGroupSpecArgs) ToKeepalivedGroupSpecPtrOutputWithContext(ctx context.Context) KeepalivedGroupSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupSpecOutput).ToKeepalivedGroupSpecPtrOutputWithContext(ctx)
}

// KeepalivedGroupSpecPtrInput is an input type that accepts KeepalivedGroupSpecArgs, KeepalivedGroupSpecPtr and KeepalivedGroupSpecPtrOutput values.
// You can construct a concrete instance of `KeepalivedGroupSpecPtrInput` via:
//
//          KeepalivedGroupSpecArgs{...}
//
//  or:
//
//          nil
type KeepalivedGroupSpecPtrInput interface {
	pulumi.Input

	ToKeepalivedGroupSpecPtrOutput() KeepalivedGroupSpecPtrOutput
	ToKeepalivedGroupSpecPtrOutputWithContext(context.Context) KeepalivedGroupSpecPtrOutput
}

type keepalivedGroupSpecPtrType KeepalivedGroupSpecArgs

func KeepalivedGroupSpecPtr(v *KeepalivedGroupSpecArgs) KeepalivedGroupSpecPtrInput {
	return (*keepalivedGroupSpecPtrType)(v)
}

func (*keepalivedGroupSpecPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**KeepalivedGroupSpec)(nil)).Elem()
}

func (i *keepalivedGroupSpecPtrType) ToKeepalivedGroupSpecPtrOutput() KeepalivedGroupSpecPtrOutput {
	return i.ToKeepalivedGroupSpecPtrOutputWithContext(context.Background())
}

func (i *keepalivedGroupSpecPtrType) ToKeepalivedGroupSpecPtrOutputWithContext(ctx context.Context) KeepalivedGroupSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupSpecPtrOutput)
}

// KeepalivedGroupSpec defines the desired state of KeepalivedGroup
type KeepalivedGroupSpecOutput struct{ *pulumi.OutputState }

func (KeepalivedGroupSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupSpec)(nil)).Elem()
}

func (o KeepalivedGroupSpecOutput) ToKeepalivedGroupSpecOutput() KeepalivedGroupSpecOutput {
	return o
}

func (o KeepalivedGroupSpecOutput) ToKeepalivedGroupSpecOutputWithContext(ctx context.Context) KeepalivedGroupSpecOutput {
	return o
}

func (o KeepalivedGroupSpecOutput) ToKeepalivedGroupSpecPtrOutput() KeepalivedGroupSpecPtrOutput {
	return o.ToKeepalivedGroupSpecPtrOutputWithContext(context.Background())
}

func (o KeepalivedGroupSpecOutput) ToKeepalivedGroupSpecPtrOutputWithContext(ctx context.Context) KeepalivedGroupSpecPtrOutput {
	return o.ApplyT(func(v KeepalivedGroupSpec) *KeepalivedGroupSpec {
		return &v
	}).(KeepalivedGroupSpecPtrOutput)
}
func (o KeepalivedGroupSpecOutput) Image() pulumi.StringPtrOutput {
	return o.ApplyT(func(v KeepalivedGroupSpec) *string { return v.Image }).(pulumi.StringPtrOutput)
}

func (o KeepalivedGroupSpecOutput) Interface() pulumi.StringOutput {
	return o.ApplyT(func(v KeepalivedGroupSpec) string { return v.Interface }).(pulumi.StringOutput)
}

func (o KeepalivedGroupSpecOutput) NodeSelector() pulumi.StringMapOutput {
	return o.ApplyT(func(v KeepalivedGroupSpec) map[string]string { return v.NodeSelector }).(pulumi.StringMapOutput)
}

func (o KeepalivedGroupSpecOutput) VerbatimConfig() pulumi.StringMapOutput {
	return o.ApplyT(func(v KeepalivedGroupSpec) map[string]string { return v.VerbatimConfig }).(pulumi.StringMapOutput)
}

type KeepalivedGroupSpecPtrOutput struct{ *pulumi.OutputState }

func (KeepalivedGroupSpecPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**KeepalivedGroupSpec)(nil)).Elem()
}

func (o KeepalivedGroupSpecPtrOutput) ToKeepalivedGroupSpecPtrOutput() KeepalivedGroupSpecPtrOutput {
	return o
}

func (o KeepalivedGroupSpecPtrOutput) ToKeepalivedGroupSpecPtrOutputWithContext(ctx context.Context) KeepalivedGroupSpecPtrOutput {
	return o
}

func (o KeepalivedGroupSpecPtrOutput) Elem() KeepalivedGroupSpecOutput {
	return o.ApplyT(func(v *KeepalivedGroupSpec) KeepalivedGroupSpec { return *v }).(KeepalivedGroupSpecOutput)
}

func (o KeepalivedGroupSpecPtrOutput) Image() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *KeepalivedGroupSpec) *string {
		if v == nil {
			return nil
		}
		return v.Image
	}).(pulumi.StringPtrOutput)
}

func (o KeepalivedGroupSpecPtrOutput) Interface() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *KeepalivedGroupSpec) *string {
		if v == nil {
			return nil
		}
		return &v.Interface
	}).(pulumi.StringPtrOutput)
}

func (o KeepalivedGroupSpecPtrOutput) NodeSelector() pulumi.StringMapOutput {
	return o.ApplyT(func(v *KeepalivedGroupSpec) map[string]string {
		if v == nil {
			return nil
		}
		return v.NodeSelector
	}).(pulumi.StringMapOutput)
}

func (o KeepalivedGroupSpecPtrOutput) VerbatimConfig() pulumi.StringMapOutput {
	return o.ApplyT(func(v *KeepalivedGroupSpec) map[string]string {
		if v == nil {
			return nil
		}
		return v.VerbatimConfig
	}).(pulumi.StringMapOutput)
}

type KeepalivedGroupSpecNodeSelector struct {
}

// KeepalivedGroupSpecNodeSelectorInput is an input type that accepts KeepalivedGroupSpecNodeSelectorArgs and KeepalivedGroupSpecNodeSelectorOutput values.
// You can construct a concrete instance of `KeepalivedGroupSpecNodeSelectorInput` via:
//
//          KeepalivedGroupSpecNodeSelectorArgs{...}
type KeepalivedGroupSpecNodeSelectorInput interface {
	pulumi.Input

	ToKeepalivedGroupSpecNodeSelectorOutput() KeepalivedGroupSpecNodeSelectorOutput
	ToKeepalivedGroupSpecNodeSelectorOutputWithContext(context.Context) KeepalivedGroupSpecNodeSelectorOutput
}

type KeepalivedGroupSpecNodeSelectorArgs struct {
}

func (KeepalivedGroupSpecNodeSelectorArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupSpecNodeSelector)(nil)).Elem()
}

func (i KeepalivedGroupSpecNodeSelectorArgs) ToKeepalivedGroupSpecNodeSelectorOutput() KeepalivedGroupSpecNodeSelectorOutput {
	return i.ToKeepalivedGroupSpecNodeSelectorOutputWithContext(context.Background())
}

func (i KeepalivedGroupSpecNodeSelectorArgs) ToKeepalivedGroupSpecNodeSelectorOutputWithContext(ctx context.Context) KeepalivedGroupSpecNodeSelectorOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupSpecNodeSelectorOutput)
}

type KeepalivedGroupSpecNodeSelectorOutput struct{ *pulumi.OutputState }

func (KeepalivedGroupSpecNodeSelectorOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupSpecNodeSelector)(nil)).Elem()
}

func (o KeepalivedGroupSpecNodeSelectorOutput) ToKeepalivedGroupSpecNodeSelectorOutput() KeepalivedGroupSpecNodeSelectorOutput {
	return o
}

func (o KeepalivedGroupSpecNodeSelectorOutput) ToKeepalivedGroupSpecNodeSelectorOutputWithContext(ctx context.Context) KeepalivedGroupSpecNodeSelectorOutput {
	return o
}

type KeepalivedGroupSpecVerbatimConfig struct {
}

// KeepalivedGroupSpecVerbatimConfigInput is an input type that accepts KeepalivedGroupSpecVerbatimConfigArgs and KeepalivedGroupSpecVerbatimConfigOutput values.
// You can construct a concrete instance of `KeepalivedGroupSpecVerbatimConfigInput` via:
//
//          KeepalivedGroupSpecVerbatimConfigArgs{...}
type KeepalivedGroupSpecVerbatimConfigInput interface {
	pulumi.Input

	ToKeepalivedGroupSpecVerbatimConfigOutput() KeepalivedGroupSpecVerbatimConfigOutput
	ToKeepalivedGroupSpecVerbatimConfigOutputWithContext(context.Context) KeepalivedGroupSpecVerbatimConfigOutput
}

type KeepalivedGroupSpecVerbatimConfigArgs struct {
}

func (KeepalivedGroupSpecVerbatimConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupSpecVerbatimConfig)(nil)).Elem()
}

func (i KeepalivedGroupSpecVerbatimConfigArgs) ToKeepalivedGroupSpecVerbatimConfigOutput() KeepalivedGroupSpecVerbatimConfigOutput {
	return i.ToKeepalivedGroupSpecVerbatimConfigOutputWithContext(context.Background())
}

func (i KeepalivedGroupSpecVerbatimConfigArgs) ToKeepalivedGroupSpecVerbatimConfigOutputWithContext(ctx context.Context) KeepalivedGroupSpecVerbatimConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupSpecVerbatimConfigOutput)
}

type KeepalivedGroupSpecVerbatimConfigOutput struct{ *pulumi.OutputState }

func (KeepalivedGroupSpecVerbatimConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupSpecVerbatimConfig)(nil)).Elem()
}

func (o KeepalivedGroupSpecVerbatimConfigOutput) ToKeepalivedGroupSpecVerbatimConfigOutput() KeepalivedGroupSpecVerbatimConfigOutput {
	return o
}

func (o KeepalivedGroupSpecVerbatimConfigOutput) ToKeepalivedGroupSpecVerbatimConfigOutputWithContext(ctx context.Context) KeepalivedGroupSpecVerbatimConfigOutput {
	return o
}

// KeepalivedGroupStatus defines the observed state of KeepalivedGroup
type KeepalivedGroupStatus struct {
	// INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
	Conditions []KeepalivedGroupStatusConditions `pulumi:"conditions"`
	RouterIDs  map[string]int                    `pulumi:"routerIDs"`
}

// KeepalivedGroupStatusInput is an input type that accepts KeepalivedGroupStatusArgs and KeepalivedGroupStatusOutput values.
// You can construct a concrete instance of `KeepalivedGroupStatusInput` via:
//
//          KeepalivedGroupStatusArgs{...}
type KeepalivedGroupStatusInput interface {
	pulumi.Input

	ToKeepalivedGroupStatusOutput() KeepalivedGroupStatusOutput
	ToKeepalivedGroupStatusOutputWithContext(context.Context) KeepalivedGroupStatusOutput
}

// KeepalivedGroupStatus defines the observed state of KeepalivedGroup
type KeepalivedGroupStatusArgs struct {
	// INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
	Conditions KeepalivedGroupStatusConditionsArrayInput `pulumi:"conditions"`
	RouterIDs  pulumi.IntMapInput                        `pulumi:"routerIDs"`
}

func (KeepalivedGroupStatusArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupStatus)(nil)).Elem()
}

func (i KeepalivedGroupStatusArgs) ToKeepalivedGroupStatusOutput() KeepalivedGroupStatusOutput {
	return i.ToKeepalivedGroupStatusOutputWithContext(context.Background())
}

func (i KeepalivedGroupStatusArgs) ToKeepalivedGroupStatusOutputWithContext(ctx context.Context) KeepalivedGroupStatusOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupStatusOutput)
}

func (i KeepalivedGroupStatusArgs) ToKeepalivedGroupStatusPtrOutput() KeepalivedGroupStatusPtrOutput {
	return i.ToKeepalivedGroupStatusPtrOutputWithContext(context.Background())
}

func (i KeepalivedGroupStatusArgs) ToKeepalivedGroupStatusPtrOutputWithContext(ctx context.Context) KeepalivedGroupStatusPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupStatusOutput).ToKeepalivedGroupStatusPtrOutputWithContext(ctx)
}

// KeepalivedGroupStatusPtrInput is an input type that accepts KeepalivedGroupStatusArgs, KeepalivedGroupStatusPtr and KeepalivedGroupStatusPtrOutput values.
// You can construct a concrete instance of `KeepalivedGroupStatusPtrInput` via:
//
//          KeepalivedGroupStatusArgs{...}
//
//  or:
//
//          nil
type KeepalivedGroupStatusPtrInput interface {
	pulumi.Input

	ToKeepalivedGroupStatusPtrOutput() KeepalivedGroupStatusPtrOutput
	ToKeepalivedGroupStatusPtrOutputWithContext(context.Context) KeepalivedGroupStatusPtrOutput
}

type keepalivedGroupStatusPtrType KeepalivedGroupStatusArgs

func KeepalivedGroupStatusPtr(v *KeepalivedGroupStatusArgs) KeepalivedGroupStatusPtrInput {
	return (*keepalivedGroupStatusPtrType)(v)
}

func (*keepalivedGroupStatusPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**KeepalivedGroupStatus)(nil)).Elem()
}

func (i *keepalivedGroupStatusPtrType) ToKeepalivedGroupStatusPtrOutput() KeepalivedGroupStatusPtrOutput {
	return i.ToKeepalivedGroupStatusPtrOutputWithContext(context.Background())
}

func (i *keepalivedGroupStatusPtrType) ToKeepalivedGroupStatusPtrOutputWithContext(ctx context.Context) KeepalivedGroupStatusPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupStatusPtrOutput)
}

// KeepalivedGroupStatus defines the observed state of KeepalivedGroup
type KeepalivedGroupStatusOutput struct{ *pulumi.OutputState }

func (KeepalivedGroupStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupStatus)(nil)).Elem()
}

func (o KeepalivedGroupStatusOutput) ToKeepalivedGroupStatusOutput() KeepalivedGroupStatusOutput {
	return o
}

func (o KeepalivedGroupStatusOutput) ToKeepalivedGroupStatusOutputWithContext(ctx context.Context) KeepalivedGroupStatusOutput {
	return o
}

func (o KeepalivedGroupStatusOutput) ToKeepalivedGroupStatusPtrOutput() KeepalivedGroupStatusPtrOutput {
	return o.ToKeepalivedGroupStatusPtrOutputWithContext(context.Background())
}

func (o KeepalivedGroupStatusOutput) ToKeepalivedGroupStatusPtrOutputWithContext(ctx context.Context) KeepalivedGroupStatusPtrOutput {
	return o.ApplyT(func(v KeepalivedGroupStatus) *KeepalivedGroupStatus {
		return &v
	}).(KeepalivedGroupStatusPtrOutput)
}

// INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
func (o KeepalivedGroupStatusOutput) Conditions() KeepalivedGroupStatusConditionsArrayOutput {
	return o.ApplyT(func(v KeepalivedGroupStatus) []KeepalivedGroupStatusConditions { return v.Conditions }).(KeepalivedGroupStatusConditionsArrayOutput)
}

func (o KeepalivedGroupStatusOutput) RouterIDs() pulumi.IntMapOutput {
	return o.ApplyT(func(v KeepalivedGroupStatus) map[string]int { return v.RouterIDs }).(pulumi.IntMapOutput)
}

type KeepalivedGroupStatusPtrOutput struct{ *pulumi.OutputState }

func (KeepalivedGroupStatusPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**KeepalivedGroupStatus)(nil)).Elem()
}

func (o KeepalivedGroupStatusPtrOutput) ToKeepalivedGroupStatusPtrOutput() KeepalivedGroupStatusPtrOutput {
	return o
}

func (o KeepalivedGroupStatusPtrOutput) ToKeepalivedGroupStatusPtrOutputWithContext(ctx context.Context) KeepalivedGroupStatusPtrOutput {
	return o
}

func (o KeepalivedGroupStatusPtrOutput) Elem() KeepalivedGroupStatusOutput {
	return o.ApplyT(func(v *KeepalivedGroupStatus) KeepalivedGroupStatus { return *v }).(KeepalivedGroupStatusOutput)
}

// INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
func (o KeepalivedGroupStatusPtrOutput) Conditions() KeepalivedGroupStatusConditionsArrayOutput {
	return o.ApplyT(func(v *KeepalivedGroupStatus) []KeepalivedGroupStatusConditions {
		if v == nil {
			return nil
		}
		return v.Conditions
	}).(KeepalivedGroupStatusConditionsArrayOutput)
}

func (o KeepalivedGroupStatusPtrOutput) RouterIDs() pulumi.IntMapOutput {
	return o.ApplyT(func(v *KeepalivedGroupStatus) map[string]int {
		if v == nil {
			return nil
		}
		return v.RouterIDs
	}).(pulumi.IntMapOutput)
}

// Condition represents an observation of an object's state. Conditions are an extension mechanism intended to be used when the details of an observation are not a priori known or would not apply to all instances of a given Kind.
//  Conditions should be added to explicitly convey properties that users and components care about rather than requiring those properties to be inferred from other observations. Once defined, the meaning of a Condition can not be changed arbitrarily - it becomes part of the API, and has the same backwards- and forwards-compatibility concerns of any other part of the API.
type KeepalivedGroupStatusConditions struct {
	LastTransitionTime *string `pulumi:"lastTransitionTime"`
	Message            *string `pulumi:"message"`
	// ConditionReason is intended to be a one-word, CamelCase representation of the category of cause of the current status. It is intended to be used in concise output, such as one-line kubectl get output, and in summarizing occurrences of causes.
	Reason *string `pulumi:"reason"`
	Status string  `pulumi:"status"`
	// ConditionType is the type of the condition and is typically a CamelCased word or short phrase.
	//  Condition types should indicate state in the "abnormal-true" polarity. For example, if the condition indicates when a policy is invalid, the "is valid" case is probably the norm, so the condition should be called "Invalid".
	Type string `pulumi:"type"`
}

// KeepalivedGroupStatusConditionsInput is an input type that accepts KeepalivedGroupStatusConditionsArgs and KeepalivedGroupStatusConditionsOutput values.
// You can construct a concrete instance of `KeepalivedGroupStatusConditionsInput` via:
//
//          KeepalivedGroupStatusConditionsArgs{...}
type KeepalivedGroupStatusConditionsInput interface {
	pulumi.Input

	ToKeepalivedGroupStatusConditionsOutput() KeepalivedGroupStatusConditionsOutput
	ToKeepalivedGroupStatusConditionsOutputWithContext(context.Context) KeepalivedGroupStatusConditionsOutput
}

// Condition represents an observation of an object's state. Conditions are an extension mechanism intended to be used when the details of an observation are not a priori known or would not apply to all instances of a given Kind.
//  Conditions should be added to explicitly convey properties that users and components care about rather than requiring those properties to be inferred from other observations. Once defined, the meaning of a Condition can not be changed arbitrarily - it becomes part of the API, and has the same backwards- and forwards-compatibility concerns of any other part of the API.
type KeepalivedGroupStatusConditionsArgs struct {
	LastTransitionTime pulumi.StringPtrInput `pulumi:"lastTransitionTime"`
	Message            pulumi.StringPtrInput `pulumi:"message"`
	// ConditionReason is intended to be a one-word, CamelCase representation of the category of cause of the current status. It is intended to be used in concise output, such as one-line kubectl get output, and in summarizing occurrences of causes.
	Reason pulumi.StringPtrInput `pulumi:"reason"`
	Status pulumi.StringInput    `pulumi:"status"`
	// ConditionType is the type of the condition and is typically a CamelCased word or short phrase.
	//  Condition types should indicate state in the "abnormal-true" polarity. For example, if the condition indicates when a policy is invalid, the "is valid" case is probably the norm, so the condition should be called "Invalid".
	Type pulumi.StringInput `pulumi:"type"`
}

func (KeepalivedGroupStatusConditionsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupStatusConditions)(nil)).Elem()
}

func (i KeepalivedGroupStatusConditionsArgs) ToKeepalivedGroupStatusConditionsOutput() KeepalivedGroupStatusConditionsOutput {
	return i.ToKeepalivedGroupStatusConditionsOutputWithContext(context.Background())
}

func (i KeepalivedGroupStatusConditionsArgs) ToKeepalivedGroupStatusConditionsOutputWithContext(ctx context.Context) KeepalivedGroupStatusConditionsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupStatusConditionsOutput)
}

// KeepalivedGroupStatusConditionsArrayInput is an input type that accepts KeepalivedGroupStatusConditionsArray and KeepalivedGroupStatusConditionsArrayOutput values.
// You can construct a concrete instance of `KeepalivedGroupStatusConditionsArrayInput` via:
//
//          KeepalivedGroupStatusConditionsArray{ KeepalivedGroupStatusConditionsArgs{...} }
type KeepalivedGroupStatusConditionsArrayInput interface {
	pulumi.Input

	ToKeepalivedGroupStatusConditionsArrayOutput() KeepalivedGroupStatusConditionsArrayOutput
	ToKeepalivedGroupStatusConditionsArrayOutputWithContext(context.Context) KeepalivedGroupStatusConditionsArrayOutput
}

type KeepalivedGroupStatusConditionsArray []KeepalivedGroupStatusConditionsInput

func (KeepalivedGroupStatusConditionsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]KeepalivedGroupStatusConditions)(nil)).Elem()
}

func (i KeepalivedGroupStatusConditionsArray) ToKeepalivedGroupStatusConditionsArrayOutput() KeepalivedGroupStatusConditionsArrayOutput {
	return i.ToKeepalivedGroupStatusConditionsArrayOutputWithContext(context.Background())
}

func (i KeepalivedGroupStatusConditionsArray) ToKeepalivedGroupStatusConditionsArrayOutputWithContext(ctx context.Context) KeepalivedGroupStatusConditionsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupStatusConditionsArrayOutput)
}

// Condition represents an observation of an object's state. Conditions are an extension mechanism intended to be used when the details of an observation are not a priori known or would not apply to all instances of a given Kind.
//  Conditions should be added to explicitly convey properties that users and components care about rather than requiring those properties to be inferred from other observations. Once defined, the meaning of a Condition can not be changed arbitrarily - it becomes part of the API, and has the same backwards- and forwards-compatibility concerns of any other part of the API.
type KeepalivedGroupStatusConditionsOutput struct{ *pulumi.OutputState }

func (KeepalivedGroupStatusConditionsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupStatusConditions)(nil)).Elem()
}

func (o KeepalivedGroupStatusConditionsOutput) ToKeepalivedGroupStatusConditionsOutput() KeepalivedGroupStatusConditionsOutput {
	return o
}

func (o KeepalivedGroupStatusConditionsOutput) ToKeepalivedGroupStatusConditionsOutputWithContext(ctx context.Context) KeepalivedGroupStatusConditionsOutput {
	return o
}

func (o KeepalivedGroupStatusConditionsOutput) LastTransitionTime() pulumi.StringPtrOutput {
	return o.ApplyT(func(v KeepalivedGroupStatusConditions) *string { return v.LastTransitionTime }).(pulumi.StringPtrOutput)
}

func (o KeepalivedGroupStatusConditionsOutput) Message() pulumi.StringPtrOutput {
	return o.ApplyT(func(v KeepalivedGroupStatusConditions) *string { return v.Message }).(pulumi.StringPtrOutput)
}

// ConditionReason is intended to be a one-word, CamelCase representation of the category of cause of the current status. It is intended to be used in concise output, such as one-line kubectl get output, and in summarizing occurrences of causes.
func (o KeepalivedGroupStatusConditionsOutput) Reason() pulumi.StringPtrOutput {
	return o.ApplyT(func(v KeepalivedGroupStatusConditions) *string { return v.Reason }).(pulumi.StringPtrOutput)
}

func (o KeepalivedGroupStatusConditionsOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v KeepalivedGroupStatusConditions) string { return v.Status }).(pulumi.StringOutput)
}

// ConditionType is the type of the condition and is typically a CamelCased word or short phrase.
//  Condition types should indicate state in the "abnormal-true" polarity. For example, if the condition indicates when a policy is invalid, the "is valid" case is probably the norm, so the condition should be called "Invalid".
func (o KeepalivedGroupStatusConditionsOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v KeepalivedGroupStatusConditions) string { return v.Type }).(pulumi.StringOutput)
}

type KeepalivedGroupStatusConditionsArrayOutput struct{ *pulumi.OutputState }

func (KeepalivedGroupStatusConditionsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]KeepalivedGroupStatusConditions)(nil)).Elem()
}

func (o KeepalivedGroupStatusConditionsArrayOutput) ToKeepalivedGroupStatusConditionsArrayOutput() KeepalivedGroupStatusConditionsArrayOutput {
	return o
}

func (o KeepalivedGroupStatusConditionsArrayOutput) ToKeepalivedGroupStatusConditionsArrayOutputWithContext(ctx context.Context) KeepalivedGroupStatusConditionsArrayOutput {
	return o
}

func (o KeepalivedGroupStatusConditionsArrayOutput) Index(i pulumi.IntInput) KeepalivedGroupStatusConditionsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) KeepalivedGroupStatusConditions {
		return vs[0].([]KeepalivedGroupStatusConditions)[vs[1].(int)]
	}).(KeepalivedGroupStatusConditionsOutput)
}

type KeepalivedGroupStatusRouterIDs struct {
}

// KeepalivedGroupStatusRouterIDsInput is an input type that accepts KeepalivedGroupStatusRouterIDsArgs and KeepalivedGroupStatusRouterIDsOutput values.
// You can construct a concrete instance of `KeepalivedGroupStatusRouterIDsInput` via:
//
//          KeepalivedGroupStatusRouterIDsArgs{...}
type KeepalivedGroupStatusRouterIDsInput interface {
	pulumi.Input

	ToKeepalivedGroupStatusRouterIDsOutput() KeepalivedGroupStatusRouterIDsOutput
	ToKeepalivedGroupStatusRouterIDsOutputWithContext(context.Context) KeepalivedGroupStatusRouterIDsOutput
}

type KeepalivedGroupStatusRouterIDsArgs struct {
}

func (KeepalivedGroupStatusRouterIDsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupStatusRouterIDs)(nil)).Elem()
}

func (i KeepalivedGroupStatusRouterIDsArgs) ToKeepalivedGroupStatusRouterIDsOutput() KeepalivedGroupStatusRouterIDsOutput {
	return i.ToKeepalivedGroupStatusRouterIDsOutputWithContext(context.Background())
}

func (i KeepalivedGroupStatusRouterIDsArgs) ToKeepalivedGroupStatusRouterIDsOutputWithContext(ctx context.Context) KeepalivedGroupStatusRouterIDsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KeepalivedGroupStatusRouterIDsOutput)
}

type KeepalivedGroupStatusRouterIDsOutput struct{ *pulumi.OutputState }

func (KeepalivedGroupStatusRouterIDsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KeepalivedGroupStatusRouterIDs)(nil)).Elem()
}

func (o KeepalivedGroupStatusRouterIDsOutput) ToKeepalivedGroupStatusRouterIDsOutput() KeepalivedGroupStatusRouterIDsOutput {
	return o
}

func (o KeepalivedGroupStatusRouterIDsOutput) ToKeepalivedGroupStatusRouterIDsOutputWithContext(ctx context.Context) KeepalivedGroupStatusRouterIDsOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(KeepalivedGroupTypeOutput{})
	pulumi.RegisterOutputType(KeepalivedGroupMetadataOutput{})
	pulumi.RegisterOutputType(KeepalivedGroupSpecOutput{})
	pulumi.RegisterOutputType(KeepalivedGroupSpecPtrOutput{})
	pulumi.RegisterOutputType(KeepalivedGroupSpecNodeSelectorOutput{})
	pulumi.RegisterOutputType(KeepalivedGroupSpecVerbatimConfigOutput{})
	pulumi.RegisterOutputType(KeepalivedGroupStatusOutput{})
	pulumi.RegisterOutputType(KeepalivedGroupStatusPtrOutput{})
	pulumi.RegisterOutputType(KeepalivedGroupStatusConditionsOutput{})
	pulumi.RegisterOutputType(KeepalivedGroupStatusConditionsArrayOutput{})
	pulumi.RegisterOutputType(KeepalivedGroupStatusRouterIDsOutput{})
}
