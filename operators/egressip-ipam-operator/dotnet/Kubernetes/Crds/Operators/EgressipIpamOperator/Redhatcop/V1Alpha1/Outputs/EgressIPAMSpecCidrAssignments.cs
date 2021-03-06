// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1
{

    [OutputType]
    public sealed class EgressIPAMSpecCidrAssignments
    {
        /// <summary>
        /// kubebuilder:validation:Pattern=^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(/(3[0-2]|2[0-9]|1[0-9]|[0-9]))?$ CIDR a CIDR. IPs in this CIDR will be added to the nodes selected by the topology label and value. These IPs must be routable when attached to the selected nodes
        /// </summary>
        public readonly string CIDR;
        /// <summary>
        /// LabelValue the label value, which together with the TopologyLabel select the nodes that will carry the IPs from this CIDR
        /// </summary>
        public readonly string LabelValue;
        /// <summary>
        /// This does not work kubebuilder:validation:Pattern=`^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$` ReservedIPs a set of IPs in the CIDR that are reserved for other purposes and cannot be assigned.
        /// </summary>
        public readonly ImmutableArray<string> ReservedIPs;

        [OutputConstructor]
        private EgressIPAMSpecCidrAssignments(
            string CIDR,

            string labelValue,

            ImmutableArray<string> reservedIPs)
        {
            this.CIDR = CIDR;
            LabelValue = labelValue;
            ReservedIPs = reservedIPs;
        }
    }
}
