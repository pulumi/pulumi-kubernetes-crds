// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Deploy.V1Alpha1
{

    /// <summary>
    /// IP address information for entries in the (plural) PodIPs field. Each entry includes:    IP: An IP address allocated to the pod. Routable at least within the cluster.
    /// </summary>
    public class OperatorStatusPodIPsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ip is an IP address (IPv4 or IPv6) assigned to the pod
        /// </summary>
        [Input("ip")]
        public Input<string>? Ip { get; set; }

        public OperatorStatusPodIPsArgs()
        {
        }
    }
}
