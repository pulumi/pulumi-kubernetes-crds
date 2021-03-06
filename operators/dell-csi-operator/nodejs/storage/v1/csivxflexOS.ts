// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * CSIVXFlexOS is the Schema for the csivxflexoses API
 */
export class CSIVXFlexOS extends pulumi.CustomResource {
    /**
     * Get an existing CSIVXFlexOS resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CSIVXFlexOS {
        return new CSIVXFlexOS(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:storage.dell.com/v1:CSIVXFlexOS';

    /**
     * Returns true if the given object is an instance of CSIVXFlexOS.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CSIVXFlexOS {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CSIVXFlexOS.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"storage.dell.com/v1" | undefined>;
    public readonly kind!: pulumi.Output<"CSIVXFlexOS" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * CSIVXFlexOSSpec defines the desired state of CSIVXFlexOS
     */
    public readonly spec!: pulumi.Output<outputs.storage.v1.CSIVXFlexOSSpec | undefined>;
    /**
     * DriverStatus defines the observed state of CSIDriver
     */
    public readonly status!: pulumi.Output<outputs.storage.v1.CSIVXFlexOSStatus | undefined>;

    /**
     * Create a CSIVXFlexOS resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: CSIVXFlexOSArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "storage.dell.com/v1";
            inputs["kind"] = "CSIVXFlexOS";
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
        super(CSIVXFlexOS.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a CSIVXFlexOS resource.
 */
export interface CSIVXFlexOSArgs {
    readonly apiVersion?: pulumi.Input<"storage.dell.com/v1">;
    readonly kind?: pulumi.Input<"CSIVXFlexOS">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * CSIVXFlexOSSpec defines the desired state of CSIVXFlexOS
     */
    readonly spec?: pulumi.Input<inputs.storage.v1.CSIVXFlexOSSpec>;
    /**
     * DriverStatus defines the observed state of CSIDriver
     */
    readonly status?: pulumi.Input<inputs.storage.v1.CSIVXFlexOSStatus>;
}
