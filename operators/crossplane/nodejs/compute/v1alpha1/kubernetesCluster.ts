// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * A KubernetesCluster is a portable resource claim that may be satisfied by binding to a Kubernetes cluster managed resource such as an AWS EKS cluster or an Azure AKS cluster.
 */
export class KubernetesCluster extends pulumi.CustomResource {
    /**
     * Get an existing KubernetesCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): KubernetesCluster {
        return new KubernetesCluster(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:compute.crossplane.io/v1alpha1:KubernetesCluster';

    /**
     * Returns true if the given object is an instance of KubernetesCluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KubernetesCluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KubernetesCluster.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"compute.crossplane.io/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"KubernetesCluster" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * KubernetesClusterSpec specifies the desired state of a KubernetesCluster.
     */
    public readonly spec!: pulumi.Output<outputs.compute.v1alpha1.KubernetesClusterSpec | undefined>;
    /**
     * A ResourceClaimStatus represents the observed status of a resource claim.
     */
    public readonly status!: pulumi.Output<outputs.compute.v1alpha1.KubernetesClusterStatus | undefined>;

    /**
     * Create a KubernetesCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: KubernetesClusterArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "compute.crossplane.io/v1alpha1";
            inputs["kind"] = "KubernetesCluster";
            inputs["metadata"] = args ? args.metadata : undefined;
            inputs["spec"] = args ? args.spec : undefined;
            inputs["status"] = args ? args.status : undefined;
        } else {
            inputs["apiVersion"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["metadata"] = undefined /*out*/;
            inputs["spec"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(KubernetesCluster.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a KubernetesCluster resource.
 */
export interface KubernetesClusterArgs {
    readonly apiVersion?: pulumi.Input<"compute.crossplane.io/v1alpha1">;
    readonly kind?: pulumi.Input<"KubernetesCluster">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * KubernetesClusterSpec specifies the desired state of a KubernetesCluster.
     */
    readonly spec?: pulumi.Input<inputs.compute.v1alpha1.KubernetesClusterSpec>;
    /**
     * A ResourceClaimStatus represents the observed status of a resource claim.
     */
    readonly status?: pulumi.Input<inputs.compute.v1alpha1.KubernetesClusterStatus>;
}