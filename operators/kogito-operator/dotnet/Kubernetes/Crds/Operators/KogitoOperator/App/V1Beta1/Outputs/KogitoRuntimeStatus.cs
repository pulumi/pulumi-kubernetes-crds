// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Beta1
{

    [OutputType]
    public sealed class KogitoRuntimeStatus
    {
        /// <summary>
        /// Describes the CloudEvents that this instance can consume or produce
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoRuntimeStatusCloudEvents CloudEvents;
        /// <summary>
        /// History of conditions for the resource
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoRuntimeStatusConditions> Conditions;
        /// <summary>
        /// General conditions for the Kogito Service deployment.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoRuntimeStatusDeploymentConditions> DeploymentConditions;
        /// <summary>
        /// URI is where the service is exposed.
        /// </summary>
        public readonly string ExternalURI;
        /// <summary>
        /// Image is the resolved image for this service.
        /// </summary>
        public readonly string Image;

        [OutputConstructor]
        private KogitoRuntimeStatus(
            Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoRuntimeStatusCloudEvents cloudEvents,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoRuntimeStatusConditions> conditions,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoRuntimeStatusDeploymentConditions> deploymentConditions,

            string externalURI,

            string image)
        {
            CloudEvents = cloudEvents;
            Conditions = conditions;
            DeploymentConditions = deploymentConditions;
            ExternalURI = externalURI;
            Image = image;
        }
    }
}
