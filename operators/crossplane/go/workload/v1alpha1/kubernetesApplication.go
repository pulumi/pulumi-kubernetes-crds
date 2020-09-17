// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A KubernetesApplication defines an application deployed by Crossplane to a Kubernetes cluster, i.e. a portable KubernetesCluster resource claim.
type KubernetesApplication struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// A KubernetesApplicationSpec specifies the resources of a Kubernetes application.
	Spec KubernetesApplicationSpecPtrOutput `pulumi:"spec"`
	// KubernetesApplicationStatus represents the observed state of a KubernetesApplication.
	Status KubernetesApplicationStatusPtrOutput `pulumi:"status"`
}

// NewKubernetesApplication registers a new resource with the given unique name, arguments, and options.
func NewKubernetesApplication(ctx *pulumi.Context,
	name string, args *KubernetesApplicationArgs, opts ...pulumi.ResourceOption) (*KubernetesApplication, error) {
	if args == nil {
		args = &KubernetesApplicationArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("workload.crossplane.io/v1alpha1")
	args.Kind = pulumi.StringPtr("KubernetesApplication")
	var resource KubernetesApplication
	err := ctx.RegisterResource("kubernetes:workload.crossplane.io/v1alpha1:KubernetesApplication", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetKubernetesApplication gets an existing KubernetesApplication resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKubernetesApplication(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *KubernetesApplicationState, opts ...pulumi.ResourceOption) (*KubernetesApplication, error) {
	var resource KubernetesApplication
	err := ctx.ReadResource("kubernetes:workload.crossplane.io/v1alpha1:KubernetesApplication", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering KubernetesApplication resources.
type kubernetesApplicationState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// A KubernetesApplicationSpec specifies the resources of a Kubernetes application.
	Spec *KubernetesApplicationSpec `pulumi:"spec"`
	// KubernetesApplicationStatus represents the observed state of a KubernetesApplication.
	Status *KubernetesApplicationStatus `pulumi:"status"`
}

type KubernetesApplicationState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// A KubernetesApplicationSpec specifies the resources of a Kubernetes application.
	Spec KubernetesApplicationSpecPtrInput
	// KubernetesApplicationStatus represents the observed state of a KubernetesApplication.
	Status KubernetesApplicationStatusPtrInput
}

func (KubernetesApplicationState) ElementType() reflect.Type {
	return reflect.TypeOf((*kubernetesApplicationState)(nil)).Elem()
}

type kubernetesApplicationArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// A KubernetesApplicationSpec specifies the resources of a Kubernetes application.
	Spec *KubernetesApplicationSpec `pulumi:"spec"`
	// KubernetesApplicationStatus represents the observed state of a KubernetesApplication.
	Status *KubernetesApplicationStatus `pulumi:"status"`
}

// The set of arguments for constructing a KubernetesApplication resource.
type KubernetesApplicationArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// A KubernetesApplicationSpec specifies the resources of a Kubernetes application.
	Spec KubernetesApplicationSpecPtrInput
	// KubernetesApplicationStatus represents the observed state of a KubernetesApplication.
	Status KubernetesApplicationStatusPtrInput
}

func (KubernetesApplicationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*kubernetesApplicationArgs)(nil)).Elem()
}