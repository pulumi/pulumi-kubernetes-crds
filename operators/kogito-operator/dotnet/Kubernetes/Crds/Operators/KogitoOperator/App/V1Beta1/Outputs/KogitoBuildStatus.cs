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
    public sealed class KogitoBuildStatus
    {
        /// <summary>
        /// History of builds
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoBuildStatusBuilds Builds;
        /// <summary>
        /// History of conditions for the resource, shows the status of the younger builder controlled by this instance
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoBuildStatusConditions> Conditions;
        public readonly string LatestBuild;

        [OutputConstructor]
        private KogitoBuildStatus(
            Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoBuildStatusBuilds builds,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoBuildStatusConditions> conditions,

            string latestBuild)
        {
            Builds = builds;
            Conditions = conditions;
            LatestBuild = latestBuild;
        }
    }
}
