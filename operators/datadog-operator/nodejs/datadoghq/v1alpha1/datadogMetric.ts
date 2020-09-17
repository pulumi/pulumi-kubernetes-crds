// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * DatadogMetric is the Schema for the datadogmetrics API
 */
export class DatadogMetric extends pulumi.CustomResource {
    /**
     * Get an existing DatadogMetric resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DatadogMetric {
        return new DatadogMetric(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:datadoghq.com/v1alpha1:DatadogMetric';

    /**
     * Returns true if the given object is an instance of DatadogMetric.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DatadogMetric {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DatadogMetric.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"datadoghq.com/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"DatadogMetric" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * DatadogMetricSpec defines the desired state of DatadogMetric
     */
    public readonly spec!: pulumi.Output<outputs.datadoghq.v1alpha1.DatadogMetricSpec | undefined>;
    /**
     * DatadogMetricStatus defines the observed state of DatadogMetric
     */
    public readonly status!: pulumi.Output<outputs.datadoghq.v1alpha1.DatadogMetricStatus | undefined>;

    /**
     * Create a DatadogMetric resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: DatadogMetricArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "datadoghq.com/v1alpha1";
            inputs["kind"] = "DatadogMetric";
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
        super(DatadogMetric.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a DatadogMetric resource.
 */
export interface DatadogMetricArgs {
    readonly apiVersion?: pulumi.Input<"datadoghq.com/v1alpha1">;
    readonly kind?: pulumi.Input<"DatadogMetric">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * DatadogMetricSpec defines the desired state of DatadogMetric
     */
    readonly spec?: pulumi.Input<inputs.datadoghq.v1alpha1.DatadogMetricSpec>;
    /**
     * DatadogMetricStatus defines the observed state of DatadogMetric
     */
    readonly status?: pulumi.Input<inputs.datadoghq.v1alpha1.DatadogMetricStatus>;
}