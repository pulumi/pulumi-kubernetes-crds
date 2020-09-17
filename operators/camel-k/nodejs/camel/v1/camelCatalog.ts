// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * CamelCatalog is the Schema for the camelcatalogs API
 */
export class CamelCatalog extends pulumi.CustomResource {
    /**
     * Get an existing CamelCatalog resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CamelCatalog {
        return new CamelCatalog(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:camel.apache.org/v1:CamelCatalog';

    /**
     * Returns true if the given object is an instance of CamelCatalog.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CamelCatalog {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CamelCatalog.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"camel.apache.org/v1" | undefined>;
    public readonly kind!: pulumi.Output<"CamelCatalog" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * CamelCatalogSpec defines the desired state of CamelCatalog
     */
    public readonly spec!: pulumi.Output<outputs.camel.v1.CamelCatalogSpec | undefined>;
    /**
     * CamelCatalogStatus defines the observed state of CamelCatalog
     */
    public readonly status!: pulumi.Output<{[key: string]: any} | undefined>;

    /**
     * Create a CamelCatalog resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: CamelCatalogArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "camel.apache.org/v1";
            inputs["kind"] = "CamelCatalog";
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
        super(CamelCatalog.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a CamelCatalog resource.
 */
export interface CamelCatalogArgs {
    readonly apiVersion?: pulumi.Input<"camel.apache.org/v1">;
    readonly kind?: pulumi.Input<"CamelCatalog">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * CamelCatalogSpec defines the desired state of CamelCatalog
     */
    readonly spec?: pulumi.Input<inputs.camel.v1.CamelCatalogSpec>;
    /**
     * CamelCatalogStatus defines the observed state of CamelCatalog
     */
    readonly status?: pulumi.Input<{[key: string]: any}>;
}