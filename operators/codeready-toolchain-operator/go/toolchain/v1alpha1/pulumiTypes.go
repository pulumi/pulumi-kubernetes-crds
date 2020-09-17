// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type CheInstallationType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
}

// CheInstallationTypeInput is an input type that accepts CheInstallationTypeArgs and CheInstallationTypeOutput values.
// You can construct a concrete instance of `CheInstallationTypeInput` via:
//
//          CheInstallationTypeArgs{...}
type CheInstallationTypeInput interface {
	pulumi.Input

	ToCheInstallationTypeOutput() CheInstallationTypeOutput
	ToCheInstallationTypeOutputWithContext(context.Context) CheInstallationTypeOutput
}

type CheInstallationTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
}

func (CheInstallationTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*CheInstallationType)(nil)).Elem()
}

func (i CheInstallationTypeArgs) ToCheInstallationTypeOutput() CheInstallationTypeOutput {
	return i.ToCheInstallationTypeOutputWithContext(context.Background())
}

func (i CheInstallationTypeArgs) ToCheInstallationTypeOutputWithContext(ctx context.Context) CheInstallationTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CheInstallationTypeOutput)
}

type CheInstallationTypeOutput struct{ *pulumi.OutputState }

func (CheInstallationTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CheInstallationType)(nil)).Elem()
}

func (o CheInstallationTypeOutput) ToCheInstallationTypeOutput() CheInstallationTypeOutput {
	return o
}

func (o CheInstallationTypeOutput) ToCheInstallationTypeOutputWithContext(ctx context.Context) CheInstallationTypeOutput {
	return o
}

func (o CheInstallationTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v CheInstallationType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o CheInstallationTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v CheInstallationType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o CheInstallationTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v CheInstallationType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

type CheInstallationMetadata struct {
}

// CheInstallationMetadataInput is an input type that accepts CheInstallationMetadataArgs and CheInstallationMetadataOutput values.
// You can construct a concrete instance of `CheInstallationMetadataInput` via:
//
//          CheInstallationMetadataArgs{...}
type CheInstallationMetadataInput interface {
	pulumi.Input

	ToCheInstallationMetadataOutput() CheInstallationMetadataOutput
	ToCheInstallationMetadataOutputWithContext(context.Context) CheInstallationMetadataOutput
}

type CheInstallationMetadataArgs struct {
}

func (CheInstallationMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*CheInstallationMetadata)(nil)).Elem()
}

func (i CheInstallationMetadataArgs) ToCheInstallationMetadataOutput() CheInstallationMetadataOutput {
	return i.ToCheInstallationMetadataOutputWithContext(context.Background())
}

func (i CheInstallationMetadataArgs) ToCheInstallationMetadataOutputWithContext(ctx context.Context) CheInstallationMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CheInstallationMetadataOutput)
}

type CheInstallationMetadataOutput struct{ *pulumi.OutputState }

func (CheInstallationMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CheInstallationMetadata)(nil)).Elem()
}

func (o CheInstallationMetadataOutput) ToCheInstallationMetadataOutput() CheInstallationMetadataOutput {
	return o
}

func (o CheInstallationMetadataOutput) ToCheInstallationMetadataOutputWithContext(ctx context.Context) CheInstallationMetadataOutput {
	return o
}

// CheInstallationSpec defines the desired state of CheInstallation
type CheInstallationSpec struct {
	// The configuration required for Che operator
	CheOperatorSpec CheInstallationSpecCheOperatorSpec `pulumi:"cheOperatorSpec"`
}

// CheInstallationSpecInput is an input type that accepts CheInstallationSpecArgs and CheInstallationSpecOutput values.
// You can construct a concrete instance of `CheInstallationSpecInput` via:
//
//          CheInstallationSpecArgs{...}
type CheInstallationSpecInput interface {
	pulumi.Input

	ToCheInstallationSpecOutput() CheInstallationSpecOutput
	ToCheInstallationSpecOutputWithContext(context.Context) CheInstallationSpecOutput
}

