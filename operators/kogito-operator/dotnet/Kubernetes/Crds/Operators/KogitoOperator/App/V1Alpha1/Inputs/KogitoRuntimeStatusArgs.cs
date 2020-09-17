// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1
{

    /// <summary>
    /// KogitoRuntimeStatus defines the observed state of KogitoRuntime.
    /// </summary>
    public class KogitoRuntimeStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoRuntimeStatusConditionsArgs>? _conditions;

        /// <summary>
        /// History of conditions for the resource
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoRuntimeStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoRuntimeStatusConditionsArgs>());
            set => _conditions = value;
        }

        [Input("deploymentConditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoRuntimeStatusDeploymentConditionsArgs>? _deploymentConditions;

        /// <summary>
        /// General conditions for the Kogito Service deployment.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoRuntimeStatusDeploymentConditionsArgs> DeploymentConditions
        {
            get => _deploymentConditions ?? (_deploymentConditions = new InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoRuntimeStatusDeploymentConditionsArgs>());
            set => _deploymentConditions = value;
        }

        /// <summary>
        /// URI is where the service is exposed.
        /// </summary>
        [Input("externalURI")]
        public Input<string>? ExternalURI { get; set; }

        /// <summary>
        /// Image is the resolved image for this service.
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        public KogitoRuntimeStatusArgs()
        {
        }
    }
}