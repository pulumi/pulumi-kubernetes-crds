// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1
{

    /// <summary>
    /// A topology selector term represents the result of label queries. A null or empty topology selector term matches no objects. The requirements of them are ANDed. It provides a subset of functionality as NodeSelectorTerm. This is an alpha feature and may change in the future.
    /// </summary>
    public class CSIIsilonSpecDriverStorageClassAllowedTopologiesArgs : Pulumi.ResourceArgs
    {
        [Input("matchLabelExpressions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIIsilonSpecDriverStorageClassAllowedTopologiesMatchLabelExpressionsArgs>? _matchLabelExpressions;

        /// <summary>
        /// A list of topology selector requirements by labels.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIIsilonSpecDriverStorageClassAllowedTopologiesMatchLabelExpressionsArgs> MatchLabelExpressions
        {
            get => _matchLabelExpressions ?? (_matchLabelExpressions = new InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIIsilonSpecDriverStorageClassAllowedTopologiesMatchLabelExpressionsArgs>());
            set => _matchLabelExpressions = value;
        }

        public CSIIsilonSpecDriverStorageClassAllowedTopologiesArgs()
        {
        }
    }
}
