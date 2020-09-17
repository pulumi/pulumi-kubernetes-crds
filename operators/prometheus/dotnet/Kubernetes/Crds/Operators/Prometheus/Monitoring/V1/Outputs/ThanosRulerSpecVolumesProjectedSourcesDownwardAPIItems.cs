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
    public sealed class ThanosRulerSpecVolumesProjectedSourcesDownwardAPIItems
    {
        /// <summary>
        /// Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecVolumesProjectedSourcesDownwardAPIItemsFieldRef FieldRef;
        /// <summary>
        /// Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        public readonly int Mode;
        /// <summary>
        /// Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef ResourceFieldRef;

        [OutputConstructor]
        private ThanosRulerSpecVolumesProjectedSourcesDownwardAPIItems(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecVolumesProjectedSourcesDownwardAPIItemsFieldRef fieldRef,

            int mode,

            string path,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef resourceFieldRef)
        {
            FieldRef = fieldRef;
            Mode = mode;
            Path = path;
            ResourceFieldRef = resourceFieldRef;
        }
    }
}
