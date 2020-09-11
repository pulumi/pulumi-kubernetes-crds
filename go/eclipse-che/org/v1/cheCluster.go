// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type CheCluster struct {
	pulumi.CustomResourceState

	ApiVersion pulumi.StringPtrOutput     `pulumi:"apiVersion"`
	Kind       pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata   metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// Desired configuration of the Che installation. Based on these settings, the operator automatically creates and maintains several config maps that will contain the appropriate environment variables the various components of the Che installation. These generated config maps should NOT be updated manually.
	Spec CheClusterSpecPtrOutput `pulumi:"spec"`
	// CheClusterStatus defines the observed state of Che installation
	Status CheClusterStatusPtrOutput `pulumi:"status"`
}

// NewCheCluster registers a new resource with the given unique name, arguments, and options.
func NewCheCluster(ctx *pulumi.Context,
	name string, args *CheClusterArgs, opts ...pulumi.ResourceOption) (*CheCluster, error) {
	if args == nil {
		args = &CheClusterArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("org.eclipse.che/v1")
	args.Kind = pulumi.StringPtr("CheCluster")
	var resource CheCluster
	err := ctx.RegisterResource("kubernetes:org.eclipse.che/v1:CheCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCheCluster gets an existing CheCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCheCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CheClusterState, opts ...pulumi.ResourceOption) (*CheCluster, error) {
	var resource CheCluster
	err := ctx.ReadResource("kubernetes:org.eclipse.che/v1:CheCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CheCluster resources.
type cheClusterState struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// Desired configuration of the Che installation. Based on these settings, the operator automatically creates and maintains several config maps that will contain the appropriate environment variables the various components of the Che installation. These generated config maps should NOT be updated manually.
	Spec *CheClusterSpec `pulumi:"spec"`
	// CheClusterStatus defines the observed state of Che installation
	Status *CheClusterStatus `pulumi:"status"`
}

type CheClusterState struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// Desired configuration of the Che installation. Based on these settings, the operator automatically creates and maintains several config maps that will contain the appropriate environment variables the various components of the Che installation. These generated config maps should NOT be updated manually.
	Spec CheClusterSpecPtrInput
	// CheClusterStatus defines the observed state of Che installation
	Status CheClusterStatusPtrInput
}

func (CheClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*cheClusterState)(nil)).Elem()
}

type cheClusterArgs struct {
	ApiVersion *string            `pulumi:"apiVersion"`
	Kind       *string            `pulumi:"kind"`
	Metadata   *metav1.ObjectMeta `pulumi:"metadata"`
	// Desired configuration of the Che installation. Based on these settings, the operator automatically creates and maintains several config maps that will contain the appropriate environment variables the various components of the Che installation. These generated config maps should NOT be updated manually.
	Spec *CheClusterSpec `pulumi:"spec"`
	// CheClusterStatus defines the observed state of Che installation
	Status *CheClusterStatus `pulumi:"status"`
}

// The set of arguments for constructing a CheCluster resource.
type CheClusterArgs struct {
	ApiVersion pulumi.StringPtrInput
	Kind       pulumi.StringPtrInput
	Metadata   metav1.ObjectMetaPtrInput
	// Desired configuration of the Che installation. Based on these settings, the operator automatically creates and maintains several config maps that will contain the appropriate environment variables the various components of the Che installation. These generated config maps should NOT be updated manually.
	Spec CheClusterSpecPtrInput
	// CheClusterStatus defines the observed state of Che installation
	Status CheClusterStatusPtrInput
}

func (CheClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*cheClusterArgs)(nil)).Elem()
}
