// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.App.V1Beta1
{

    /// <summary>
    /// Describes the CloudEvents that this instance can consume or produce
    /// </summary>
    public class KogitoSupportingServiceStatusCloudEventsArgs : Pulumi.ResourceArgs
    {
        [Input("consumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoSupportingServiceStatusCloudEventsConsumesArgs>? _consumes;
        public InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoSupportingServiceStatusCloudEventsConsumesArgs> Consumes
        {
            get => _consumes ?? (_consumes = new InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoSupportingServiceStatusCloudEventsConsumesArgs>());
            set => _consumes = value;
        }

        [Input("produces")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoSupportingServiceStatusCloudEventsProducesArgs>? _produces;
        public InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoSupportingServiceStatusCloudEventsProducesArgs> Produces
        {
            get => _produces ?? (_produces = new InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.KogitoSupportingServiceStatusCloudEventsProducesArgs>());
            set => _produces = value;
        }

        public KogitoSupportingServiceStatusCloudEventsArgs()
        {
        }
    }
}