// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * Service is an instance of a Service resource on IBM Cloud.
 */
export class Service extends pulumi.CustomResource {
    /**
     * Get an existing Service resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Service {
        return new Service(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:ibmcloud.ibm.com/v1beta1:Service';

    /**
     * Returns true if the given object is an instance of Service.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Service {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Service.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"ibmcloud.ibm.com/v1beta1" | undefined>;
    public readonly kind!: pulumi.Output<"Service" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * ServiceSpec defines the desired state of Service
     */
    public readonly spec!: pulumi.Output<outputs.ibmcloud.v1beta1.ServiceSpec | undefined>;
    /**
     * ServiceStatus defines the observed state of Service
     */
    public readonly status!: pulumi.Output<outputs.ibmcloud.v1beta1.ServiceStatus | undefined>;

    /**
     * Create a Service resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ServiceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "ibmcloud.ibm.com/v1beta1";
            inputs["kind"] = "Service";
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
        super(Service.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Service resource.
 */
export interface ServiceArgs {
    readonly apiVersion?: pulumi.Input<"ibmcloud.ibm.com/v1beta1">;
    readonly kind?: pulumi.Input<"Service">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * ServiceSpec defines the desired state of Service
     */
    readonly spec?: pulumi.Input<inputs.ibmcloud.v1beta1.ServiceSpec>;
    /**
     * ServiceStatus defines the observed state of Service
     */
    readonly status?: pulumi.Input<inputs.ibmcloud.v1beta1.ServiceStatus>;
}
