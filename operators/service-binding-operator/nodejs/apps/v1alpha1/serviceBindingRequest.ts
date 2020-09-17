// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * ServiceBindingRequest expresses intent to bind an operator-backed service with an application workload.
 */
export class ServiceBindingRequest extends pulumi.CustomResource {
    /**
     * Get an existing ServiceBindingRequest resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ServiceBindingRequest {
        return new ServiceBindingRequest(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:apps.openshift.io/v1alpha1:ServiceBindingRequest';

    /**
     * Returns true if the given object is an instance of ServiceBindingRequest.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServiceBindingRequest {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServiceBindingRequest.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"apps.openshift.io/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"ServiceBindingRequest" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * ServiceBindingRequestSpec defines the desired state of ServiceBindingRequest
     */
    public readonly spec!: pulumi.Output<outputs.apps.v1alpha1.ServiceBindingRequestSpec | undefined>;
    /**
     * ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
     */
    public readonly status!: pulumi.Output<outputs.apps.v1alpha1.ServiceBindingRequestStatus | undefined>;

    /**
     * Create a ServiceBindingRequest resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ServiceBindingRequestArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "apps.openshift.io/v1alpha1";
            inputs["kind"] = "ServiceBindingRequest";
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
        super(ServiceBindingRequest.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ServiceBindingRequest resource.
 */
export interface ServiceBindingRequestArgs {
    readonly apiVersion?: pulumi.Input<"apps.openshift.io/v1alpha1">;
    readonly kind?: pulumi.Input<"ServiceBindingRequest">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * ServiceBindingRequestSpec defines the desired state of ServiceBindingRequest
     */
    readonly spec?: pulumi.Input<inputs.apps.v1alpha1.ServiceBindingRequestSpec>;
    /**
     * ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
     */
    readonly status?: pulumi.Input<inputs.apps.v1alpha1.ServiceBindingRequestStatus>;
}
