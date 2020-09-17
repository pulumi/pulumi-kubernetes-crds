// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1
{

    /// <summary>
    /// PlacementRuleStatus defines the observed state of PlacementRule
    /// </summary>
    public class PlacementRuleStatusArgs : Pulumi.ResourceArgs
    {
        [Input("decisions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.PlacementRuleStatusDecisionsArgs>? _decisions;

        /// <summary>
        /// INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.PlacementRuleStatusDecisionsArgs> Decisions
        {
            get => _decisions ?? (_decisions = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.PlacementRuleStatusDecisionsArgs>());
            set => _decisions = value;
        }

        public PlacementRuleStatusArgs()
        {
        }
    }
}