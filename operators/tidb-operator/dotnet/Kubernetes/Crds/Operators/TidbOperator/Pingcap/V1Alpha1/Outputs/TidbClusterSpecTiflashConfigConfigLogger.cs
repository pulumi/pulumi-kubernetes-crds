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
    public sealed class TidbClusterSpecTiflashConfigConfigLogger
    {
        public readonly int Count;
        public readonly string Level;
        public readonly string Size;

        [OutputConstructor]
        private TidbClusterSpecTiflashConfigConfigLogger(
            int count,

            string level,

            string size)
        {
            Count = count;
            Level = level;
            Size = size;
        }
    }
}
