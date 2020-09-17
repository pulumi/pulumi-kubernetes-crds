// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// Selector to select which namespaces the Endpoints objects are discovered from.
    /// </summary>
    public class ServiceMonitorSpecNamespaceSelectorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Boolean describing whether all namespaces are selected in contrast to a list restricting them.
        /// </summary>
        [Input("any")]
        public Input<bool>? Any { get; set; }

        [Input("matchNames")]
        private InputList<string>? _matchNames;

        /// <summary>
        /// List of namespace names.
        /// </summary>
        public InputList<string> MatchNames
        {
            get => _matchNames ?? (_matchNames = new InputList<string>());
            set => _matchNames = value;
        }

        public ServiceMonitorSpecNamespaceSelectorArgs()
        {
        }
    }
}
