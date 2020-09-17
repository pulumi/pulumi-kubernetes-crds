// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1
{

    [OutputType]
    public sealed class SubscriptionSpec
    {
        public readonly string Channel;
        /// <summary>
        /// To specify 1 package in channel
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// for hub use only to specify the overrides when apply to clusters
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1.SubscriptionSpecOverrides> Overrides;
        /// <summary>
        /// To specify more than 1 package in channel
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1.SubscriptionSpecPackageFilter PackageFilter;
        /// <summary>
        /// To provide flexibility to override package in channel with local input
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1.SubscriptionSpecPackageOverrides> PackageOverrides;
        /// <summary>
        /// For hub use only, to specify which clusters to go to
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1.SubscriptionSpecPlacement Placement;
        /// <summary>
        /// help user control when the subscription will take affect
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1.SubscriptionSpecTimewindow Timewindow;

        [OutputConstructor]
        private SubscriptionSpec(
            string channel,

            string name,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1.SubscriptionSpecOverrides> overrides,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1.SubscriptionSpecPackageFilter packageFilter,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1.SubscriptionSpecPackageOverrides> packageOverrides,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1.SubscriptionSpecPlacement placement,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1.SubscriptionSpecTimewindow timewindow)
        {
            Channel = channel;
            Name = name;
            Overrides = overrides;
            PackageFilter = packageFilter;
            PackageOverrides = packageOverrides;
            Placement = placement;
            Timewindow = timewindow;
        }
    }
}
