// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1
{

    [OutputType]
    public sealed class ElasticsearchSpecSecureSettings
    {
        /// <summary>
        /// Entries define how to project each key-value pair in the secret to filesystem paths. If not defined, all keys will be projected to similarly named paths in the filesystem. If defined, only the specified keys will be projected to the corresponding paths.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1.ElasticsearchSpecSecureSettingsEntries> Entries;
        /// <summary>
        /// SecretName is the name of the secret.
        /// </summary>
        public readonly string SecretName;

        [OutputConstructor]
        private ElasticsearchSpecSecureSettings(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1.ElasticsearchSpecSecureSettingsEntries> entries,

            string secretName)
        {
            Entries = entries;
            SecretName = secretName;
        }
    }
}
