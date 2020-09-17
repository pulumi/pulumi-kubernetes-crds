// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * A MachineInstance is a portable resource claim that may be satisfied by binding to a machine instance, which may include Virtual Machine managed resources such as an AWS EC2 instance or bare metal managed resources such as a Packet Device.
 */
export class MachineInstance extends pulumi.CustomResource {
    /**
     * Get an existing MachineInstance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): MachineInstance {
        return new MachineInstance(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:compute.crossplane.io/v1alpha1:MachineInstance';

    /**
     * Returns true if the given object is an instance of MachineInstance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MachineInstance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MachineInstance.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"compute.crossplane.io/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"MachineInstance" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * MachineInstanceSpec specifies the desired state of a MachineInstance.
     */
    public readonly spec!: pulumi.Output<outputs.compute.v1alpha1.MachineInstanceSpec | undefined>;
    /**
     * A ResourceClaimStatus represents the observed status of a resource claim.
     */
    public readonly status!: pulumi.Output<outputs.compute.v1alpha1.MachineInstanceStatus | undefined>;

    /**
     * Create a MachineInstance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: MachineInstanceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "compute.crossplane.io/v1alpha1";
            inputs["kind"] = "MachineInstance";
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
        super(MachineInstance.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a MachineInstance resource.
 */
export interface MachineInstanceArgs {
    readonly apiVersion?: pulumi.Input<"compute.crossplane.io/v1alpha1">;
    readonly kind?: pulumi.Input<"MachineInstance">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * MachineInstanceSpec specifies the desired state of a MachineInstance.
     */
    readonly spec?: pulumi.Input<inputs.compute.v1alpha1.MachineInstanceSpec>;
    /**
     * A ResourceClaimStatus represents the observed status of a resource claim.
     */
    readonly status?: pulumi.Input<inputs.compute.v1alpha1.MachineInstanceStatus>;
}