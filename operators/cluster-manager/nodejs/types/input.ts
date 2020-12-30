// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace operator {
    export namespace v1 {
        /**
         * Spec represents a desired deployment configuration of controllers that govern registration and work distribution for attached Klusterlets.
         */
        export interface ClusterManagerSpec {
            /**
             * RegistrationImagePullSpec represents the desired image of registration controller/webhook installed on hub.
             */
            registrationImagePullSpec?: pulumi.Input<string>;
            /**
             * WorkImagePullSpec represents the desired image configuration of work controller/webhook installed on hub.
             */
            workImagePullSpec?: pulumi.Input<string>;
        }

        /**
         * Status represents the current status of controllers that govern the lifecycle of managed clusters.
         */
        export interface ClusterManagerStatus {
            /**
             * Conditions contain the different condition statuses for this ClusterManager. Valid condition types are: Applied: components in hub are applied. Available: components in hub are available and ready to serve. Progressing: components in hub are in a transitioning state. Degraded: components in hub do not match the desired configuration and only provide degraded service.
             */
            conditions?: pulumi.Input<pulumi.Input<inputs.operator.v1.ClusterManagerStatusConditions>[]>;
            /**
             * Generations are used to determine when an item needs to be reconciled or has changed in a way that needs a reaction.
             */
            generations?: pulumi.Input<pulumi.Input<inputs.operator.v1.ClusterManagerStatusGenerations>[]>;
            /**
             * ObservedGeneration is the last generation change you've dealt with
             */
            observedGeneration?: pulumi.Input<number>;
            /**
             * RelatedResources are used to track the resources that are related to this ClusterManager
             */
            relatedResources?: pulumi.Input<pulumi.Input<inputs.operator.v1.ClusterManagerStatusRelatedResources>[]>;
        }

        /**
         * Condition contains details for one aspect of the current state of this API Resource. --- This struct is intended for direct use as an array at the field path .status.conditions.  For example, type FooStatus struct{     // Represents the observations of a foo's current state.     // Known .status.conditions.type are: "Available", "Progressing", and "Degraded"     // +patchMergeKey=type     // +patchStrategy=merge     // +listType=map     // +listMapKey=type     Conditions []metav1.Condition `json:"conditions,omitempty" patchStrategy:"merge" patchMergeKey:"type" protobuf:"bytes,1,rep,name=conditions"` 
         *      // other fields }
         */
        export interface ClusterManagerStatusConditions {
            /**
             * lastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
             */
            lastTransitionTime: pulumi.Input<string>;
            /**
             * message is a human readable message indicating details about the transition. This may be an empty string.
             */
            message: pulumi.Input<string>;
            /**
             * observedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.
             */
            observedGeneration?: pulumi.Input<number>;
            /**
             * reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty.
             */
            reason: pulumi.Input<string>;
            /**
             * status of the condition, one of True, False, Unknown.
             */
            status: pulumi.Input<string>;
            /**
             * type of condition in CamelCase or in foo.example.com/CamelCase. --- Many .condition.type values are consistent across resources like Available, but because arbitrary conditions can be useful (see .node.status.conditions), the ability to deconflict is important. The regex it matches is (dns1123SubdomainFmt/)?(qualifiedNameFmt)
             */
            type: pulumi.Input<string>;
        }

        /**
         * GenerationStatus keeps track of the generation for a given resource so that decisions about forced updates can be made. the definition matches the GenerationStatus defined in github.com/openshift/api/v1
         */
        export interface ClusterManagerStatusGenerations {
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
        export interface ClusterManagerStatusRelatedResources {
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