// CheInstallationSpec defines the desired state of CheInstallation
type CheInstallationSpecArgs struct {
	// The configuration required for Che operator
	CheOperatorSpec CheInstallationSpecCheOperatorSpecInput `pulumi:"cheOperatorSpec"`
}

func (CheInstallationSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*CheInstallationSpec)(nil)).Elem()
}

func (i CheInstallationSpecArgs) ToCheInstallationSpecOutput() CheInstallationSpecOutput {
	return i.ToCheInstallationSpecOutputWithContext(context.Background())
}

func (i CheInstallationSpecArgs) ToCheInstallationSpecOutputWithContext(ctx context.Context) CheInstallationSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CheInstallationSpecOutput)
}

// CheInstallationSpec defines the desired state of CheInstallation
type CheInstallationSpecOutput struct{ *pulumi.OutputState }

func (CheInstallationSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CheInstallationSpec)(nil)).Elem()
}

func (o CheInstallationSpecOutput) ToCheInstallationSpecOutput() CheInstallationSpecOutput {
	return o
}

func (o CheInstallationSpecOutput) ToCheInstallationSpecOutputWithContext(ctx context.Context) CheInstallationSpecOutput {
	return o
}

// The configuration required for Che operator
func (o CheInstallationSpecOutput) CheOperatorSpec() CheInstallationSpecCheOperatorSpecOutput {
	return o.ApplyT(func(v CheInstallationSpec) CheInstallationSpecCheOperatorSpec { return v.CheOperatorSpec }).(CheInstallationSpecCheOperatorSpecOutput)
}

// The configuration required for Che operator
type CheInstallationSpecCheOperatorSpec struct {
	// The namespace where the CodeReady Workspaces operator will be installed
	Namespace string `pulumi:"namespace"`
}

// CheInstallationSpecCheOperatorSpecInput is an input type that accepts CheInstallationSpecCheOperatorSpecArgs and CheInstallationSpecCheOperatorSpecOutput values.
// You can construct a concrete instance of `CheInstallationSpecCheOperatorSpecInput` via:
//
//          CheInstallationSpecCheOperatorSpecArgs{...}
type CheInstallationSpecCheOperatorSpecInput interface {
	pulumi.Input

	ToCheInstallationSpecCheOperatorSpecOutput() CheInstallationSpecCheOperatorSpecOutput
	ToCheInstallationSpecCheOperatorSpecOutputWithContext(context.Context) CheInstallationSpecCheOperatorSpecOutput
}

// The configuration required for Che operator
type CheInstallationSpecCheOperatorSpecArgs struct {
	// The namespace where the CodeReady Workspaces operator will be installed
	Namespace pulumi.StringInput `pulumi:"namespace"`
}

func (CheInstallationSpecCheOperatorSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*CheInstallationSpecCheOperatorSpec)(nil)).Elem()
}

func (i CheInstallationSpecCheOperatorSpecArgs) ToCheInstallationSpecCheOperatorSpecOutput() CheInstallationSpecCheOperatorSpecOutput {
	return i.ToCheInstallationSpecCheOperatorSpecOutputWithContext(context.Background())
}

func (i CheInstallationSpecCheOperatorSpecArgs) ToCheInstallationSpecCheOperatorSpecOutputWithContext(ctx context.Context) CheInstallationSpecCheOperatorSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CheInstallationSpecCheOperatorSpecOutput)
}

// The configuration required for Che operator
type CheInstallationSpecCheOperatorSpecOutput struct{ *pulumi.OutputState }

func (CheInstallationSpecCheOperatorSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CheInstallationSpecCheOperatorSpec)(nil)).Elem()
}

func (o CheInstallationSpecCheOperatorSpecOutput) ToCheInstallationSpecCheOperatorSpecOutput() CheInstallationSpecCheOperatorSpecOutput {
	return o
}

func (o CheInstallationSpecCheOperatorSpecOutput) ToCheInstallationSpecCheOperatorSpecOutputWithContext(ctx context.Context) CheInstallationSpecCheOperatorSpecOutput {
	return o
}

