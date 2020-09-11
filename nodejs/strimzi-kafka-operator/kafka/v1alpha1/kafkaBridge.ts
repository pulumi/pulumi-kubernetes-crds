// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

export class KafkaBridge extends pulumi.CustomResource {
    /**
     * Get an existing KafkaBridge resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): KafkaBridge {
        return new KafkaBridge(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:kafka.strimzi.io/v1alpha1:KafkaBridge';

    /**
     * Returns true if the given object is an instance of KafkaBridge.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KafkaBridge {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KafkaBridge.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"kafka.strimzi.io/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"KafkaBridge" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * The specification of the Kafka Bridge.
     */
    public readonly spec!: pulumi.Output<outputs.kafka.v1alpha1.KafkaBridgeSpec | undefined>;
    /**
     * The status of the Kafka Bridge.
     */
    public readonly status!: pulumi.Output<outputs.kafka.v1alpha1.KafkaBridgeStatus | undefined>;

    /**
     * Create a KafkaBridge resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: KafkaBridgeArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "kafka.strimzi.io/v1alpha1";
            inputs["kind"] = "KafkaBridge";
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
        super(KafkaBridge.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a KafkaBridge resource.
 */
export interface KafkaBridgeArgs {
    readonly apiVersion?: pulumi.Input<"kafka.strimzi.io/v1alpha1">;
    readonly kind?: pulumi.Input<"KafkaBridge">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * The specification of the Kafka Bridge.
     */
    readonly spec?: pulumi.Input<inputs.kafka.v1alpha1.KafkaBridgeSpec>;
    /**
     * The status of the Kafka Bridge.
     */
    readonly status?: pulumi.Input<inputs.kafka.v1alpha1.KafkaBridgeStatus>;
}
