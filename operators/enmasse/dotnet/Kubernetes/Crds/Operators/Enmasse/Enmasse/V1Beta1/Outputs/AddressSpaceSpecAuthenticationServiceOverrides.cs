// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1
{

    [OutputType]
    public sealed class AddressSpaceSpecAuthenticationServiceOverrides
    {
        public readonly string Host;
        public readonly int Port;
        public readonly string Realm;

        [OutputConstructor]
        private AddressSpaceSpecAuthenticationServiceOverrides(
            string host,

            int port,

            string realm)
        {
            Host = host;
            Port = port;
            Realm = realm;
        }
    }
}
