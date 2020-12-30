// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressArgs : Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("requestedNetworkView")]
        private InputList<string>? _requestedNetworkView;
        public InputList<string> RequestedNetworkView
        {
            get => _requestedNetworkView ?? (_requestedNetworkView = new InputList<string>());
            set => _requestedNetworkView = value;
        }

        [Input("routerMode")]
        public Input<string>? RouterMode { get; set; }

        [Input("runtime")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressRuntimeArgs>? Runtime { get; set; }

        [Input("service")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressServiceArgs>? Service { get; set; }

        [Input("volumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressVolumesArgs>? _volumes;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressVolumesArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressVolumesArgs>());
            set => _volumes = value;
        }

        public ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressArgs()
        {
        }
    }
}
