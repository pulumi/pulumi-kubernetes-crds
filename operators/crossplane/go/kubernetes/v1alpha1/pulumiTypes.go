// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A Provider configures a Kubernetes 'provider', i.e. a connection to a particular Kubernetes cluster using the referenced Secret.
type ProviderType struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// A ProviderSpec defines the desired state of a Provider.
	Spec *ProviderSpec `pulumi:"spec"`
}

// ProviderTypeInput is an input type that accepts ProviderTypeArgs and ProviderTypeOutput values.
// You can construct a concrete instance of `ProviderTypeInput` via:
//
//          ProviderTypeArgs{...}
type ProviderTypeInput interface {
	pulumi.Input

	ToProviderTypeOutput() ProviderTypeOutput
	ToProviderTypeOutputWithContext(context.Context) ProviderTypeOutput
}

// A Provider configures a Kubernetes 'provider', i.e. a connection to a particular Kubernetes cluster using the referenced Secret.
type ProviderTypeArgs struct {
	ApiVersion pulumi.StringPtrInput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrInput `pulumi:"metadata"`
	// A ProviderSpec defines the desired state of a Provider.
	Spec ProviderSpecPtrInput `pulumi:"spec"`
}

func (ProviderTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ProviderType)(nil)).Elem()
}

func (i ProviderTypeArgs) ToProviderTypeOutput() ProviderTypeOutput {
	return i.ToProviderTypeOutputWithContext(context.Background())
}

func (i ProviderTypeArgs) ToProviderTypeOutputWithContext(ctx context.Context) ProviderTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderTypeOutput)
}

// A Provider configures a Kubernetes 'provider', i.e. a connection to a particular Kubernetes cluster using the referenced Secret.
type ProviderTypeOutput struct{ *pulumi.OutputState }

func (ProviderTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ProviderType)(nil)).Elem()
}

func (o ProviderTypeOutput) ToProviderTypeOutput() ProviderTypeOutput {
	return o
}

func (o ProviderTypeOutput) ToProviderTypeOutputWithContext(ctx context.Context) ProviderTypeOutput {
	return o
}

func (o ProviderTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ProviderType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

func (o ProviderTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ProviderType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o ProviderTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v ProviderType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

// A ProviderSpec defines the desired state of a Provider.
func (o ProviderTypeOutput) Spec() ProviderSpecPtrOutput {
	return o.ApplyT(func(v ProviderType) *ProviderSpec { return v.Spec }).(ProviderSpecPtrOutput)
}

type ProviderMetadata struct {
}

// ProviderMetadataInput is an input type that accepts ProviderMetadataArgs and ProviderMetadataOutput values.
// You can construct a concrete instance of `ProviderMetadataInput` via:
//
//          ProviderMetadataArgs{...}
type ProviderMetadataInput interface {
	pulumi.Input

	ToProviderMetadataOutput() ProviderMetadataOutput
	ToProviderMetadataOutputWithContext(context.Context) ProviderMetadataOutput
}

type ProviderMetadataArgs struct {
}

func (ProviderMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ProviderMetadata)(nil)).Elem()
}

func (i ProviderMetadataArgs) ToProviderMetadataOutput() ProviderMetadataOutput {
	return i.ToProviderMetadataOutputWithContext(context.Background())
}

func (i ProviderMetadataArgs) ToProviderMetadataOutputWithContext(ctx context.Context) ProviderMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderMetadataOutput)
}

type ProviderMetadataOutput struct{ *pulumi.OutputState }

func (ProviderMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ProviderMetadata)(nil)).Elem()
}

func (o ProviderMetadataOutput) ToProviderMetadataOutput() ProviderMetadataOutput {
	return o
}

func (o ProviderMetadataOutput) ToProviderMetadataOutputWithContext(ctx context.Context) ProviderMetadataOutput {
	return o
}

// A ProviderSpec defines the desired state of a Provider.
type ProviderSpec struct {
	// A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
	CredentialsSecretRef ProviderSpecCredentialsSecretRef `pulumi:"credentialsSecretRef"`
}

