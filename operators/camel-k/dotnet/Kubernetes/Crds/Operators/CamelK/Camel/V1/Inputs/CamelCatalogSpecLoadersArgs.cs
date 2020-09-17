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
    /// CamelLoader --
    /// </summary>
    public class CamelCatalogSpecLoadersArgs : Pulumi.ResourceArgs
    {
        [Input("artifactId", required: true)]
        public Input<string> ArtifactId { get; set; } = null!;

        [Input("dependencies")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.CamelCatalogSpecLoadersDependenciesArgs>? _dependencies;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.CamelCatalogSpecLoadersDependenciesArgs> Dependencies
        {
            get => _dependencies ?? (_dependencies = new InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.CamelCatalogSpecLoadersDependenciesArgs>());
            set => _dependencies = value;
        }

        [Input("groupId", required: true)]
        public Input<string> GroupId { get; set; } = null!;

        [Input("languages")]
        private InputList<string>? _languages;
        public InputList<string> Languages
        {
            get => _languages ?? (_languages = new InputList<string>());
            set => _languages = value;
        }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public CamelCatalogSpecLoadersArgs()
        {
        }
    }
}