// The namespace where the CodeReady Workspaces operator will be installed
func (o CheInstallationSpecCheOperatorSpecOutput) Namespace() pulumi.StringOutput {
	return o.ApplyT(func(v CheInstallationSpecCheOperatorSpec) string { return v.Namespace }).(pulumi.StringOutput)
}

// CheInstallationStatus defines the observed state of CheInstallation
type CheInstallationStatus struct {
	// Route to access CodeReady Workspaces
	CheServerURL *string `pulumi:"cheServerURL"`
	// Last known condition of the CodeReady Workspaces  operator installation. Supported condition types: CheReady
	Conditions []CheInstallationStatusConditions `pulumi:"conditions"`
}

// CheInstallationStatusInput is an input type that accepts CheInstallationStatusArgs and CheInstallationStatusOutput values.
// You can construct a concrete instance of `CheInstallationStatusInput` via:
//
//          CheInstallationStatusArgs{...}
type CheInstallationStatusInput interface {
	pulumi.Input

	ToCheInstallationStatusOutput() CheInstallationStatusOutput
	ToCheInstallationStatusOutputWithContext(context.Context) CheInstallationStatusOutput
}

// CheInstallationStatus defines the observed state of CheInstallation
type CheInstallationStatusArgs struct {
	// Route to access CodeReady Workspaces
	CheServerURL pulumi.StringPtrInput `pulumi:"cheServerURL"`
	// Last known condition of the CodeReady Workspaces  operator installation. Supported condition types: CheReady
	Conditions CheInstallationStatusConditionsArrayInput `pulumi:"conditions"`
}

func (CheInstallationStatusArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*CheInstallationStatus)(nil)).Elem()
}

func (i CheInstallationStatusArgs) ToCheInstallationStatusOutput() CheInstallationStatusOutput {
	return i.ToCheInstallationStatusOutputWithContext(context.Background())
}

func (i CheInstallationStatusArgs) ToCheInstallationStatusOutputWithContext(ctx context.Context) CheInstallationStatusOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CheInstallationStatusOutput)
}

// CheInstallationStatus defines the observed state of CheInstallation
type CheInstallationStatusOutput struct{ *pulumi.OutputState }

func (CheInstallationStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CheInstallationStatus)(nil)).Elem()
}

func (o CheInstallationStatusOutput) ToCheInstallationStatusOutput() CheInstallationStatusOutput {
	return o
}

func (o CheInstallationStatusOutput) ToCheInstallationStatusOutputWithContext(ctx context.Context) CheInstallationStatusOutput {
	return o
}

// Route to access CodeReady Workspaces
func (o CheInstallationStatusOutput) CheServerURL() pulumi.StringPtrOutput {
	return o.ApplyT(func(v CheInstallationStatus) *string { return v.CheServerURL }).(pulumi.StringPtrOutput)
}

// Last known condition of the CodeReady Workspaces  operator installation. Supported condition types: CheReady
func (o CheInstallationStatusOutput) Conditions() CheInstallationStatusConditionsArrayOutput {
	return o.ApplyT(func(v CheInstallationStatus) []CheInstallationStatusConditions { return v.Conditions }).(CheInstallationStatusConditionsArrayOutput)
}

type CheInstallationStatusConditions struct {
	// Last time the condition transit from one status to another.
	LastTransitionTime *string `pulumi:"lastTransitionTime"`
	// Human readable message indicating details about last transition.
	Message *string `pulumi:"message"`
	// (brief) reason for the condition's last transition.
	Reason *string `pulumi:"reason"`
	// Status of the condition, one of True, False, Unknown.
	Status string `pulumi:"status"`
	// Type of condition
	Type string `pulumi:"type"`
}

// CheInstallationStatusConditionsInput is an input type that accepts CheInstallationStatusConditionsArgs and CheInstallationStatusConditionsOutput values.
// You can construct a concrete instance of `CheInstallationStatusConditionsInput` via:
//
//          CheInstallationStatusConditionsArgs{...}
type CheInstallationStatusConditionsInput interface {
	pulumi.Input

	ToCheInstallationStatusConditionsOutput() CheInstallationStatusConditionsOutput
	ToCheInstallationStatusConditionsOutputWithContext(context.Context) CheInstallationStatusConditionsOutput
}

