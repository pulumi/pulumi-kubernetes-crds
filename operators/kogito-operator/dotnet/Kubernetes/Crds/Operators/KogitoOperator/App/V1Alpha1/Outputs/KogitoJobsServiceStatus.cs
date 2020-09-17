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
    public sealed class KogitoJobsServiceStatus
    {
        /// <summary>
        /// History of conditions for the resource
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoJobsServiceStatusConditions> Conditions;
        /// <summary>
        /// General conditions for the Kogito Service deployment.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoJobsServiceStatusDeploymentConditions> DeploymentConditions;
        /// <summary>
        /// URI is where the service is exposed.
        /// </summary>
        public readonly string ExternalURI;
        /// <summary>
        /// Image is the resolved image for this service.
        /// </summary>
        public readonly string Image;

        [OutputConstructor]
        private KogitoJobsServiceStatus(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoJobsServiceStatusConditions> conditions,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1.KogitoJobsServiceStatusDeploymentConditions> deploymentConditions,

            string externalURI,

            string image)
        {
            Conditions = conditions;
            DeploymentConditions = deploymentConditions;
            ExternalURI = externalURI;
            Image = image;
        }
    }
}
