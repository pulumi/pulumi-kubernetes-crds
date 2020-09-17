// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * ClusterPool represents a pool of clusters that should be kept ready to be given out to users. Clusters are removed from the pool once claimed and then automatically replaced with a new one.
 */
export class ClusterPool extends pulumi.CustomResource {
    /**
     * Get an existing ClusterPool resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ClusterPool {
        return new ClusterPool(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:hive.openshift.io/v1:ClusterPool';

    /**
     * Returns true if the given object is an instance of ClusterPool.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ClusterPool {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ClusterPool.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"hive.openshift.io/v1" | undefined>;
    public readonly kind!: pulumi.Output<"ClusterPool" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * ClusterPoolSpec defines the desired state of the ClusterPool.
     */
    public readonly spec!: pulumi.Output<outputs.hive.v1.ClusterPoolSpec>;
    /**
     * ClusterPoolStatus defines the observed state of ClusterPool
     */
    public readonly status!: pulumi.Output<outputs.hive.v1.ClusterPoolStatus | undefined>;

    /**
     * Create a ClusterPool resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ClusterPoolArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "hive.openshift.io/v1";
            inputs["kind"] = "ClusterPool";
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
        super(ClusterPool.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ClusterPool resource.
 */
export interface ClusterPoolArgs {
    readonly apiVersion?: pulumi.Input<"hive.openshift.io/v1">;
    readonly kind?: pulumi.Input<"ClusterPool">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * ClusterPoolSpec defines the desired state of the ClusterPool.
     */
    readonly spec?: pulumi.Input<inputs.hive.v1.ClusterPoolSpec>;
    /**
     * ClusterPoolStatus defines the observed state of ClusterPool
     */
    readonly status?: pulumi.Input<inputs.hive.v1.ClusterPoolStatus>;
}
