// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2
{

    [OutputType]
    public sealed class StandaloneSpecVolumesPersistentVolumeClaim
    {
        /// <summary>
        /// ClaimName is the name of a PersistentVolumeClaim in the same namespace as the pod using this volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        public readonly string ClaimName;
        /// <summary>
        /// Will force the ReadOnly setting in VolumeMounts. Default false.
        /// </summary>
        public readonly bool ReadOnly;

        [OutputConstructor]
        private StandaloneSpecVolumesPersistentVolumeClaim(
            string claimName,

            bool readOnly)
        {
            ClaimName = claimName;
            ReadOnly = readOnly;
        }
    }
}
