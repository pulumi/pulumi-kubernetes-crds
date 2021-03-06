// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace iot {
    export namespace v1alpha1 {
        export interface HawkbitSpec {
            database?: any;
            imageOverrides?: pulumi.Input<{[key: string]: pulumi.Input<inputs.iot.v1alpha1.HawkbitSpecImageOverrides>}>;
            rabbit?: any;
            signOn?: pulumi.Input<inputs.iot.v1alpha1.HawkbitSpecSignOn>;
        }

        export interface HawkbitSpecImageOverrides {
            image?: pulumi.Input<string>;
            pullPolicy?: pulumi.Input<string>;
        }

        export interface HawkbitSpecSignOn {
            keycloak?: pulumi.Input<inputs.iot.v1alpha1.HawkbitSpecSignOnKeycloak>;
        }

        export interface HawkbitSpecSignOnKeycloak {
            hawkbitUrl?: pulumi.Input<string>;
            /**
             * Selector for looking up Keycloak Custom Resources.
             */
            instanceSelector?: pulumi.Input<inputs.iot.v1alpha1.HawkbitSpecSignOnKeycloakInstanceSelector>;
        }

        /**
         * Selector for looking up Keycloak Custom Resources.
         */
        export interface HawkbitSpecSignOnKeycloakInstanceSelector {
            /**
             * matchExpressions is a list of label selector requirements. The requirements are ANDed.
             */
            matchExpressions?: pulumi.Input<pulumi.Input<inputs.iot.v1alpha1.HawkbitSpecSignOnKeycloakInstanceSelectorMatchExpressions>[]>;
            /**
             * matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
             */
            matchLabels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        }

        /**
         * A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface HawkbitSpecSignOnKeycloakInstanceSelectorMatchExpressions {
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

        export interface HawkbitStatus {
            message?: pulumi.Input<string>;
            phase?: pulumi.Input<string>;
        }
    }
}
