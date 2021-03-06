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
    /// GlobalDNSRecordStatus defines the observed state of GlobalDNSRecord
    /// </summary>
    public class GlobalDNSRecordStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalDNSRecordStatusConditionsArgs>? _conditions;

        /// <summary>
        /// ReconcileStatus this is the general status of the main reconciler
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalDNSRecordStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalDNSRecordStatusConditionsArgs>());
            set => _conditions = value;
        }

        [Input("endpointStatuses")]
        private InputMap<ImmutableArray<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalDNSRecordStatusEndpointStatusesArgs>>? _endpointStatuses;

        /// <summary>
        /// EndpointStatuses contains the status of the endpoint as they were looked up during the latest reconcile. We don't fail when an endpoint look up fails, but we need to tarck its status.
        /// </summary>
        public InputMap<ImmutableArray<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalDNSRecordStatusEndpointStatusesArgs>> EndpointStatuses
        {
            get => _endpointStatuses ?? (_endpointStatuses = new InputMap<ImmutableArray<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalDNSRecordStatusEndpointStatusesArgs>>());
            set => _endpointStatuses = value;
        }

        [Input("monitoredServiceStatuses")]
        private InputMap<ImmutableArray<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalDNSRecordStatusMonitoredServiceStatusesArgs>>? _monitoredServiceStatuses;

        /// <summary>
        /// MonitoredServiceStatuses contains the reconcile status of each of the monitored services in the remote clusters
        /// </summary>
        public InputMap<ImmutableArray<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalDNSRecordStatusMonitoredServiceStatusesArgs>> MonitoredServiceStatuses
        {
            get => _monitoredServiceStatuses ?? (_monitoredServiceStatuses = new InputMap<ImmutableArray<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalDNSRecordStatusMonitoredServiceStatusesArgs>>());
            set => _monitoredServiceStatuses = value;
        }

        /// <summary>
        /// ProviderStatus contains provider specific status information
        /// </summary>
        [Input("providerStatus")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.GlobalDNSRecordStatusProviderStatusArgs>? ProviderStatus { get; set; }

        public GlobalDNSRecordStatusArgs()
        {
        }
    }
}
