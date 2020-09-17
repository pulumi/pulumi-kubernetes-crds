// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * BuildRun is the Schema for the buildruns API
 */
export class BuildRun extends pulumi.CustomResource {
    /**
     * Get an existing BuildRun resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): BuildRun {
        return new BuildRun(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:build.dev/v1alpha1:BuildRun';

    /**
     * Returns true if the given object is an instance of BuildRun.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is BuildRun {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === BuildRun.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"build.dev/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"BuildRun" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * BuildRunSpec defines the desired state of BuildRun
     */
    public readonly spec!: pulumi.Output<outputs.build.v1alpha1.BuildRunSpec | undefined>;
    /**
     * BuildRunStatus defines the observed state of BuildRun
     */
    public readonly status!: pulumi.Output<outputs.build.v1alpha1.BuildRunStatus | undefined>;

    /**
     * Create a BuildRun resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: BuildRunArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "build.dev/v1alpha1";
            inputs["kind"] = "BuildRun";
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
        super(BuildRun.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a BuildRun resource.
 */
export interface BuildRunArgs {
    readonly apiVersion?: pulumi.Input<"build.dev/v1alpha1">;
    readonly kind?: pulumi.Input<"BuildRun">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * BuildRunSpec defines the desired state of BuildRun
     */
    readonly spec?: pulumi.Input<inputs.build.v1alpha1.BuildRunSpec>;
    /**
     * BuildRunStatus defines the observed state of BuildRun
     */
    readonly status?: pulumi.Input<inputs.build.v1alpha1.BuildRunStatus>;
}
