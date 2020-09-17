// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A MySQLInstance is a portable resource claim that may be satisfied by binding to a MySQL managed resource such as an AWS RDS instance or a GCP CloudSQL instance.
type MySQLInstance struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// MySQLInstanceSpec specifies the desired state of a MySQLInstance.
	Spec MySQLInstanceSpecPtrOutput `pulumi:"spec"`
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status MySQLInstanceStatusPtrOutput `pulumi:"status"`
}

// NewMySQLInstance registers a new resource with the given unique name, arguments, and options.
func NewMySQLInstance(ctx *pulumi.Context,
	name string, args *MySQLInstanceArgs, opts ...pulumi.ResourceOption) (*MySQLInstance, error) {
	if args == nil {
		args = &MySQLInstanceArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("database.crossplane.io/v1alpha1")
	args.Kind = pulumi.StringPtr("MySQLInstance")
	var resource MySQLInstance
	err := ctx.RegisterResource("kubernetes:database.crossplane.io/v1alpha1:MySQLInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMySQLInstance gets an existing MySQLInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMySQLInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MySQLInstanceState, opts ...pulumi.ResourceOption) (*MySQLInstance, error) {
	var resource MySQLInstance
	err := ctx.ReadResource("kubernetes:database.crossplane.io/v1alpha1:MySQLInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MySQLInstance resources.
type mySQLInstanceState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// MySQLInstanceSpec specifies the desired state of a MySQLInstance.
	Spec *MySQLInstanceSpec `pulumi:"spec"`
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status *MySQLInstanceStatus `pulumi:"status"`
}

type MySQLInstanceState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// MySQLInstanceSpec specifies the desired state of a MySQLInstance.
	Spec MySQLInstanceSpecPtrInput
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status MySQLInstanceStatusPtrInput
}

func (MySQLInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*mySQLInstanceState)(nil)).Elem()
}

type mySQLInstanceArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// MySQLInstanceSpec specifies the desired state of a MySQLInstance.
	Spec *MySQLInstanceSpec `pulumi:"spec"`
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status *MySQLInstanceStatus `pulumi:"status"`
}

// The set of arguments for constructing a MySQLInstance resource.
type MySQLInstanceArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// MySQLInstanceSpec specifies the desired state of a MySQLInstance.
	Spec MySQLInstanceSpecPtrInput
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status MySQLInstanceStatusPtrInput
}

func (MySQLInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mySQLInstanceArgs)(nil)).Elem()
}
