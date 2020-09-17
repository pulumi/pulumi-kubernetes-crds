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
    public sealed class KafkaConnectS2ISpecAuthenticationPasswordSecret
    {
        /// <summary>
        /// The name of the key in the Secret under which the password is stored.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// The name of the Secret containing the password.
        /// </summary>
        public readonly string SecretName;

        [OutputConstructor]
        private KafkaConnectS2ISpecAuthenticationPasswordSecret(
            string password,

            string secretName)
        {
            Password = password;
            SecretName = secretName;
        }
    }
}