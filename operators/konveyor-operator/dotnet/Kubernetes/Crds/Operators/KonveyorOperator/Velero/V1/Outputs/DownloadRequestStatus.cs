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
    public sealed class DownloadRequestStatus
    {
        /// <summary>
        /// DownloadURL contains the pre-signed URL for the target file.
        /// </summary>
        public readonly string DownloadURL;
        /// <summary>
        /// Expiration is when this DownloadRequest expires and can be deleted by the system.
        /// </summary>
        public readonly string Expiration;
        /// <summary>
        /// Phase is the current state of the DownloadRequest.
        /// </summary>
        public readonly string Phase;

        [OutputConstructor]
        private DownloadRequestStatus(
            string downloadURL,

            string expiration,

            string phase)
        {
            DownloadURL = downloadURL;
            Expiration = expiration;
            Phase = phase;
        }
    }
}