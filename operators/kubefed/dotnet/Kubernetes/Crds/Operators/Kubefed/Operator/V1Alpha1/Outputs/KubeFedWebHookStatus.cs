// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Operator.V1Alpha1
{

    [OutputType]
    public sealed class KubeFedWebHookStatus
    {
        /// <summary>
        /// The version of the installed release
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private KubeFedWebHookStatus(string version)
        {
            Version = version;
        }
    }
}