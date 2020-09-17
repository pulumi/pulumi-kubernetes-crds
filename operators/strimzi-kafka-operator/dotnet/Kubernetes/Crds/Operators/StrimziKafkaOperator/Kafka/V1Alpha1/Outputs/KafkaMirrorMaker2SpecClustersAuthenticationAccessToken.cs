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
    public sealed class KafkaMirrorMaker2SpecClustersAuthenticationAccessToken
    {
        /// <summary>
        /// The key under which the secret value is stored in the Kubernetes Secret.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// The name of the Kubernetes Secret containing the secret value.
        /// </summary>
        public readonly string SecretName;

        [OutputConstructor]
        private KafkaMirrorMaker2SpecClustersAuthenticationAccessToken(
            string key,

            string secretName)
        {
            Key = key;
            SecretName = secretName;
        }
    }
}
