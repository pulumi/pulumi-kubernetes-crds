// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * Qperf is the Schema for the qperves API
 */
export class Qperf extends pulumi.CustomResource {
    /**
     * Get an existing Qperf resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Qperf {
        return new Qperf(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:perf.kubestone.xridge.io/v1alpha1:Qperf';

    /**
     * Returns true if the given object is an instance of Qperf.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Qperf {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Qperf.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"perf.kubestone.xridge.io/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"Qperf" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * QperfSpec defines the Qperf Benchmark Stone which consist of server deployment with service definition and client pod.
     */
    public readonly spec!: pulumi.Output<outputs.perf.v1alpha1.QperfSpec | undefined>;
    /**
     * BenchmarkStatus describes the current state of the benchmark
     */
    public readonly status!: pulumi.Output<outputs.perf.v1alpha1.QperfStatus | undefined>;

    /**
     * Create a Qperf resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: QperfArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "perf.kubestone.xridge.io/v1alpha1";
            inputs["kind"] = "Qperf";
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
        super(Qperf.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Qperf resource.
 */
export interface QperfArgs {
    readonly apiVersion?: pulumi.Input<"perf.kubestone.xridge.io/v1alpha1">;
    readonly kind?: pulumi.Input<"Qperf">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * QperfSpec defines the Qperf Benchmark Stone which consist of server deployment with service definition and client pod.
     */
    readonly spec?: pulumi.Input<inputs.perf.v1alpha1.QperfSpec>;
    /**
     * BenchmarkStatus describes the current state of the benchmark
     */
    readonly status?: pulumi.Input<inputs.perf.v1alpha1.QperfStatus>;
}
