// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Camel.V1
{

    /// <summary>
    /// IntegrationKitStatus defines the observed state of IntegrationKit
    /// </summary>
    public class IntegrationKitStatusArgs : Pulumi.ResourceArgs
    {
        [Input("artifacts")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationKitStatusArtifactsArgs>? _artifacts;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationKitStatusArtifactsArgs> Artifacts
        {
            get => _artifacts ?? (_artifacts = new InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationKitStatusArtifactsArgs>());
            set => _artifacts = value;
        }

        [Input("baseImage")]
        public Input<string>? BaseImage { get; set; }

        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationKitStatusConditionsArgs>? _conditions;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationKitStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationKitStatusConditionsArgs>());
            set => _conditions = value;
        }

        [Input("digest")]
        public Input<string>? Digest { get; set; }

        /// <summary>
        /// Failure --
        /// </summary>
        [Input("failure")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationKitStatusFailureArgs>? Failure { get; set; }

        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// IntegrationKitPhase --
        /// </summary>
        [Input("phase")]
        public Input<string>? Phase { get; set; }

        [Input("platform")]
        public Input<string>? Platform { get; set; }

        /// <summary>
        /// RuntimeProvider --
        /// </summary>
        [Input("runtimeProvider")]
        public Input<string>? RuntimeProvider { get; set; }

        [Input("runtimeVersion")]
        public Input<string>? RuntimeVersion { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public IntegrationKitStatusArgs()
        {
        }
    }
}