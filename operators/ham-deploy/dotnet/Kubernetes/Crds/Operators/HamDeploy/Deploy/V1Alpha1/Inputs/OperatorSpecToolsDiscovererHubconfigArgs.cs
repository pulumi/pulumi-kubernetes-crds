// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Deploy.V1Alpha1
{

    public class OperatorSpecToolsDiscovererHubconfigArgs : Pulumi.ResourceArgs
    {
        [Input("kubeconfig")]
        public Input<string>? Kubeconfig { get; set; }

        [Input("mountpath", required: true)]
        public Input<string> Mountpath { get; set; } = null!;

        /// <summary>
        /// LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.
        /// </summary>
        [Input("secretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Deploy.V1Alpha1.OperatorSpecToolsDiscovererHubconfigSecretRefArgs> SecretRef { get; set; } = null!;

        public OperatorSpecToolsDiscovererHubconfigArgs()
        {
        }
    }
}
