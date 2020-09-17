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
    public sealed class AddressSpaceSpecConnectorsCredentials
    {
        /// <summary>
        /// Password to use for connector.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsCredentialsPassword Password;
        /// <summary>
        /// Username to use for connector.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsCredentialsUsername Username;

        [OutputConstructor]
        private AddressSpaceSpecConnectorsCredentials(
            Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsCredentialsPassword password,

            Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1.AddressSpaceSpecConnectorsCredentialsUsername username)
        {
            Password = password;
            Username = username;
        }
    }
}
