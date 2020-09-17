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
    public sealed class ApplicationStatusOperationStateSyncResultSourceDirectoryJsonnet
    {
        /// <summary>
        /// ExtVars is a list of Jsonnet External Variables
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourceDirectoryJsonnetExtVars> ExtVars;
        /// <summary>
        /// TLAS is a list of Jsonnet Top-level Arguments
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourceDirectoryJsonnetTlas> Tlas;

        [OutputConstructor]
        private ApplicationStatusOperationStateSyncResultSourceDirectoryJsonnet(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourceDirectoryJsonnetExtVars> extVars,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourceDirectoryJsonnetTlas> tlas)
        {
            ExtVars = extVars;
            Tlas = tlas;
        }
    }
}
