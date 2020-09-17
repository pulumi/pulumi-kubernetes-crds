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
    /// A ContainerizedWorkloadSpec defines the desired state of a ContainerizedWorkload.
    /// </summary>
    public class ContainerizedWorkloadSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CPUArchitecture required by this workload.
        /// </summary>
        [Input("arch")]
        public Input<string>? Arch { get; set; }

        [Input("containers", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersArgs>? _containers;

        /// <summary>
        /// Containers of which this workload consists.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersArgs> Containers
        {
            get => _containers ?? (_containers = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ContainerizedWorkloadSpecContainersArgs>());
            set => _containers = value;
        }

        /// <summary>
        /// OperatingSystem required by this workload.
        /// </summary>
        [Input("osType")]
        public Input<string>? OsType { get; set; }

        public ContainerizedWorkloadSpecArgs()
        {
        }
    }
}