// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace sources {
    export namespace v1alpha1 {
        export interface CamelSourceSpec {
            /**
             * Defines overrides to control modifications of the event sent to the sink.
             */
            ceOverrides?: {[key: string]: any};
            /**
             * Reference to an object that will resolve to a domain name to use as the sink.
             */
            sink?: {[key: string]: any};
            source: outputs.sources.v1alpha1.CamelSourceSpecSource;
        }

        export interface CamelSourceSpecSource {
            flow?: {[key: string]: any};
            integration?: {[key: string]: any};
        }

        export interface CamelSourceStatus {
            conditions?: outputs.sources.v1alpha1.CamelSourceStatusConditions[];
            sinkUri?: string;
        }

        export interface CamelSourceStatusConditions {
            lastTransitionTime?: string;
            message?: string;
            reason?: string;
            severity?: string;
            status: string;
            type: string;
        }
    }
}
