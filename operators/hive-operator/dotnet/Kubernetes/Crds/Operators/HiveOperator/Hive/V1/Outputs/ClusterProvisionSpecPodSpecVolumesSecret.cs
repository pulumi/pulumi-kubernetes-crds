// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class ClusterProvisionSpecPodSpecVolumesSecret
    {
        /// <summary>
        /// Optional: mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        public readonly int DefaultMode;
        /// <summary>
        /// If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecVolumesSecretItems> Items;
        /// <summary>
        /// Specify whether the Secret or its keys must be defined
        /// </summary>
        public readonly bool Optional;
        /// <summary>
        /// Name of the secret in the pod's namespace to use. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
        /// </summary>
        public readonly string SecretName;

        [OutputConstructor]
        private ClusterProvisionSpecPodSpecVolumesSecret(
            int defaultMode,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpecVolumesSecretItems> items,

            bool optional,

            string secretName)
        {
            DefaultMode = defaultMode;
            Items = items;
            Optional = optional;
            SecretName = secretName;
        }
    }
}
