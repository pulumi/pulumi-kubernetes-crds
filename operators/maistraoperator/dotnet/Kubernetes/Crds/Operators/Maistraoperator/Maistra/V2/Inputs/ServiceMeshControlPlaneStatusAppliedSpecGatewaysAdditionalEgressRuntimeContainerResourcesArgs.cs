// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressRuntimeContainerResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("limits")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressRuntimeContainerResourcesLimitsArgs>? _limits;
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressRuntimeContainerResourcesLimitsArgs> Limits
        {
            get => _limits ?? (_limits = new InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressRuntimeContainerResourcesLimitsArgs>());
            set => _limits = value;
        }

        [Input("requests")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressRuntimeContainerResourcesRequestsArgs>? _requests;
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressRuntimeContainerResourcesRequestsArgs> Requests
        {
            get => _requests ?? (_requests = new InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressRuntimeContainerResourcesRequestsArgs>());
            set => _requests = value;
        }

        public ServiceMeshControlPlaneStatusAppliedSpecGatewaysAdditionalEgressRuntimeContainerResourcesArgs()
        {
        }
    }
}
