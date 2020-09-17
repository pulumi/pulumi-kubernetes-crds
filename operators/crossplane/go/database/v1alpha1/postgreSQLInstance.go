// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A PostgreSQLInstance is a portable resource claim that may be satisfied by binding to a PostgreSQL managed resource such as an AWS RDS instance or a GCP CloudSQL instance.
type PostgreSQLInstance struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// PostgreSQLInstanceSpec specifies the desired state of a PostgreSQLInstance. PostgreSQLInstance.
	Spec PostgreSQLInstanceSpecPtrOutput `pulumi:"spec"`
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status PostgreSQLInstanceStatusPtrOutput `pulumi:"status"`
}

// NewPostgreSQLInstance registers a new resource with the given unique name, arguments, and options.
func NewPostgreSQLInstance(ctx *pulumi.Context,
	name string, args *PostgreSQLInstanceArgs, opts ...pulumi.ResourceOption) (*PostgreSQLInstance, error) {
	if args == nil {
		args = &PostgreSQLInstanceArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("database.crossplane.io/v1alpha1")
	args.Kind = pulumi.StringPtr("PostgreSQLInstance")
	var resource PostgreSQLInstance
	err := ctx.RegisterResource("kubernetes:database.crossplane.io/v1alpha1:PostgreSQLInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPostgreSQLInstance gets an existing PostgreSQLInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPostgreSQLInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PostgreSQLInstanceState, opts ...pulumi.ResourceOption) (*PostgreSQLInstance, error) {
	var resource PostgreSQLInstance
	err := ctx.ReadResource("kubernetes:database.crossplane.io/v1alpha1:PostgreSQLInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PostgreSQLInstance resources.
type postgreSQLInstanceState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// PostgreSQLInstanceSpec specifies the desired state of a PostgreSQLInstance. PostgreSQLInstance.
	Spec *PostgreSQLInstanceSpec `pulumi:"spec"`
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status *PostgreSQLInstanceStatus `pulumi:"status"`
}

type PostgreSQLInstanceState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// PostgreSQLInstanceSpec specifies the desired state of a PostgreSQLInstance. PostgreSQLInstance.
	Spec PostgreSQLInstanceSpecPtrInput
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status PostgreSQLInstanceStatusPtrInput
}

func (PostgreSQLInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*postgreSQLInstanceState)(nil)).Elem()
}

type postgreSQLInstanceArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// PostgreSQLInstanceSpec specifies the desired state of a PostgreSQLInstance. PostgreSQLInstance.
	Spec *PostgreSQLInstanceSpec `pulumi:"spec"`
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status *PostgreSQLInstanceStatus `pulumi:"status"`
}

// The set of arguments for constructing a PostgreSQLInstance resource.
type PostgreSQLInstanceArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// PostgreSQLInstanceSpec specifies the desired state of a PostgreSQLInstance. PostgreSQLInstance.
	Spec PostgreSQLInstanceSpecPtrInput
	// A ResourceClaimStatus represents the observed status of a resource claim.
	Status PostgreSQLInstanceStatusPtrInput
}

func (PostgreSQLInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*postgreSQLInstanceArgs)(nil)).Elem()
}