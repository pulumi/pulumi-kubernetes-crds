// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1
{

    [OutputType]
    public sealed class KogitoBuildSpec
    {
        /// <summary>
        /// Artifact contains override information for building the Maven artifact (used for Local Source builds). You might want to override this information when building from decisions, rules or process files. In this scenario the Kogito Images will generate a new Java project for you underneath. This information will be used to generate this project.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecArtifact Artifact;
        /// <summary>
        /// Image used to build the Kogito Service from source (Local and Remote). The operator will use the one provided by the Kogito Team based on the "Runtime" field. Example: Domain: quay.io, Namespace: kiegroup, Name: kogito-jvm-builder, Tag: latest. On OpenShift an ImageStream will be created in the current namespace pointing to the given image.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecBuildImage BuildImage;
        /// <summary>
        /// DisableIncremental indicates that source to image builds should NOT be incremental. Defaults to false.
        /// </summary>
        public readonly bool DisableIncremental;
        /// <summary>
        /// If set to true will print the logs for downloading/uploading of maven dependencies. Defaults to false.
        /// </summary>
        public readonly bool EnableMavenDownloadOutput;
        /// <summary>
        /// Environment variables used during build time.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecEnvs> Envs;
        /// <summary>
        /// Information about the git repository where the Kogito Service source code resides. Ignored for binary builds.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecGitSource GitSource;
        /// <summary>
        /// Maven Mirror URL to be used during source-to-image builds (Local and Remote) to considerably increase build speed.
        /// </summary>
        public readonly string MavenMirrorURL;
        /// <summary>
        /// Native indicates if the Kogito Service built should be compiled to run on native mode when Runtime is Quarkus (Source to Image build only). For more information, see https://www.graalvm.org/docs/reference-manual/aot-compilation/.
        /// </summary>
        public readonly bool Native;
        /// <summary>
        /// Resources Requirements for builder pods.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecResources Resources;
        /// <summary>
        /// Which runtime Kogito service base image to use when building the Kogito service. If "BuildImage" is set, this value is ignored by the operator. Default value: quarkus.
        /// </summary>
        public readonly string Runtime;
        /// <summary>
        /// Image used as the base image for the final Kogito service. This image only has the required packages to run the application. For example: quarkus based services will have only JVM installed, native services only the packages required by the OS. The operator will use the one provided by the Kogito Team based on the "Runtime" field. Example: Domain: quay.io, Namespace: kiegroup, Name: kogito-jvm-builder, Tag: latest. On OpenShift an ImageStream will be created in the current namespace pointing to the given image.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecRuntimeImage RuntimeImage;
        /// <summary>
        /// Set this field targeting the desired KogitoRuntime when this KogitoBuild instance has a different name than the KogitoRuntime. By default this KogitoBuild instance will generate a final image named after its own name (.metadata.name). On OpenShift, an ImageStream will be created causing a redeployment on any KogitoRuntime with the same name. On Kubernetes, the final image will be pushed to the KogitoRuntime deployment. If you have multiple KogitoBuild instances (let's say BinaryBuildType and Remote Source), you might need that both target the same KogitoRuntime. Both KogitoBuilds will update the same ImageStream or generate a final image to the same KogitoRuntime deployment.
        /// </summary>
        public readonly string TargetKogitoRuntime;
        /// <summary>
        /// Sets the type of build that this instance will handle: Binary - takes an uploaded binary file already compiled and creates a Kogito service image from it. RemoteSource - pulls the source code from a Git repository, builds the binary and then the final Kogito service image. LocalSource - takes an uploaded resource file such as DRL (rules), DMN (decision) or BPMN (process), builds the binary and the final Kogito service image.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// WebHooks secrets for source to image builds based on Git repositories (Remote Sources).
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecWebHooks> WebHooks;

        [OutputConstructor]
        private KogitoBuildSpec(
            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecArtifact artifact,

            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecBuildImage buildImage,

            bool disableIncremental,

            bool enableMavenDownloadOutput,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecEnvs> envs,

            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecGitSource gitSource,

            string mavenMirrorURL,

            bool native,

            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecResources resources,

            string runtime,

            Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecRuntimeImage runtimeImage,

            string targetKogitoRuntime,

            string type,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoBuildSpecWebHooks> webHooks)
        {
            Artifact = artifact;
            BuildImage = buildImage;
            DisableIncremental = disableIncremental;
            EnableMavenDownloadOutput = enableMavenDownloadOutput;
            Envs = envs;
            GitSource = gitSource;
            MavenMirrorURL = mavenMirrorURL;
            Native = native;
            Resources = resources;
            Runtime = runtime;
            RuntimeImage = runtimeImage;
            TargetKogitoRuntime = targetKogitoRuntime;
            Type = type;
            WebHooks = webHooks;
        }
    }
}