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
    /// ClusterClaimSpec defines the desired state of the ClusterClaim.
    /// </summary>
    public class ClusterClaimSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ClusterPoolName is the name of the cluster pool from which to claim a cluster.
        /// </summary>
        [Input("clusterPoolName", required: true)]
        public Input<string> ClusterPoolName { get; set; } = null!;

        /// <summary>
        /// Namespace is the namespace containing the ClusterDeployment of the claimed cluster. This field will be set by the ClusterPool when the claim is assigned a cluster.
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("subjects")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterClaimSpecSubjectsArgs>? _subjects;

        /// <summary>
        /// Subjects hold references to which to authorize access to the claimed cluster.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterClaimSpecSubjectsArgs> Subjects
        {
            get => _subjects ?? (_subjects = new InputList<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterClaimSpecSubjectsArgs>());
            set => _subjects = value;
        }

        public ClusterClaimSpecArgs()
        {
        }
    }
}
