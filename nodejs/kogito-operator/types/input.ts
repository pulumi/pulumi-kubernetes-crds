// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace app {
    export namespace v1alpha1 {
        /**
         * KogitoBuildSpec defines the desired state of KogitoBuild.
         */
        export interface KogitoBuildSpec {
            /**
             * Artifact contains override information for building the Maven artifact (used for Local Source builds). You might want to override this information when building from decisions, rules or process files. In this scenario the Kogito Images will generate a new Java project for you underneath. This information will be used to generate this project.
             */
            artifact?: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecArtifact>;
            /**
             * Image used to build the Kogito Service from source (Local and Remote). The operator will use the one provided by the Kogito Team based on the "Runtime" field. Example: Domain: quay.io, Namespace: kiegroup, Name: kogito-jvm-builder, Tag: latest. On OpenShift an ImageStream will be created in the current namespace pointing to the given image.
             */
            buildImage?: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecBuildImage>;
            /**
             * DisableIncremental indicates that source to image builds should NOT be incremental. Defaults to false.
             */
            disableIncremental?: pulumi.Input<boolean>;
            /**
             * If set to true will print the logs for downloading/uploading of maven dependencies. Defaults to false.
             */
            enableMavenDownloadOutput?: pulumi.Input<boolean>;
            /**
             * Environment variables used during build time.
             */
            envs?: pulumi.Input<pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecEnvs>[]>;
            /**
             * Information about the git repository where the Kogito Service source code resides. Ignored for binary builds.
             */
            gitSource?: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecGitSource>;
            /**
             * Maven Mirror URL to be used during source-to-image builds (Local and Remote) to considerably increase build speed.
             */
            mavenMirrorURL?: pulumi.Input<string>;
            /**
             * Native indicates if the Kogito Service built should be compiled to run on native mode when Runtime is Quarkus (Source to Image build only). For more information, see https://www.graalvm.org/docs/reference-manual/aot-compilation/.
             */
            native?: pulumi.Input<boolean>;
            /**
             * Resources Requirements for builder pods.
             */
            resources?: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecResources>;
            /**
             * Which runtime Kogito service base image to use when building the Kogito service. If "BuildImage" is set, this value is ignored by the operator. Default value: quarkus.
             */
            runtime?: pulumi.Input<string>;
            /**
             * Image used as the base image for the final Kogito service. This image only has the required packages to run the application. For example: quarkus based services will have only JVM installed, native services only the packages required by the OS. The operator will use the one provided by the Kogito Team based on the "Runtime" field. Example: Domain: quay.io, Namespace: kiegroup, Name: kogito-jvm-builder, Tag: latest. On OpenShift an ImageStream will be created in the current namespace pointing to the given image.
             */
            runtimeImage?: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecRuntimeImage>;
            /**
             * Set this field targeting the desired KogitoRuntime when this KogitoBuild instance has a different name than the KogitoRuntime. By default this KogitoBuild instance will generate a final image named after its own name (.metadata.name). On OpenShift, an ImageStream will be created causing a redeployment on any KogitoRuntime with the same name. On Kubernetes, the final image will be pushed to the KogitoRuntime deployment. If you have multiple KogitoBuild instances (let's say BinaryBuildType and Remote Source), you might need that both target the same KogitoRuntime. Both KogitoBuilds will update the same ImageStream or generate a final image to the same KogitoRuntime deployment.
             */
            targetKogitoRuntime?: pulumi.Input<string>;
            /**
             * Sets the type of build that this instance will handle: Binary - takes an uploaded binary file already compiled and creates a Kogito service image from it. RemoteSource - pulls the source code from a Git repository, builds the binary and then the final Kogito service image. LocalSource - takes an uploaded resource file such as DRL (rules), DMN (decision) or BPMN (process), builds the binary and the final Kogito service image.
             */
            type: pulumi.Input<string>;
            /**
             * WebHooks secrets for source to image builds based on Git repositories (Remote Sources).
             */
            webHooks?: pulumi.Input<pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecWebHooks>[]>;
        }

        /**
         * Artifact contains override information for building the Maven artifact (used for Local Source builds). You might want to override this information when building from decisions, rules or process files. In this scenario the Kogito Images will generate a new Java project for you underneath. This information will be used to generate this project.
         */
        export interface KogitoBuildSpecArtifact {
            /**
             * Indicates the unique base name of the primary artifact being generated.
             */
            artifactId?: pulumi.Input<string>;
            /**
             * Indicates the unique identifier of the organization or group that created the project.
             */
            groupId?: pulumi.Input<string>;
            /**
             * Indicates the version of the artifact generated by the project.
             */
            version?: pulumi.Input<string>;
        }

        /**
         * Image used to build the Kogito Service from source (Local and Remote). The operator will use the one provided by the Kogito Team based on the "Runtime" field. Example: Domain: quay.io, Namespace: kiegroup, Name: kogito-jvm-builder, Tag: latest. On OpenShift an ImageStream will be created in the current namespace pointing to the given image.
         */
        export interface KogitoBuildSpecBuildImage {
            domain?: pulumi.Input<string>;
            name?: pulumi.Input<string>;
            namespace?: pulumi.Input<string>;
            tag?: pulumi.Input<string>;
        }

        /**
         * EnvVar represents an environment variable present in a Container.
         */
        export interface KogitoBuildSpecEnvs {
            /**
             * Name of the environment variable. Must be a C_IDENTIFIER.
             */
            name: pulumi.Input<string>;
            /**
             * Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".
             */
            value?: pulumi.Input<string>;
            /**
             * Source for the environment variable's value. Cannot be used if value is not empty.
             */
            valueFrom?: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecEnvsValueFrom>;
        }

        /**
         * Source for the environment variable's value. Cannot be used if value is not empty.
         */
        export interface KogitoBuildSpecEnvsValueFrom {
            /**
             * Selects a key of a ConfigMap.
             */
            configMapKeyRef?: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecEnvsValueFromConfigMapKeyRef>;
            /**
             * Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.
             */
            fieldRef?: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecEnvsValueFromFieldRef>;
            /**
             * Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
             */
            resourceFieldRef?: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecEnvsValueFromResourceFieldRef>;
            /**
             * Selects a key of a secret in the pod's namespace
             */
            secretKeyRef?: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecEnvsValueFromSecretKeyRef>;
        }

        /**
         * Selects a key of a ConfigMap.
         */
        export interface KogitoBuildSpecEnvsValueFromConfigMapKeyRef {
            /**
             * The key to select.
             */
            key: pulumi.Input<string>;
            /**
             * Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
             */
            name?: pulumi.Input<string>;
            /**
             * Specify whether the ConfigMap or its key must be defined
             */
            optional?: pulumi.Input<boolean>;
        }

        /**
         * Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.
         */
        export interface KogitoBuildSpecEnvsValueFromFieldRef {
            /**
             * Version of the schema the FieldPath is written in terms of, defaults to "v1".
             */
            apiVersion?: pulumi.Input<string>;
            /**
             * Path of the field to select in the specified API version.
             */
            fieldPath: pulumi.Input<string>;
        }

        /**
         * Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
         */
        export interface KogitoBuildSpecEnvsValueFromResourceFieldRef {
            /**
             * Container name: required for volumes, optional for env vars
             */
            containerName?: pulumi.Input<string>;
            /**
             * Specifies the output format of the exposed resources, defaults to "1"
             */
            divisor?: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecEnvsValueFromResourceFieldRefDivisor>;
            /**
             * Required: resource to select
             */
            resource: pulumi.Input<string>;
        }

        export interface KogitoBuildSpecEnvsValueFromResourceFieldRefDivisor {
        }

        /**
         * Selects a key of a secret in the pod's namespace
         */
        export interface KogitoBuildSpecEnvsValueFromSecretKeyRef {
            /**
             * The key of the secret to select from.  Must be a valid secret key.
             */
            key: pulumi.Input<string>;
            /**
             * Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
             */
            name?: pulumi.Input<string>;
            /**
             * Specify whether the Secret or its key must be defined
             */
            optional?: pulumi.Input<boolean>;
        }

        /**
         * Information about the git repository where the Kogito Service source code resides. Ignored for binary builds.
         */
        export interface KogitoBuildSpecGitSource {
            /**
             * Context/subdirectory where the code is located, relative to the repo root.
             */
            contextDir?: pulumi.Input<string>;
            /**
             * Branch to use in the Git repository.
             */
            reference?: pulumi.Input<string>;
            /**
             * Git URI for the s2i source.
             */
            uri: pulumi.Input<string>;
        }

        /**
         * Resources Requirements for builder pods.
         */
        export interface KogitoBuildSpecResources {
            /**
             * Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
             */
            limits?: pulumi.Input<{[key: string]: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecResourcesLimits>}>;
            /**
             * Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
             */
            requests?: pulumi.Input<{[key: string]: pulumi.Input<inputs.app.v1alpha1.KogitoBuildSpecResourcesRequests>}>;
        }

        export interface KogitoBuildSpecResourcesLimits {
        }

        export interface KogitoBuildSpecResourcesRequests {
        }

        /**
         * Image used as the base image for the final Kogito service. This image only has the required packages to run the application. For example: quarkus based services will have only JVM installed, native services only the packages required by the OS. The operator will use the one provided by the Kogito Team based on the "Runtime" field. Example: Domain: quay.io, Namespace: kiegroup, Name: kogito-jvm-builder, Tag: latest. On OpenShift an ImageStream will be created in the current namespace pointing to the given image.
         */
        export interface KogitoBuildSpecRuntimeImage {
            domain?: pulumi.Input<string>;
            name?: pulumi.Input<string>;
            namespace?: pulumi.Input<string>;
            tag?: pulumi.Input<string>;
        }

        /**
         * WebHookSecret Secret to use for a given webHook.
         */
        export interface KogitoBuildSpecWebHooks {
            /**
             * Secret value for webHook
             */
            secret?: pulumi.Input<string>;
            /**
             * WebHook type, either GitHub or Generic.
             */
            type?: pulumi.Input<string>;
        }

        /**
         * KogitoBuildStatus defines the observed state of KogitoBuild.
         */
        export interface KogitoBuildStatus {
            /**
             * History of builds
             */
            builds: pulumi.Input<inputs.app.v1alpha1.KogitoBuildStatusBuilds>;
            /**
             * History of conditions for the resource, shows the status of the younger builder controlled by this instance
             */
            conditions: pulumi.Input<pulumi.Input<inputs.app.v1alpha1.KogitoBuildStatusConditions>[]>;
            latestBuild?: pulumi.Input<string>;
        }

        /**
         * History of builds
         */
        export interface KogitoBuildStatusBuilds {
            /**
             * Builds have been stopped from executing.
             */
            cancelled?: pulumi.Input<pulumi.Input<string>[]>;
            /**
             * Builds have executed and succeeded.
             */
            complete?: pulumi.Input<pulumi.Input<string>[]>;
            /**
             * Builds have been prevented from executing by an error.
             */
            error?: pulumi.Input<pulumi.Input<string>[]>;
            /**
             * Builds have executed and failed.
             */
            failed?: pulumi.Input<pulumi.Input<string>[]>;
            /**
             * Builds are being created.
             */
            new?: pulumi.Input<pulumi.Input<string>[]>;
            /**
             * Builds are about to start running.
             */
            pending?: pulumi.Input<pulumi.Input<string>[]>;
            /**
             * Builds are running.
             */
            running?: pulumi.Input<pulumi.Input<string>[]>;
        }

        /**
         * KogitoBuildConditions describes the conditions for this build instance according to Kubernetes status interface.
         */
        export interface KogitoBuildStatusConditions {
            /**
             * LastTransitionTime ...
             */
            lastTransitionTime?: pulumi.Input<string>;
            /**
             * Message ...
             */
            message?: pulumi.Input<string>;
            /**
             * Reason of this condition
             */
            reason?: pulumi.Input<string>;
            /**
             * Status ...
             */
            status: pulumi.Input<string>;
            /**
             * Type of this condition
             */
            type: pulumi.Input<string>;
        }
    }
}