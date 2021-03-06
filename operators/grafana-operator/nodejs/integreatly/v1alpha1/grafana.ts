// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

export class Grafana extends pulumi.CustomResource {
    /**
     * Get an existing Grafana resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Grafana {
        return new Grafana(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:integreatly.org/v1alpha1:Grafana';

    /**
     * Returns true if the given object is an instance of Grafana.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Grafana {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Grafana.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"integreatly.org/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"Grafana" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    public readonly spec!: pulumi.Output<any>;

    /**
     * Create a Grafana resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: GrafanaArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "integreatly.org/v1alpha1";
            inputs["kind"] = "Grafana";
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
        super(Grafana.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Grafana resource.
 */
export interface GrafanaArgs {
    readonly apiVersion?: pulumi.Input<"integreatly.org/v1alpha1">;
    readonly kind?: pulumi.Input<"Grafana">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    readonly spec?: any;
}
