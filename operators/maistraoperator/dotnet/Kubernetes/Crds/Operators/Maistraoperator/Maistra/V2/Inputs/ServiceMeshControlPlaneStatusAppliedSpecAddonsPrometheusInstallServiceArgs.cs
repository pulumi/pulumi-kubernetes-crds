// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecAddonsPrometheusInstallServiceArgs : Pulumi.ResourceArgs
    {
        [Input("ingress")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsPrometheusInstallServiceIngressArgs>? Ingress { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsPrometheusInstallServiceMetadataArgs>? Metadata { get; set; }

        [Input("nodePort")]
        public Input<int>? NodePort { get; set; }

        public ServiceMeshControlPlaneStatusAppliedSpecAddonsPrometheusInstallServiceArgs()
        {
        }
    }
}
