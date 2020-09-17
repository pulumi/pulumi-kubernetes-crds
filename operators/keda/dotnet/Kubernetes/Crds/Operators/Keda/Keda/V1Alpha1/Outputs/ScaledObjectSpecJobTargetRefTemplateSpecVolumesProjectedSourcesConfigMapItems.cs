// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Keda.V1Alpha1
{

    [OutputType]
    public sealed class ScaledObjectSpecJobTargetRefTemplateSpecVolumesProjectedSourcesConfigMapItems
    {
        /// <summary>
        /// The key to project.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        public readonly int Mode;
        /// <summary>
        /// The relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.
        /// </summary>
        public readonly string Path;

        [OutputConstructor]
        private ScaledObjectSpecJobTargetRefTemplateSpecVolumesProjectedSourcesConfigMapItems(
            string key,

            int mode,

            string path)
        {
            Key = key;
            Mode = mode;
            Path = path;
        }
    }
}
