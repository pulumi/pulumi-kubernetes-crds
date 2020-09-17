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
    /// CamelScheme --
    /// </summary>
    public class CamelCatalogSpecArtifactsSchemesArgs : Pulumi.ResourceArgs
    {
        [Input("http", required: true)]
        public Input<bool> Http { get; set; } = null!;

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("passive", required: true)]
        public Input<bool> Passive { get; set; } = null!;

        public CamelCatalogSpecArtifactsSchemesArgs()
        {
        }
    }
}
