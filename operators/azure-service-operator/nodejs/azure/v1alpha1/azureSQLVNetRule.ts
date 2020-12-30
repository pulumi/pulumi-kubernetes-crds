// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * AzureSQLVNetRule is the Schema for the azuresqlvnetrules API
 */
export class AzureSQLVNetRule extends pulumi.CustomResource {
    /**
     * Get an existing AzureSQLVNetRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AzureSQLVNetRule {
        return new AzureSQLVNetRule(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:azure.microsoft.com/v1alpha1:AzureSQLVNetRule';

    /**
     * Returns true if the given object is an instance of AzureSQLVNetRule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AzureSQLVNetRule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AzureSQLVNetRule.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"azure.microsoft.com/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"AzureSQLVNetRule" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * NOTE: json tags are required.  Any new fields you add must have json tags for the fields to be serialized. AzureSQLVNetRuleSpec defines the desired state of AzureSQLVNetRule
     */
    public readonly spec!: pulumi.Output<outputs.azure.v1alpha1.AzureSQLVNetRuleSpec | undefined>;
    /**
     * ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
     */
    public readonly status!: pulumi.Output<outputs.azure.v1alpha1.AzureSQLVNetRuleStatus | undefined>;

    /**
     * Create a AzureSQLVNetRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: AzureSQLVNetRuleArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "azure.microsoft.com/v1alpha1";
            inputs["kind"] = "AzureSQLVNetRule";
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
        super(AzureSQLVNetRule.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AzureSQLVNetRule resource.
 */
export interface AzureSQLVNetRuleArgs {
    readonly apiVersion?: pulumi.Input<"azure.microsoft.com/v1alpha1">;
    readonly kind?: pulumi.Input<"AzureSQLVNetRule">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * NOTE: json tags are required.  Any new fields you add must have json tags for the fields to be serialized. AzureSQLVNetRuleSpec defines the desired state of AzureSQLVNetRule
     */
    readonly spec?: pulumi.Input<inputs.azure.v1alpha1.AzureSQLVNetRuleSpec>;
    /**
     * ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
     */
    readonly status?: pulumi.Input<inputs.azure.v1alpha1.AzureSQLVNetRuleStatus>;
}