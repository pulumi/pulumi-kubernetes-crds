// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Csi.V1
{

    /// <summary>
    /// IBMBlockCSIControllerSpec defines the desired state of IBMBlockCSIController
    /// </summary>
    public class IBMBlockCSISpecControllerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Affinity is a group of affinity scheduling rules.
        /// </summary>
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Csi.V1.IBMBlockCSISpecControllerAffinityArgs>? Affinity { get; set; }

        /// <summary>
        /// PullPolicy describes a policy for if/when to pull a container image
        /// </summary>
        [Input("imagePullPolicy")]
        public Input<string>? ImagePullPolicy { get; set; }

        [Input("repository", required: true)]
        public Input<string> Repository { get; set; } = null!;

        [Input("tag", required: true)]
        public Input<string> Tag { get; set; } = null!;

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Csi.V1.IBMBlockCSISpecControllerTolerationsArgs>? _tolerations;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Csi.V1.IBMBlockCSISpecControllerTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Csi.V1.IBMBlockCSISpecControllerTolerationsArgs>());
            set => _tolerations = value;
        }

        public IBMBlockCSISpecControllerArgs()
        {
        }
    }
}
