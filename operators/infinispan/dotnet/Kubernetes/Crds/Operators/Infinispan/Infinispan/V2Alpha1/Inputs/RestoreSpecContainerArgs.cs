// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Infinispan.V2Alpha1
{

    /// <summary>
    /// InfinispanContainerSpec specify resource requirements per container
    /// </summary>
    public class RestoreSpecContainerArgs : Pulumi.ResourceArgs
    {
        [Input("cpu")]
        public Input<string>? Cpu { get; set; }

        [Input("extraJvmOpts")]
        public Input<string>? ExtraJvmOpts { get; set; }

        [Input("memory")]
        public Input<string>? Memory { get; set; }

        public RestoreSpecContainerArgs()
        {
        }
    }
}
