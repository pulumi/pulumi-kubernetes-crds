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
    public sealed class IntegrationPlatformSpec
    {
        /// <summary>
        /// IntegrationPlatformBuildSpec contains platform related build information
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformSpecBuild Build;
        /// <summary>
        /// IntegrationPlatformCluster is the kind of orchestration cluster the platform is installed into
        /// </summary>
        public readonly string Cluster;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformSpecConfiguration> Configuration;
        /// <summary>
        /// TraitProfile represents lists of traits that are enabled for the specific installation/integration
        /// </summary>
        public readonly string Profile;
        /// <summary>
        /// IntegrationPlatformResourcesSpec contains platform related resources
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformSpecResources Resources;
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformSpecTraits> Traits;

        [OutputConstructor]
        private IntegrationPlatformSpec(
            Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformSpecBuild build,

            string cluster,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformSpecConfiguration> configuration,

            string profile,

            Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformSpecResources resources,

            ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Camel.V1.IntegrationPlatformSpecTraits> traits)
        {
            Build = build;
            Cluster = cluster;
            Configuration = configuration;
            Profile = profile;
            Resources = resources;
            Traits = traits;
        }
    }
}
