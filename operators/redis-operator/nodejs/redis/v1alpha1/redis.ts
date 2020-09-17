// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * Redis is the Schema for the redis API
 */
export class Redis extends pulumi.CustomResource {
    /**
     * Get an existing Redis resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Redis {
        return new Redis(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:redis.opstreelabs.in/v1alpha1:Redis';

    /**
     * Returns true if the given object is an instance of Redis.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Redis {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Redis.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"redis.opstreelabs.in/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"Redis" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * RedisSpec defines the desired state of Redis
     */
    public readonly spec!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * RedisStatus defines the observed state of Redis
     */
    public readonly status!: pulumi.Output<{[key: string]: any} | undefined>;

    /**
     * Create a Redis resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: RedisArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "redis.opstreelabs.in/v1alpha1";
            inputs["kind"] = "Redis";
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
        super(Redis.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Redis resource.
 */
export interface RedisArgs {
    readonly apiVersion?: pulumi.Input<"redis.opstreelabs.in/v1alpha1">;
    readonly kind?: pulumi.Input<"Redis">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * RedisSpec defines the desired state of Redis
     */
    readonly spec?: pulumi.Input<{[key: string]: any}>;
    /**
     * RedisStatus defines the observed state of Redis
     */
    readonly status?: pulumi.Input<{[key: string]: any}>;
}