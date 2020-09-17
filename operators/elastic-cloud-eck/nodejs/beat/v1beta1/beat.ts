// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * Beat is the Schema for the Beats API.
 */
export class Beat extends pulumi.CustomResource {
    /**
     * Get an existing Beat resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Beat {
        return new Beat(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:beat.k8s.elastic.co/v1beta1:Beat';

    /**
     * Returns true if the given object is an instance of Beat.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Beat {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Beat.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"beat.k8s.elastic.co/v1beta1" | undefined>;
    public readonly kind!: pulumi.Output<"Beat" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * BeatSpec defines the desired state of a Beat.
     */
    public readonly spec!: pulumi.Output<outputs.beat.v1beta1.BeatSpec | undefined>;
    /**
     * BeatStatus defines the observed state of a Beat.
     */
    public readonly status!: pulumi.Output<outputs.beat.v1beta1.BeatStatus | undefined>;

    /**
     * Create a Beat resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: BeatArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "beat.k8s.elastic.co/v1beta1";
            inputs["kind"] = "Beat";
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
        super(Beat.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Beat resource.
 */
export interface BeatArgs {
    readonly apiVersion?: pulumi.Input<"beat.k8s.elastic.co/v1beta1">;
    readonly kind?: pulumi.Input<"Beat">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * BeatSpec defines the desired state of a Beat.
     */
    readonly spec?: pulumi.Input<inputs.beat.v1beta1.BeatSpec>;
    /**
     * BeatStatus defines the observed state of a Beat.
     */
    readonly status?: pulumi.Input<inputs.beat.v1beta1.BeatStatus>;
}