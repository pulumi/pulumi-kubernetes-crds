// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Eventing.V1Alpha1
{

    [OutputType]
    public sealed class KnativeEventingKafkaSpec
    {
        /// <summary>
        /// URI(s) of Apache Kafka broker(s)
        /// </summary>
        public readonly string BootstrapServers;
        /// <summary>
        /// Flag that controls whether Kafka channel provisioner is configured as the cluster default. Defaults to false.
        /// </summary>
        public readonly bool SetAsDefaultChannelProvisioner;

        [OutputConstructor]
        private KnativeEventingKafkaSpec(
            string bootstrapServers,

            bool setAsDefaultChannelProvisioner)
        {
            BootstrapServers = bootstrapServers;
            SetAsDefaultChannelProvisioner = setAsDefaultChannelProvisioner;
        }
    }
}
