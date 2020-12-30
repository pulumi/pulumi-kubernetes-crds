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
    public sealed class JaegerSpecStorageCassandraCreateSchema
    {
        public readonly string Datacenter;
        public readonly bool Enabled;
        public readonly string Image;
        public readonly string Mode;
        public readonly string Timeout;
        public readonly string TraceTTL;
        public readonly int TtlSecondsAfterFinished;

        [OutputConstructor]
        private JaegerSpecStorageCassandraCreateSchema(
            string datacenter,

            bool enabled,

            string image,

            string mode,

            string timeout,

            string traceTTL,

            int ttlSecondsAfterFinished)
        {
            Datacenter = datacenter;
            Enabled = enabled;
            Image = image;
            Mode = mode;
            Timeout = timeout;
            TraceTTL = traceTTL;
            TtlSecondsAfterFinished = ttlSecondsAfterFinished;
        }
    }
}
