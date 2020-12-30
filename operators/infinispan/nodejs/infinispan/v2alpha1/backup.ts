// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * Backup is the Schema for the backups API
 */
export class Backup extends pulumi.CustomResource {
    /**
     * Get an existing Backup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Backup {
        return new Backup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:infinispan.org/v2alpha1:Backup';

    /**
     * Returns true if the given object is an instance of Backup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Backup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Backup.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"infinispan.org/v2alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"Backup" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * BackupSpec defines the desired state of Backup
     */
    public readonly spec!: pulumi.Output<outputs.infinispan.v2alpha1.BackupSpec | undefined>;
    /**
     * BackupStatus defines the observed state of Backup
     */
    public readonly status!: pulumi.Output<outputs.infinispan.v2alpha1.BackupStatus | undefined>;

    /**
     * Create a Backup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: BackupArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "infinispan.org/v2alpha1";
            inputs["kind"] = "Backup";
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
        super(Backup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Backup resource.
 */
export interface BackupArgs {
    readonly apiVersion?: pulumi.Input<"infinispan.org/v2alpha1">;
    readonly kind?: pulumi.Input<"Backup">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * BackupSpec defines the desired state of Backup
     */
    readonly spec?: pulumi.Input<inputs.infinispan.v2alpha1.BackupSpec>;
    /**
     * BackupStatus defines the observed state of Backup
     */
    readonly status?: pulumi.Input<inputs.infinispan.v2alpha1.BackupStatus>;
}
