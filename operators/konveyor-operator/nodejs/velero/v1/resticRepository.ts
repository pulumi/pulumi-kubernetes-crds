// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

export class ResticRepository extends pulumi.CustomResource {
    /**
     * Get an existing ResticRepository resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ResticRepository {
        return new ResticRepository(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:velero.io/v1:ResticRepository';

    /**
     * Returns true if the given object is an instance of ResticRepository.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ResticRepository {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ResticRepository.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"velero.io/v1" | undefined>;
    public readonly kind!: pulumi.Output<"ResticRepository" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * ResticRepositorySpec is the specification for a ResticRepository.
     */
    public readonly spec!: pulumi.Output<outputs.velero.v1.ResticRepositorySpec | undefined>;
    /**
     * ResticRepositoryStatus is the current status of a ResticRepository.
     */
    public readonly status!: pulumi.Output<outputs.velero.v1.ResticRepositoryStatus | undefined>;

    /**
     * Create a ResticRepository resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ResticRepositoryArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "velero.io/v1";
            inputs["kind"] = "ResticRepository";
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
        super(ResticRepository.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ResticRepository resource.
 */
export interface ResticRepositoryArgs {
    readonly apiVersion?: pulumi.Input<"velero.io/v1">;
    readonly kind?: pulumi.Input<"ResticRepository">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * ResticRepositorySpec is the specification for a ResticRepository.
     */
    readonly spec?: pulumi.Input<inputs.velero.v1.ResticRepositorySpec>;
    /**
     * ResticRepositoryStatus is the current status of a ResticRepository.
     */
    readonly status?: pulumi.Input<inputs.velero.v1.ResticRepositoryStatus>;
}
