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
    /// DNSZoneStatus defines the observed state of DNSZone
    /// </summary>
    public class DNSZoneStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AWSDNSZoneStatus contains status information specific to AWS
        /// </summary>
        [Input("aws")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.DNSZoneStatusAwsArgs>? Aws { get; set; }

        [Input("azure")]
        private InputMap<object>? _azure;

        /// <summary>
        /// AzureDNSZoneStatus contains status information specific to Azure
        /// </summary>
        public InputMap<object> Azure
        {
            get => _azure ?? (_azure = new InputMap<object>());
            set => _azure = value;
        }

        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Hive.V1.DNSZoneStatusConditionsArgs>? _conditions;

        /// <summary>
        /// Conditions includes more detailed status for the DNSZone
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Hive.V1.DNSZoneStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Hive.V1.DNSZoneStatusConditionsArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// GCPDNSZoneStatus contains status information specific to GCP
        /// </summary>
        [Input("gcp")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.DNSZoneStatusGcpArgs>? Gcp { get; set; }

        /// <summary>
        /// LastSyncGeneration is the generation of the zone resource that was last sync'd. This is used to know if the Object has changed and we should sync immediately.
        /// </summary>
        [Input("lastSyncGeneration")]
        public Input<int>? LastSyncGeneration { get; set; }

        /// <summary>
        /// LastSyncTimestamp is the time that the zone was last sync'd.
        /// </summary>
        [Input("lastSyncTimestamp")]
        public Input<string>? LastSyncTimestamp { get; set; }

        [Input("nameServers")]
        private InputList<string>? _nameServers;

        /// <summary>
        /// NameServers is a list of nameservers for this DNS zone
        /// </summary>
        public InputList<string> NameServers
        {
            get => _nameServers ?? (_nameServers = new InputList<string>());
            set => _nameServers = value;
        }

        public DNSZoneStatusArgs()
        {
        }
    }
}