// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class ThanosRulerSpecStorage
    {
        /// <summary>
        /// EmptyDirVolumeSource to be used by the Prometheus StatefulSets. If specified, used in place of any volumeClaimTemplate. More info: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecStorageEmptyDir EmptyDir;
        /// <summary>
        /// A PVC spec to be used by the Prometheus StatefulSets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecStorageVolumeClaimTemplate VolumeClaimTemplate;

        [OutputConstructor]
        private ThanosRulerSpecStorage(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecStorageEmptyDir emptyDir,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecStorageVolumeClaimTemplate volumeClaimTemplate)
        {
            EmptyDir = emptyDir;
            VolumeClaimTemplate = volumeClaimTemplate;
        }
    }
}