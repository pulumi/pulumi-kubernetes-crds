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
    public sealed class CamelCatalogSpecArtifactsDependencies
    {
        public readonly string ArtifactId;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1.CamelCatalogSpecArtifactsDependenciesExclusions> Exclusions;
        public readonly string GroupId;
        public readonly string Version;

        [OutputConstructor]
        private CamelCatalogSpecArtifactsDependencies(
            string artifactId,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1.CamelCatalogSpecArtifactsDependenciesExclusions> exclusions,

            string groupId,

            string version)
        {
            ArtifactId = artifactId;
            Exclusions = exclusions;
            GroupId = groupId;
            Version = version;
        }
    }
}
