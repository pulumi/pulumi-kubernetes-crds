// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Storage.V1
{

    [OutputType]
    public sealed class CSIPowerMaxRevProxySpecConfig
    {
        /// <summary>
        /// LinkConfig is one of the configuration modes for reverse proxy
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxRevProxySpecConfigLinkConfig LinkConfig;
        public readonly string Mode;
        public readonly int Port;
        /// <summary>
        /// StandAloneConfig is one of the configuration modes for reverse proxy
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfig StandAloneConfig;

        [OutputConstructor]
        private CSIPowerMaxRevProxySpecConfig(
            Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxRevProxySpecConfigLinkConfig linkConfig,

            string mode,

            int port,

            Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfig standAloneConfig)
        {
            LinkConfig = linkConfig;
            Mode = mode;
            Port = port;
            StandAloneConfig = standAloneConfig;
        }
    }
}
