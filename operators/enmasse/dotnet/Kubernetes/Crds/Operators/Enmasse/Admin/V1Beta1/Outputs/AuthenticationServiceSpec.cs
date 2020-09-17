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
    public sealed class AuthenticationServiceSpec
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.AuthenticationServiceSpecExternal External;
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.AuthenticationServiceSpecNone None;
        public readonly string Realm;
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.AuthenticationServiceSpecStandard Standard;
        public readonly string Type;

        [OutputConstructor]
        private AuthenticationServiceSpec(
            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.AuthenticationServiceSpecExternal external,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.AuthenticationServiceSpecNone none,

            string realm,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.AuthenticationServiceSpecStandard standard,

            string type)
        {
            External = external;
            None = none;
            Realm = realm;
            Standard = standard;
            Type = type;
        }
    }
}