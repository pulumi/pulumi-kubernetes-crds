// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

export class ScheduledSparkApplication extends pulumi.CustomResource {
    /**
     * Get an existing ScheduledSparkApplication resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ScheduledSparkApplication {
        return new ScheduledSparkApplication(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:sparkoperator.k8s.io/v1beta1:ScheduledSparkApplication';

    /**
     * Returns true if the given object is an instance of ScheduledSparkApplication.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ScheduledSparkApplication {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ScheduledSparkApplication.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"sparkoperator.k8s.io/v1beta1" | undefined>;
    public readonly kind!: pulumi.Output<"ScheduledSparkApplication" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    public readonly spec!: pulumi.Output<any | undefined>;

    /**
     * Create a ScheduledSparkApplication resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ScheduledSparkApplicationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "sparkoperator.k8s.io/v1beta1";
            inputs["kind"] = "ScheduledSparkApplication";
            inputs["metadata"] = args ? args.metadata : undefined;
            inputs["spec"] = args ? args.spec : undefined;
        } else {
            inputs["apiVersion"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["metadata"] = undefined /*out*/;
            inputs["spec"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ScheduledSparkApplication.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ScheduledSparkApplication resource.
 */
export interface ScheduledSparkApplicationArgs {
    readonly apiVersion?: pulumi.Input<"sparkoperator.k8s.io/v1beta1">;
    readonly kind?: pulumi.Input<"ScheduledSparkApplication">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    readonly spec?: any;
}
