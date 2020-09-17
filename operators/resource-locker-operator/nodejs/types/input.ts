// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace redhatcop {
    export namespace v1alpha1 {
        /**
         * ResourceLockerSpec defines the desired state of ResourceLocker
         */
        export interface ResourceLockerSpec {
            /**
             * Patches is a list of patches that should be enforced at runtime.
             */
            patches?: pulumi.Input<pulumi.Input<inputs.redhatcop.v1alpha1.ResourceLockerSpecPatches>[]>;
            /**
             * Resources is a list of resource manifests that should be locked into the specified configuration
             */
            resources?: pulumi.Input<pulumi.Input<inputs.redhatcop.v1alpha1.ResourceLockerSpecResources>[]>;
            /**
             * ServiceAccountRef is the service account to be used to run the controllers associated with this configuration kubebuilder:default:="{Name: &#34;default&#34;}"
             */
            serviceAccountRef?: pulumi.Input<inputs.redhatcop.v1alpha1.ResourceLockerSpecServiceAccountRef>;
        }

        /**
         * Patch describe a patch to be enforced at runtime
         */
        export interface ResourceLockerSpecPatches {
            /**
             * ID represent a unique identifier for the patch in the array of patches oc this CR
             */
            id: pulumi.Input<string>;
            /**
             * PatchTemplate is a go template that will be resolved using the SourceObjectRefs as parameters. The result must be a valid patch based on the patch type and the target object.
             */
            patchTemplate: pulumi.Input<string>;
            /**
             * PatchType is the type of patch to be applied, one of "application/json-patch+json"'"application/merge-patch+json","application/strategic-merge-patch+json","application/apply-patch+yaml" kubebuilder:default:="application/strategic-merge-patch+json"
             */
            patchType?: pulumi.Input<string>;
            /**
             * SourceObject refs is an array of references to source objects that will be used as input for the template processing
             */
            sourceObjectRefs?: pulumi.Input<pulumi.Input<inputs.redhatcop.v1alpha1.ResourceLockerSpecPatchesSourceObjectRefs>[]>;
            /**
             * TargetObjectRef is a reference to the object to which the patch should be applied.
             */
            targetObjectRef: pulumi.Input<inputs.redhatcop.v1alpha1.ResourceLockerSpecPatchesTargetObjectRef>;
        }

        /**
         * ObjectReference contains enough information to let you inspect or modify the referred object. --- New uses of this type are discouraged because of difficulty describing its usage when embedded in APIs.  1. Ignored fields.  It includes many fields which are not generally honored.  For instance, ResourceVersion and FieldPath are both very rarely valid in actual usage.  2. Invalid usage help.  It is impossible to add specific help for individual usage.  In most embedded usages, there are particular     restrictions like, "must refer only to types A and B" or "UID not honored" or "name must be restricted".     Those cannot be well described when embedded.  3. Inconsistent validation.  Because the usages are different, the validation rules are different by usage, which makes it hard for users to predict what will happen.  4. The fields are both imprecise and overly precise.  Kind is not a precise mapping to a URL. This can produce ambiguity     during interpretation and require a REST mapping.  In most cases, the dependency is on the group,resource tuple     and the version of the actual struct is irrelevant.  5. We cannot easily change it.  Because this type is embedded in many locations, updates to this type     will affect numerous schemas.  Don't make new APIs embed an underspecified API type they do not control. Instead of using this type, create a locally provided and used type that is well-focused on your reference. For example, ServiceReferences for admission registration: https://github.com/kubernetes/api/blob/release-1.17/admissionregistration/v1/types.go#L533 .
         */
        export interface ResourceLockerSpecPatchesSourceObjectRefs {
            /**
             * API version of the referent.
             */
            apiVersion?: pulumi.Input<string>;
            /**
             * If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object. TODO: this design is not final and this field is subject to change in the future.
             */
            fieldPath?: pulumi.Input<string>;
            /**
             * Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
             */
            kind?: pulumi.Input<string>;
            /**
             * Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
             */
            name?: pulumi.Input<string>;
            /**
             * Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
             */
            namespace?: pulumi.Input<string>;
            /**
             * Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
             */
            resourceVersion?: pulumi.Input<string>;
            /**
             * UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
             */
            uid?: pulumi.Input<string>;
        }

        /**
         * TargetObjectRef is a reference to the object to which the patch should be applied.
         */
        export interface ResourceLockerSpecPatchesTargetObjectRef {
            /**
             * API version of the referent.
             */
            apiVersion?: pulumi.Input<string>;
            /**
             * If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object. TODO: this design is not final and this field is subject to change in the future.
             */
            fieldPath?: pulumi.Input<string>;
            /**
             * Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
             */
            kind?: pulumi.Input<string>;
            /**
             * Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
             */
            name?: pulumi.Input<string>;
            /**
             * Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
             */
            namespace?: pulumi.Input<string>;
            /**
             * Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
             */
            resourceVersion?: pulumi.Input<string>;
            /**
             * UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
             */
            uid?: pulumi.Input<string>;
        }

        /**
         * Resource represent a resource to be enforced
         */
        export interface ResourceLockerSpecResources {
            excludedPaths?: pulumi.Input<pulumi.Input<string>[]>;
            object: pulumi.Input<{[key: string]: any}>;
        }

        /**
         * ServiceAccountRef is the service account to be used to run the controllers associated with this configuration kubebuilder:default:="{Name: &#34;default&#34;}"
         */
        export interface ResourceLockerSpecServiceAccountRef {
            /**
             * Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
             */
            name?: pulumi.Input<string>;
        }

        /**
         * ResourceLockerStatus defines the observed state of ResourceLocker
         */
        export interface ResourceLockerStatus {
            /**
             * ReconcileStatus this is the general status of the main reconciler
             */
            conditions?: pulumi.Input<pulumi.Input<inputs.redhatcop.v1alpha1.ResourceLockerStatusConditions>[]>;
            /**
             * LockedResourceStatuses contains the reconcile status for each of the managed resources
             */
            lockedPatchStatuses?: pulumi.Input<{[key: string]: pulumi.Input<pulumi.Input<inputs.redhatcop.v1alpha1.ResourceLockerStatusLockedPatchStatuses>[]>}>;
            /**
             * LockedResourceStatuses contains the reconcile status for each of the managed resources
             */
            lockedResourceStatuses?: pulumi.Input<{[key: string]: pulumi.Input<pulumi.Input<inputs.redhatcop.v1alpha1.ResourceLockerStatusLockedResourceStatuses>[]>}>;
        }

        /**
         * Condition represents an observation of an object's state. Conditions are an extension mechanism intended to be used when the details of an observation are not a priori known or would not apply to all instances of a given Kind. 
         *  Conditions should be added to explicitly convey properties that users and components care about rather than requiring those properties to be inferred from other observations. Once defined, the meaning of a Condition can not be changed arbitrarily - it becomes part of the API, and has the same backwards- and forwards-compatibility concerns of any other part of the API.
         */
        export interface ResourceLockerStatusConditions {
            lastTransitionTime?: pulumi.Input<string>;
            message?: pulumi.Input<string>;
            /**
             * ConditionReason is intended to be a one-word, CamelCase representation of the category of cause of the current status. It is intended to be used in concise output, such as one-line kubectl get output, and in summarizing occurrences of causes.
             */
            reason?: pulumi.Input<string>;
            status: pulumi.Input<string>;
            /**
             * ConditionType is the type of the condition and is typically a CamelCased word or short phrase. 
             *  Condition types should indicate state in the "abnormal-true" polarity. For example, if the condition indicates when a policy is invalid, the "is valid" case is probably the norm, so the condition should be called "Invalid".
             */
            type: pulumi.Input<string>;
        }

        /**
         * Condition represents an observation of an object's state. Conditions are an extension mechanism intended to be used when the details of an observation are not a priori known or would not apply to all instances of a given Kind. 
         *  Conditions should be added to explicitly convey properties that users and components care about rather than requiring those properties to be inferred from other observations. Once defined, the meaning of a Condition can not be changed arbitrarily - it becomes part of the API, and has the same backwards- and forwards-compatibility concerns of any other part of the API.
         */
        export interface ResourceLockerStatusLockedPatchStatuses {
            lastTransitionTime?: pulumi.Input<string>;
            message?: pulumi.Input<string>;
            /**
             * ConditionReason is intended to be a one-word, CamelCase representation of the category of cause of the current status. It is intended to be used in concise output, such as one-line kubectl get output, and in summarizing occurrences of causes.
             */
            reason?: pulumi.Input<string>;
            status: pulumi.Input<string>;
            /**
             * ConditionType is the type of the condition and is typically a CamelCased word or short phrase. 
             *  Condition types should indicate state in the "abnormal-true" polarity. For example, if the condition indicates when a policy is invalid, the "is valid" case is probably the norm, so the condition should be called "Invalid".
             */
            type: pulumi.Input<string>;
        }

        /**
         * Condition represents an observation of an object's state. Conditions are an extension mechanism intended to be used when the details of an observation are not a priori known or would not apply to all instances of a given Kind. 
         *  Conditions should be added to explicitly convey properties that users and components care about rather than requiring those properties to be inferred from other observations. Once defined, the meaning of a Condition can not be changed arbitrarily - it becomes part of the API, and has the same backwards- and forwards-compatibility concerns of any other part of the API.
         */
        export interface ResourceLockerStatusLockedResourceStatuses {
            lastTransitionTime?: pulumi.Input<string>;
            message?: pulumi.Input<string>;
            /**
             * ConditionReason is intended to be a one-word, CamelCase representation of the category of cause of the current status. It is intended to be used in concise output, such as one-line kubectl get output, and in summarizing occurrences of causes.
             */
            reason?: pulumi.Input<string>;
            status: pulumi.Input<string>;
            /**
             * ConditionType is the type of the condition and is typically a CamelCased word or short phrase. 
             *  Condition types should indicate state in the "abnormal-true" polarity. For example, if the condition indicates when a policy is invalid, the "is valid" case is probably the norm, so the condition should be called "Invalid".
             */
            type: pulumi.Input<string>;
        }
    }
}
