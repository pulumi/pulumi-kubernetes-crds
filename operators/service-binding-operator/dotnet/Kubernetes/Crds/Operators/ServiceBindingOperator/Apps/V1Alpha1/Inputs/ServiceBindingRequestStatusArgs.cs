// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    /// <summary>
    /// ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
    /// </summary>
    public class ServiceBindingRequestStatusArgs : Pulumi.ResourceArgs
    {
        [Input("applications")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.ServiceBindingRequestStatusApplicationsArgs>? _applications;

        /// <summary>
        /// Applications contain all the applications filtered by name or label
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.ServiceBindingRequestStatusApplicationsArgs> Applications
        {
            get => _applications ?? (_applications = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.ServiceBindingRequestStatusApplicationsArgs>());
            set => _applications = value;
        }

        [Input("conditions", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.ServiceBindingRequestStatusConditionsArgs>? _conditions;

        /// <summary>
        /// Conditions describes the state of the operator's reconciliation functionality.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.ServiceBindingRequestStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.ServiceBindingRequestStatusConditionsArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// Secret is the name of the intermediate secret
        /// </summary>
        [Input("secret", required: true)]
        public Input<string> Secret { get; set; } = null!;

        public ServiceBindingRequestStatusArgs()
        {
        }
    }
}
