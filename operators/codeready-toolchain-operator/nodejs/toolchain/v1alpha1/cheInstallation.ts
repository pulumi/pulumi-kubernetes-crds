// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

export class CheInstallation extends pulumi.CustomResource {
    /**
     * Get an existing CheInstallation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CheInstallation {
        return new CheInstallation(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:toolchain.openshift.dev/v1alpha1:CheInstallation';

    /**
     * Returns true if the given object is an instance of CheInstallation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CheInstallation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CheInstallation.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"toolchain.openshift.dev/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"TektonInstallation" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;

    /**
     * Create a CheInstallation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: CheInstallationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "toolchain.openshift.dev/v1alpha1";
            inputs["kind"] = "TektonInstallation";
            inputs["metadata"] = args ? args.metadata : undefined;
        } else {
            inputs["apiVersion"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["metadata"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(CheInstallation.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a CheInstallation resource.
 */
export interface CheInstallationArgs {
    readonly apiVersion?: pulumi.Input<"toolchain.openshift.dev/v1alpha1">;
    readonly kind?: pulumi.Input<"TektonInstallation">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
}
