// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * KfDef is the Schema for the kfdefs API
 */
export class KfDef extends pulumi.CustomResource {
    /**
     * Get an existing KfDef resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): KfDef {
        return new KfDef(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:kfdef.apps.kubeflow.org/v1:KfDef';

    /**
     * Returns true if the given object is an instance of KfDef.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KfDef {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KfDef.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"kfdef.apps.kubeflow.org/v1" | undefined>;
    public readonly kind!: pulumi.Output<"KfDef" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * KfDefSpec defines the desired state of KfDef
     */
    public readonly spec!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * KfDefStatus defines the observed state of KfDef
     */
    public readonly status!: pulumi.Output<{[key: string]: any} | undefined>;

    /**
     * Create a KfDef resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: KfDefArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "kfdef.apps.kubeflow.org/v1";
            inputs["kind"] = "KfDef";
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
        super(KfDef.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a KfDef resource.
 */
export interface KfDefArgs {
    readonly apiVersion?: pulumi.Input<"kfdef.apps.kubeflow.org/v1">;
    readonly kind?: pulumi.Input<"KfDef">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * KfDefSpec defines the desired state of KfDef
     */
    readonly spec?: pulumi.Input<{[key: string]: any}>;
    /**
     * KfDefStatus defines the observed state of KfDef
     */
    readonly status?: pulumi.Input<{[key: string]: any}>;
}