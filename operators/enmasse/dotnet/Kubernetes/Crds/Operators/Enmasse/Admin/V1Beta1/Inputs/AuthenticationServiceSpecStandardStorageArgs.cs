// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1
{

    public class AuthenticationServiceSpecStandardStorageArgs : Pulumi.ResourceArgs
    {
        [Input("claimName")]
        public Input<string>? ClaimName { get; set; }

        [Input("class")]
        public Input<string>? Class { get; set; }

        [Input("deleteClaim")]
        public Input<bool>? DeleteClaim { get; set; }

        [Input("size")]
        public Input<string>? Size { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public AuthenticationServiceSpecStandardStorageArgs()
        {
        }
    }
}
