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
    public sealed class XlSpecMediation-AcimsResourcesLimits
    {
        /// <summary>
        /// component memory limits
        /// </summary>
        public readonly string Memory;

        [OutputConstructor]
        private XlSpecMediation-AcimsResourcesLimits(string memory)
        {
            Memory = memory;
        }
    }
}
