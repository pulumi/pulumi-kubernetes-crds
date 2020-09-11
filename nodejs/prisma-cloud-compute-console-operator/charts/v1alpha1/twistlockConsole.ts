// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

export class TwistlockConsole extends pulumi.CustomResource {
    /**
     * Get an existing TwistlockConsole resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): TwistlockConsole {
        return new TwistlockConsole(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:charts.helm.k8s.io/v1alpha1:TwistlockConsole';

    /**
     * Returns true if the given object is an instance of TwistlockConsole.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is TwistlockConsole {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === TwistlockConsole.__pulumiType;
    }


    /**
     * Create a TwistlockConsole resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: TwistlockConsoleArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
        } else {
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(TwistlockConsole.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a TwistlockConsole resource.
 */
export interface TwistlockConsoleArgs {
}
