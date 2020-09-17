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
    public sealed class JaegerSpecVolumesGlusterfs
    {
        public readonly string Endpoints;
        public readonly string Path;
        public readonly bool ReadOnly;

        [OutputConstructor]
        private JaegerSpecVolumesGlusterfs(
            string endpoints,

            string path,

            bool readOnly)
        {
            Endpoints = endpoints;
            Path = path;
            ReadOnly = readOnly;
        }
    }
}
