// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1
{

    public class StandardInfraConfigSpecBrokerPodTemplateArgs : Pulumi.ResourceArgs
    {
        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.StandardInfraConfigSpecBrokerPodTemplateMetadataArgs>? Metadata { get; set; }

        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.StandardInfraConfigSpecBrokerPodTemplateSpecArgs>? Spec { get; set; }

        public StandardInfraConfigSpecBrokerPodTemplateArgs()
        {
        }
    }
}
