// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1
{

    [OutputType]
    public sealed class SubmarinerStatusGatewaysStatusConnections
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusGatewaysStatusConnectionsEndpoint Endpoint;
        public readonly string Status;
        public readonly string StatusMessage;

        [OutputConstructor]
        private SubmarinerStatusGatewaysStatusConnections(
            Pulumi.Kubernetes.Types.Outputs.Submariner.V1Alpha1.SubmarinerStatusGatewaysStatusConnectionsEndpoint endpoint,

            string status,

            string statusMessage)
        {
            Endpoint = endpoint;
            Status = status;
            StatusMessage = statusMessage;
        }
    }
}