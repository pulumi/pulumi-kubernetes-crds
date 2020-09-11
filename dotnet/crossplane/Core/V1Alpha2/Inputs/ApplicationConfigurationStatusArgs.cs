// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2
{

    /// <summary>
    /// An ApplicationConfigurationStatus represents the observed state of a ApplicationConfiguration.
    /// </summary>
    public class ApplicationConfigurationStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ApplicationConfigurationStatusConditionsArgs>? _conditions;

        /// <summary>
        /// Conditions of the resource.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ApplicationConfigurationStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ApplicationConfigurationStatusConditionsArgs>());
            set => _conditions = value;
        }

        [Input("workloads")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ApplicationConfigurationStatusWorkloadsArgs>? _workloads;

        /// <summary>
        /// Workloads created by this ApplicationConfiguration.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ApplicationConfigurationStatusWorkloadsArgs> Workloads
        {
            get => _workloads ?? (_workloads = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ApplicationConfigurationStatusWorkloadsArgs>());
            set => _workloads = value;
        }

        public ApplicationConfigurationStatusArgs()
        {
        }
    }
}