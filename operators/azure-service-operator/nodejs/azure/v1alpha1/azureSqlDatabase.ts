// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * AzureSqlDatabase is the Schema for the azuresqldatabases API
 */
export class AzureSqlDatabase extends pulumi.CustomResource {
    /**
     * Get an existing AzureSqlDatabase resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AzureSqlDatabase {
        return new AzureSqlDatabase(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:azure.microsoft.com/v1alpha1:AzureSqlDatabase';

    /**
     * Returns true if the given object is an instance of AzureSqlDatabase.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AzureSqlDatabase {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AzureSqlDatabase.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"azure.microsoft.com/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"AzureSqlDatabase" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * AzureSqlDatabaseSpec defines the desired state of AzureSqlDatabase
     */
    public readonly spec!: pulumi.Output<outputs.azure.v1alpha1.AzureSqlDatabaseSpec | undefined>;
    /**
     * ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
     */
    public readonly status!: pulumi.Output<outputs.azure.v1alpha1.AzureSqlDatabaseStatus | undefined>;

    /**
     * Create a AzureSqlDatabase resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: AzureSqlDatabaseArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "azure.microsoft.com/v1alpha1";
            inputs["kind"] = "AzureSqlDatabase";
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
        super(AzureSqlDatabase.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AzureSqlDatabase resource.
 */
export interface AzureSqlDatabaseArgs {
    readonly apiVersion?: pulumi.Input<"azure.microsoft.com/v1alpha1">;
    readonly kind?: pulumi.Input<"AzureSqlDatabase">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * AzureSqlDatabaseSpec defines the desired state of AzureSqlDatabase
     */
    readonly spec?: pulumi.Input<inputs.azure.v1alpha1.AzureSqlDatabaseSpec>;
    /**
     * ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
     */
    readonly status?: pulumi.Input<inputs.azure.v1alpha1.AzureSqlDatabaseStatus>;
}
