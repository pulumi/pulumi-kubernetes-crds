// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * AzureSqlFailoverGroup is the Schema for the azuresqlfailovergroups API
 */
export class AzureSqlFailoverGroup extends pulumi.CustomResource {
    /**
     * Get an existing AzureSqlFailoverGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AzureSqlFailoverGroup {
        return new AzureSqlFailoverGroup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:azure.microsoft.com/v1beta1:AzureSqlFailoverGroup';

    /**
     * Returns true if the given object is an instance of AzureSqlFailoverGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AzureSqlFailoverGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AzureSqlFailoverGroup.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"azure.microsoft.com/v1beta1" | undefined>;
    public readonly kind!: pulumi.Output<"AzureSqlFailoverGroup" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * AzureSqlFailoverGroupSpec defines the desired state of AzureSqlFailoverGroup
     */
    public readonly spec!: pulumi.Output<outputs.azure.v1beta1.AzureSqlFailoverGroupSpec | undefined>;
    /**
     * ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
     */
    public readonly status!: pulumi.Output<outputs.azure.v1beta1.AzureSqlFailoverGroupStatus | undefined>;

    /**
     * Create a AzureSqlFailoverGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: AzureSqlFailoverGroupArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "azure.microsoft.com/v1beta1";
            inputs["kind"] = "AzureSqlFailoverGroup";
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
        super(AzureSqlFailoverGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AzureSqlFailoverGroup resource.
 */
export interface AzureSqlFailoverGroupArgs {
    readonly apiVersion?: pulumi.Input<"azure.microsoft.com/v1beta1">;
    readonly kind?: pulumi.Input<"AzureSqlFailoverGroup">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * AzureSqlFailoverGroupSpec defines the desired state of AzureSqlFailoverGroup
     */
    readonly spec?: pulumi.Input<inputs.azure.v1beta1.AzureSqlFailoverGroupSpec>;
    /**
     * ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
     */
    readonly status?: pulumi.Input<inputs.azure.v1beta1.AzureSqlFailoverGroupStatus>;
}
