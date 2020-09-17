// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * KogitoTrusty defines the Trusty Service infrastructure deployment.
 */
export class KogitoTrusty extends pulumi.CustomResource {
    /**
     * Get an existing KogitoTrusty resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): KogitoTrusty {
        return new KogitoTrusty(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:app.kiegroup.org/v1alpha1:KogitoTrusty';

    /**
     * Returns true if the given object is an instance of KogitoTrusty.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KogitoTrusty {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KogitoTrusty.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"app.kiegroup.org/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"KogitoTrusty" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * KogitoTrustySpec defines the desired state of KogitoTrusty.
     */
    public readonly spec!: pulumi.Output<outputs.app.v1alpha1.KogitoTrustySpec | undefined>;
    /**
     * KogitoTrustyStatus defines the observed state of KogitoTrusty.
     */
    public readonly status!: pulumi.Output<outputs.app.v1alpha1.KogitoTrustyStatus | undefined>;

    /**
     * Create a KogitoTrusty resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: KogitoTrustyArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "app.kiegroup.org/v1alpha1";
            inputs["kind"] = "KogitoTrusty";
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
        super(KogitoTrusty.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a KogitoTrusty resource.
 */
export interface KogitoTrustyArgs {
    readonly apiVersion?: pulumi.Input<"app.kiegroup.org/v1alpha1">;
    readonly kind?: pulumi.Input<"KogitoTrusty">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * KogitoTrustySpec defines the desired state of KogitoTrusty.
     */
    readonly spec?: pulumi.Input<inputs.app.v1alpha1.KogitoTrustySpec>;
    /**
     * KogitoTrustyStatus defines the observed state of KogitoTrusty.
     */
    readonly status?: pulumi.Input<inputs.app.v1alpha1.KogitoTrustyStatus>;
}