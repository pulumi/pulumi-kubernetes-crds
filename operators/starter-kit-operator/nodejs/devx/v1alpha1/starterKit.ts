// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * StarterKit is the Schema for the starterkits API
 */
export class StarterKit extends pulumi.CustomResource {
    /**
     * Get an existing StarterKit resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): StarterKit {
        return new StarterKit(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:devx.ibm.com/v1alpha1:StarterKit';

    /**
     * Returns true if the given object is an instance of StarterKit.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StarterKit {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StarterKit.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"devx.ibm.com/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"StarterKit" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * StarterKitSpec defines the desired state of StarterKit
     */
    public readonly spec!: pulumi.Output<outputs.devx.v1alpha1.StarterKitSpec | undefined>;
    /**
     * StarterKitStatus defines the observed state of StarterKit
     */
    public readonly status!: pulumi.Output<outputs.devx.v1alpha1.StarterKitStatus | undefined>;

    /**
     * Create a StarterKit resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: StarterKitArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "devx.ibm.com/v1alpha1";
            inputs["kind"] = "StarterKit";
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
        super(StarterKit.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a StarterKit resource.
 */
export interface StarterKitArgs {
    readonly apiVersion?: pulumi.Input<"devx.ibm.com/v1alpha1">;
    readonly kind?: pulumi.Input<"StarterKit">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * StarterKitSpec defines the desired state of StarterKit
     */
    readonly spec?: pulumi.Input<inputs.devx.v1alpha1.StarterKitSpec>;
    /**
     * StarterKitStatus defines the observed state of StarterKit
     */
    readonly status?: pulumi.Input<inputs.devx.v1alpha1.StarterKitStatus>;
}
