// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    public class APIManagerSpecApicastStagingSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Affinity is a group of affinity scheduling rules.
        /// </summary>
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecApicastStagingSpecAffinityArgs>? Affinity { get; set; }

        [Input("replicas")]
        public Input<int>? Replicas { get; set; }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecApicastStagingSpecTolerationsArgs>? _tolerations;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecApicastStagingSpecTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecApicastStagingSpecTolerationsArgs>());
            set => _tolerations = value;
        }

        public APIManagerSpecApicastStagingSpecArgs()
        {
        }
    }
}