// ProviderSpecInput is an input type that accepts ProviderSpecArgs and ProviderSpecOutput values.
// You can construct a concrete instance of `ProviderSpecInput` via:
//
//          ProviderSpecArgs{...}
type ProviderSpecInput interface {
	pulumi.Input

	ToProviderSpecOutput() ProviderSpecOutput
	ToProviderSpecOutputWithContext(context.Context) ProviderSpecOutput
}

// A ProviderSpec defines the desired state of a Provider.
type ProviderSpecArgs struct {
	// A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
	CredentialsSecretRef ProviderSpecCredentialsSecretRefInput `pulumi:"credentialsSecretRef"`
}

func (ProviderSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ProviderSpec)(nil)).Elem()
}

func (i ProviderSpecArgs) ToProviderSpecOutput() ProviderSpecOutput {
	return i.ToProviderSpecOutputWithContext(context.Background())
}

func (i ProviderSpecArgs) ToProviderSpecOutputWithContext(ctx context.Context) ProviderSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderSpecOutput)
}

func (i ProviderSpecArgs) ToProviderSpecPtrOutput() ProviderSpecPtrOutput {
	return i.ToProviderSpecPtrOutputWithContext(context.Background())
}

func (i ProviderSpecArgs) ToProviderSpecPtrOutputWithContext(ctx context.Context) ProviderSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderSpecOutput).ToProviderSpecPtrOutputWithContext(ctx)
}

// ProviderSpecPtrInput is an input type that accepts ProviderSpecArgs, ProviderSpecPtr and ProviderSpecPtrOutput values.
// You can construct a concrete instance of `ProviderSpecPtrInput` via:
//
//          ProviderSpecArgs{...}
//
//  or:
//
//          nil
type ProviderSpecPtrInput interface {
	pulumi.Input

	ToProviderSpecPtrOutput() ProviderSpecPtrOutput
	ToProviderSpecPtrOutputWithContext(context.Context) ProviderSpecPtrOutput
}

type providerSpecPtrType ProviderSpecArgs

func ProviderSpecPtr(v *ProviderSpecArgs) ProviderSpecPtrInput {
	return (*providerSpecPtrType)(v)
}

func (*providerSpecPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ProviderSpec)(nil)).Elem()
}

func (i *providerSpecPtrType) ToProviderSpecPtrOutput() ProviderSpecPtrOutput {
	return i.ToProviderSpecPtrOutputWithContext(context.Background())
}

func (i *providerSpecPtrType) ToProviderSpecPtrOutputWithContext(ctx context.Context) ProviderSpecPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderSpecPtrOutput)
}

// A ProviderSpec defines the desired state of a Provider.
type ProviderSpecOutput struct{ *pulumi.OutputState }

func (ProviderSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ProviderSpec)(nil)).Elem()
}

func (o ProviderSpecOutput) ToProviderSpecOutput() ProviderSpecOutput {
	return o
}

func (o ProviderSpecOutput) ToProviderSpecOutputWithContext(ctx context.Context) ProviderSpecOutput {
	return o
}

func (o ProviderSpecOutput) ToProviderSpecPtrOutput() ProviderSpecPtrOutput {
	return o.ToProviderSpecPtrOutputWithContext(context.Background())
}

func (o ProviderSpecOutput) ToProviderSpecPtrOutputWithContext(ctx context.Context) ProviderSpecPtrOutput {
	return o.ApplyT(func(v ProviderSpec) *ProviderSpec {
		return &v
	}).(ProviderSpecPtrOutput)
}

// A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
func (o ProviderSpecOutput) CredentialsSecretRef() ProviderSpecCredentialsSecretRefOutput {
	return o.ApplyT(func(v ProviderSpec) ProviderSpecCredentialsSecretRef { return v.CredentialsSecretRef }).(ProviderSpecCredentialsSecretRefOutput)
}

type ProviderSpecPtrOutput struct{ *pulumi.OutputState }

func (ProviderSpecPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ProviderSpec)(nil)).Elem()
}

func (o ProviderSpecPtrOutput) ToProviderSpecPtrOutput() ProviderSpecPtrOutput {
	return o
}

func (o ProviderSpecPtrOutput) ToProviderSpecPtrOutputWithContext(ctx context.Context) ProviderSpecPtrOutput {
	return o
}

func (o ProviderSpecPtrOutput) Elem() ProviderSpecOutput {
	return o.ApplyT(func(v *ProviderSpec) ProviderSpec { return *v }).(ProviderSpecOutput)
}

