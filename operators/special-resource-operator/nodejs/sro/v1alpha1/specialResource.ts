// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * SpecialResource is the Schema for the specialresources API
 */
export class SpecialResource extends pulumi.CustomResource {
    /**
     * Get an existing SpecialResource resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SpecialResource {
        return new SpecialResource(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:sro.openshift.io/v1alpha1:SpecialResource';

    /**
     * Returns true if the given object is an instance of SpecialResource.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SpecialResource {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SpecialResource.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"sro.openshift.io/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"SpecialResource" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * SpecialResourceSpec defines the desired state of SpecialResource
     */
    public readonly spec!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * SpecialResourceStatus defines the observed state of SpecialResource
     */
    public readonly status!: pulumi.Output<outputs.sro.v1alpha1.SpecialResourceStatus | undefined>;

    /**
     * Create a SpecialResource resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: SpecialResourceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "sro.openshift.io/v1alpha1";
            inputs["kind"] = "SpecialResource";
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
        super(SpecialResource.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SpecialResource resource.
 */
export interface SpecialResourceArgs {
    readonly apiVersion?: pulumi.Input<"sro.openshift.io/v1alpha1">;
    readonly kind?: pulumi.Input<"SpecialResource">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * SpecialResourceSpec defines the desired state of SpecialResource
     */
    readonly spec?: pulumi.Input<{[key: string]: any}>;
    /**
     * SpecialResourceStatus defines the observed state of SpecialResource
     */
    readonly status?: pulumi.Input<inputs.sro.v1alpha1.SpecialResourceStatus>;
}