// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1Alpha1
{

    /// <summary>
    /// A ResourceClaimStatus represents the observed status of a resource claim.
    /// </summary>
    public class BucketStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Phase represents the binding phase of a managed resource or claim. Unbindable resources cannot be bound, typically because they are currently unavailable, or still being created. Unbound resource are available for binding, and Bound resources have successfully bound to another resource.
        /// </summary>
        [Input("bindingPhase")]
        public Input<string>? BindingPhase { get; set; }

        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1Alpha1.BucketStatusConditionsArgs>? _conditions;

        /// <summary>
        /// Conditions of the resource.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1Alpha1.BucketStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1Alpha1.BucketStatusConditionsArgs>());
            set => _conditions = value;
        }

        public BucketStatusArgs()
        {
        }
    }
}
