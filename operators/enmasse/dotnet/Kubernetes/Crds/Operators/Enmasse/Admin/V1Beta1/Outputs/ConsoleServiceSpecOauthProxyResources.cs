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
    public sealed class ConsoleServiceSpecOauthProxyResources
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpecOauthProxyResourcesLimits Limits;
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpecOauthProxyResourcesRequests Requests;

        [OutputConstructor]
        private ConsoleServiceSpecOauthProxyResources(
            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpecOauthProxyResourcesLimits limits,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpecOauthProxyResourcesRequests requests)
        {
            Limits = limits;
            Requests = requests;
        }
    }
}
