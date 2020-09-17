// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1
{

    /// <summary>
    /// LoadBalancerServiceRef contains a reference to the load balancer service that will receive the traffic, if using a router, put here the service created by the ingress controller.
    /// </summary>
    public class GlobalDNSRecordSpecEndpointsLoadBalancerServiceRefArgs : Pulumi.ResourceArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("namespace", required: true)]
        public Input<string> Namespace { get; set; } = null!;

        public GlobalDNSRecordSpecEndpointsLoadBalancerServiceRefArgs()
        {
        }
    }
}