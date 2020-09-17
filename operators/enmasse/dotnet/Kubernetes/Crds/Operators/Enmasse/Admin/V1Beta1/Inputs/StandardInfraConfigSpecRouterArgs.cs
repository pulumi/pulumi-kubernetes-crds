// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1
{

    public class StandardInfraConfigSpecRouterArgs : Pulumi.ResourceArgs
    {
        [Input("idleTimeout")]
        public Input<int>? IdleTimeout { get; set; }

        [Input("linkCapacity")]
        public Input<int>? LinkCapacity { get; set; }

        [Input("maxUnavailable")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.StandardInfraConfigSpecRouterMaxUnavailableArgs>? MaxUnavailable { get; set; }

        [Input("minAvailable")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.StandardInfraConfigSpecRouterMinAvailableArgs>? MinAvailable { get; set; }

        [Input("minReplicas")]
        public Input<int>? MinReplicas { get; set; }

        [Input("podTemplate")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.StandardInfraConfigSpecRouterPodTemplateArgs>? PodTemplate { get; set; }

        [Input("policy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.StandardInfraConfigSpecRouterPolicyArgs>? Policy { get; set; }

        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.StandardInfraConfigSpecRouterResourcesArgs>? Resources { get; set; }

        [Input("workerThreads")]
        public Input<int>? WorkerThreads { get; set; }

        public StandardInfraConfigSpecRouterArgs()
        {
        }
    }
}