// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace apps {
    export namespace v1alpha1 {
        /**
         * ServiceBindingRequestSpec defines the desired state of ServiceBindingRequest
         */
        export interface ServiceBindingRequestSpec {
            /**
             * ApplicationSelector is used to identify the application connecting to the backing service operator.
             */
            applicationSelector?: outputs.apps.v1alpha1.ServiceBindingRequestSpecApplicationSelector;
            /**
             * BackingServiceSelector is used to identify the backing service operator. Deprecation Notice: In the upcoming release, this field would be depcreated. It would be mandatory to set "backingServiceSelectors".
             */
            backingServiceSelector?: outputs.apps.v1alpha1.ServiceBindingRequestSpecBackingServiceSelector;
            /**
             * BackingServiceSelectors is used to identify multiple backing services. This would be made a required field after 'BackingServiceSelector' is removed.
             */
            backingServiceSelectors?: outputs.apps.v1alpha1.ServiceBindingRequestSpecBackingServiceSelectors[];
            /**
             * Custom env variables
             */
            customEnvVar?: outputs.apps.v1alpha1.ServiceBindingRequestSpecCustomEnvVar[];
            /**
             * DetectBindingResources is flag used to bind all non-bindable variables from different subresources owned by backing operator CR.
             */
            detectBindingResources?: boolean;
            /**
             * EnvVarPrefix is the prefix for environment variables
             */
            envVarPrefix?: string;
            /**
             * MountPathPrefix is the prefix for volume mount
             */
            mountPathPrefix?: string;
        }

        /**
         * ApplicationSelector is used to identify the application connecting to the backing service operator.
         */
        export interface ServiceBindingRequestSpecApplicationSelector {
            /**
             * BindingPath refers to the path in the application workload's schema where the binding workload would be referenced.
             */
            bindingPath?: outputs.apps.v1alpha1.ServiceBindingRequestSpecApplicationSelectorBindingPath;
            group: string;
            /**
             * A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.
             */
            labelSelector?: outputs.apps.v1alpha1.ServiceBindingRequestSpecApplicationSelectorLabelSelector;
            resource: string;
            resourceRef?: string;
            version: string;
        }

        /**
         * BindingPath refers to the path in the application workload's schema where the binding workload would be referenced.
         */
        export interface ServiceBindingRequestSpecApplicationSelectorBindingPath {
            /**
             * ContainersPath defines the path to the corev1.Containers reference The default location is going to this: "spec.template.spec.containers"
             */
            containersPath?: string;
            /**
             * SecretPath defines the path to a string field where the secret needs to be assigned. The default name is going to the value of the name of SBR CR (metadata.name)
             */
            secretPath?: string;
        }

        /**
         * A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.
         */
        export interface ServiceBindingRequestSpecApplicationSelectorLabelSelector {
            /**
             * matchExpressions is a list of label selector requirements. The requirements are ANDed.
             */
            matchExpressions?: outputs.apps.v1alpha1.ServiceBindingRequestSpecApplicationSelectorLabelSelectorMatchExpressions[];
            /**
             * matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
             */
            matchLabels?: {[key: string]: string};
        }

        /**
         * A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface ServiceBindingRequestSpecApplicationSelectorLabelSelectorMatchExpressions {
            /**
             * key is the label key that the selector applies to.
             */
            key: string;
            /**
             * operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.
             */
            operator: string;
            /**
             * values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
             */
            values?: string[];
        }

        /**
         * BackingServiceSelector is used to identify the backing service operator. Deprecation Notice: In the upcoming release, this field would be depcreated. It would be mandatory to set "backingServiceSelectors".
         */
        export interface ServiceBindingRequestSpecBackingServiceSelector {
            envVarPrefix?: string;
            group: string;
            id?: string;
            kind: string;
            namespace?: string;
            resourceRef: string;
            version: string;
        }

        /**
         * BackingServiceSelector defines the selector based on resource name, version, and resource kind
         */
        export interface ServiceBindingRequestSpecBackingServiceSelectors {
            envVarPrefix?: string;
            group: string;
            id?: string;
            kind: string;
            namespace?: string;
            resourceRef: string;
            version: string;
        }

        /**
         * EnvVar represents an environment variable present in a Container.
         */
        export interface ServiceBindingRequestSpecCustomEnvVar {
            /**
             * Name of the environment variable. Must be a C_IDENTIFIER.
             */
            name: string;
            /**
             * Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".
             */
            value?: string;
            /**
             * Source for the environment variable's value. Cannot be used if value is not empty.
             */
            valueFrom?: outputs.apps.v1alpha1.ServiceBindingRequestSpecCustomEnvVarValueFrom;
        }

        /**
         * Source for the environment variable's value. Cannot be used if value is not empty.
         */
        export interface ServiceBindingRequestSpecCustomEnvVarValueFrom {
            /**
             * Selects a key of a ConfigMap.
             */
            configMapKeyRef?: outputs.apps.v1alpha1.ServiceBindingRequestSpecCustomEnvVarValueFromConfigMapKeyRef;
            /**
             * Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP.
             */
            fieldRef?: outputs.apps.v1alpha1.ServiceBindingRequestSpecCustomEnvVarValueFromFieldRef;
            /**
             * Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
             */
            resourceFieldRef?: outputs.apps.v1alpha1.ServiceBindingRequestSpecCustomEnvVarValueFromResourceFieldRef;
            /**
             * Selects a key of a secret in the pod's namespace
             */
            secretKeyRef?: outputs.apps.v1alpha1.ServiceBindingRequestSpecCustomEnvVarValueFromSecretKeyRef;
        }

        /**
         * Selects a key of a ConfigMap.
         */
        export interface ServiceBindingRequestSpecCustomEnvVarValueFromConfigMapKeyRef {
            /**
             * The key to select.
             */
            key: string;
            /**
             * Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
             */
            name?: string;
            /**
             * Specify whether the ConfigMap or its key must be defined
             */
            optional?: boolean;
        }

        /**
         * Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP.
         */
        export interface ServiceBindingRequestSpecCustomEnvVarValueFromFieldRef {
            /**
             * Version of the schema the FieldPath is written in terms of, defaults to "v1".
             */
            apiVersion?: string;
            /**
             * Path of the field to select in the specified API version.
             */
            fieldPath: string;
        }

        /**
         * Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
         */
        export interface ServiceBindingRequestSpecCustomEnvVarValueFromResourceFieldRef {
            /**
             * Container name: required for volumes, optional for env vars
             */
            containerName?: string;
            /**
             * Specifies the output format of the exposed resources, defaults to "1"
             */
            divisor?: string;
            /**
             * Required: resource to select
             */
            resource: string;
        }

        /**
         * Selects a key of a secret in the pod's namespace
         */
        export interface ServiceBindingRequestSpecCustomEnvVarValueFromSecretKeyRef {
            /**
             * The key of the secret to select from.  Must be a valid secret key.
             */
            key: string;
            /**
             * Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
             */
            name?: string;
            /**
             * Specify whether the Secret or its key must be defined
             */
            optional?: boolean;
        }

        /**
         * ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
         */
        export interface ServiceBindingRequestStatus {
            /**
             * Applications contain all the applications filtered by name or label
             */
            applications?: outputs.apps.v1alpha1.ServiceBindingRequestStatusApplications[];
            /**
             * Conditions describes the state of the operator's reconciliation functionality.
             */
            conditions: outputs.apps.v1alpha1.ServiceBindingRequestStatusConditions[];
            /**
             * Secret is the name of the intermediate secret
             */
            secret: string;
        }

        /**
         * BoundApplication defines the application workloads to which the binding secret has injected.
         */
        export interface ServiceBindingRequestStatusApplications {
            group: string;
            kind: string;
            /**
             * Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
             */
            name?: string;
            version: string;
        }

        /**
         * Condition represents the state of the operator's reconciliation functionality.
         */
        export interface ServiceBindingRequestStatusConditions {
            lastHeartbeatTime?: string;
            lastTransitionTime?: string;
            message?: string;
            reason?: string;
            status: string;
            /**
             * ConditionType is the state of the operator's reconciliation functionality.
             */
            type: string;
        }
    }
}