// A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
func (o ProviderSpecPtrOutput) CredentialsSecretRef() ProviderSpecCredentialsSecretRefPtrOutput {
	return o.ApplyT(func(v *ProviderSpec) *ProviderSpecCredentialsSecretRef {
		if v == nil {
			return nil
		}
		return &v.CredentialsSecretRef
	}).(ProviderSpecCredentialsSecretRefPtrOutput)
}

// A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
type ProviderSpecCredentialsSecretRef struct {
	// Name of the secret.
	Name string `pulumi:"name"`
	// Namespace of the secret.
	Namespace string `pulumi:"namespace"`
}

// ProviderSpecCredentialsSecretRefInput is an input type that accepts ProviderSpecCredentialsSecretRefArgs and ProviderSpecCredentialsSecretRefOutput values.
// You can construct a concrete instance of `ProviderSpecCredentialsSecretRefInput` via:
//
//          ProviderSpecCredentialsSecretRefArgs{...}
type ProviderSpecCredentialsSecretRefInput interface {
	pulumi.Input

	ToProviderSpecCredentialsSecretRefOutput() ProviderSpecCredentialsSecretRefOutput
	ToProviderSpecCredentialsSecretRefOutputWithContext(context.Context) ProviderSpecCredentialsSecretRefOutput
}

// A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
type ProviderSpecCredentialsSecretRefArgs struct {
	// Name of the secret.
	Name pulumi.StringInput `pulumi:"name"`
	// Namespace of the secret.
	Namespace pulumi.StringInput `pulumi:"namespace"`
}

func (ProviderSpecCredentialsSecretRefArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ProviderSpecCredentialsSecretRef)(nil)).Elem()
}

func (i ProviderSpecCredentialsSecretRefArgs) ToProviderSpecCredentialsSecretRefOutput() ProviderSpecCredentialsSecretRefOutput {
	return i.ToProviderSpecCredentialsSecretRefOutputWithContext(context.Background())
}

func (i ProviderSpecCredentialsSecretRefArgs) ToProviderSpecCredentialsSecretRefOutputWithContext(ctx context.Context) ProviderSpecCredentialsSecretRefOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderSpecCredentialsSecretRefOutput)
}

func (i ProviderSpecCredentialsSecretRefArgs) ToProviderSpecCredentialsSecretRefPtrOutput() ProviderSpecCredentialsSecretRefPtrOutput {
	return i.ToProviderSpecCredentialsSecretRefPtrOutputWithContext(context.Background())
}

func (i ProviderSpecCredentialsSecretRefArgs) ToProviderSpecCredentialsSecretRefPtrOutputWithContext(ctx context.Context) ProviderSpecCredentialsSecretRefPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderSpecCredentialsSecretRefOutput).ToProviderSpecCredentialsSecretRefPtrOutputWithContext(ctx)
}

// ProviderSpecCredentialsSecretRefPtrInput is an input type that accepts ProviderSpecCredentialsSecretRefArgs, ProviderSpecCredentialsSecretRefPtr and ProviderSpecCredentialsSecretRefPtrOutput values.
// You can construct a concrete instance of `ProviderSpecCredentialsSecretRefPtrInput` via:
//
//          ProviderSpecCredentialsSecretRefArgs{...}
//
//  or:
//
//          nil
type ProviderSpecCredentialsSecretRefPtrInput interface {
	pulumi.Input

	ToProviderSpecCredentialsSecretRefPtrOutput() ProviderSpecCredentialsSecretRefPtrOutput
	ToProviderSpecCredentialsSecretRefPtrOutputWithContext(context.Context) ProviderSpecCredentialsSecretRefPtrOutput
}

type providerSpecCredentialsSecretRefPtrType ProviderSpecCredentialsSecretRefArgs

func ProviderSpecCredentialsSecretRefPtr(v *ProviderSpecCredentialsSecretRefArgs) ProviderSpecCredentialsSecretRefPtrInput {
	return (*providerSpecCredentialsSecretRefPtrType)(v)
}

func (*providerSpecCredentialsSecretRefPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ProviderSpecCredentialsSecretRef)(nil)).Elem()
}

