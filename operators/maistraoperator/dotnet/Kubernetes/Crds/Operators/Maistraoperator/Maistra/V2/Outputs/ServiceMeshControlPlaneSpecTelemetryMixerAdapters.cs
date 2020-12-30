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
    public sealed class ServiceMeshControlPlaneSpecTelemetryMixerAdapters
    {
        public readonly bool Kubernetesenv;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecTelemetryMixerAdaptersStdio Stdio;
        public readonly bool UseAdapterCRDs;

        [OutputConstructor]
        private ServiceMeshControlPlaneSpecTelemetryMixerAdapters(
            bool kubernetesenv,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneSpecTelemetryMixerAdaptersStdio stdio,

            bool useAdapterCRDs)
        {
            Kubernetesenv = kubernetesenv;
            Stdio = stdio;
            UseAdapterCRDs = useAdapterCRDs;
        }
    }
}
