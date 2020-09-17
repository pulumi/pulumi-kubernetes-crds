// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1
{

    [OutputType]
    public sealed class KafkaMirrorMaker2SpecExternalConfiguration
    {
        /// <summary>
        /// Allows to pass data from Secret or ConfigMap to the Kafka Connect pods as environment variables.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecExternalConfigurationEnv> Env;
        /// <summary>
        /// Allows to pass data from Secret or ConfigMap to the Kafka Connect pods as volumes.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecExternalConfigurationVolumes> Volumes;

        [OutputConstructor]
        private KafkaMirrorMaker2SpecExternalConfiguration(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecExternalConfigurationEnv> env,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecExternalConfigurationVolumes> volumes)
        {
            Env = env;
            Volumes = volumes;
        }
    }
}