// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace app {
    export namespace v1beta1 {
        /**
         * ApplicationSpec defines the specification for an Application.
         */
        export interface ApplicationSpec {
            /**
             * AddOwnerRef objects - flag to indicate if we need to add OwnerRefs to matching objects Matching is done by using Selector to query all ComponentGroupKinds
             */
            addOwnerRef?: boolean;
            /**
             * AssemblyPhase represents the current phase of the application's assembly. An empty value is equivalent to "Succeeded".
             */
            assemblyPhase?: string;
            /**
             * ComponentGroupKinds is a list of Kinds for Application's components (e.g. Deployments, Pods, Services, CRDs). It can be used in conjunction with the Application's Selector to list or watch the Applications components.
             */
            componentKinds?: outputs.app.v1beta1.ApplicationSpecComponentKinds[];
            /**
             * Descriptor regroups information and metadata about an application.
             */
            descriptor?: outputs.app.v1beta1.ApplicationSpecDescriptor;
            /**
             * Info contains human readable key,value pairs for the Application.
             */
            info?: outputs.app.v1beta1.ApplicationSpecInfo[];
            /**
             * Selector is a label query over kinds that created by the application. It must match the component objects' labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
             */
            selector?: outputs.app.v1beta1.ApplicationSpecSelector;
        }

        /**
         * GroupKind specifies a Group and a Kind, but does not force a version.  This is useful for identifying concepts during lookup stages without having partially valid types
         */
        export interface ApplicationSpecComponentKinds {
            group: string;
            kind: string;
        }

        /**
         * Descriptor regroups information and metadata about an application.
         */
        export interface ApplicationSpecDescriptor {
            /**
             * Description is a brief string description of the Application.
             */
            description?: string;
            /**
             * Icons is an optional list of icons for an application. Icon information includes the source, size, and mime type.
             */
            icons?: outputs.app.v1beta1.ApplicationSpecDescriptorIcons[];
            /**
             * Keywords is an optional list of key words associated with the application (e.g. MySQL, RDBMS, database).
             */
            keywords?: string[];
            /**
             * Links are a list of descriptive URLs intended to be used to surface additional documentation, dashboards, etc.
             */
            links?: outputs.app.v1beta1.ApplicationSpecDescriptorLinks[];
            /**
             * Maintainers is an optional list of maintainers of the application. The maintainers in this list maintain the the source code, images, and package for the application.
             */
            maintainers?: outputs.app.v1beta1.ApplicationSpecDescriptorMaintainers[];
            /**
             * Notes contain a human readable snippets intended as a quick start for the users of the Application. CommonMark markdown syntax may be used for rich text representation.
             */
            notes?: string;
            /**
             * Owners is an optional list of the owners of the installed application. The owners of the application should be contacted in the event of a planned or unplanned disruption affecting the application.
             */
            owners?: outputs.app.v1beta1.ApplicationSpecDescriptorOwners[];
            /**
             * Type is the type of the application (e.g. WordPress, MySQL, Cassandra).
             */
            type?: string;
            /**
             * Version is an optional version indicator for the Application.
             */
            version?: string;
        }

        /**
         * ImageSpec contains information about an image used as an icon.
         */
        export interface ApplicationSpecDescriptorIcons {
            /**
             * (optional) The size of the image in pixels (e.g., 25x25).
             */
            size?: string;
            /**
             * The source for image represented as either an absolute URL to the image or a Data URL containing the image. Data URLs are defined in RFC 2397.
             */
            src: string;
            /**
             * (optional) The mine type of the image (e.g., "image/png").
             */
            type?: string;
        }

        /**
         * Link contains information about an URL to surface documentation, dashboards, etc.
         */
        export interface ApplicationSpecDescriptorLinks {
            /**
             * Description is human readable content explaining the purpose of the link.
             */
            description?: string;
            /**
             * Url typically points at a website address.
             */
            url?: string;
        }

        /**
         * ContactData contains information about an individual or organization.
         */
        export interface ApplicationSpecDescriptorMaintainers {
            /**
             * Email is the email address.
             */
            email?: string;
            /**
             * Name is the descriptive name.
             */
            name?: string;
            /**
             * Url could typically be a website address.
             */
            url?: string;
        }

        /**
         * ContactData contains information about an individual or organization.
         */
        export interface ApplicationSpecDescriptorOwners {
            /**
             * Email is the email address.
             */
            email?: string;
            /**
             * Name is the descriptive name.
             */
            name?: string;
            /**
             * Url could typically be a website address.
             */
            url?: string;
        }

        /**
         * InfoItem is a human readable key,value pair containing important information about how to access the Application.
         */
        export interface ApplicationSpecInfo {
            /**
             * Name is a human readable title for this piece of information.
             */
            name?: string;
            /**
             * Type of the value for this InfoItem.
             */
            type?: string;
            /**
             * Value is human readable content.
             */
            value?: string;
            /**
             * ValueFrom defines a reference to derive the value from another source.
             */
            valueFrom?: outputs.app.v1beta1.ApplicationSpecInfoValueFrom;
        }

        /**
         * ValueFrom defines a reference to derive the value from another source.
         */
        export interface ApplicationSpecInfoValueFrom {
            /**
             * Selects a key of a ConfigMap.
             */
            configMapKeyRef?: outputs.app.v1beta1.ApplicationSpecInfoValueFromConfigMapKeyRef;
            /**
             * Select an Ingress.
             */
            ingressRef?: outputs.app.v1beta1.ApplicationSpecInfoValueFromIngressRef;
            /**
             * Selects a key of a Secret.
             */
            secretKeyRef?: outputs.app.v1beta1.ApplicationSpecInfoValueFromSecretKeyRef;
            /**
             * Select a Service.
             */
            serviceRef?: outputs.app.v1beta1.ApplicationSpecInfoValueFromServiceRef;
            /**
             * Type of source.
             */
            type?: string;
        }

        /**
         * Selects a key of a ConfigMap.
         */
        export interface ApplicationSpecInfoValueFromConfigMapKeyRef {
            /**
             * API version of the referent.
             */
            apiVersion?: string;
            /**
             * If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object. TODO: this design is not final and this field is subject to change in the future.
             */
            fieldPath?: string;
            /**
             * The key to select.
             */
            key?: string;
            /**
             * Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
             */
            kind?: string;
            /**
             * Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
             */
            name?: string;
            /**
             * Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
             */
            namespace?: string;
            /**
             * Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
             */
            resourceVersion?: string;
            /**
             * UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
             */
            uid?: string;
        }

        /**
         * Select an Ingress.
         */
        export interface ApplicationSpecInfoValueFromIngressRef {
            /**
             * API version of the referent.
             */
            apiVersion?: string;
            /**
             * If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object. TODO: this design is not final and this field is subject to change in the future.
             */
            fieldPath?: string;
            /**
             * The optional host to select.
             */
            host?: string;
            /**
             * Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
             */
            kind?: string;
            /**
             * Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
             */
            name?: string;
            /**
             * Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
             */
            namespace?: string;
            /**
             * The optional HTTP path.
             */
            path?: string;
            /**
             * Protocol for the ingress
             */
            protocol?: string;
            /**
             * Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
             */
            resourceVersion?: string;
            /**
             * UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
             */
            uid?: string;
        }

        /**
         * Selects a key of a Secret.
         */
        export interface ApplicationSpecInfoValueFromSecretKeyRef {
            /**
             * API version of the referent.
             */
            apiVersion?: string;
            /**
             * If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object. TODO: this design is not final and this field is subject to change in the future.
             */
            fieldPath?: string;
            /**
             * The key to select.
             */
            key?: string;
            /**
             * Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
             */
            kind?: string;
            /**
             * Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
             */
            name?: string;
            /**
             * Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
             */
            namespace?: string;
            /**
             * Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
             */
            resourceVersion?: string;
            /**
             * UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
             */
            uid?: string;
        }

        /**
         * Select a Service.
         */
        export interface ApplicationSpecInfoValueFromServiceRef {
            /**
             * API version of the referent.
             */
            apiVersion?: string;
            /**
             * If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object. TODO: this design is not final and this field is subject to change in the future.
             */
            fieldPath?: string;
            /**
             * Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
             */
            kind?: string;
            /**
             * Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
             */
            name?: string;
            /**
             * Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
             */
            namespace?: string;
            /**
             * The optional HTTP path.
             */
            path?: string;
            /**
             * The optional port to select.
             */
            port?: number;
            /**
             * Protocol for the service
             */
            protocol?: string;
            /**
             * Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
             */
            resourceVersion?: string;
            /**
             * UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
             */
            uid?: string;
        }

        /**
         * Selector is a label query over kinds that created by the application. It must match the component objects' labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
         */
        export interface ApplicationSpecSelector {
            /**
             * matchExpressions is a list of label selector requirements. The requirements are ANDed.
             */
            matchExpressions?: outputs.app.v1beta1.ApplicationSpecSelectorMatchExpressions[];
            /**
             * matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
             */
            matchLabels?: {[key: string]: string};
        }

        /**
         * A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface ApplicationSpecSelectorMatchExpressions {
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
         * ApplicationStatus defines controller's the observed state of Application
         */
        export interface ApplicationStatus {
            /**
             * Object status array for all matching objects
             */
            components?: outputs.app.v1beta1.ApplicationStatusComponents[];
            /**
             * ComponentsReady: status of the components in the format ready/total
             */
            componentsReady?: string;
            /**
             * Conditions represents the latest state of the object
             */
            conditions?: outputs.app.v1beta1.ApplicationStatusConditions[];
            /**
             * ObservedGeneration is the most recent generation observed. It corresponds to the Object's generation, which is updated on mutation by the API Server.
             */
            observedGeneration?: number;
        }

        /**
         * ObjectStatus is a generic status holder for objects
         */
        export interface ApplicationStatusComponents {
            /**
             * Object group
             */
            group?: string;
            /**
             * Kind of object
             */
            kind?: string;
            /**
             * Link to object
             */
            link?: string;
            /**
             * Name of object
             */
            name?: string;
            /**
             * Status. Values: InProgress, Ready, Unknown
             */
            status?: string;
        }

        /**
         * Condition describes the state of an object at a certain point.
         */
        export interface ApplicationStatusConditions {
            /**
             * Last time the condition transitioned from one status to another.
             */
            lastTransitionTime?: string;
            /**
             * Last time the condition was probed
             */
            lastUpdateTime?: string;
            /**
             * A human readable message indicating details about the transition.
             */
            message?: string;
            /**
             * The reason for the condition's last transition.
             */
            reason?: string;
            /**
             * Status of the condition, one of True, False, Unknown.
             */
            status: string;
            /**
             * Type of condition.
             */
            type: string;
        }
    }
}