type CheInstallationStatusConditionsArgs struct {
	// Last time the condition transit from one status to another.
	LastTransitionTime pulumi.StringPtrInput `pulumi:"lastTransitionTime"`
	// Human readable message indicating details about last transition.
	Message pulumi.StringPtrInput `pulumi:"message"`
	// (brief) reason for the condition's last transition.
	Reason pulumi.StringPtrInput `pulumi:"reason"`
	// Status of the condition, one of True, False, Unknown.
	Status pulumi.StringInput `pulumi:"status"`
	// Type of condition
	Type pulumi.StringInput `pulumi:"type"`
}

func (CheInstallationStatusConditionsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*CheInstallationStatusConditions)(nil)).Elem()
}

func (i CheInstallationStatusConditionsArgs) ToCheInstallationStatusConditionsOutput() CheInstallationStatusConditionsOutput {
	return i.ToCheInstallationStatusConditionsOutputWithContext(context.Background())
}

func (i CheInstallationStatusConditionsArgs) ToCheInstallationStatusConditionsOutputWithContext(ctx context.Context) CheInstallationStatusConditionsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CheInstallationStatusConditionsOutput)
}

// CheInstallationStatusConditionsArrayInput is an input type that accepts CheInstallationStatusConditionsArray and CheInstallationStatusConditionsArrayOutput values.
// You can construct a concrete instance of `CheInstallationStatusConditionsArrayInput` via:
//
//          CheInstallationStatusConditionsArray{ CheInstallationStatusConditionsArgs{...} }
type CheInstallationStatusConditionsArrayInput interface {
	pulumi.Input

	ToCheInstallationStatusConditionsArrayOutput() CheInstallationStatusConditionsArrayOutput
	ToCheInstallationStatusConditionsArrayOutputWithContext(context.Context) CheInstallationStatusConditionsArrayOutput
}

type CheInstallationStatusConditionsArray []CheInstallationStatusConditionsInput

func (CheInstallationStatusConditionsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]CheInstallationStatusConditions)(nil)).Elem()
}

func (i CheInstallationStatusConditionsArray) ToCheInstallationStatusConditionsArrayOutput() CheInstallationStatusConditionsArrayOutput {
	return i.ToCheInstallationStatusConditionsArrayOutputWithContext(context.Background())
}

func (i CheInstallationStatusConditionsArray) ToCheInstallationStatusConditionsArrayOutputWithContext(ctx context.Context) CheInstallationStatusConditionsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CheInstallationStatusConditionsArrayOutput)
}

type CheInstallationStatusConditionsOutput struct{ *pulumi.OutputState }

func (CheInstallationStatusConditionsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CheInstallationStatusConditions)(nil)).Elem()
}

func (o CheInstallationStatusConditionsOutput) ToCheInstallationStatusConditionsOutput() CheInstallationStatusConditionsOutput {
	return o
}

func (o CheInstallationStatusConditionsOutput) ToCheInstallationStatusConditionsOutputWithContext(ctx context.Context) CheInstallationStatusConditionsOutput {
	return o
}

// Last time the condition transit from one status to another.
func (o CheInstallationStatusConditionsOutput) LastTransitionTime() pulumi.StringPtrOutput {
	return o.ApplyT(func(v CheInstallationStatusConditions) *string { return v.LastTransitionTime }).(pulumi.StringPtrOutput)
}

// Human readable message indicating details about last transition.
func (o CheInstallationStatusConditionsOutput) Message() pulumi.StringPtrOutput {
	return o.ApplyT(func(v CheInstallationStatusConditions) *string { return v.Message }).(pulumi.StringPtrOutput)
}

// (brief) reason for the condition's last transition.
func (o CheInstallationStatusConditionsOutput) Reason() pulumi.StringPtrOutput {
	return o.ApplyT(func(v CheInstallationStatusConditions) *string { return v.Reason }).(pulumi.StringPtrOutput)
}

