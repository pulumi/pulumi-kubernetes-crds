// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Camel.V1
{

    [OutputType]
    public sealed class IntegrationPlatformStatus
    {
        /// <summary>
        /// IntegrationPlatformBuildSpec contains platform related build information
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformStatusBuild Build;
        /// <summary>
        /// IntegrationPlatformCluster is the kind of orchestration cluster the platform is installed into
        /// </summary>
        public readonly string Cluster;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformStatusConditions> Conditions;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformStatusConfiguration> Configuration;
        /// <summary>
        /// IntegrationPlatformPhase --
        /// </summary>
        public readonly string Phase;
        /// <summary>
        /// TraitProfile represents lists of traits that are enabled for the specific installation/integration
        /// </summary>
        public readonly string Profile;
        /// <summary>
        /// IntegrationPlatformResourcesSpec contains platform related resources
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformStatusResources Resources;
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformStatusTraits> Traits;
        public readonly string Version;

        [OutputConstructor]
        private IntegrationPlatformStatus(
            Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformStatusBuild build,

            string cluster,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformStatusConditions> conditions,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformStatusConfiguration> configuration,

            string phase,

            string profile,

            Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformStatusResources resources,

            ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformStatusTraits> traits,

            string version)
        {
            Build = build;
            Cluster = cluster;
            Conditions = conditions;
            Configuration = configuration;
            Phase = phase;
            Profile = profile;
            Resources = resources;
            Traits = traits;
            Version = version;
        }
    }
}
