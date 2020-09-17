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
    public sealed class KafkaSpecEntityOperatorUserOperatorLogging
    {
        /// <summary>
        /// A Map from logger name to logger level.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Loggers;
        /// <summary>
        /// The name of the `ConfigMap` from which to get the logging configuration.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Logging type, must be either 'inline' or 'external'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KafkaSpecEntityOperatorUserOperatorLogging(
            ImmutableDictionary<string, object> loggers,

            string name,

            string type)
        {
            Loggers = loggers;
            Name = name;
            Type = type;
        }
    }
}
