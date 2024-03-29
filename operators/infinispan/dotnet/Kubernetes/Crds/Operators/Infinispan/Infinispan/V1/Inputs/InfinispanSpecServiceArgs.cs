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
    /// InfinispanServiceSpec specify configuration for specific service
    /// </summary>
    public class InfinispanSpecServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// InfinispanServiceContainerSpec resource requirements specific for service
        /// </summary>
        [Input("container")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Infinispan.V1.InfinispanSpecServiceContainerArgs>? Container { get; set; }

        [Input("replicationFactor")]
        public Input<int>? ReplicationFactor { get; set; }

        [Input("sites")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Infinispan.V1.InfinispanSpecServiceSitesArgs>? Sites { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public InfinispanSpecServiceArgs()
        {
        }
    }
}
