// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1
{

    [OutputType]
    public sealed class APIManagerStatusConditions
    {
        public readonly string Status;
        public readonly string Type;

        [OutputConstructor]
        private APIManagerStatusConditions(
            string status,

            string type)
        {
            Status = status;
            Type = type;
        }
    }
}
