// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Maistra.V2
{

    [OutputType]
    public sealed class ServiceMeshControlPlaneSpecClusterMeshExpansionIlbGatewayServicePorts
    {
        public readonly string AppProtocol;
        public readonly string Name;
        public readonly int NodePort;
        public readonly int Port;
        public readonly string Protocol;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecClusterMeshExpansionIlbGatewayServicePortsTargetPort TargetPort;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecClusterMeshExpansionIlbGatewayServicePorts(
            string appProtocol,

            string name,

            int nodePort,

            int port,

            string protocol,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecClusterMeshExpansionIlbGatewayServicePortsTargetPort targetPort)
        {
            AppProtocol = appProtocol;
            Name = name;
            NodePort = nodePort;
            Port = port;
            Protocol = protocol;
            TargetPort = targetPort;
        }
    }
}
