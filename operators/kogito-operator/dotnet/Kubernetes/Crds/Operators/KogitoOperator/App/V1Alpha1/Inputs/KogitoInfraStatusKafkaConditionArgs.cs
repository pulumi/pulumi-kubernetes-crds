// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1
{

    /// <summary>
    /// InstallCondition defines the installation condition for the infrastructure actor.
    /// </summary>
    public class KogitoInfraStatusKafkaConditionArgs : Pulumi.ResourceArgs
    {
        [Input("lastTransitionTime")]
        public Input<string>? LastTransitionTime { get; set; }

        [Input("message")]
        public Input<string>? Message { get; set; }

        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        /// <summary>
        /// InstallConditionType defines the possibles conditions that a install might have.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public KogitoInfraStatusKafkaConditionArgs()
        {
        }
    }
}