// Status of the condition, one of True, False, Unknown.
func (o CheInstallationStatusConditionsOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v CheInstallationStatusConditions) string { return v.Status }).(pulumi.StringOutput)
}

// Type of condition
func (o CheInstallationStatusConditionsOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v CheInstallationStatusConditions) string { return v.Type }).(pulumi.StringOutput)
}

type CheInstallationStatusConditionsArrayOutput struct{ *pulumi.OutputState }

func (CheInstallationStatusConditionsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]CheInstallationStatusConditions)(nil)).Elem()
}

func (o CheInstallationStatusConditionsArrayOutput) ToCheInstallationStatusConditionsArrayOutput() CheInstallationStatusConditionsArrayOutput {
	return o
}

func (o CheInstallationStatusConditionsArrayOutput) ToCheInstallationStatusConditionsArrayOutputWithContext(ctx context.Context) CheInstallationStatusConditionsArrayOutput {
	return o
}

func (o CheInstallationStatusConditionsArrayOutput) Index(i pulumi.IntInput) CheInstallationStatusConditionsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) CheInstallationStatusConditions {
		return vs[0].([]CheInstallationStatusConditions)[vs[1].(int)]
	}).(CheInstallationStatusConditionsOutput)
}

type TektonInstallationType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
}

// TektonInstallationTypeInput is an input type that accepts TektonInstallationTypeArgs and TektonInstallationTypeOutput values.
// You can construct a concrete instance of `TektonInstallationTypeInput` via:
//
//          TektonInstallationTypeArgs{...}
type TektonInstallationTypeInput interface {
	pulumi.Input

	ToTektonInstallationTypeOutput() TektonInstallationTypeOutput
	ToTektonInstallationTypeOutputWithContext(context.Context) TektonInstallationTypeOutput
}

type TektonInstallationTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
}

func (TektonInstallationTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*TektonInstallationType)(nil)).Elem()
}

func (i TektonInstallationTypeArgs) ToTektonInstallationTypeOutput() TektonInstallationTypeOutput {
	return i.ToTektonInstallationTypeOutputWithContext(context.Background())
}

func (i TektonInstallationTypeArgs) ToTektonInstallationTypeOutputWithContext(ctx context.Context) TektonInstallationTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TektonInstallationTypeOutput)
}

type TektonInstallationTypeOutput struct{ *pulumi.OutputState }

func (TektonInstallationTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TektonInstallationType)(nil)).Elem()
}

func (o TektonInstallationTypeOutput) ToTektonInstallationTypeOutput() TektonInstallationTypeOutput {
	return o
}

func (o TektonInstallationTypeOutput) ToTektonInstallationTypeOutputWithContext(ctx context.Context) TektonInstallationTypeOutput {
	return o
}

func (o TektonInstallationTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v TektonInstallationType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o TektonInstallationTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v TektonInstallationType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o TektonInstallationTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v TektonInstallationType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

type TektonInstallationMetadata struct {
}

// TektonInstallationMetadataInput is an input type that accepts TektonInstallationMetadataArgs and TektonInstallationMetadataOutput values.
// You can construct a concrete instance of `TektonInstallationMetadataInput` via:
//
//          TektonInstallationMetadataArgs{...}
type TektonInstallationMetadataInput interface {
	pulumi.Input

	ToTektonInstallationMetadataOutput() TektonInstallationMetadataOutput
	ToTektonInstallationMetadataOutputWithContext(context.Context) TektonInstallationMetadataOutput
}

type TektonInstallationMetadataArgs struct {
}

func (TektonInstallationMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*TektonInstallationMetadata)(nil)).Elem()
}

func (i TektonInstallationMetadataArgs) ToTektonInstallationMetadataOutput() TektonInstallationMetadataOutput {
	return i.ToTektonInstallationMetadataOutputWithContext(context.Background())
}

func (i TektonInstallationMetadataArgs) ToTektonInstallationMetadataOutputWithContext(ctx context.Context) TektonInstallationMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TektonInstallationMetadataOutput)
}

