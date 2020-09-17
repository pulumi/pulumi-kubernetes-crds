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
    /// MavenArtifact --
    /// </summary>
    public class CamelCatalogSpecRuntimeCapabilitiesDependenciesArgs : Pulumi.ResourceArgs
    {
        [Input("artifactId", required: true)]
        public Input<string> ArtifactId { get; set; } = null!;

        [Input("groupId", required: true)]
        public Input<string> GroupId { get; set; } = null!;

        [Input("version")]
        public Input<string>? Version { get; set; }

        public CamelCatalogSpecRuntimeCapabilitiesDependenciesArgs()
        {
        }
    }
}