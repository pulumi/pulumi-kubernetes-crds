// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1
{

    [OutputType]
    public sealed class ConsoleServiceSpecImpersonation
    {
        /// <summary>
        /// Headers to use for user impersonation.
        /// </summary>
        public readonly string UserHeader;

        [OutputConstructor]
        private ConsoleServiceSpecImpersonation(string userHeader)
        {
            UserHeader = userHeader;
        }
    }
}