type TektonInstallationMetadataOutput struct{ *pulumi.OutputState }

func (TektonInstallationMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TektonInstallationMetadata)(nil)).Elem()
}

func (o TektonInstallationMetadataOutput) ToTektonInstallationMetadataOutput() TektonInstallationMetadataOutput {
	return o
}

func (o TektonInstallationMetadataOutput) ToTektonInstallationMetadataOutputWithContext(ctx context.Context) TektonInstallationMetadataOutput {
	return o
}

// TektonInstallationSpec defines the desired state of TektonInstallation
type TektonInstallationSpec struct {
}

// TektonInstallationSpecInput is an input type that accepts TektonInstallationSpecArgs and TektonInstallationSpecOutput values.
// You can construct a concrete instance of `TektonInstallationSpecInput` via:
//
//          TektonInstallationSpecArgs{...}
type TektonInstallationSpecInput interface {
	pulumi.Input

	ToTektonInstallationSpecOutput() TektonInstallationSpecOutput
	ToTektonInstallationSpecOutputWithContext(context.Context) TektonInstallationSpecOutput
}

// TektonInstallationSpec defines the desired state of TektonInstallation
type TektonInstallationSpecArgs struct {
}

func (TektonInstallationSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*TektonInstallationSpec)(nil)).Elem()
}

func (i TektonInstallationSpecArgs) ToTektonInstallationSpecOutput() TektonInstallationSpecOutput {
	return i.ToTektonInstallationSpecOutputWithContext(context.Background())
}

func (i TektonInstallationSpecArgs) ToTektonInstallationSpecOutputWithContext(ctx context.Context) TektonInstallationSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TektonInstallationSpecOutput)
}

// TektonInstallationSpec defines the desired state of TektonInstallation
type TektonInstallationSpecOutput struct{ *pulumi.OutputState }

func (TektonInstallationSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TektonInstallationSpec)(nil)).Elem()
}

func (o TektonInstallationSpecOutput) ToTektonInstallationSpecOutput() TektonInstallationSpecOutput {
	return o
}

func (o TektonInstallationSpecOutput) ToTektonInstallationSpecOutputWithContext(ctx context.Context) TektonInstallationSpecOutput {
	return o
}

// TektonInstallationStatus defines the observed state of TektonInstallation
type TektonInstallationStatus struct {
	// Last known condition of the OpenShift Pipelines operator installation. Supported condition types: TektonReady
	Conditions []TektonInstallationStatusConditions `pulumi:"conditions"`
}

// TektonInstallationStatusInput is an input type that accepts TektonInstallationStatusArgs and TektonInstallationStatusOutput values.
// You can construct a concrete instance of `TektonInstallationStatusInput` via:
//
//          TektonInstallationStatusArgs{...}
type TektonInstallationStatusInput interface {
	pulumi.Input

	ToTektonInstallationStatusOutput() TektonInstallationStatusOutput
	ToTektonInstallationStatusOutputWithContext(context.Context) TektonInstallationStatusOutput
}

// TektonInstallationStatus defines the observed state of TektonInstallation
type TektonInstallationStatusArgs struct {
	// Last known condition of the OpenShift Pipelines operator installation. Supported condition types: TektonReady
	Conditions TektonInstallationStatusConditionsArrayInput `pulumi:"conditions"`
}

func (TektonInstallationStatusArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*TektonInstallationStatus)(nil)).Elem()
}

func (i TektonInstallationStatusArgs) ToTektonInstallationStatusOutput() TektonInstallationStatusOutput {
	return i.ToTektonInstallationStatusOutputWithContext(context.Background())
}

func (i TektonInstallationStatusArgs) ToTektonInstallationStatusOutputWithContext(ctx context.Context) TektonInstallationStatusOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TektonInstallationStatusOutput)
}

// TektonInstallationStatus defines the observed state of TektonInstallation
type TektonInstallationStatusOutput struct{ *pulumi.OutputState }

func (TektonInstallationStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TektonInstallationStatus)(nil)).Elem()
}

func (o TektonInstallationStatusOutput) ToTektonInstallationStatusOutput() TektonInstallationStatusOutput {
	return o
}

