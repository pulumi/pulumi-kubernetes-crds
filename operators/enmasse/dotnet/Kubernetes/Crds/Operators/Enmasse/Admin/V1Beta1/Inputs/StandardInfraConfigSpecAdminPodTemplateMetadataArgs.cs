// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1
{

    public class StandardInfraConfigSpecAdminPodTemplateMetadataArgs : Pulumi.ResourceArgs
    {
        [Input("labels")]
        private InputMap<object>? _labels;
        public InputMap<object> Labels
        {
            get => _labels ?? (_labels = new InputMap<object>());
            set => _labels = value;
        }

        public StandardInfraConfigSpecAdminPodTemplateMetadataArgs()
        {
        }
    }
}
