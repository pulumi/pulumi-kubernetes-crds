// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

export class CostManagement extends pulumi.CustomResource {
    /**
     * Get an existing CostManagement resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CostManagement {
        return new CostManagement(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:cost-mgmt.openshift.io/v1alpha1:CostManagement';

    /**
     * Returns true if the given object is an instance of CostManagement.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CostManagement {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CostManagement.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"cost-mgmt-data.openshift.io/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"CostManagementData" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;

    /**
     * Create a CostManagement resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: CostManagementArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "cost-mgmt-data.openshift.io/v1alpha1";
            inputs["kind"] = "CostManagementData";
            inputs["metadata"] = args ? args.metadata : undefined;
        } else {
            inputs["apiVersion"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["metadata"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(CostManagement.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a CostManagement resource.
 */
export interface CostManagementArgs {
    readonly apiVersion?: pulumi.Input<"cost-mgmt-data.openshift.io/v1alpha1">;
    readonly kind?: pulumi.Input<"CostManagementData">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
}
