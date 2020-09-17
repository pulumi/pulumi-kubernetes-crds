// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Camel.V1
{

    [OutputType]
    public sealed class IntegrationKitStatusFailureRecovery
    {
        public readonly int Attempt;
        public readonly int AttemptMax;
        public readonly string AttemptTime;

        [OutputConstructor]
        private IntegrationKitStatusFailureRecovery(
            int attempt,

            int attemptMax,

            string attemptTime)
        {
            Attempt = attempt;
            AttemptMax = attemptMax;
            AttemptTime = attemptTime;
        }
    }
}
