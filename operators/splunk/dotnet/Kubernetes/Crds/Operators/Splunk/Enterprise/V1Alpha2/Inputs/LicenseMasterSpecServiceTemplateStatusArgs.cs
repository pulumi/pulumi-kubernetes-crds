// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2
{

    /// <summary>
    /// Most recently observed status of the service. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    public class LicenseMasterSpecServiceTemplateStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// LoadBalancer contains the current status of the load-balancer, if one is present.
        /// </summary>
        [Input("loadBalancer")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.LicenseMasterSpecServiceTemplateStatusLoadBalancerArgs>? LoadBalancer { get; set; }

        public LicenseMasterSpecServiceTemplateStatusArgs()
        {
        }
    }
}
