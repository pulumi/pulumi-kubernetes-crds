// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1
{

    /// <summary>
    /// KeepalivedGroupStatus defines the observed state of KeepalivedGroup
    /// </summary>
    public class KeepalivedGroupStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.KeepalivedGroupStatusConditionsArgs>? _conditions;

        /// <summary>
        /// INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.KeepalivedGroupStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.KeepalivedGroupStatusConditionsArgs>());
            set => _conditions = value;
        }

        [Input("routerIDs")]
        private InputMap<int>? _routerIDs;
        public InputMap<int> RouterIDs
        {
            get => _routerIDs ?? (_routerIDs = new InputMap<int>());
            set => _routerIDs = value;
        }

        public KeepalivedGroupStatusArgs()
        {
        }
    }
}
