// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// MachineSetStatus is the status of a machineset in the remote cluster.
    /// </summary>
    public class MachinePoolStatusMachineSetsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// MaxReplicas is the maximum number of replicas for the machine set.
        /// </summary>
        [Input("maxReplicas", required: true)]
        public Input<int> MaxReplicas { get; set; } = null!;

        /// <summary>
        /// MinReplicas is the minimum number of replicas for the machine set.
        /// </summary>
        [Input("minReplicas", required: true)]
        public Input<int> MinReplicas { get; set; } = null!;

        /// <summary>
        /// Name is the name of the machine set.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Replicas is the current number of replicas for the machine set.
        /// </summary>
        [Input("replicas", required: true)]
        public Input<int> Replicas { get; set; } = null!;

        public MachinePoolStatusMachineSetsArgs()
        {
        }
    }
}