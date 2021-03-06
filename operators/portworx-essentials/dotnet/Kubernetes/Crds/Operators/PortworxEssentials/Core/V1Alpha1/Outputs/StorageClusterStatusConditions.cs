// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1
{

    [OutputType]
    public sealed class StorageClusterStatusConditions
    {
        /// <summary>
        /// Reason is human readable message indicating details about the current state of the cluster.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// Status of the condition.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Type of the condition.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private StorageClusterStatusConditions(
            string reason,

            string status,

            string type)
        {
            Reason = reason;
            Status = status;
            Type = type;
        }
    }
}
