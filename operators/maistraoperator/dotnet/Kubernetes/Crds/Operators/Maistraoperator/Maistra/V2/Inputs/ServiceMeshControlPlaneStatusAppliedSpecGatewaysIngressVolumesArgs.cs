// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecGatewaysIngressVolumesArgs : Pulumi.ResourceArgs
    {
        [Input("volume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysIngressVolumesVolumeArgs>? Volume { get; set; }

        [Input("volumeMount")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysIngressVolumesVolumeMountArgs>? VolumeMount { get; set; }

        public ServiceMeshControlPlaneStatusAppliedSpecGatewaysIngressVolumesArgs()
        {
        }
    }
}
