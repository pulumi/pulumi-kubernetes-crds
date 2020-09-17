// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
    /// </summary>
    public class ThanosRulerSpecVolumesPersistentVolumeClaimArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ClaimName is the name of a PersistentVolumeClaim in the same namespace as the pod using this volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        [Input("claimName", required: true)]
        public Input<string> ClaimName { get; set; } = null!;

        /// <summary>
        /// Will force the ReadOnly setting in VolumeMounts. Default false.
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        public ThanosRulerSpecVolumesPersistentVolumeClaimArgs()
        {
        }
    }
}
