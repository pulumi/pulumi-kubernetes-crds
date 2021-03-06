// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * ApicurioRegistry is the Schema for the apicurioregistries API
 */
export class ApicurioRegistry extends pulumi.CustomResource {
    /**
     * Get an existing ApicurioRegistry resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ApicurioRegistry {
        return new ApicurioRegistry(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:apicur.io/v1alpha1:ApicurioRegistry';

    /**
     * Returns true if the given object is an instance of ApicurioRegistry.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApicurioRegistry {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApicurioRegistry.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"apicur.io/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"ApicurioRegistry" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * ApicurioRegistrySpec defines the desired state of ApicurioRegistry
     */
    public readonly spec!: pulumi.Output<outputs.apicur.v1alpha1.ApicurioRegistrySpec | undefined>;
    /**
     * ApicurioRegistryStatus defines the observed state of ApicurioRegistry
     */
    public readonly status!: pulumi.Output<outputs.apicur.v1alpha1.ApicurioRegistryStatus | undefined>;

    /**
     * Create a ApicurioRegistry resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ApicurioRegistryArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "apicur.io/v1alpha1";
            inputs["kind"] = "ApicurioRegistry";
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
        super(ApicurioRegistry.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ApicurioRegistry resource.
 */
export interface ApicurioRegistryArgs {
    readonly apiVersion?: pulumi.Input<"apicur.io/v1alpha1">;
    readonly kind?: pulumi.Input<"ApicurioRegistry">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * ApicurioRegistrySpec defines the desired state of ApicurioRegistry
     */
    readonly spec?: pulumi.Input<inputs.apicur.v1alpha1.ApicurioRegistrySpec>;
    /**
     * ApicurioRegistryStatus defines the observed state of ApicurioRegistry
     */
    readonly status?: pulumi.Input<inputs.apicur.v1alpha1.ApicurioRegistryStatus>;
}
