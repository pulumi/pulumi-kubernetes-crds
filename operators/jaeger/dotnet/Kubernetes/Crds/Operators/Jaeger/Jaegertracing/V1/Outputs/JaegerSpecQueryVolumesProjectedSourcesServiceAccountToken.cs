// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1
{

    [OutputType]
    public sealed class JaegerSpecQueryVolumesProjectedSourcesServiceAccountToken
    {
        public readonly string Audience;
        public readonly int ExpirationSeconds;
        public readonly string Path;

        [OutputConstructor]
        private JaegerSpecQueryVolumesProjectedSourcesServiceAccountToken(
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
