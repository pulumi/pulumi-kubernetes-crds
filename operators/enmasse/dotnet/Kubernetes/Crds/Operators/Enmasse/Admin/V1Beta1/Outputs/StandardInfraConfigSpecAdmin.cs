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
    public sealed class StandardInfraConfigSpecAdmin
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.StandardInfraConfigSpecAdminPodTemplate PodTemplate;
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.StandardInfraConfigSpecAdminResources Resources;

        [OutputConstructor]
        private StandardInfraConfigSpecAdmin(
            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.StandardInfraConfigSpecAdminPodTemplate podTemplate,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.StandardInfraConfigSpecAdminResources resources)
        {
            PodTemplate = podTemplate;
            Resources = resources;
        }
    }
}
