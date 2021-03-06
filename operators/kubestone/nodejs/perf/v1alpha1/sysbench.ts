// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * Sysbench is the Schema for the sysbenches API
 */
export class Sysbench extends pulumi.CustomResource {
    /**
     * Get an existing Sysbench resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Sysbench {
        return new Sysbench(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:perf.kubestone.xridge.io/v1alpha1:Sysbench';

    /**
     * Returns true if the given object is an instance of Sysbench.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Sysbench {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Sysbench.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"perf.kubestone.xridge.io/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"Sysbench" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * SysbenchSpec contains the configuration parameters with scheduling options for the sysbench benchmark. The options, testName and command parameters are passed to the sysbench benchmarking application.
     */
    public readonly spec!: pulumi.Output<outputs.perf.v1alpha1.SysbenchSpec | undefined>;
    /**
     * BenchmarkStatus describes the current state of the benchmark
     */
    public readonly status!: pulumi.Output<outputs.perf.v1alpha1.SysbenchStatus | undefined>;

    /**
     * Create a Sysbench resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: SysbenchArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "perf.kubestone.xridge.io/v1alpha1";
            inputs["kind"] = "Sysbench";
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
        super(Sysbench.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Sysbench resource.
 */
export interface SysbenchArgs {
    readonly apiVersion?: pulumi.Input<"perf.kubestone.xridge.io/v1alpha1">;
    readonly kind?: pulumi.Input<"Sysbench">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * SysbenchSpec contains the configuration parameters with scheduling options for the sysbench benchmark. The options, testName and command parameters are passed to the sysbench benchmarking application.
     */
    readonly spec?: pulumi.Input<inputs.perf.v1alpha1.SysbenchSpec>;
    /**
     * BenchmarkStatus describes the current state of the benchmark
     */
    readonly status?: pulumi.Input<inputs.perf.v1alpha1.SysbenchStatus>;
}
