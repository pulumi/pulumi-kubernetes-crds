// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * PostgreSQLDatabase is the Schema for the postgresqldatabases API
 */
export class PostgreSQLDatabase extends pulumi.CustomResource {
    /**
     * Get an existing PostgreSQLDatabase resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PostgreSQLDatabase {
        return new PostgreSQLDatabase(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:azure.microsoft.com/v1alpha1:PostgreSQLDatabase';

    /**
     * Returns true if the given object is an instance of PostgreSQLDatabase.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PostgreSQLDatabase {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PostgreSQLDatabase.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"azure.microsoft.com/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"PostgreSQLDatabase" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * PostgreSQLDatabaseSpec defines the desired state of PostgreSQLDatabase
     */
    public readonly spec!: pulumi.Output<outputs.azure.v1alpha1.PostgreSQLDatabaseSpec | undefined>;
    /**
     * ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
     */
    public readonly status!: pulumi.Output<outputs.azure.v1alpha1.PostgreSQLDatabaseStatus | undefined>;

    /**
     * Create a PostgreSQLDatabase resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: PostgreSQLDatabaseArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "azure.microsoft.com/v1alpha1";
            inputs["kind"] = "PostgreSQLDatabase";
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
        super(PostgreSQLDatabase.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PostgreSQLDatabase resource.
 */
export interface PostgreSQLDatabaseArgs {
    readonly apiVersion?: pulumi.Input<"azure.microsoft.com/v1alpha1">;
    readonly kind?: pulumi.Input<"PostgreSQLDatabase">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * PostgreSQLDatabaseSpec defines the desired state of PostgreSQLDatabase
     */
    readonly spec?: pulumi.Input<inputs.azure.v1alpha1.PostgreSQLDatabaseSpec>;
    /**
     * ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
     */
    readonly status?: pulumi.Input<inputs.azure.v1alpha1.PostgreSQLDatabaseStatus>;
}
