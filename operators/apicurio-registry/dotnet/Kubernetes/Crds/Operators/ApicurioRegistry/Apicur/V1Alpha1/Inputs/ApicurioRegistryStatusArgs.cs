// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apicur.V1Alpha1
{

    /// <summary>
    /// ApicurioRegistryStatus defines the observed state of ApicurioRegistry
    /// </summary>
    public class ApicurioRegistryStatusArgs : Pulumi.ResourceArgs
    {
        [Input("deploymentName")]
        public Input<string>? DeploymentName { get; set; }

        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("ingressName")]
        public Input<string>? IngressName { get; set; }

        [Input("replicaCount")]
        public Input<int>? ReplicaCount { get; set; }

        [Input("serviceName")]
        public Input<string>? ServiceName { get; set; }

        public ApicurioRegistryStatusArgs()
        {
        }
    }
}