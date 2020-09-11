// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace operator {
    export namespace v1 {
        /**
         * Spec represents the desired deployment configuration of Klusterlet agent.
         */
        export interface KlusterletSpec {
            /**
             * ClusterName is the name of the managed cluster to be created on hub. The Klusterlet agent generates a random name if it is not set, or discovers the appropriate cluster name on openshift.
             */
            clusterName?: pulumi.Input<string>;
            /**
             * ExternalServerURLs represents the a list of apiserver urls and ca bundles that is accessible externally If it is set empty, managed cluster has no externally accessible url that hub cluster can visit.
             */
            externalServerURLs?: pulumi.Input<pulumi.Input<inputs.operator.v1.KlusterletSpecExternalServerURLs>[]>;
            /**
             * Namespace is the namespace to deploy the agent. The namespace must have a prefix of "open-cluster-management-", and if it is not set, the namespace of "open-cluster-management-agent" is used to deploy agent.
             */
            namespace?: pulumi.Input<string>;
            /**
             * RegistrationImagePullSpec represents the desired image configuration of registration agent.
             */
            registrationImagePullSpec?: pulumi.Input<string>;
            /**
             * WorkImagePullSpec represents the desired image configuration of work agent.
             */
            workImagePullSpec?: pulumi.Input<string>;
        }

        /**
         * ServerURL represents the apiserver url and ca bundle that is accessible externally
         */
        export interface KlusterletSpecExternalServerURLs {
            /**
             * CABundle is the ca bundle to connect to apiserver of the managed cluster. System certs are used if it is not set.
             */
            caBundle?: pulumi.Input<string>;
            /**
             * URL is the url of apiserver endpoint of the managed cluster.
             */
            url?: pulumi.Input<string>;
        }

        /**
         * Status represents the current status of Klusterlet agent.
         */
        export interface KlusterletStatus {
            /**
             * Conditions contain the different condition statuses for this Klusterlet. Valid condition types are: Applied: components have been applied in the managed cluster. Available: components in the managed cluster are available and ready to serve. Progressing: components in the managed cluster are in a transitioning state. Degraded: components in the managed cluster do not match the desired configuration and only provide degraded service.
             */
            conditions?: pulumi.Input<pulumi.Input<inputs.operator.v1.KlusterletStatusConditions>[]>;
            /**
             * Generations are used to determine when an item needs to be reconciled or has changed in a way that needs a reaction.
             */
            generations?: pulumi.Input<pulumi.Input<inputs.operator.v1.KlusterletStatusGenerations>[]>;
            /**
             * ObservedGeneration is the last generation change you've dealt with
             */
            observedGeneration?: pulumi.Input<number>;
            /**
             * RelatedResources are used to track the resources that are related to this Klusterlet
             */
            relatedResources?: pulumi.Input<pulumi.Input<inputs.operator.v1.KlusterletStatusRelatedResources>[]>;
        }

        /**
         * StatusCondition contains condition information.
         */
        export interface KlusterletStatusConditions {
            /**
             * LastTransitionTime is the last time the condition changed from one status to another.
             */
            lastTransitionTime?: pulumi.Input<string>;
            /**
             * Message is a human-readable message indicating details about the last status change.
             */
            message?: pulumi.Input<string>;
            /**
             * Reason is a (brief) reason for the condition's last status change.
             */
            reason?: pulumi.Input<string>;
            /**
             * Status is the status of the condition. One of True, False, Unknown.
             */
            status?: pulumi.Input<string>;
            /**
             * Type is the type of the cluster condition.
             */
            type?: pulumi.Input<string>;
        }

        /**
         * GenerationStatus keeps track of the generation for a given resource so that decisions about forced updates can be made. the definition matches the GenerationStatus defined in github.com/openshift/api/v1
         */
        export interface KlusterletStatusGenerations {
            /**
             * group is the group of the thing you're tracking
             */
            group?: pulumi.Input<string>;
            /**
             * lastGeneration is the last generation of the thing that controller applies
             */
            lastGeneration?: pulumi.Input<number>;
            /**
             * name is the name of the thing you're tracking
             */
            name?: pulumi.Input<string>;
            /**
             * namespace is where the thing you're tracking is
             */
            namespace?: pulumi.Input<string>;
            /**
             * resource is the resource type of the thing you're tracking
             */
            resource?: pulumi.Input<string>;
            /**
             * version is the version of the thing you're tracking
             */
            version?: pulumi.Input<string>;
        }

        /**
         * RelatedResourceMeta represents the resource that is managed by an operator
         */
        export interface KlusterletStatusRelatedResources {
            /**
             * group is the group of the thing you're tracking
             */
            group?: pulumi.Input<string>;
            /**
             * name is the name of the thing you're tracking
             */
            name?: pulumi.Input<string>;
            /**
             * namespace is where the thing you're tracking is
             */
            namespace?: pulumi.Input<string>;
            /**
             * resource is the resource type of the thing you're tracking
             */
            resource?: pulumi.Input<string>;
            /**
             * version is the version of the thing you're tracking
             */
            version?: pulumi.Input<string>;
        }
    }
}
