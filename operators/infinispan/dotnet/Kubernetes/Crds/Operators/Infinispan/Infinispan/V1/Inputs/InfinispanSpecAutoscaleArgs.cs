// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Infinispan.V1
{

    /// <summary>
    /// Autoscale describe autoscaling configuration for the cluster
    /// </summary>
    public class InfinispanSpecAutoscaleArgs : Pulumi.ResourceArgs
    {
        [Input("maxMemUsagePercent", required: true)]
        public Input<int> MaxMemUsagePercent { get; set; } = null!;

        [Input("maxReplicas", required: true)]
        public Input<int> MaxReplicas { get; set; } = null!;

        [Input("minMemUsagePercent", required: true)]
        public Input<int> MinMemUsagePercent { get; set; } = null!;

        [Input("minReplicas", required: true)]
        public Input<int> MinReplicas { get; set; } = null!;

        public InfinispanSpecAutoscaleArgs()
        {
        }
    }
}
