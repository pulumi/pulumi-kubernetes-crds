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
    /// SubscriptionSpec defines the desired state of Subscription
    /// </summary>
    public class SubscriptionSpecArgs : Pulumi.ResourceArgs
    {
        [Input("channel", required: true)]
        public Input<string> Channel { get; set; } = null!;

        /// <summary>
        /// To specify 1 package in channel
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("overrides")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.SubscriptionSpecOverridesArgs>? _overrides;

        /// <summary>
        /// for hub use only to specify the overrides when apply to clusters
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.SubscriptionSpecOverridesArgs> Overrides
        {
            get => _overrides ?? (_overrides = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.SubscriptionSpecOverridesArgs>());
            set => _overrides = value;
        }

        /// <summary>
        /// To specify more than 1 package in channel
        /// </summary>
        [Input("packageFilter")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1.SubscriptionSpecPackageFilterArgs>? PackageFilter { get; set; }

        [Input("packageOverrides")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.SubscriptionSpecPackageOverridesArgs>? _packageOverrides;

        /// <summary>
        /// To provide flexibility to override package in channel with local input
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.SubscriptionSpecPackageOverridesArgs> PackageOverrides
        {
            get => _packageOverrides ?? (_packageOverrides = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.SubscriptionSpecPackageOverridesArgs>());
            set => _packageOverrides = value;
        }

        /// <summary>
        /// For hub use only, to specify which clusters to go to
        /// </summary>
        [Input("placement")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1.SubscriptionSpecPlacementArgs>? Placement { get; set; }

        /// <summary>
        /// help user control when the subscription will take affect
        /// </summary>
        [Input("timewindow")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1.SubscriptionSpecTimewindowArgs>? Timewindow { get; set; }

        public SubscriptionSpecArgs()
        {
        }
    }
}