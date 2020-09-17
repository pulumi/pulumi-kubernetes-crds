// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1
{

    [OutputType]
    public sealed class TidbClusterSpecTiflashConfigConfig
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashConfigConfigFlash Flash;
        public readonly Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashConfigConfigLogger Logger;
        public readonly int Mark_cache_size;
        public readonly int Minmax_index_cache_size;
        public readonly bool Path_realtime_mode;

        [OutputConstructor]
        private TidbClusterSpecTiflashConfigConfig(
            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashConfigConfigFlash flash,

            Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1.TidbClusterSpecTiflashConfigConfigLogger logger,

            int mark_cache_size,

            int minmax_index_cache_size,

            bool path_realtime_mode)
        {
            Flash = flash;
            Logger = logger;
            Mark_cache_size = mark_cache_size;
            Minmax_index_cache_size = minmax_index_cache_size;
            Path_realtime_mode = path_realtime_mode;
        }
    }
}