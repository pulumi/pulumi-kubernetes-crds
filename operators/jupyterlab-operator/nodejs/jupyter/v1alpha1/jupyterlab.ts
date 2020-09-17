// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * Jupyterlab is the Schema for the jupyterlabs API
 */
export class Jupyterlab extends pulumi.CustomResource {
    /**
     * Get an existing Jupyterlab resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Jupyterlab {
        return new Jupyterlab(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:jupyter.example.com/v1alpha1:Jupyterlab';

    /**
     * Returns true if the given object is an instance of Jupyterlab.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Jupyterlab {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Jupyterlab.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"jupyter.example.com/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"Jupyterlab" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * JupyterlabSpec defines the desired state of Jupyterlab
     */
    public readonly spec!: pulumi.Output<outputs.jupyter.v1alpha1.JupyterlabSpec | undefined>;
    /**
     * JupyterlabStatus defines the observed state of Jupyterlab
     */
    public readonly status!: pulumi.Output<outputs.jupyter.v1alpha1.JupyterlabStatus | undefined>;

    /**
     * Create a Jupyterlab resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: JupyterlabArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "jupyter.example.com/v1alpha1";
            inputs["kind"] = "Jupyterlab";
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
        super(Jupyterlab.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Jupyterlab resource.
 */
export interface JupyterlabArgs {
    readonly apiVersion?: pulumi.Input<"jupyter.example.com/v1alpha1">;
    readonly kind?: pulumi.Input<"Jupyterlab">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * JupyterlabSpec defines the desired state of Jupyterlab
     */
    readonly spec?: pulumi.Input<inputs.jupyter.v1alpha1.JupyterlabSpec>;
    /**
     * JupyterlabStatus defines the observed state of Jupyterlab
     */
    readonly status?: pulumi.Input<inputs.jupyter.v1alpha1.JupyterlabStatus>;
}
