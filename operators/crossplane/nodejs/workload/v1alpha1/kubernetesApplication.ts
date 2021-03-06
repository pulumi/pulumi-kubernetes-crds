// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

import {ObjectMeta} from "../../meta/v1";

/**
 * A KubernetesApplication defines an application deployed by Crossplane to a Kubernetes cluster, i.e. a portable KubernetesCluster resource claim.
 */
export class KubernetesApplication extends pulumi.CustomResource {
    /**
     * Get an existing KubernetesApplication resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): KubernetesApplication {
        return new KubernetesApplication(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'kubernetes:workload.crossplane.io/v1alpha1:KubernetesApplication';

    /**
     * Returns true if the given object is an instance of KubernetesApplication.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KubernetesApplication {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KubernetesApplication.__pulumiType;
    }

    public readonly apiVersion!: pulumi.Output<"workload.crossplane.io/v1alpha1" | undefined>;
    public readonly kind!: pulumi.Output<"KubernetesApplication" | undefined>;
    public readonly metadata!: pulumi.Output<ObjectMeta | undefined>;
    /**
     * A KubernetesApplicationSpec specifies the resources of a Kubernetes application.
     */
    public readonly spec!: pulumi.Output<outputs.workload.v1alpha1.KubernetesApplicationSpec | undefined>;
    /**
     * KubernetesApplicationStatus represents the observed state of a KubernetesApplication.
     */
    public readonly status!: pulumi.Output<outputs.workload.v1alpha1.KubernetesApplicationStatus | undefined>;

    /**
     * Create a KubernetesApplication resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: KubernetesApplicationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            inputs["apiVersion"] = "workload.crossplane.io/v1alpha1";
            inputs["kind"] = "KubernetesApplication";
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
        super(KubernetesApplication.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a KubernetesApplication resource.
 */
export interface KubernetesApplicationArgs {
    readonly apiVersion?: pulumi.Input<"workload.crossplane.io/v1alpha1">;
    readonly kind?: pulumi.Input<"KubernetesApplication">;
    readonly metadata?: pulumi.Input<ObjectMeta>;
    /**
     * A KubernetesApplicationSpec specifies the resources of a Kubernetes application.
     */
    readonly spec?: pulumi.Input<inputs.workload.v1alpha1.KubernetesApplicationSpec>;
    /**
     * KubernetesApplicationStatus represents the observed state of a KubernetesApplication.
     */
    readonly status?: pulumi.Input<inputs.workload.v1alpha1.KubernetesApplicationStatus>;
}
