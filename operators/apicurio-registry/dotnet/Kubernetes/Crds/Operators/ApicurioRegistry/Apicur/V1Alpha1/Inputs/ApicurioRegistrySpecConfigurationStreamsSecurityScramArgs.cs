// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apicur.V1Alpha1
{

    public class ApicurioRegistrySpecConfigurationStreamsSecurityScramArgs : Pulumi.ResourceArgs
    {
        [Input("mechanism")]
        public Input<string>? Mechanism { get; set; }

        [Input("passwordSecretName")]
        public Input<string>? PasswordSecretName { get; set; }

        [Input("truststoreSecretName")]
        public Input<string>? TruststoreSecretName { get; set; }

        [Input("user")]
        public Input<string>? User { get; set; }

        public ApicurioRegistrySpecConfigurationStreamsSecurityScramArgs()
        {
        }
    }
}
