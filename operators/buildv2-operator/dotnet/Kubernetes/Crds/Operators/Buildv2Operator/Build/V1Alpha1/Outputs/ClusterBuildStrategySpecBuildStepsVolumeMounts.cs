// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1
{

    [OutputType]
    public sealed class ClusterBuildStrategySpecBuildStepsVolumeMounts
    {
        /// <summary>
        /// Path within the container at which the volume should be mounted.  Must not contain ':'.
        /// </summary>
        public readonly string MountPath;
        /// <summary>
        /// mountPropagation determines how mounts are propagated from the host to container and the other way around. When not set, MountPropagationNone is used. This field is beta in 1.10.
        /// </summary>
        public readonly string MountPropagation;
        /// <summary>
        /// This must match the Name of a Volume.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root).
        /// </summary>
        public readonly string SubPath;
        /// <summary>
        /// Expanded path within the volume from which the container's volume should be mounted. Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to "" (volume's root). SubPathExpr and SubPath are mutually exclusive.
        /// </summary>
        public readonly string SubPathExpr;

        [OutputConstructor]
        private ClusterBuildStrategySpecBuildStepsVolumeMounts(
            string mountPath,

            string mountPropagation,

            string name,

            bool readOnly,

            string subPath,

            string subPathExpr)
        {
            MountPath = mountPath;
            MountPropagation = mountPropagation;
            Name = name;
            ReadOnly = readOnly;
            SubPath = subPath;
            SubPathExpr = subPathExpr;
        }
    }
}
