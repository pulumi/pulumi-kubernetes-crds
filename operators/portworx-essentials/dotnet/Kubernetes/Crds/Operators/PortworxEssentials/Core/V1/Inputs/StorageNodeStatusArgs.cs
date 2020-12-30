// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1
{

    /// <summary>
    /// Most recently observed status of the storage node. The data may not be up to date.
    /// </summary>
    public class StorageNodeStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageNodeStatusConditionsArgs>? _conditions;

        /// <summary>
        /// Contains details for the current condition of this storage node.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageNodeStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageNodeStatusConditionsArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// Contains topology information for the storage node.
        /// </summary>
        [Input("geography")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageNodeStatusGeographyArgs>? Geography { get; set; }

        /// <summary>
        /// Contains network information used by the storage node
        /// </summary>
        [Input("network")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageNodeStatusNetworkArgs>? Network { get; set; }

        /// <summary>
        /// Unique ID of the storage node.
        /// </summary>
        [Input("nodeUid")]
        public Input<string>? NodeUid { get; set; }

        /// <summary>
        /// Phase of the StorageNode is a simple, high-level summary of where the StorageNode is in its lifecycle. The condition array contains more detailed information about the state of the node.
        /// </summary>
        [Input("phase")]
        public Input<string>? Phase { get; set; }

        /// <summary>
        /// Contains details of the status of storage for the node
        /// </summary>
        [Input("storage")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageNodeStatusStorageArgs>? Storage { get; set; }

        public StorageNodeStatusArgs()
        {
        }
    }
}
