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
    /// ClusterMetadata contains metadata information about the installed cluster.
    /// </summary>
    public class ClusterDeploymentSpecClusterMetadataArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AdminKubeconfigSecretRef references the secret containing the admin kubeconfig for this cluster.
        /// </summary>
        [Input("adminKubeconfigSecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterDeploymentSpecClusterMetadataAdminKubeconfigSecretRefArgs> AdminKubeconfigSecretRef { get; set; } = null!;

        /// <summary>
        /// AdminPasswordSecretRef references the secret containing the admin username/password which can be used to login to this cluster.
        /// </summary>
        [Input("adminPasswordSecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterDeploymentSpecClusterMetadataAdminPasswordSecretRefArgs> AdminPasswordSecretRef { get; set; } = null!;

        /// <summary>
        /// ClusterID is a globally unique identifier for this cluster generated during installation. Used for reporting metrics among other places.
        /// </summary>
        [Input("clusterID", required: true)]
        public Input<string> ClusterID { get; set; } = null!;

        /// <summary>
        /// InfraID is an identifier for this cluster generated during installation and used for tagging/naming resources in cloud providers.
        /// </summary>
        [Input("infraID", required: true)]
        public Input<string> InfraID { get; set; } = null!;

        public ClusterDeploymentSpecClusterMetadataArgs()
        {
        }
    }
}