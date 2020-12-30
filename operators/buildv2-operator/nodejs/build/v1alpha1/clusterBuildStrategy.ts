// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * ClusterBuildStrategy is the Schema representing a strategy in the cluster scope to build images from source code.
 */
export class ClusterBuildStrategy extends pulumi.CustomResource {
    /**
     * Get an existing ClusterBuildStrategy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ClusterBuildStrategy {
        return new ClusterBuildStrategy(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:build.dev/v1alpha1:ClusterBuildStrategy';

    /**
     * Returns true if the given object is an instance of ClusterBuildStrategy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ClusterBuildStrategy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ClusterBuildStrategy.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"build.dev/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"ClusterBuildStrategy" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * BuildStrategySpec defines the desired state of BuildStrategy
     */
    public readonly spec!: pulumi.Output<outputs.build.v1alpha1.ClusterBuildStrategySpec | undefined>;
    /**
     * BuildStrategyStatus defines the observed state of BuildStrategy
     */
    public readonly status!: pulumi.Output<{[key: string]: any} | undefined>;

    /**
     * Create a ClusterBuildStrategy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ClusterBuildStrategyArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "build.dev/v1alpha1";
            inputs["kind"] = "ClusterBuildStrategy";
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
        super(ClusterBuildStrategy.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ClusterBuildStrategy resource.
 */
export interface ClusterBuildStrategyArgs {
    readonly apiVersion?: pulumi.Input<"build.dev/v1alpha1">;
    readonly kind?: pulumi.Input<"ClusterBuildStrategy">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * BuildStrategySpec defines the desired state of BuildStrategy
     */
    readonly spec?: pulumi.Input<inputs.build.v1alpha1.ClusterBuildStrategySpec>;
    /**
     * BuildStrategyStatus defines the observed state of BuildStrategy
     */
    readonly status?: pulumi.Input<{[key: string]: any}>;
}
