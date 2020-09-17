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
    /// CompositionStatus shows the observed state of the composition.
    /// </summary>
    public class CompositionStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apiextensions.V1Alpha1.CompositionStatusConditionsArgs>? _conditions;

        /// <summary>
        /// Conditions of the resource.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apiextensions.V1Alpha1.CompositionStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Apiextensions.V1Alpha1.CompositionStatusConditionsArgs>());
            set => _conditions = value;
        }

        public CompositionStatusArgs()
        {
        }
    }
}
