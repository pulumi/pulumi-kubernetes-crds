// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1
{

    [OutputType]
    public sealed class TopicStatus
    {
        public readonly string Message;
        public readonly string State;

        [OutputConstructor]
        private TopicStatus(
            string message,

            string state)
        {
            Message = message;
            State = state;
        }
    }
}