// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace eventing {
    export namespace v1alpha1 {
        export interface KnativeEventingKafkaSpec {
            /**
             * URI(s) of Apache Kafka broker(s)
             */
            bootstrapServers: string;
            /**
             * Flag that controls whether Kafka channel provisioner is configured as the cluster default. Defaults to false.
             */
            setAsDefaultChannelProvisioner?: boolean;
        }

        export interface KnativeEventingKafkaStatus {
            /**
             * The latest available observations of a resource's current state. +patchMergeKey=type +patchStrategy=merge
             */
            conditions?: outputs.eventing.v1alpha1.KnativeEventingKafkaStatusConditions[];
            /**
             * The version of the installed release
             */
            version?: string;
        }

        export interface KnativeEventingKafkaStatusConditions {
            /**
             * LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant).
             */
            lastTransitionTime?: string;
            /**
             * A human readable message indicating details about the transition.
             */
            message?: string;
            /**
             * The reason for the condition's last transition.
             */
            reason?: string;
            /**
             * Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error.
             */
            severity?: string;
            /**
             * Status of the condition, one of True, False, Unknown. +required
             */
            status: string;
            /**
             * Type of condition. +required
             */
            type: string;
        }
    }
}
