// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V1
{

    public class ServiceMeshMemberRollStatusConditionsArgs : Pulumi.ResourceArgs
    {
        [Input("lastTransitionTime")]
        public Input<string>? LastTransitionTime { get; set; }

        [Input("message")]
        public Input<string>? Message { get; set; }

        [Input("reason")]
        public Input<string>? Reason { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public ServiceMeshMemberRollStatusConditionsArgs()
        {
        }
    }
}