func (o TektonInstallationStatusOutput) ToTektonInstallationStatusOutputWithContext(ctx context.Context) TektonInstallationStatusOutput {
	return o
}

// Last known condition of the OpenShift Pipelines operator installation. Supported condition types: TektonReady
func (o TektonInstallationStatusOutput) Conditions() TektonInstallationStatusConditionsArrayOutput {
	return o.ApplyT(func(v TektonInstallationStatus) []TektonInstallationStatusConditions { return v.Conditions }).(TektonInstallationStatusConditionsArrayOutput)
}

type TektonInstallationStatusConditions struct {
	// Last time the condition transit from one status to another.
	LastTransitionTime *string `pulumi:"lastTransitionTime"`
	// Human readable message indicating details about last transition.
	Message *string `pulumi:"message"`
	// (brief) reason for the condition's last transition.
	Reason *string `pulumi:"reason"`
	// Status of the condition, one of True, False, Unknown.
	Status string `pulumi:"status"`
	// Type of condition
	Type string `pulumi:"type"`
}

// TektonInstallationStatusConditionsInput is an input type that accepts TektonInstallationStatusConditionsArgs and TektonInstallationStatusConditionsOutput values.
// You can construct a concrete instance of `TektonInstallationStatusConditionsInput` via:
//
//          TektonInstallationStatusConditionsArgs{...}
type TektonInstallationStatusConditionsInput interface {
	pulumi.Input

	ToTektonInstallationStatusConditionsOutput() TektonInstallationStatusConditionsOutput
	ToTektonInstallationStatusConditionsOutputWithContext(context.Context) TektonInstallationStatusConditionsOutput
}

type TektonInstallationStatusConditionsArgs struct {
	// Last time the condition transit from one status to another.
	LastTransitionTime pulumi.StringPtrInput `pulumi:"lastTransitionTime"`
	// Human readable message indicating details about last transition.
	Message pulumi.StringPtrInput `pulumi:"message"`
	// (brief) reason for the condition's last transition.
	Reason pulumi.StringPtrInput `pulumi:"reason"`
	// Status of the condition, one of True, False, Unknown.
	Status pulumi.StringInput `pulumi:"status"`
	// Type of condition
	Type pulumi.StringInput `pulumi:"type"`
}

func (TektonInstallationStatusConditionsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*TektonInstallationStatusConditions)(nil)).Elem()
}

func (i TektonInstallationStatusConditionsArgs) ToTektonInstallationStatusConditionsOutput() TektonInstallationStatusConditionsOutput {
	return i.ToTektonInstallationStatusConditionsOutputWithContext(context.Background())
}

func (i TektonInstallationStatusConditionsArgs) ToTektonInstallationStatusConditionsOutputWithContext(ctx context.Context) TektonInstallationStatusConditionsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TektonInstallationStatusConditionsOutput)
}

// TektonInstallationStatusConditionsArrayInput is an input type that accepts TektonInstallationStatusConditionsArray and TektonInstallationStatusConditionsArrayOutput values.
// You can construct a concrete instance of `TektonInstallationStatusConditionsArrayInput` via:
//
//          TektonInstallationStatusConditionsArray{ TektonInstallationStatusConditionsArgs{...} }
type TektonInstallationStatusConditionsArrayInput interface {
	pulumi.Input

	ToTektonInstallationStatusConditionsArrayOutput() TektonInstallationStatusConditionsArrayOutput
	ToTektonInstallationStatusConditionsArrayOutputWithContext(context.Context) TektonInstallationStatusConditionsArrayOutput
}

type TektonInstallationStatusConditionsArray []TektonInstallationStatusConditionsInput

func (TektonInstallationStatusConditionsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]TektonInstallationStatusConditions)(nil)).Elem()
}

func (i TektonInstallationStatusConditionsArray) ToTektonInstallationStatusConditionsArrayOutput() TektonInstallationStatusConditionsArrayOutput {
	return i.ToTektonInstallationStatusConditionsArrayOutputWithContext(context.Background())
}

