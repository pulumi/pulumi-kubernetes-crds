// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Camel.V1
{

    /// <summary>
    /// FailureRecovery --
    /// </summary>
    public class BuildStatusFailureRecoveryArgs : Pulumi.ResourceArgs
    {
        [Input("attempt", required: true)]
        public Input<int> Attempt { get; set; } = null!;

        [Input("attemptMax", required: true)]
        public Input<int> AttemptMax { get; set; } = null!;

        [Input("attemptTime")]
        public Input<string>? AttemptTime { get; set; }

        public BuildStatusFailureRecoveryArgs()
        {
        }
    }
}
