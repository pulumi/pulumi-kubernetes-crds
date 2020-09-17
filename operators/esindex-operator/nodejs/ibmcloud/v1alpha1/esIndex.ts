// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

export class EsIndex extends pulumi.CustomResource {
    /**
     * Get an existing EsIndex resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): EsIndex {
        return new EsIndex(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:ibmcloud.ibm.com/v1alpha1:EsIndex';

    /**
     * Returns true if the given object is an instance of EsIndex.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is EsIndex {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === EsIndex.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"ibmcloud.ibm.com/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"EsIndex" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    public readonly spec!: pulumi.Output<outputs.ibmcloud.v1alpha1.EsIndexSpec | undefined>;
    public readonly status!: pulumi.Output<outputs.ibmcloud.v1alpha1.EsIndexStatus | undefined>;

    /**
     * Create a EsIndex resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: EsIndexArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "ibmcloud.ibm.com/v1alpha1";
            inputs["kind"] = "EsIndex";
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
        super(EsIndex.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a EsIndex resource.
 */
export interface EsIndexArgs {
    readonly apiVersion?: pulumi.Input<"ibmcloud.ibm.com/v1alpha1">;
    readonly kind?: pulumi.Input<"EsIndex">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    readonly spec?: pulumi.Input<inputs.ibmcloud.v1alpha1.EsIndexSpec>;
    readonly status?: pulumi.Input<inputs.ibmcloud.v1alpha1.EsIndexStatus>;
}
