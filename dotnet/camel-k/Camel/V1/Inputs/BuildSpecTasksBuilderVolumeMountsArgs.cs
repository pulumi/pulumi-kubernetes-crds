// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Camel.V1
{

    /// <summary>
    /// VolumeMount describes a mounting of a Volume within a container.
    /// </summary>
    public class BuildSpecTasksBuilderVolumeMountsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Path within the container at which the volume should be mounted.  Must not contain ':'.
        /// </summary>
        [Input("mountPath", required: true)]
        public Input<string> MountPath { get; set; } = null!;

        /// <summary>
        /// mountPropagation determines how mounts are propagated from the host to container and the other way around. When not set, MountPropagationNone is used. This field is beta in 1.10.
        /// </summary>
        [Input("mountPropagation")]
        public Input<string>? MountPropagation { get; set; }

        /// <summary>
        /// This must match the Name of a Volume.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        /// <summary>
        /// Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root).
        /// </summary>
        [Input("subPath")]
        public Input<string>? SubPath { get; set; }

        /// <summary>
        /// Expanded path within the volume from which the container's volume should be mounted. Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to "" (volume's root). SubPathExpr and SubPath are mutually exclusive.
        /// </summary>
        [Input("subPathExpr")]
        public Input<string>? SubPathExpr { get; set; }

        public BuildSpecTasksBuilderVolumeMountsArgs()
        {
        }
    }
}
