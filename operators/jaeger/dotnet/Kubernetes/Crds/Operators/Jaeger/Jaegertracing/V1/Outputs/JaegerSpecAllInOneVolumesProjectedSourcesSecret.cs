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
    public sealed class JaegerSpecAllInOneVolumesProjectedSourcesSecret
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesProjectedSourcesSecretItems> Items;
        public readonly string Name;
        public readonly bool Optional;

        [OutputConstructor]
        private JaegerSpecAllInOneVolumesProjectedSourcesSecret(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesProjectedSourcesSecretItems> items,

            string name,

            bool optional)
        {
            Items = items;
            Name = name;
            Optional = optional;
        }
    }
}