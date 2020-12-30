// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * Ibmqe is the Schema for the ibmqes API
 */
export class Ibmqe extends pulumi.CustomResource {
    /**
     * Get an existing Ibmqe resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Ibmqe {
        return new Ibmqe(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:singhp11.io/v1:Ibmqe';

    /**
     * Returns true if the given object is an instance of Ibmqe.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Ibmqe {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Ibmqe.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"singhp11.io/v1" | undefined>;
    public readonly kind!: pulumi.Output<"Ibmqe" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * IbmqeSpec defines the desired state of Ibmqe
     */
    public readonly spec!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * IbmqeStatus defines the observed state of Ibmqe
     */
    public readonly status!: pulumi.Output<{[key: string]: any} | undefined>;

    /**
     * Create a Ibmqe resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: IbmqeArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "singhp11.io/v1";
            inputs["kind"] = "Ibmqe";
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
        super(Ibmqe.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Ibmqe resource.
 */
export interface IbmqeArgs {
    readonly apiVersion?: pulumi.Input<"singhp11.io/v1">;
    readonly kind?: pulumi.Input<"Ibmqe">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * IbmqeSpec defines the desired state of Ibmqe
     */
    readonly spec?: pulumi.Input<{[key: string]: any}>;
    /**
     * IbmqeStatus defines the observed state of Ibmqe
     */
    readonly status?: pulumi.Input<{[key: string]: any}>;
}
