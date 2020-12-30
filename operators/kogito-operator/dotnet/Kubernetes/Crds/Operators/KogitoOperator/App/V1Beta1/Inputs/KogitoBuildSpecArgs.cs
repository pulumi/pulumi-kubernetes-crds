// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.App.V1Beta1
{

    /// <summary>
    /// KogitoBuildSpec defines the desired state of KogitoBuild.
    /// </summary>
    public class KogitoBuildSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Artifact contains override information for building the Maven artifact (used for Local Source builds). You might want to override this information when building from decisions, rules or process files. In this scenario the Kogito Images will generate a new Java project for you underneath. This information will be used to generate this project.
        /// </summary>
        [Input("artifact")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoBuildSpecArtifactArgs>? Artifact { get; set; }

        /// <summary>
        /// Image used to build the Kogito Service from source (Local and Remote). The operator will use the one provided by the Kogito Team based on the "Runtime" field. Example: "quay.io/kiegroup/kogito-jvm-builder:latest". On OpenShift an ImageStream will be created in the current namespace pointing to the given image.
        /// </summary>
        [Input("buildImage")]
        public Input<string>? BuildImage { get; set; }

        /// <summary>
        /// DisableIncremental indicates that source to image builds should NOT be incremental. Defaults to false.
        /// </summary>
        [Input("disableIncremental")]
        public Input<bool>? DisableIncremental { get; set; }

        /// <summary>
        /// If set to true will print the logs for downloading/uploading of maven dependencies. Defaults to false.
        /// </summary>
        [Input("enableMavenDownloadOutput")]
        public Input<bool>? EnableMavenDownloadOutput { get; set; }

        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoBuildSpecEnvArgs>? _env;

        /// <summary>
        /// Environment variables used during build time.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoBuildSpecEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoBuildSpecEnvArgs>());
            set => _env = value;
        }

        /// <summary>
        /// Information about the git repository where the Kogito Service source code resides. Ignored for binary builds.
        /// </summary>
        [Input("gitSource")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoBuildSpecGitSourceArgs>? GitSource { get; set; }

        /// <summary>
        /// Maven Mirror URL to be used during source-to-image builds (Local and Remote) to considerably increase build speed.
        /// </summary>
        [Input("mavenMirrorURL")]
        public Input<string>? MavenMirrorURL { get; set; }

        /// <summary>
        /// Native indicates if the Kogito Service built should be compiled to run on native mode when Runtime is Quarkus (Source to Image build only). For more information, see https://www.graalvm.org/docs/reference-manual/aot-compilation/.
        /// </summary>
        [Input("native")]
        public Input<bool>? Native { get; set; }

        /// <summary>
        /// Resources Requirements for builder pods.
        /// </summary>
        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoBuildSpecResourcesArgs>? Resources { get; set; }

        /// <summary>
        /// Which runtime Kogito service base image to use when building the Kogito service. If "BuildImage" is set, this value is ignored by the operator. Default value: quarkus.
        /// </summary>
        [Input("runtime")]
        public Input<string>? Runtime { get; set; }

        /// <summary>
        /// Image used as the base image for the final Kogito service. This image only has the required packages to run the application. For example: quarkus based services will have only JVM installed, native services only the packages required by the OS. The operator will use the one provided by the Kogito Team based on the "Runtime" field. Example: "quay.io/kiegroup/kogito-jvm-builder:latest". On OpenShift an ImageStream will be created in the current namespace pointing to the given image.
        /// </summary>
        [Input("runtimeImage")]
        public Input<string>? RuntimeImage { get; set; }

        /// <summary>
        /// Set this field targeting the desired KogitoRuntime when this KogitoBuild instance has a different name than the KogitoRuntime. By default this KogitoBuild instance will generate a final image named after its own name (.metadata.name). On OpenShift, an ImageStream will be created causing a redeployment on any KogitoRuntime with the same name. On Kubernetes, the final image will be pushed to the KogitoRuntime deployment. If you have multiple KogitoBuild instances (let's say BinaryBuildType and Remote Source), you might need that both target the same KogitoRuntime. Both KogitoBuilds will update the same ImageStream or generate a final image to the same KogitoRuntime deployment.
        /// </summary>
        [Input("targetKogitoRuntime")]
        public Input<string>? TargetKogitoRuntime { get; set; }

        /// <summary>
        /// Sets the type of build that this instance will handle: Binary - takes an uploaded binary file already compiled and creates a Kogito service image from it. RemoteSource - pulls the source code from a Git repository, builds the binary and then the final Kogito service image. LocalSource - takes an uploaded resource file such as DRL (rules), DMN (decision) or BPMN (process), builds the binary and the final Kogito service image.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("webHooks")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoBuildSpecWebHooksArgs>? _webHooks;

        /// <summary>
        /// WebHooks secrets for source to image builds based on Git repositories (Remote Sources).
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoBuildSpecWebHooksArgs> WebHooks
        {
            get => _webHooks ?? (_webHooks = new InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoBuildSpecWebHooksArgs>());
            set => _webHooks = value;
        }

        public KogitoBuildSpecArgs()
        {
        }
    }
}