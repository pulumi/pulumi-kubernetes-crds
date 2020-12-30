// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1
{

    [OutputType]
    public sealed class APIManagerSpecApicastStagingSpec
    {
        /// <summary>
        /// Affinity is a group of affinity scheduling rules.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecApicastStagingSpecAffinity Affinity;
        public readonly int Replicas;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecApicastStagingSpecTolerations> Tolerations;

        [OutputConstructor]
        private APIManagerSpecApicastStagingSpec(
            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecApicastStagingSpecAffinity affinity,

            int replicas,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecApicastStagingSpecTolerations> tolerations)
        {
            Affinity = affinity;
            Replicas = replicas;
            Tolerations = tolerations;
        }
    }
}