func (i *providerSpecCredentialsSecretRefPtrType) ToProviderSpecCredentialsSecretRefPtrOutput() ProviderSpecCredentialsSecretRefPtrOutput {
	return i.ToProviderSpecCredentialsSecretRefPtrOutputWithContext(context.Background())
}

func (i *providerSpecCredentialsSecretRefPtrType) ToProviderSpecCredentialsSecretRefPtrOutputWithContext(ctx context.Context) ProviderSpecCredentialsSecretRefPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderSpecCredentialsSecretRefPtrOutput)
}

// A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
type ProviderSpecCredentialsSecretRefOutput struct{ *pulumi.OutputState }

func (ProviderSpecCredentialsSecretRefOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ProviderSpecCredentialsSecretRef)(nil)).Elem()
}

func (o ProviderSpecCredentialsSecretRefOutput) ToProviderSpecCredentialsSecretRefOutput() ProviderSpecCredentialsSecretRefOutput {
	return o
}

func (o ProviderSpecCredentialsSecretRefOutput) ToProviderSpecCredentialsSecretRefOutputWithContext(ctx context.Context) ProviderSpecCredentialsSecretRefOutput {
	return o
}

func (o ProviderSpecCredentialsSecretRefOutput) ToProviderSpecCredentialsSecretRefPtrOutput() ProviderSpecCredentialsSecretRefPtrOutput {
	return o.ToProviderSpecCredentialsSecretRefPtrOutputWithContext(context.Background())
}

func (o ProviderSpecCredentialsSecretRefOutput) ToProviderSpecCredentialsSecretRefPtrOutputWithContext(ctx context.Context) ProviderSpecCredentialsSecretRefPtrOutput {
	return o.ApplyT(func(v ProviderSpecCredentialsSecretRef) *ProviderSpecCredentialsSecretRef {
		return &v
	}).(ProviderSpecCredentialsSecretRefPtrOutput)
}

// Name of the secret.
func (o ProviderSpecCredentialsSecretRefOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v ProviderSpecCredentialsSecretRef) string { return v.Name }).(pulumi.StringOutput)
}

// Namespace of the secret.
func (o ProviderSpecCredentialsSecretRefOutput) Namespace() pulumi.StringOutput {
	return o.ApplyT(func(v ProviderSpecCredentialsSecretRef) string { return v.Namespace }).(pulumi.StringOutput)
}

type ProviderSpecCredentialsSecretRefPtrOutput struct{ *pulumi.OutputState }

func (ProviderSpecCredentialsSecretRefPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ProviderSpecCredentialsSecretRef)(nil)).Elem()
}

func (o ProviderSpecCredentialsSecretRefPtrOutput) ToProviderSpecCredentialsSecretRefPtrOutput() ProviderSpecCredentialsSecretRefPtrOutput {
	return o
}

func (o ProviderSpecCredentialsSecretRefPtrOutput) ToProviderSpecCredentialsSecretRefPtrOutputWithContext(ctx context.Context) ProviderSpecCredentialsSecretRefPtrOutput {
	return o
}

func (o ProviderSpecCredentialsSecretRefPtrOutput) Elem() ProviderSpecCredentialsSecretRefOutput {
	return o.ApplyT(func(v *ProviderSpecCredentialsSecretRef) ProviderSpecCredentialsSecretRef { return *v }).(ProviderSpecCredentialsSecretRefOutput)
}

// Name of the secret.
func (o ProviderSpecCredentialsSecretRefPtrOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProviderSpecCredentialsSecretRef) *string {
		if v == nil {
			return nil
		}
		return &v.Name
	}).(pulumi.StringPtrOutput)
}

// Namespace of the secret.
func (o ProviderSpecCredentialsSecretRefPtrOutput) Namespace() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProviderSpecCredentialsSecretRef) *string {
		if v == nil {
			return nil
		}
		return &v.Namespace
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(ProviderTypeOutput{})
	pulumi.RegisterOutputType(ProviderMetadataOutput{})
	pulumi.RegisterOutputType(ProviderSpecOutput{})
	pulumi.RegisterOutputType(ProviderSpecPtrOutput{})
	pulumi.RegisterOutputType(ProviderSpecCredentialsSecretRefOutput{})
	pulumi.RegisterOutputType(ProviderSpecCredentialsSecretRefPtrOutput{})
}