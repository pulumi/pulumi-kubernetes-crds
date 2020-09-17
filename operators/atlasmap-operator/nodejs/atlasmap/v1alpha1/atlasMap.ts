// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * AtlasMap is the Schema for the atlasmaps API
 */
export class AtlasMap extends pulumi.CustomResource {
    /**
     * Get an existing AtlasMap resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AtlasMap {
        return new AtlasMap(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:atlasmap.io/v1alpha1:AtlasMap';

    /**
     * Returns true if the given object is an instance of AtlasMap.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AtlasMap {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AtlasMap.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"atlasmap.io/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"AtlasMap" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * AtlasMapSpec defines the desired state of AtlasMap
     */
    public readonly spec!: pulumi.Output<outputs.atlasmap.v1alpha1.AtlasMapSpec | undefined>;
    /**
     * AtlasMapStatus defines the observed state of AtlasMap
     */
    public readonly status!: pulumi.Output<outputs.atlasmap.v1alpha1.AtlasMapStatus | undefined>;

    /**
     * Create a AtlasMap resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: AtlasMapArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "atlasmap.io/v1alpha1";
            inputs["kind"] = "AtlasMap";
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
        super(AtlasMap.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AtlasMap resource.
 */
export interface AtlasMapArgs {
    readonly apiVersion?: pulumi.Input<"atlasmap.io/v1alpha1">;
    readonly kind?: pulumi.Input<"AtlasMap">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * AtlasMapSpec defines the desired state of AtlasMap
     */
    readonly spec?: pulumi.Input<inputs.atlasmap.v1alpha1.AtlasMapSpec>;
    /**
     * AtlasMapStatus defines the observed state of AtlasMap
     */
    readonly status?: pulumi.Input<inputs.atlasmap.v1alpha1.AtlasMapStatus>;
}