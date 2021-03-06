// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Yaks.V1Alpha1
{

    [OutputType]
    public sealed class TestStatusResults
    {
        public readonly ImmutableArray<string> Errors;
        public readonly Pulumi.Kubernetes.Types.Outputs.Yaks.V1Alpha1.TestStatusResultsSummary Summary;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Yaks.V1Alpha1.TestStatusResultsTests> Tests;

        [OutputConstructor]
        private TestStatusResults(
            ImmutableArray<string> errors,

            Pulumi.Kubernetes.Types.Outputs.Yaks.V1Alpha1.TestStatusResultsSummary summary,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Yaks.V1Alpha1.TestStatusResultsTests> tests)
        {
            Errors = errors;
            Summary = summary;
            Tests = tests;
        }
    }
}
