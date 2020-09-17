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
    /// EgressIPAMSpec defines the desired state of EgressIPAM
    /// </summary>
    public class EgressIPAMSpecArgs : Pulumi.ResourceArgs
    {
        [Input("cidrAssignments")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.EgressIPAMSpecCidrAssignmentsArgs>? _cidrAssignments;

        /// <summary>
        /// CIDRAssignments is a set of CIDRs. Namespaces will receive one available IP from each of this CIDRs.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.EgressIPAMSpecCidrAssignmentsArgs> CidrAssignments
        {
            get => _cidrAssignments ?? (_cidrAssignments = new InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.EgressIPAMSpecCidrAssignmentsArgs>());
            set => _cidrAssignments = value;
        }

        /// <summary>
        /// NodeSelector is a selector that allows to subset which nodes will be managed by this EgressIPAM
        /// </summary>
        [Input("nodeSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.EgressIPAMSpecNodeSelectorArgs>? NodeSelector { get; set; }

        /// <summary>
        /// TopologyLabel is the label that needs to identified nodes that will carry egressIPs in the CIDRAssignments. Each label value should map to a CIDR in the CIDRAssignments.
        /// </summary>
        [Input("topologyLabel", required: true)]
        public Input<string> TopologyLabel { get; set; } = null!;

        public EgressIPAMSpecArgs()
        {
        }
    }
}
