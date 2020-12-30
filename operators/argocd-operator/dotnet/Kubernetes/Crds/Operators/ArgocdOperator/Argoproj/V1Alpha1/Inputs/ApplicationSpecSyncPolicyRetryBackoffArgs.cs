// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// Backoff is a backoff strategy
    /// </summary>
    public class ApplicationSpecSyncPolicyRetryBackoffArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Duration is the amount to back off. Default unit is seconds, but could also be a duration (e.g. "2m", "1h")
        /// </summary>
        [Input("duration")]
        public Input<string>? Duration { get; set; }

        /// <summary>
        /// Factor is a factor to multiply the base duration after each failed retry
        /// </summary>
        [Input("factor")]
        public Input<int>? Factor { get; set; }

        /// <summary>
        /// MaxDuration is the maximum amount of time allowed for the backoff strategy
        /// </summary>
        [Input("maxDuration")]
        public Input<string>? MaxDuration { get; set; }

        public ApplicationSpecSyncPolicyRetryBackoffArgs()
        {
        }
    }
}
