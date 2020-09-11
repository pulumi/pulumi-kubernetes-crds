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
    public sealed class AlertmanagerSpecVolumesDownwardAPI
    {
        /// <summary>
        /// Optional: mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        public readonly int DefaultMode;
        /// <summary>
        /// Items is a list of downward API volume file
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecVolumesDownwardAPIItems> Items;

        [OutputConstructor]
        private AlertmanagerSpecVolumesDownwardAPI(
            int defaultMode,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.AlertmanagerSpecVolumesDownwardAPIItems> items)
        {
            DefaultMode = defaultMode;
            Items = items;
        }
    }
}
