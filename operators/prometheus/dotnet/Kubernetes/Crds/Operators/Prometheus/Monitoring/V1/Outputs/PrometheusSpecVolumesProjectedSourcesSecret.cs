// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class PrometheusSpecVolumesProjectedSourcesSecret
    {
        /// <summary>
        /// If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecVolumesProjectedSourcesSecretItems> Items;
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Specify whether the Secret or its key must be defined
        /// </summary>
        public readonly bool Optional;

        [OutputConstructor]
        private PrometheusSpecVolumesProjectedSourcesSecret(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecVolumesProjectedSourcesSecretItems> items,

            string name,

            bool optional)
        {
            Items = items;
            Name = name;
            Optional = optional;
        }
    }
}
