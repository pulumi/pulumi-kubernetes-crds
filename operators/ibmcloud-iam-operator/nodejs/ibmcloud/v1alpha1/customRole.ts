// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * CustomRole is the Schema for the customroles API
 */
export class CustomRole extends pulumi.CustomResource {
    /**
     * Get an existing CustomRole resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CustomRole {
        return new CustomRole(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:ibmcloud.ibm.com/v1alpha1:CustomRole';

    /**
     * Returns true if the given object is an instance of CustomRole.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CustomRole {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CustomRole.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"ibmcloud.ibm.com/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"CustomRole" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * CustomRoleSpec defines the desired state of CustomRole
     */
    public readonly spec!: pulumi.Output<outputs.ibmcloud.v1alpha1.CustomRoleSpec | undefined>;
    /**
     * CustomRoleStatus defines the observed state of CustomRole
     */
    public readonly status!: pulumi.Output<outputs.ibmcloud.v1alpha1.CustomRoleStatus | undefined>;

    /**
     * Create a CustomRole resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: CustomRoleArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "ibmcloud.ibm.com/v1alpha1";
            inputs["kind"] = "CustomRole";
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
        super(CustomRole.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a CustomRole resource.
 */
export interface CustomRoleArgs {
    readonly apiVersion?: pulumi.Input<"ibmcloud.ibm.com/v1alpha1">;
    readonly kind?: pulumi.Input<"CustomRole">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * CustomRoleSpec defines the desired state of CustomRole
     */
    readonly spec?: pulumi.Input<inputs.ibmcloud.v1alpha1.CustomRoleSpec>;
    /**
     * CustomRoleStatus defines the observed state of CustomRole
     */
    readonly status?: pulumi.Input<inputs.ibmcloud.v1alpha1.CustomRoleStatus>;
}
