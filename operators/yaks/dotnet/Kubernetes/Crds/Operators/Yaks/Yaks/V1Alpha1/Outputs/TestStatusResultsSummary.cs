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
    public sealed class TestStatusResultsSummary
    {
        public readonly int Failed;
        public readonly int Passed;
        public readonly int Pending;
        public readonly int Skipped;
        public readonly int Total;
        public readonly int Undefined;

        [OutputConstructor]
        private TestStatusResultsSummary(
            int failed,

            int passed,

            int pending,

            int skipped,

            int total,

            int undefined)
        {
            Failed = failed;
            Passed = passed;
            Pending = pending;
            Skipped = skipped;
            Total = total;
            Undefined = undefined;
        }
    }
}
