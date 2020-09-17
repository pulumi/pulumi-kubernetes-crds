// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1
{

    [OutputType]
    public sealed class KafkaSpecKafkaJmxOptionsAuthentication
    {
        /// <summary>
        /// Authentication type. Currently the only supported types are `password`.`password` type creates a username and protected port with no TLS.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KafkaSpecKafkaJmxOptionsAuthentication(string type)
        {
            Type = type;
        }
    }
}