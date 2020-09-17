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
    /// InfinispanSpec defines the desired state of Infinispan
    /// </summary>
    public class InfinispanSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Autoscale describe autoscaling configuration for the cluster
        /// </summary>
        [Input("autoscale")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Infinispan.V1.InfinispanSpecAutoscaleArgs>? Autoscale { get; set; }

        /// <summary>
        /// InfinispanContainerSpec specify resource requirements per container
        /// </summary>
        [Input("container")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Infinispan.V1.InfinispanSpecContainerArgs>? Container { get; set; }

        /// <summary>
        /// ExposeSpec describe how Infinispan will be exposed externally
        /// </summary>
        [Input("expose")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Infinispan.V1.InfinispanSpecExposeArgs>? Expose { get; set; }

        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("logging")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Infinispan.V1.InfinispanSpecLoggingArgs>? Logging { get; set; }

        [Input("replicas", required: true)]
        public Input<int> Replicas { get; set; } = null!;

        /// <summary>
        /// InfinispanSecurity info for the user application connection
        /// </summary>
        [Input("security")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Infinispan.V1.InfinispanSpecSecurityArgs>? Security { get; set; }

        /// <summary>
        /// InfinispanServiceSpec specify configuration for specific service
        /// </summary>
        [Input("service")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Infinispan.V1.InfinispanSpecServiceArgs>? Service { get; set; }

        public InfinispanSpecArgs()
        {
        }
    }
}
