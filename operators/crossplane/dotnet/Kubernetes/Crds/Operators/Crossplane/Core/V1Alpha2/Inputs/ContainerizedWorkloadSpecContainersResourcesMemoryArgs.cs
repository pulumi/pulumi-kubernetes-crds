// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2
{

    /// <summary>
    /// Memory required by this container.
    /// </summary>
    public class ContainerizedWorkloadSpecContainersResourcesMemoryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Required memory.
        /// </summary>
        [Input("required", required: true)]
        public Input<string> Required { get; set; } = null!;

        public ContainerizedWorkloadSpecContainersResourcesMemoryArgs()
        {
        }
    }
}
