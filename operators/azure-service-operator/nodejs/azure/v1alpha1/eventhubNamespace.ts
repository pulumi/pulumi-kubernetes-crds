// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * EventhubNamespace is the Schema for the eventhubnamespaces API
 */
export class EventhubNamespace extends pulumi.CustomResource {
    /**
     * Get an existing EventhubNamespace resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): EventhubNamespace {
        return new EventhubNamespace(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:azure.microsoft.com/v1alpha1:EventhubNamespace';

    /**
     * Returns true if the given object is an instance of EventhubNamespace.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is EventhubNamespace {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === EventhubNamespace.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"azure.microsoft.com/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"EventhubNamespace" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * EventhubNamespaceSpec defines the desired state of EventhubNamespace
     */
    public readonly spec!: pulumi.Output<outputs.azure.v1alpha1.EventhubNamespaceSpec | undefined>;
    /**
     * ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
     */
    public readonly status!: pulumi.Output<outputs.azure.v1alpha1.EventhubNamespaceStatus | undefined>;

    /**
     * Create a EventhubNamespace resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: EventhubNamespaceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "azure.microsoft.com/v1alpha1";
            inputs["kind"] = "EventhubNamespace";
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
        super(EventhubNamespace.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a EventhubNamespace resource.
 */
export interface EventhubNamespaceArgs {
    readonly apiVersion?: pulumi.Input<"azure.microsoft.com/v1alpha1">;
    readonly kind?: pulumi.Input<"EventhubNamespace">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * EventhubNamespaceSpec defines the desired state of EventhubNamespace
     */
    readonly spec?: pulumi.Input<inputs.azure.v1alpha1.EventhubNamespaceSpec>;
    /**
     * ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
     */
    readonly status?: pulumi.Input<inputs.azure.v1alpha1.EventhubNamespaceStatus>;
}
