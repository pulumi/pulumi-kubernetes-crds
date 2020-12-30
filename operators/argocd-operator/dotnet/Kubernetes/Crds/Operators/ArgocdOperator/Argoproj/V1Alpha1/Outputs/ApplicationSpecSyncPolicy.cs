// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ApplicationSpecSyncPolicy
    {
        /// <summary>
        /// Automated will keep an application synced to the target revision
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecSyncPolicyAutomated Automated;
        /// <summary>
        /// Retry controls failed sync retry behavior
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecSyncPolicyRetry Retry;
        /// <summary>
        /// Options allow you to specify whole app sync-options
        /// </summary>
        public readonly ImmutableArray<string> SyncOptions;

        [OutputConstructor]
        private ApplicationSpecSyncPolicy(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecSyncPolicyAutomated automated,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSpecSyncPolicyRetry retry,

            ImmutableArray<string> syncOptions)
        {
            Automated = automated;
            Retry = retry;
            SyncOptions = syncOptions;
        }
    }
}
