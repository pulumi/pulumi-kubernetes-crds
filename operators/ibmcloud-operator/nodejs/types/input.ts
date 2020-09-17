// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace ibmcloud {
    export namespace v1alpha1 {
        export interface BindingSpec {
            alias?: pulumi.Input<string>;
            parameters?: pulumi.Input<pulumi.Input<inputs.ibmcloud.v1alpha1.BindingSpecParameters>[]>;
            role?: pulumi.Input<string>;
            secretName?: pulumi.Input<string>;
            serviceName: pulumi.Input<string>;
            serviceNamespace?: pulumi.Input<string>;
        }

        export interface BindingSpecParameters {
            /**
             * A parameter may have attributes (e.g. message hub topic might have partitions)
             */
            attributes?: pulumi.Input<{[key: string]: any}>;
            /**
             * Name representing the key.
             */
            name: pulumi.Input<string>;
            /**
             * Defaults to null.
             */
            value?: any;
            /**
             * Source for the value. Cannot be used if value is not empty.
             */
            valueFrom?: pulumi.Input<inputs.ibmcloud.v1alpha1.BindingSpecParametersValueFrom>;
        }

        /**
         * Source for the value. Cannot be used if value is not empty.
         */
        export interface BindingSpecParametersValueFrom {
            /**
             * Selects a key of a ConfigMap.
             */
            configMapKeyRef?: pulumi.Input<{[key: string]: any}>;
            /**
             * Selects a key of a secret in the resource namespace
             */
            secretKeyRef?: pulumi.Input<{[key: string]: any}>;
        }

        export interface BindingStatus {
            generation?: pulumi.Input<number>;
            instanceId?: pulumi.Input<string>;
            keyInstanceId?: pulumi.Input<string>;
            message?: pulumi.Input<string>;
            secretName?: pulumi.Input<string>;
            state?: pulumi.Input<string>;
        }

        export interface ServiceSpec {
            context?: pulumi.Input<inputs.ibmcloud.v1alpha1.ServiceSpecContext>;
            externalName?: pulumi.Input<string>;
            parameters?: pulumi.Input<pulumi.Input<inputs.ibmcloud.v1alpha1.ServiceSpecParameters>[]>;
            plan: pulumi.Input<string>;
            serviceClass: pulumi.Input<string>;
            serviceClassType?: pulumi.Input<string>;
            tags?: pulumi.Input<pulumi.Input<string>[]>;
        }

        export interface ServiceSpecContext {
            org?: pulumi.Input<string>;
            region?: pulumi.Input<string>;
            resourcegroup?: pulumi.Input<string>;
            resourcegroupid?: pulumi.Input<string>;
            resourcelocation?: pulumi.Input<string>;
            space?: pulumi.Input<string>;
            user?: pulumi.Input<string>;
        }

        export interface ServiceSpecParameters {
            /**
             * A parameter may have attributes (e.g. message hub topic might have partitions)
             */
            attributes?: pulumi.Input<{[key: string]: any}>;
            /**
             * Name representing the key.
             */
            name: pulumi.Input<string>;
            /**
             * Defaults to null.
             */
            value?: any;
            /**
             * Source for the value. Cannot be used if value is not empty.
             */
            valueFrom?: pulumi.Input<inputs.ibmcloud.v1alpha1.ServiceSpecParametersValueFrom>;
        }

        /**
         * Source for the value. Cannot be used if value is not empty.
         */
        export interface ServiceSpecParametersValueFrom {
            /**
             * Selects a key of a ConfigMap.
             */
            configMapKeyRef?: pulumi.Input<{[key: string]: any}>;
            /**
             * Selects a key of a secret in the resource namespace
             */
            secretKeyRef?: pulumi.Input<{[key: string]: any}>;
        }

        export interface ServiceStatus {
            context?: pulumi.Input<inputs.ibmcloud.v1alpha1.ServiceStatusContext>;
            dashboardURL?: pulumi.Input<string>;
            externalName?: pulumi.Input<string>;
            generation?: pulumi.Input<number>;
            instanceId?: pulumi.Input<string>;
            message?: pulumi.Input<string>;
            parameters?: pulumi.Input<pulumi.Input<inputs.ibmcloud.v1alpha1.ServiceStatusParameters>[]>;
            plan: pulumi.Input<string>;
            serviceClass: pulumi.Input<string>;
            serviceClassType: pulumi.Input<string>;
            state?: pulumi.Input<string>;
            tags?: pulumi.Input<pulumi.Input<string>[]>;
        }

        export interface ServiceStatusContext {
            org?: pulumi.Input<string>;
            region?: pulumi.Input<string>;
            resourcegroup?: pulumi.Input<string>;
            resourcegroupid?: pulumi.Input<string>;
            resourcelocation?: pulumi.Input<string>;
            space?: pulumi.Input<string>;
            user?: pulumi.Input<string>;
        }

        export interface ServiceStatusParameters {
            /**
             * A parameter may have attributes (e.g. message hub topic might have partitions)
             */
            attributes?: pulumi.Input<{[key: string]: any}>;
            /**
             * Name representing the key.
             */
            name: pulumi.Input<string>;
            /**
             * Defaults to null.
             */
            value?: any;
            /**
             * Source for the value. Cannot be used if value is not empty.
             */
            valueFrom?: pulumi.Input<inputs.ibmcloud.v1alpha1.ServiceStatusParametersValueFrom>;
        }

        /**
         * Source for the value. Cannot be used if value is not empty.
         */
        export interface ServiceStatusParametersValueFrom {
            /**
             * Selects a key of a ConfigMap.
             */
            configMapKeyRef?: pulumi.Input<{[key: string]: any}>;
            /**
             * Selects a key of a secret in the resource namespace
             */
            secretKeyRef?: pulumi.Input<{[key: string]: any}>;
        }

    }
}