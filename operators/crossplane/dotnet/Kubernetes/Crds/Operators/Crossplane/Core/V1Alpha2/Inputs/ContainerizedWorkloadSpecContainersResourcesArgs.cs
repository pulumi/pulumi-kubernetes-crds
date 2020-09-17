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
    /// Resources required by this container
    /// </summary>
    public class ContainerizedWorkloadSpecContainersResourcesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CPU required by this container.
        /// </summary>
        [Input("cpu", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResourcesCpuArgs> Cpu { get; set; } = null!;

        [Input("extended")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResourcesExtendedArgs>? _extended;

        /// <summary>
        /// Extended resources required by this container.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResourcesExtendedArgs> Extended
        {
            get => _extended ?? (_extended = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResourcesExtendedArgs>());
            set => _extended = value;
        }

        /// <summary>
        /// GPU required by this container.
        /// </summary>
        [Input("gpu")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResourcesGpuArgs>? Gpu { get; set; }

        /// <summary>
        /// Memory required by this container.
        /// </summary>
        [Input("memory", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResourcesMemoryArgs> Memory { get; set; } = null!;

        [Input("volumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResourcesVolumesArgs>? _volumes;

        /// <summary>
        /// Volumes required by this container.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResourcesVolumesArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersResourcesVolumesArgs>());
            set => _volumes = value;
        }

        public ContainerizedWorkloadSpecContainersResourcesArgs()
        {
        }
    }
}