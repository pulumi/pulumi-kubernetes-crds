// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * The `CheCluster` custom resource allows defining and managing a Che server installation
 */
export class CheCluster extends pulumi.CustomResource {
    /**
     * Get an existing CheCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CheCluster {
        return new CheCluster(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:org.eclipse.che/v1:CheCluster';

    /**
     * Returns true if the given object is an instance of CheCluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CheCluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CheCluster.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"org.eclipse.che/v1" | undefined>;
    public readonly kind!: pulumi.Output<"CheCluster" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * Desired configuration of the Che installation. Based on these settings, the operator automatically creates and maintains several config maps that will contain the appropriate environment variables the various components of the Che installation. These generated config maps should NOT be updated manually.
     */
    public readonly spec!: pulumi.Output<outputs.org.v1.CheClusterSpec | undefined>;
    /**
     * CheClusterStatus defines the observed state of Che installation
     */
    public readonly status!: pulumi.Output<outputs.org.v1.CheClusterStatus | undefined>;

    /**
     * Create a CheCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: CheClusterArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "org.eclipse.che/v1";
            inputs["kind"] = "CheCluster";
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
        super(CheCluster.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a CheCluster resource.
 */
export interface CheClusterArgs {
    readonly apiVersion?: pulumi.Input<"org.eclipse.che/v1">;
    readonly kind?: pulumi.Input<"CheCluster">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * Desired configuration of the Che installation. Based on these settings, the operator automatically creates and maintains several config maps that will contain the appropriate environment variables the various components of the Che installation. These generated config maps should NOT be updated manually.
     */
    readonly spec?: pulumi.Input<inputs.org.v1.CheClusterSpec>;
    /**
     * CheClusterStatus defines the observed state of Che installation
     */
    readonly status?: pulumi.Input<inputs.org.v1.CheClusterStatus>;
}
