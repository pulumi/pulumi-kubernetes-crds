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
    public sealed class ServiceMeshControlPlaneSpecTelemetryRemote
    {
        public readonly string Address;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecTelemetryRemoteBatching Batching;
        public readonly bool CreateService;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecTelemetryRemote(
            string address,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecTelemetryRemoteBatching batching,

            bool createService)
        {
            Address = address;
            Batching = batching;
            CreateService = createService;
        }
    }
}
