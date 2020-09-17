// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * A Bucket is a portable resource claim that may be satisfied by binding to a managed resource such as an AWS S3 bucket or Azure storage container.
 */
export class Bucket extends pulumi.CustomResource {
    /**
     * Get an existing Bucket resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Bucket {
        return new Bucket(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:storage.crossplane.io/v1alpha1:Bucket';

    /**
     * Returns true if the given object is an instance of Bucket.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Bucket {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Bucket.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"storage.crossplane.io/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"Bucket" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * BucketSpec specifies the desired state of a Bucket.
     */
    public readonly spec!: pulumi.Output<outputs.storage.v1alpha1.BucketSpec | undefined>;
    /**
     * A ResourceClaimStatus represents the observed status of a resource claim.
     */
    public readonly status!: pulumi.Output<outputs.storage.v1alpha1.BucketStatus | undefined>;

    /**
     * Create a Bucket resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: BucketArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "storage.crossplane.io/v1alpha1";
            inputs["kind"] = "Bucket";
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
        super(Bucket.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Bucket resource.
 */
export interface BucketArgs {
    readonly apiVersion?: pulumi.Input<"storage.crossplane.io/v1alpha1">;
    readonly kind?: pulumi.Input<"Bucket">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * BucketSpec specifies the desired state of a Bucket.
     */
    readonly spec?: pulumi.Input<inputs.storage.v1alpha1.BucketSpec>;
    /**
     * A ResourceClaimStatus represents the observed status of a resource claim.
     */
    readonly status?: pulumi.Input<inputs.storage.v1alpha1.BucketStatus>;
}
