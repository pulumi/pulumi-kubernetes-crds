// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * PrometheusExporter is the Schema for the prometheus exporters
 */
export class PrometheusExporter extends pulumi.CustomResource {
    /**
     * Get an existing PrometheusExporter resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PrometheusExporter {
        return new PrometheusExporter(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:monitoring.3scale.net/v1alpha1:PrometheusExporter';

    /**
     * Returns true if the given object is an instance of PrometheusExporter.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PrometheusExporter {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PrometheusExporter.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"monitoring.3scale.net/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"PrometheusExporter" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * PrometheusExporterSpec defines the desired state of PrometheusExporter
     */
    public readonly spec!: pulumi.Output<outputs.monitoring.v1alpha1.PrometheusExporterSpec | undefined>;

    /**
     * Create a PrometheusExporter resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: PrometheusExporterArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "monitoring.3scale.net/v1alpha1";
            inputs["kind"] = "PrometheusExporter";
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
        super(PrometheusExporter.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PrometheusExporter resource.
 */
export interface PrometheusExporterArgs {
    readonly apiVersion?: pulumi.Input<"monitoring.3scale.net/v1alpha1">;
    readonly kind?: pulumi.Input<"PrometheusExporter">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * PrometheusExporterSpec defines the desired state of PrometheusExporter
     */
    readonly spec?: pulumi.Input<inputs.monitoring.v1alpha1.PrometheusExporterSpec>;
}
