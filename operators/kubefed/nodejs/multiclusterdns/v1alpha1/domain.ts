// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

export class Domain extends pulumi.CustomResource {
    /**
     * Get an existing Domain resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Domain {
        return new Domain(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:multiclusterdns.kubefed.io/v1alpha1:Domain';

    /**
     * Returns true if the given object is an instance of Domain.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Domain {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Domain.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"multiclusterdns.kubefed.io/v1alpha1" | undefined>;
    /**
     * Domain is the DNS zone associated with the KubeFed control plane
     */
    public readonly domain!: pulumi.Output<string>;
    public readonly kind!: pulumi.Output<"Domain" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * NameServer is the authoritative DNS name server for the KubeFed domain
     */
    public readonly nameServer!: pulumi.Output<string | undefined>;

    /**
     * Create a Domain resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: DomainArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "multiclusterdns.kubefed.io/v1alpha1";
            inputs["domain"] = args ? args.domain : undefined;
            inputs["kind"] = "Domain";
            inputs["metadata"] = args ? args.metadata : undefined;
            inputs["nameServer"] = args ? args.nameServer : undefined;
        } else {
            inputs["apiVersion"] = undefined /*out*/;
            inputs["domain"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["metadata"] = undefined /*out*/;
            inputs["nameServer"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Domain.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Domain resource.
 */
export interface DomainArgs {
    readonly apiVersion?: pulumi.Input<"multiclusterdns.kubefed.io/v1alpha1">;
    /**
     * Domain is the DNS zone associated with the KubeFed control plane
     */
    readonly domain?: pulumi.Input<string>;
    readonly kind?: pulumi.Input<"Domain">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * NameServer is the authoritative DNS name server for the KubeFed domain
     */
    readonly nameServer?: pulumi.Input<string>;
}