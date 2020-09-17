// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

export class FederatedServiceStatus extends pulumi.CustomResource {
    /**
     * Get an existing FederatedServiceStatus resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): FederatedServiceStatus {
        return new FederatedServiceStatus(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:core.kubefed.io/v1alpha1:FederatedServiceStatus';

    /**
     * Returns true if the given object is an instance of FederatedServiceStatus.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FederatedServiceStatus {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FederatedServiceStatus.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"core.kubefed.io/v1alpha1" | undefined>;
    public readonly clusterStatus!: pulumi.Output<outputs.core.v1alpha1.FederatedServiceStatusClusterStatus[] | undefined>;
    public readonly kind!: pulumi.Output<"FederatedServiceStatus" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;

    /**
     * Create a FederatedServiceStatus resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: FederatedServiceStatusArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "core.kubefed.io/v1alpha1";
            inputs["clusterStatus"] = args ? args.clusterStatus : undefined;
            inputs["kind"] = "FederatedServiceStatus";
            inputs["metadata"] = args ? args.metadata : undefined;
        } else {
            inputs["apiVersion"] = undefined /*out*/;
            inputs["clusterStatus"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["metadata"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(FederatedServiceStatus.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a FederatedServiceStatus resource.
 */
export interface FederatedServiceStatusArgs {
    readonly apiVersion?: pulumi.Input<"core.kubefed.io/v1alpha1">;
    readonly clusterStatus?: pulumi.Input<pulumi.Input<inputs.core.v1alpha1.FederatedServiceStatusClusterStatus>[]>;
    readonly kind?: pulumi.Input<"FederatedServiceStatus">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
}