// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * StandardInfraConfig defines configuration applied to routers and brokers for an instance of the standard address space type. This resource is created by the service administrator.
 */
export class StandardInfraConfig extends pulumi.CustomResource {
    /**
     * Get an existing StandardInfraConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): StandardInfraConfig {
        return new StandardInfraConfig(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:admin.enmasse.io/v1beta1:StandardInfraConfig';

    /**
     * Returns true if the given object is an instance of StandardInfraConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StandardInfraConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StandardInfraConfig.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"admin.enmasse.io/v1beta1" | undefined>;
    public readonly kind!: pulumi.Output<"StandardInfraConfig" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    public readonly spec!: pulumi.Output<outputs.admin.v1beta1.StandardInfraConfigSpec | undefined>;

    /**
     * Create a StandardInfraConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: StandardInfraConfigArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "admin.enmasse.io/v1beta1";
            inputs["kind"] = "StandardInfraConfig";
            inputs["metadata"] = args ? args.metadata : undefined;
            inputs["spec"] = args ? args.spec : undefined;
        } else {
            inputs["apiVersion"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["metadata"] = undefined /*out*/;
            inputs["spec"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(StandardInfraConfig.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a StandardInfraConfig resource.
 */
export interface StandardInfraConfigArgs {
    readonly apiVersion?: pulumi.Input<"admin.enmasse.io/v1beta1">;
    readonly kind?: pulumi.Input<"StandardInfraConfig">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    readonly spec?: pulumi.Input<inputs.admin.v1beta1.StandardInfraConfigSpec>;
}
