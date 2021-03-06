// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Wso2.V1Alpha1
{

    public class SecuritySpecSecurityConfigArgs : Pulumi.ResourceArgs
    {
        [Input("alias")]
        public Input<string>? Alias { get; set; }

        [Input("audience")]
        public Input<string>? Audience { get; set; }

        [Input("certificate")]
        public Input<string>? Certificate { get; set; }

        [Input("credentials")]
        public Input<string>? Credentials { get; set; }

        [Input("endpoint")]
        public Input<string>? Endpoint { get; set; }

        [Input("issuer")]
        public Input<string>? Issuer { get; set; }

        [Input("validateAllowedAPIs")]
        public Input<bool>? ValidateAllowedAPIs { get; set; }

        [Input("validateSubscription")]
        public Input<bool>? ValidateSubscription { get; set; }

        public SecuritySpecSecurityConfigArgs()
        {
        }
    }
}
