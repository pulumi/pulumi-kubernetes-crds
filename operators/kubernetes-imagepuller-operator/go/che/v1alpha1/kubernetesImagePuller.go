// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// KubernetesImagePuller is the Schema for the kubernetesimagepullers API
type KubernetesImagePuller struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// KubernetesImagePullerSpec defines the desired state of KubernetesImagePuller
	Spec KubernetesImagePullerSpecPtrOutput `pulumi:"spec"`
	// KubernetesImagePullerStatus defines the observed state of KubernetesImagePuller
	Status pulumi.MapOutput `pulumi:"status"`
}

// NewKubernetesImagePuller registers a new resource with the given unique name, arguments, and options.
func NewKubernetesImagePuller(ctx *pulumi.Context,
	name string, args *KubernetesImagePullerArgs, opts ...pulumi.ResourceOption) (*KubernetesImagePuller, error) {
	if args == nil {
		args = &KubernetesImagePullerArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("che.eclipse.org/v1alpha1")
	args.Kind = pulumi.StringPtr("KubernetesImagePuller")
	var resource KubernetesImagePuller
	err := ctx.RegisterResource("kubernetes:che.eclipse.org/v1alpha1:KubernetesImagePuller", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetKubernetesImagePuller gets an existing KubernetesImagePuller resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKubernetesImagePuller(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *KubernetesImagePullerState, opts ...pulumi.ResourceOption) (*KubernetesImagePuller, error) {
	var resource KubernetesImagePuller
	err := ctx.ReadResource("kubernetes:che.eclipse.org/v1alpha1:KubernetesImagePuller", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering KubernetesImagePuller resources.
type kubernetesImagePullerState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KubernetesImagePullerSpec defines the desired state of KubernetesImagePuller
	Spec *KubernetesImagePullerSpec `pulumi:"spec"`
	// KubernetesImagePullerStatus defines the observed state of KubernetesImagePuller
	Status map[string]interface{} `pulumi:"status"`
}

type KubernetesImagePullerState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KubernetesImagePullerSpec defines the desired state of KubernetesImagePuller
	Spec KubernetesImagePullerSpecPtrInput
	// KubernetesImagePullerStatus defines the observed state of KubernetesImagePuller
	Status pulumi.MapInput
}

func (KubernetesImagePullerState) ElementType() reflect.Type {
	return reflect.TypeOf((*kubernetesImagePullerState)(nil)).Elem()
}

type kubernetesImagePullerArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// KubernetesImagePullerSpec defines the desired state of KubernetesImagePuller
	Spec *KubernetesImagePullerSpec `pulumi:"spec"`
	// KubernetesImagePullerStatus defines the observed state of KubernetesImagePuller
	Status map[string]interface{} `pulumi:"status"`
}

// The set of arguments for constructing a KubernetesImagePuller resource.
type KubernetesImagePullerArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// KubernetesImagePullerSpec defines the desired state of KubernetesImagePuller
	Spec KubernetesImagePullerSpecPtrInput
	// KubernetesImagePullerStatus defines the observed state of KubernetesImagePuller
	Status pulumi.MapInput
}

func (KubernetesImagePullerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*kubernetesImagePullerArgs)(nil)).Elem()
}
