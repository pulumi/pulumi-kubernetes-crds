// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace ibmcloud {
    export namespace v1alpha1 {
        /**
         * ComposableSpec defines the desired state of Composable
         */
        export interface ComposableSpec {
            /**
             * Template defines the underlying object
             */
            template: {[key: string]: any};
        }

        /**
         * ComposableStatus defines the observed state of Composable
         */
        export interface ComposableStatus {
            /**
             * Message - provides human readable explanation of the Composable status
             */
            message?: string;
            /**
             * State shows the composable object state
             */
            state?: string;
        }
    }
}