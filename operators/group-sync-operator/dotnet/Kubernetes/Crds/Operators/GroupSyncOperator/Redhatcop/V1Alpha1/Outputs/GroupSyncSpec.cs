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
    public sealed class GroupSyncSpec
    {
        /// <summary>
        /// List of Providers that can be mounted by containers belonging to the pod.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProviders> Providers;
        public readonly string Schedule;

        [OutputConstructor]
        private GroupSyncSpec(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProviders> providers,

            string schedule)
        {
            Providers = providers;
            Schedule = schedule;
        }
    }
}
