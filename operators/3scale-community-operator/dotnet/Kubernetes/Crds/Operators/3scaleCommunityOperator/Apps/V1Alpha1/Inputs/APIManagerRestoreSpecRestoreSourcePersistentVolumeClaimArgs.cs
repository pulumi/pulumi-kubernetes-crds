// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    /// <summary>
    /// Restore data soure configuration
    /// </summary>
    public class APIManagerRestoreSpecRestoreSourcePersistentVolumeClaimArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// PersistentVolumeClaim source of an existing PersistentVolumeClaim. See
        /// </summary>
        [Input("claimSource", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerRestoreSpecRestoreSourcePersistentVolumeClaimClaimSourceArgs> ClaimSource { get; set; } = null!;

        public APIManagerRestoreSpecRestoreSourcePersistentVolumeClaimArgs()
        {
        }
    }
}
