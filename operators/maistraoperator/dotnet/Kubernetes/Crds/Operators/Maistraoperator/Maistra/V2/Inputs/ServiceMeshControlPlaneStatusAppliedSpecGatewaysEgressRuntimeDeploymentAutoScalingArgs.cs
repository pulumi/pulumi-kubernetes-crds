// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecGatewaysEgressRuntimeDeploymentAutoScalingArgs : Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("maxReplicas")]
        public Input<int>? MaxReplicas { get; set; }

        [Input("minReplicas")]
        public Input<int>? MinReplicas { get; set; }

        [Input("targetCPUUtilizationPercentage")]
        public Input<int>? TargetCPUUtilizationPercentage { get; set; }

        public ServiceMeshControlPlaneStatusAppliedSpecGatewaysEgressRuntimeDeploymentAutoScalingArgs()
        {
        }
    }
}
