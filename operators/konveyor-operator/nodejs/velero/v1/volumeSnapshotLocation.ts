// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * VolumeSnapshotLocation is a location where Velero stores volume snapshots.
 */
export class VolumeSnapshotLocation extends pulumi.CustomResource {
    /**
     * Get an existing VolumeSnapshotLocation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VolumeSnapshotLocation {
        return new VolumeSnapshotLocation(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:velero.io/v1:VolumeSnapshotLocation';

    /**
     * Returns true if the given object is an instance of VolumeSnapshotLocation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VolumeSnapshotLocation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VolumeSnapshotLocation.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"velero.io/v1" | undefined>;
    public readonly kind!: pulumi.Output<"VolumeSnapshotLocation" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * VolumeSnapshotLocationSpec defines the specification for a Velero VolumeSnapshotLocation.
     */
    public readonly spec!: pulumi.Output<outputs.velero.v1.VolumeSnapshotLocationSpec | undefined>;
    /**
     * VolumeSnapshotLocationStatus describes the current status of a Velero VolumeSnapshotLocation.
     */
    public readonly status!: pulumi.Output<outputs.velero.v1.VolumeSnapshotLocationStatus | undefined>;

    /**
     * Create a VolumeSnapshotLocation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: VolumeSnapshotLocationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "velero.io/v1";
            inputs["kind"] = "VolumeSnapshotLocation";
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
        super(VolumeSnapshotLocation.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VolumeSnapshotLocation resource.
 */
export interface VolumeSnapshotLocationArgs {
    readonly apiVersion?: pulumi.Input<"velero.io/v1">;
    readonly kind?: pulumi.Input<"VolumeSnapshotLocation">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * VolumeSnapshotLocationSpec defines the specification for a Velero VolumeSnapshotLocation.
     */
    readonly spec?: pulumi.Input<inputs.velero.v1.VolumeSnapshotLocationSpec>;
    /**
     * VolumeSnapshotLocationStatus describes the current status of a Velero VolumeSnapshotLocation.
     */
    readonly status?: pulumi.Input<inputs.velero.v1.VolumeSnapshotLocationStatus>;
}