func (i TektonInstallationStatusConditionsArray) ToTektonInstallationStatusConditionsArrayOutputWithContext(ctx context.Context) TektonInstallationStatusConditionsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TektonInstallationStatusConditionsArrayOutput)
}

type TektonInstallationStatusConditionsOutput struct{ *pulumi.OutputState }

func (TektonInstallationStatusConditionsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TektonInstallationStatusConditions)(nil)).Elem()
}

func (o TektonInstallationStatusConditionsOutput) ToTektonInstallationStatusConditionsOutput() TektonInstallationStatusConditionsOutput {
	return o
}

func (o TektonInstallationStatusConditionsOutput) ToTektonInstallationStatusConditionsOutputWithContext(ctx context.Context) TektonInstallationStatusConditionsOutput {
	return o
}

// Last time the condition transit from one status to another.
func (o TektonInstallationStatusConditionsOutput) LastTransitionTime() pulumi.StringPtrOutput {
	return o.ApplyT(func(v TektonInstallationStatusConditions) *string { return v.LastTransitionTime }).(pulumi.StringPtrOutput)
}

// Human readable message indicating details about last transition.
func (o TektonInstallationStatusConditionsOutput) Message() pulumi.StringPtrOutput {
	return o.ApplyT(func(v TektonInstallationStatusConditions) *string { return v.Message }).(pulumi.StringPtrOutput)
}

// (brief) reason for the condition's last transition.
func (o TektonInstallationStatusConditionsOutput) Reason() pulumi.StringPtrOutput {
	return o.ApplyT(func(v TektonInstallationStatusConditions) *string { return v.Reason }).(pulumi.StringPtrOutput)
}

// Status of the condition, one of True, False, Unknown.
func (o TektonInstallationStatusConditionsOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v TektonInstallationStatusConditions) string { return v.Status }).(pulumi.StringOutput)
}

// Type of condition
func (o TektonInstallationStatusConditionsOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v TektonInstallationStatusConditions) string { return v.Type }).(pulumi.StringOutput)
}

type TektonInstallationStatusConditionsArrayOutput struct{ *pulumi.OutputState }

func (TektonInstallationStatusConditionsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]TektonInstallationStatusConditions)(nil)).Elem()
}

func (o TektonInstallationStatusConditionsArrayOutput) ToTektonInstallationStatusConditionsArrayOutput() TektonInstallationStatusConditionsArrayOutput {
	return o
}

func (o TektonInstallationStatusConditionsArrayOutput) ToTektonInstallationStatusConditionsArrayOutputWithContext(ctx context.Context) TektonInstallationStatusConditionsArrayOutput {
	return o
}

func (o TektonInstallationStatusConditionsArrayOutput) Index(i pulumi.IntInput) TektonInstallationStatusConditionsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) TektonInstallationStatusConditions {
		return vs[0].([]TektonInstallationStatusConditions)[vs[1].(int)]
	}).(TektonInstallationStatusConditionsOutput)
}

func init() {
	pulumi.RegisterOutputType(CheInstallationTypeOutput{})
	pulumi.RegisterOutputType(CheInstallationMetadataOutput{})
	pulumi.RegisterOutputType(CheInstallationSpecOutput{})
	pulumi.RegisterOutputType(CheInstallationSpecCheOperatorSpecOutput{})
	pulumi.RegisterOutputType(CheInstallationStatusOutput{})
	pulumi.RegisterOutputType(CheInstallationStatusConditionsOutput{})
	pulumi.RegisterOutputType(CheInstallationStatusConditionsArrayOutput{})
	pulumi.RegisterOutputType(TektonInstallationTypeOutput{})
	pulumi.RegisterOutputType(TektonInstallationMetadataOutput{})
	pulumi.RegisterOutputType(TektonInstallationSpecOutput{})
	pulumi.RegisterOutputType(TektonInstallationStatusOutput{})
	pulumi.RegisterOutputType(TektonInstallationStatusConditionsOutput{})
	pulumi.RegisterOutputType(TektonInstallationStatusConditionsArrayOutput{})
}