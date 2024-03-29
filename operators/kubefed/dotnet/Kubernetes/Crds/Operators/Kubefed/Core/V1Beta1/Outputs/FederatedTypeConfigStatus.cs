// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Beta1
{

    [OutputType]
    public sealed class FederatedTypeConfigStatus
    {
        /// <summary>
        /// ObservedGeneration is the generation as observed by the controller consuming the FederatedTypeConfig.
        /// </summary>
        public readonly int ObservedGeneration;
        /// <summary>
        /// PropagationController tracks the status of the sync controller.
        /// </summary>
        public readonly string PropagationController;
        /// <summary>
        /// StatusController tracks the status of the status controller.
        /// </summary>
        public readonly string StatusController;

        [OutputConstructor]
        private FederatedTypeConfigStatus(
            int observedGeneration,

            string propagationController,

            string statusController)
        {
            ObservedGeneration = observedGeneration;
            PropagationController = propagationController;
            StatusController = statusController;
        }
    }
}
