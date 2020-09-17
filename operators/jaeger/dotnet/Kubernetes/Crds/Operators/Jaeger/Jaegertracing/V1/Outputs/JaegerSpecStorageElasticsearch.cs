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
    public sealed class JaegerSpecStorageElasticsearch
    {
        public readonly string Image;
        public readonly int NodeCount;
        public readonly ImmutableDictionary<string, string> NodeSelector;
        public readonly string RedundancyPolicy;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageElasticsearchResources Resources;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageElasticsearchStorage Storage;

        [OutputConstructor]
        private JaegerSpecStorageElasticsearch(
            string image,

            int nodeCount,

            ImmutableDictionary<string, string> nodeSelector,

            string redundancyPolicy,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageElasticsearchResources resources,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecStorageElasticsearchStorage storage)
        {
            Image = image;
            NodeCount = nodeCount;
            NodeSelector = nodeSelector;
            RedundancyPolicy = redundancyPolicy;
            Resources = resources;
            Storage = storage;
        }
    }
}