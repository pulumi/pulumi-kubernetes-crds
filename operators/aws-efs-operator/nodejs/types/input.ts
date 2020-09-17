// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace awsefs {
    export namespace v1alpha1 {
        /**
         * SharedVolumeSpec defines the desired state of SharedVolume
         */
        export interface SharedVolumeSpec {
            /**
             * The ID of an EFS volume access point, e.g. `fsap-0123456789abcdef`. The EFS volume will be mounted to the specified access point. Required. Immutable.
             */
            accessPointID: pulumi.Input<string>;
            /**
             * The ID of the EFS volume, e.g. `fs-0123cdef`. Required. Immutable.
             */
            fileSystemID: pulumi.Input<string>;
        }

        /**
         * SharedVolumeStatus defines the observed state of SharedVolume
         */
        export interface SharedVolumeStatus {
            /**
             * ClaimRef refers to the PersistentVolumeClaim bound to a PersistentVolume representing the file system access point, both of which are created at the behest of this SharedVolume.
             */
            claimRef?: pulumi.Input<inputs.awsefs.v1alpha1.SharedVolumeStatusClaimRef>;
            /**
             * Message is a human-readable string, usually describing what went wrong when `Phase` is `SharedVolumeFailed`.
             */
            message?: pulumi.Input<string>;
            /**
             * Phase indicates the state of the PersistentVolume and PersistentVolumeClaim artifacts associated with this SharedVolume. See SharedVolumePhase consts for possible values.
             */
            phase?: pulumi.Input<string>;
        }

        /**
         * ClaimRef refers to the PersistentVolumeClaim bound to a PersistentVolume representing the file system access point, both of which are created at the behest of this SharedVolume.
         */
        export interface SharedVolumeStatusClaimRef {
            /**
             * APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.
             */
            apiGroup?: pulumi.Input<string>;
            /**
             * Kind is the type of resource being referenced
             */
            kind: pulumi.Input<string>;
            /**
             * Name is the name of resource being referenced
             */
            name: pulumi.Input<string>;
        }
    }
}
