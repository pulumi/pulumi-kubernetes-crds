// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1
{

    /// <summary>
    /// ClusterReference contains the infomation necessary to connect to a cluster
    /// </summary>
    public class GlobalRouteDiscoverySpecClustersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CredentialsSecretRef is a reference to a secret containing the credentials to access the cluster a key called "kubeconfig" containing a valid kubeconfig file for connecting to the cluster must exist in this secret.
        /// </summary>
        [Input("clusterCredentialRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalRouteDiscoverySpecClustersClusterCredentialRefArgs> ClusterCredentialRef { get; set; } = null!;

        /// <summary>
        /// ClusterName name of the cluster to connect to.
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        public GlobalRouteDiscoverySpecClustersArgs()
        {
        }
    }
}
