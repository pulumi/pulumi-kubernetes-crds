// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1
{

    [OutputType]
    public sealed class RestoreSpecTo
    {
        public readonly string Host;
        public readonly int Port;
        public readonly string SecretName;
        public readonly string TlsClientSecretName;
        public readonly string User;

        [OutputConstructor]
        private RestoreSpecTo(
            string host,

            int port,

            string secretName,

            string tlsClientSecretName,

            string user)
        {
            Host = host;
            Port = port;
            SecretName = secretName;
            TlsClientSecretName = tlsClientSecretName;
            User = user;
        }
    }
}
