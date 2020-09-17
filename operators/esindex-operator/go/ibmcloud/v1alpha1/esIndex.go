// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type EsIndex struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	Spec       EsIndexSpecPtrOutput       `pulumi:"spec"`
	Status     EsIndexStatusPtrOutput     `pulumi:"status"`
}

// NewEsIndex registers a new resource with the given unique name, arguments, and options.
func NewEsIndex(ctx *pulumi.Context,
	name string, args *EsIndexArgs, opts ...pulumi.ResourceOption) (*EsIndex, error) {
	if args == nil {
		args = &EsIndexArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("ibmcloud.ibm.com/v1alpha1")
	args.Kind = pulumi.StringPtr("EsIndex")
	var resource EsIndex
	err := ctx.RegisterResource("kubernetes:ibmcloud.ibm.com/v1alpha1:EsIndex", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEsIndex gets an existing EsIndex resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEsIndex(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EsIndexState, opts ...pulumi.ResourceOption) (*EsIndex, error) {
	var resource EsIndex
	err := ctx.ReadResource("kubernetes:ibmcloud.ibm.com/v1alpha1:EsIndex", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EsIndex resources.
type esIndexState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       *EsIndexSpec       `pulumi:"spec"`
	Status     *EsIndexStatus     `pulumi:"status"`
}

type EsIndexState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       EsIndexSpecPtrInput
	Status     EsIndexStatusPtrInput
}

func (EsIndexState) ElementType() reflect.Type {
	return reflect.TypeOf((*esIndexState)(nil)).Elem()
}

type esIndexArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	Spec       *EsIndexSpec       `pulumi:"spec"`
	Status     *EsIndexStatus     `pulumi:"status"`
}

// The set of arguments for constructing a EsIndex resource.
type EsIndexArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	Spec       EsIndexSpecPtrInput
	Status     EsIndexStatusPtrInput
}

func (EsIndexArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*esIndexArgs)(nil)).Elem()
}