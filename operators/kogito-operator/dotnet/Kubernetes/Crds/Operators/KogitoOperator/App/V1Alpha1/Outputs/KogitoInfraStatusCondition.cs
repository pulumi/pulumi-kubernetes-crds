// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1
{

    [OutputType]
    public sealed class KogitoInfraStatusCondition
    {
        public readonly string LastTransitionTime;
        public readonly string Message;
        public readonly string Status;
        /// <summary>
        /// KogitoInfraConditionType ...
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KogitoInfraStatusCondition(
            string lastTransitionTime,

            string message,

            string status,

            string type)
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Status = status;
            Type = type;
        }
    }
}
