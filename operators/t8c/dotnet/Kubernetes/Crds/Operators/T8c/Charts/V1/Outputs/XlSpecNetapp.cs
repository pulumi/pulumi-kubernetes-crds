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
    public sealed class XlSpecNetapp
    {
        /// <summary>
        /// Enable NetApp mediation
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private XlSpecNetapp(bool enabled)
        {
            Enabled = enabled;
        }
    }
}
