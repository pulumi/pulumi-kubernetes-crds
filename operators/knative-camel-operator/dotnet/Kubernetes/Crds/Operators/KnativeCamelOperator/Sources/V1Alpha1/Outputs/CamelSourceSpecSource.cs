// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Sources.V1Alpha1
{

    [OutputType]
    public sealed class CamelSourceSpecSource
    {
        public readonly ImmutableDictionary<string, object> Flow;
        public readonly ImmutableDictionary<string, object> Integration;

        [OutputConstructor]
        private CamelSourceSpecSource(
            ImmutableDictionary<string, object> flow,

            ImmutableDictionary<string, object> integration)
        {
            Flow = flow;
            Integration = integration;
        }
    }
}