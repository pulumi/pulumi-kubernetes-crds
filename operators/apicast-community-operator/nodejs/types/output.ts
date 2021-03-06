// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace apps {
    export namespace v1alpha1 {
        export interface APIcastSpec {
            adminPortalCredentialsRef?: {[key: string]: any};
            embeddedConfigurationSecretRef?: {[key: string]: any};
        }

        /**
         * APIcastStatus defines the observed state of APIcast
         */
        export interface APIcastStatus {
            /**
             * Represents the latest available observations of a replica set's current state.
             */
            conditions?: outputs.apps.v1alpha1.APIcastStatusConditions[];
            /**
             * The image being used in the APIcast deployment
             */
            image?: string;
        }

        export interface APIcastStatusConditions {
            /**
             * Status of the condition, one of True, False, Unknown.
             */
            status: string;
            /**
             * Type of replica set condition.
             */
            type: string;
        }
    }
}
