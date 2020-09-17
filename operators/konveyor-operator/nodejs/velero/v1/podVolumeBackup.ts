// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

export class PodVolumeBackup extends pulumi.CustomResource {
    /**
     * Get an existing PodVolumeBackup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PodVolumeBackup {
        return new PodVolumeBackup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:velero.io/v1:PodVolumeBackup';

    /**
     * Returns true if the given object is an instance of PodVolumeBackup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PodVolumeBackup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PodVolumeBackup.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"velero.io/v1" | undefined>;
    public readonly kind!: pulumi.Output<"PodVolumeBackup" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * PodVolumeBackupSpec is the specification for a PodVolumeBackup.
     */
    public readonly spec!: pulumi.Output<outputs.velero.v1.PodVolumeBackupSpec | undefined>;
    /**
     * PodVolumeBackupStatus is the current status of a PodVolumeBackup.
     */
    public readonly status!: pulumi.Output<outputs.velero.v1.PodVolumeBackupStatus | undefined>;

    /**
     * Create a PodVolumeBackup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: PodVolumeBackupArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "velero.io/v1";
            inputs["kind"] = "PodVolumeBackup";
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
        super(PodVolumeBackup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PodVolumeBackup resource.
 */
export interface PodVolumeBackupArgs {
    readonly apiVersion?: pulumi.Input<"velero.io/v1">;
    readonly kind?: pulumi.Input<"PodVolumeBackup">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * PodVolumeBackupSpec is the specification for a PodVolumeBackup.
     */
    readonly spec?: pulumi.Input<inputs.velero.v1.PodVolumeBackupSpec>;
    /**
     * PodVolumeBackupStatus is the current status of a PodVolumeBackup.
     */
    readonly status?: pulumi.Input<inputs.velero.v1.PodVolumeBackupStatus>;
}