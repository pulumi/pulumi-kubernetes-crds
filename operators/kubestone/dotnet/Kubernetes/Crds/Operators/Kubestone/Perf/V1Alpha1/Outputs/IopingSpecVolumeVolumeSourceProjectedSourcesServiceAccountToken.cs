// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1
{

    [OutputType]
    public sealed class IopingSpecVolumeVolumeSourceProjectedSourcesServiceAccountToken
    {
        /// <summary>
        /// Audience is the intended audience of the token. A recipient of a token must identify itself with an identifier specified in the audience of the token, and otherwise should reject the token. The audience defaults to the identifier of the apiserver.
        /// </summary>
        public readonly string Audience;
        /// <summary>
        /// ExpirationSeconds is the requested duration of validity of the service account token. As the token approaches expiration, the kubelet volume plugin will proactively rotate the service account token. The kubelet will start trying to rotate the token if the token is older than 80 percent of its time to live or if the token is older than 24 hours.Defaults to 1 hour and must be at least 10 minutes.
        /// </summary>
        public readonly int ExpirationSeconds;
        /// <summary>
        /// Path is the path relative to the mount point of the file to project the token into.
        /// </summary>
        public readonly string Path;

        [OutputConstructor]
        private IopingSpecVolumeVolumeSourceProjectedSourcesServiceAccountToken(
            string audience,

            int expirationSeconds,

            string path)
        {
            Audience = audience;
            ExpirationSeconds = expirationSeconds;
            Path = path;
        }
    }
}
