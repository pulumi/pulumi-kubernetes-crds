// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Charts.V1
{

    [OutputType]
    public sealed class XlSpecMediation-AwsbillingResources
    {
        /// <summary>
        /// component limits
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecMediation-AwsbillingResourcesLimits Limits;

        [OutputConstructor]
        private XlSpecMediation-AwsbillingResources(Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecMediation-AwsbillingResourcesLimits limits)
        {
            Limits = limits;
        }
    }
}
