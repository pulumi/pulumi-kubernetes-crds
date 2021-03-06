// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace snapscheduler {
    export namespace v1 {
        /**
         * SnapshotScheduleSpec defines the desired state of SnapshotSchedule
         */
        export interface SnapshotScheduleSpec {
            /**
             * ClaimSelector selects which PVCs will be snapshotted according to this schedule.
             */
            claimSelector?: pulumi.Input<inputs.snapscheduler.v1.SnapshotScheduleSpecClaimSelector>;
            /**
             * Disabled determines whether this schedule is currently disabled.
             */
            disabled?: pulumi.Input<boolean>;
            /**
             * Retention determines how long this schedule's snapshots will be kept.
             */
            retention?: pulumi.Input<inputs.snapscheduler.v1.SnapshotScheduleSpecRetention>;
            /**
             * Schedule is a Cronspec specifying when snapshots should be taken. See https://en.wikipedia.org/wiki/Cron for a description of the format.
             */
            schedule?: pulumi.Input<string>;
            /**
             * SnapshotTemplate is a template description of the Snapshots to be created.
             */
            snapshotTemplate?: pulumi.Input<inputs.snapscheduler.v1.SnapshotScheduleSpecSnapshotTemplate>;
        }

        /**
         * ClaimSelector selects which PVCs will be snapshotted according to this schedule.
         */
        export interface SnapshotScheduleSpecClaimSelector {
            /**
             * matchExpressions is a list of label selector requirements. The requirements are ANDed.
             */
            matchExpressions?: pulumi.Input<pulumi.Input<inputs.snapscheduler.v1.SnapshotScheduleSpecClaimSelectorMatchExpressions>[]>;
            /**
             * matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
             */
            matchLabels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        }

        /**
         * A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface SnapshotScheduleSpecClaimSelectorMatchExpressions {
            /**
             * key is the label key that the selector applies to.
             */
            key: pulumi.Input<string>;
            /**
             * operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.
             */
            operator: pulumi.Input<string>;
            /**
             * values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
             */
            values?: pulumi.Input<pulumi.Input<string>[]>;
        }

        /**
         * Retention determines how long this schedule's snapshots will be kept.
         */
        export interface SnapshotScheduleSpecRetention {
            /**
             * Expires is the length of time (time.Duration) after which a given Snapshot will be deleted.
             */
            expires?: pulumi.Input<string>;
            maxCount?: pulumi.Input<number>;
        }

        /**
         * SnapshotTemplate is a template description of the Snapshots to be created.
         */
        export interface SnapshotScheduleSpecSnapshotTemplate {
            /**
             * Labels is a list of labels that should be added to each Snapshot created by this schedule.
             */
            labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
            /**
             * SnapshotClassName is the name of the VSC to be used when creating Snapshots.
             */
            snapshotClassName?: pulumi.Input<string>;
        }

        /**
         * SnapshotScheduleStatus defines the observed state of SnapshotSchedule
         */
        export interface SnapshotScheduleStatus {
            /**
             * Conditions is a list of conditions related to operator reconciliation.
             */
            conditions?: pulumi.Input<pulumi.Input<inputs.snapscheduler.v1.SnapshotScheduleStatusConditions>[]>;
            /**
             * LastSnapshotTime is the time of the most recent set of snapshots generated by this schedule.
             */
            lastSnapshotTime?: pulumi.Input<string>;
            /**
             * NextSnapshotTime is the time when this schedule should create the next set of snapshots.
             */
            nextSnapshotTime?: pulumi.Input<string>;
        }

        /**
         * Condition represents the state of the operator's reconciliation functionality.
         */
        export interface SnapshotScheduleStatusConditions {
            lastHeartbeatTime?: pulumi.Input<string>;
            lastTransitionTime?: pulumi.Input<string>;
            message?: pulumi.Input<string>;
            reason?: pulumi.Input<string>;
            status: pulumi.Input<string>;
            /**
             * ConditionType is the state of the operator's reconciliation functionality.
             */
            type: pulumi.Input<string>;
        }
    }
}
