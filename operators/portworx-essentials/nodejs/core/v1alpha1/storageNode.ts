// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

export class StorageNode extends pulumi.CustomResource {
    /**
     * Get an existing StorageNode resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): StorageNode {
        return new StorageNode(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:core.libopenstorage.org/v1alpha1:StorageNode';

    /**
     * Returns true if the given object is an instance of StorageNode.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StorageNode {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StorageNode.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"core.libopenstorage.org/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"StorageNode" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * The desired behavior of the storage node. Currently changing the spec does not affect the actual storage node in the cluster. Eventually spec in StorageNode will override the spec from StorageCluster so that configuration can be overridden at node level.
     */
    public readonly spec!: pulumi.Output<outputs.core.v1alpha1.StorageNodeSpec | undefined>;
    /**
     * Most recently observed status of the storage node. The data may not be up to date.
     */
    public readonly status!: pulumi.Output<outputs.core.v1alpha1.StorageNodeStatus | undefined>;

    /**
     * Create a StorageNode resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: StorageNodeArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "core.libopenstorage.org/v1alpha1";
            inputs["kind"] = "StorageNode";
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
        super(StorageNode.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a StorageNode resource.
 */
export interface StorageNodeArgs {
    readonly apiVersion?: pulumi.Input<"core.libopenstorage.org/v1alpha1">;
    readonly kind?: pulumi.Input<"StorageNode">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * The desired behavior of the storage node. Currently changing the spec does not affect the actual storage node in the cluster. Eventually spec in StorageNode will override the spec from StorageCluster so that configuration can be overridden at node level.
     */
    readonly spec?: pulumi.Input<inputs.core.v1alpha1.StorageNodeSpec>;
    /**
     * Most recently observed status of the storage node. The data may not be up to date.
     */
    readonly status?: pulumi.Input<inputs.core.v1alpha1.StorageNodeStatus>;
}
