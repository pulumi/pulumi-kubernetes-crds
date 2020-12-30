// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Capabilities.V1Beta1
{

    [OutputType]
    public sealed class BackendSpecMappingRules
    {
        public readonly string HttpMethod;
        public readonly int Increment;
        public readonly string MetricMethodRef;
        public readonly string Pattern;
        public readonly int Position;

        [OutputConstructor]
        private BackendSpecMappingRules(
            string httpMethod,

            int increment,

            string metricMethodRef,

            string pattern,

            int position)
        {
            HttpMethod = httpMethod;
            Increment = increment;
            MetricMethodRef = metricMethodRef;
            Pattern = pattern;
            Position = position;
        }
    }
}
