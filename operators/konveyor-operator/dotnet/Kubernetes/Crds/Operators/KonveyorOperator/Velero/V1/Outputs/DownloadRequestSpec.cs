// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Velero.V1
{

    [OutputType]
    public sealed class DownloadRequestSpec
    {
        /// <summary>
        /// Target is what to download (e.g. logs for a backup).
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Velero.V1.DownloadRequestSpecTarget Target;

        [OutputConstructor]
        private DownloadRequestSpec(Pulumi.Kubernetes.Types.Outputs.Velero.V1.DownloadRequestSpecTarget target)
        {
            Target = target;
        }
    }
}