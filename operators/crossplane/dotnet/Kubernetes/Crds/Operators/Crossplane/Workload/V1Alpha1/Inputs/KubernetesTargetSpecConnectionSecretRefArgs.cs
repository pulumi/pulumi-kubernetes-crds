// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Workload.V1Alpha1
{

    /// <summary>
    /// WriteConnectionSecretToReference specifies the name of a Secret, in the same namespace as this target, to which any connection details for this target should be written or already exist. Connection secrets referenced by a target should contain information for connecting to a resource that allows for scheduling of workloads.
    /// </summary>
    public class KubernetesTargetSpecConnectionSecretRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the secret.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public KubernetesTargetSpecConnectionSecretRefArgs()
        {
        }
    }
}
