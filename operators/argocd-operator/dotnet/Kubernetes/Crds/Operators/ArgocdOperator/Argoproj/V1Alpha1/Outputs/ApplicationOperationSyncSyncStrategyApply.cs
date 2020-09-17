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
    public sealed class ApplicationOperationSyncSyncStrategyApply
    {
        /// <summary>
        /// Force indicates whether or not to supply the --force flag to `kubectl apply`. The --force flag deletes and re-create the resource, when PATCH encounters conflict and has retried for 5 times.
        /// </summary>
        public readonly bool Force;

        [OutputConstructor]
        private ApplicationOperationSyncSyncStrategyApply(bool force)
        {
            Force = force;
        }
    }
}
