// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("limits")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResourcesLimitsArgs>? _limits;
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResourcesLimitsArgs> Limits
        {
            get => _limits ?? (_limits = new InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResourcesLimitsArgs>());
            set => _limits = value;
        }

        [Input("requests")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResourcesRequestsArgs>? _requests;
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResourcesRequestsArgs> Requests
        {
            get => _requests ?? (_requests = new InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResourcesRequestsArgs>());
            set => _requests = value;
        }

        public ServiceMeshControlPlaneSpecGatewaysAdditionalEgressRuntimeContainerResourcesArgs()
        {
        }
    }
}
