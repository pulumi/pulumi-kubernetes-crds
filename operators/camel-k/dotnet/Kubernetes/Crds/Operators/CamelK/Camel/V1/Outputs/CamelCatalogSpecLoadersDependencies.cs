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
    public sealed class CamelCatalogSpecLoadersDependencies
    {
        public readonly string ArtifactId;
        public readonly string GroupId;
        public readonly string Version;

        [OutputConstructor]
        private CamelCatalogSpecLoadersDependencies(
            string artifactId,

            string groupId,

            string version)
        {
            ArtifactId = artifactId;
            GroupId = groupId;
            Version = version;
        }
    }
}
