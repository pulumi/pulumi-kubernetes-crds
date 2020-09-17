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
    /// GlobalRouteDiscoveryStatus defines the observed state of GlobalRouteDiscovery
    /// </summary>
    public class GlobalRouteDiscoveryStatusArgs : Pulumi.ResourceArgs
    {
        [Input("clusterReferenceStatuses")]
        private InputMap<ImmutableArray<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalRouteDiscoveryStatusClusterReferenceStatusesArgs>>? _clusterReferenceStatuses;

        /// <summary>
        /// ClusterReferenceStatuses contains the status of the cluster refence connections and their latest reconcile.
        /// </summary>
        public InputMap<ImmutableArray<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalRouteDiscoveryStatusClusterReferenceStatusesArgs>> ClusterReferenceStatuses
        {
            get => _clusterReferenceStatuses ?? (_clusterReferenceStatuses = new InputMap<ImmutableArray<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalRouteDiscoveryStatusClusterReferenceStatusesArgs>>());
            set => _clusterReferenceStatuses = value;
        }

        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalRouteDiscoveryStatusConditionsArgs>? _conditions;

        /// <summary>
        /// ReconcileStatus this is the general status of the main reconciler
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalRouteDiscoveryStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalRouteDiscoveryStatusConditionsArgs>());
            set => _conditions = value;
        }

        public GlobalRouteDiscoveryStatusArgs()
        {
        }
    }
}