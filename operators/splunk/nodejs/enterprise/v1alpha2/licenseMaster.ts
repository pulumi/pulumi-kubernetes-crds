// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * LicenseMaster is the Schema for a Splunk Enterprise license master.
 */
export class LicenseMaster extends pulumi.CustomResource {
    /**
     * Get an existing LicenseMaster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): LicenseMaster {
        return new LicenseMaster(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:enterprise.splunk.com/v1alpha2:LicenseMaster';

    /**
     * Returns true if the given object is an instance of LicenseMaster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LicenseMaster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LicenseMaster.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"enterprise.splunk.com/v1alpha2" | undefined>;
    public readonly kind!: pulumi.Output<"LicenseMaster" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * LicenseMasterSpec defines the desired state of a Splunk Enterprise license master.
     */
    public readonly spec!: pulumi.Output<outputs.enterprise.v1alpha2.LicenseMasterSpec | undefined>;
    /**
     * LicenseMasterStatus defines the observed state of a Splunk Enterprise license master.
     */
    public readonly status!: pulumi.Output<outputs.enterprise.v1alpha2.LicenseMasterStatus | undefined>;

    /**
     * Create a LicenseMaster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: LicenseMasterArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "enterprise.splunk.com/v1alpha2";
            inputs["kind"] = "LicenseMaster";
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
        super(LicenseMaster.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a LicenseMaster resource.
 */
export interface LicenseMasterArgs {
    readonly apiVersion?: pulumi.Input<"enterprise.splunk.com/v1alpha2">;
    readonly kind?: pulumi.Input<"LicenseMaster">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * LicenseMasterSpec defines the desired state of a Splunk Enterprise license master.
     */
    readonly spec?: pulumi.Input<inputs.enterprise.v1alpha2.LicenseMasterSpec>;
    /**
     * LicenseMasterStatus defines the observed state of a Splunk Enterprise license master.
     */
    readonly status?: pulumi.Input<inputs.enterprise.v1alpha2.LicenseMasterStatus>;
}
