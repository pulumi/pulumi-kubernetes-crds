// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Velero.V1
{

    [OutputType]
    public sealed class VolumeSnapshotLocationSpec
    {
        /// <summary>
        /// Config is for provider-specific configuration fields.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Config;
        /// <summary>
        /// Provider is the provider of the volume storage.
        /// </summary>
        public readonly string Provider;

        [OutputConstructor]
        private VolumeSnapshotLocationSpec(
            ImmutableDictionary<string, string> config,

            string provider)
        {
            Config = config;
            Provider = provider;
        }
    }
}
