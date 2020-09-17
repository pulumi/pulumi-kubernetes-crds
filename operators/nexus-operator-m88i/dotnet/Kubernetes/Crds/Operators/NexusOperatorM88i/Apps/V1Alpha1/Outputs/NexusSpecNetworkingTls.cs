// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1
{

    [OutputType]
    public sealed class NexusSpecNetworkingTls
    {
        /// <summary>
        /// When exposing via Route, set to `true` to only allow encrypted traffic using TLS (disables HTTP in favor of HTTPS). Defaults to false.
        /// </summary>
        public readonly bool Mandatory;
        /// <summary>
        /// When exposing via Ingress, inform the name of the TLS secret containing certificate and private key for TLS encryption. It must be present in the same namespace as the Operator.
        /// </summary>
        public readonly string SecretName;

        [OutputConstructor]
        private NexusSpecNetworkingTls(
            bool mandatory,

            string secretName)
        {
            Mandatory = mandatory;
            SecretName = secretName;
        }
    }
}