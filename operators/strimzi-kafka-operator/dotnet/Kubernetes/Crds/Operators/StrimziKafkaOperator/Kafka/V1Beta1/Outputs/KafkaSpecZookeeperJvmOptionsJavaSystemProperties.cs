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
    public sealed class KafkaSpecZookeeperJvmOptionsJavaSystemProperties
    {
        /// <summary>
        /// The system property name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The system property value.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private KafkaSpecZookeeperJvmOptionsJavaSystemProperties(
            string name,

            string value)
        {
            Name = name;
            Value = value;
        }
    }
}
