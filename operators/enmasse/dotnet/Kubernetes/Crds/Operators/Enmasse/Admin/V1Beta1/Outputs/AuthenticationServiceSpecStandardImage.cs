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
    public sealed class AuthenticationServiceSpecStandardImage
    {
        public readonly string Name;
        public readonly string PullPolicy;

        [OutputConstructor]
        private AuthenticationServiceSpecStandardImage(
            string name,

            string pullPolicy)
        {
            Name = name;
            PullPolicy = pullPolicy;
        }
    }
}
