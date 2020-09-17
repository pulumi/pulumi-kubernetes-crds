// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apiextensions.V1Alpha1
{

    /// <summary>
    /// InfrastructurePublicationStatus shows the observed state of the definition.
    /// </summary>
    public class InfrastructurePublicationStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apiextensions.V1Alpha1.InfrastructurePublicationStatusConditionsArgs>? _conditions;

        /// <summary>
        /// Conditions of the resource.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apiextensions.V1Alpha1.InfrastructurePublicationStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Apiextensions.V1Alpha1.InfrastructurePublicationStatusConditionsArgs>());
            set => _conditions = value;
        }

        public InfrastructurePublicationStatusArgs()
        {
        }
    }
}