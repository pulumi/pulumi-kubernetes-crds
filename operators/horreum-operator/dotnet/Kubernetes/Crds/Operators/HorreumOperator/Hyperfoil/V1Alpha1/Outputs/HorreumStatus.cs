// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hyperfoil.V1Alpha1
{

    [OutputType]
    public sealed class HorreumStatus
    {
        /// <summary>
        /// Last time state has changed.
        /// </summary>
        public readonly string LastUpdate;
        /// <summary>
        /// Explanation for the current status.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// Ready, Pending or Error.
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private HorreumStatus(
            string lastUpdate,

            string reason,

            string status)
        {
            LastUpdate = lastUpdate;
            Reason = reason;
            Status = status;
        }
    }
}
