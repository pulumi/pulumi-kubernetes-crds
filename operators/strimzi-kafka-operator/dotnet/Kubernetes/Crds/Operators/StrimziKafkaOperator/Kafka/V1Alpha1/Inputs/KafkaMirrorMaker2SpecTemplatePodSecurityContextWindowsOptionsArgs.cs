// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1
{

    public class KafkaMirrorMaker2SpecTemplatePodSecurityContextWindowsOptionsArgs : Pulumi.ResourceArgs
    {
        [Input("gmsaCredentialSpec")]
        public Input<string>? GmsaCredentialSpec { get; set; }

        [Input("gmsaCredentialSpecName")]
        public Input<string>? GmsaCredentialSpecName { get; set; }

        public KafkaMirrorMaker2SpecTemplatePodSecurityContextWindowsOptionsArgs()
        {
        }
    }
}
