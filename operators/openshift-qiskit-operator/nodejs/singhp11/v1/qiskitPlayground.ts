// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * QiskitPlayground is the Schema for the qiskitplaygrounds API
 */
export class QiskitPlayground extends pulumi.CustomResource {
    /**
     * Get an existing QiskitPlayground resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): QiskitPlayground {
        return new QiskitPlayground(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:singhp11.io/v1:QiskitPlayground';

    /**
     * Returns true if the given object is an instance of QiskitPlayground.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is QiskitPlayground {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === QiskitPlayground.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"singhp11.io/v1" | undefined>;
    public readonly kind!: pulumi.Output<"QiskitPlayground" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * QiskitPlaygroundSpec defines the desired state of QiskitPlayground
     */
    public readonly spec!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * QiskitPlaygroundStatus defines the observed state of QiskitPlayground
     */
    public readonly status!: pulumi.Output<{[key: string]: any} | undefined>;

    /**
     * Create a QiskitPlayground resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: QiskitPlaygroundArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "singhp11.io/v1";
            inputs["kind"] = "QiskitPlayground";
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
        super(QiskitPlayground.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a QiskitPlayground resource.
 */
export interface QiskitPlaygroundArgs {
    readonly apiVersion?: pulumi.Input<"singhp11.io/v1">;
    readonly kind?: pulumi.Input<"QiskitPlayground">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * QiskitPlaygroundSpec defines the desired state of QiskitPlayground
     */
    readonly spec?: pulumi.Input<{[key: string]: any}>;
    /**
     * QiskitPlaygroundStatus defines the observed state of QiskitPlayground
     */
    readonly status?: pulumi.Input<{[key: string]: any}>;
}
