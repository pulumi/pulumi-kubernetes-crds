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
    public sealed class SubscriptionStatusStatuses
    {
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Apps.V1.SubscriptionStatusStatusesPackages> Packages;

        [OutputConstructor]
        private SubscriptionStatusStatuses(ImmutableDictionary<string, Pulumi.Kubernetes.Types.Outputs.Apps.V1.SubscriptionStatusStatusesPackages> packages)
        {
            Packages = packages;
        }
    }
}