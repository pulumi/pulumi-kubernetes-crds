// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1
{

    /// <summary>
    /// Link to Kubernetes Secret containing the OAuth client secret which the Kafka client can use to authenticate against the OAuth server and use the token endpoint URI.
    /// </summary>
    public class KafkaMirrorMaker2SpecClustersAuthenticationClientSecretArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key under which the secret value is stored in the Kubernetes Secret.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// The name of the Kubernetes Secret containing the secret value.
        /// </summary>
        [Input("secretName", required: true)]
        public Input<string> SecretName { get; set; } = null!;

        public KafkaMirrorMaker2SpecClustersAuthenticationClientSecretArgs()
        {
        }
    }
}