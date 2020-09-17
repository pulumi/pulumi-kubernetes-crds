// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1
{

    /// <summary>
    /// Auth contains user authentication and authorization security settings for Elasticsearch.
    /// </summary>
    public class ElasticsearchSpecAuthArgs : Pulumi.ResourceArgs
    {
        [Input("fileRealm")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchSpecAuthFileRealmArgs>? _fileRealm;

        /// <summary>
        /// FileRealm to propagate to the Elasticsearch cluster.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchSpecAuthFileRealmArgs> FileRealm
        {
            get => _fileRealm ?? (_fileRealm = new InputList<Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchSpecAuthFileRealmArgs>());
            set => _fileRealm = value;
        }

        [Input("roles")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchSpecAuthRolesArgs>? _roles;

        /// <summary>
        /// Roles to propagate to the Elasticsearch cluster.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchSpecAuthRolesArgs> Roles
        {
            get => _roles ?? (_roles = new InputList<Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1.ElasticsearchSpecAuthRolesArgs>());
            set => _roles = value;
        }

        public ElasticsearchSpecAuthArgs()
        {
        }
    }
}
