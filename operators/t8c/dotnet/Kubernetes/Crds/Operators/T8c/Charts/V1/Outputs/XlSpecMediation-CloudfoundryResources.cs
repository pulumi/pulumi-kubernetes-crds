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
    public sealed class XlSpecMediation-CloudfoundryResources
    {
        /// <summary>
        /// component limits
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecMediation-CloudfoundryResourcesLimits Limits;

        [OutputConstructor]
        private XlSpecMediation-CloudfoundryResources(Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecMediation-CloudfoundryResourcesLimits limits)
        {
            Limits = limits;
        }
    }
}
