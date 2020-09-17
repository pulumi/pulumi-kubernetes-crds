// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// BareMetal is the configuration used when installing on bare metal.
    /// </summary>
    public class ClusterDeploymentSpecPlatformBaremetalArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// LibvirtSSHPrivateKeySecretRef is the reference to the secret that contains the private SSH key to use for access to the libvirt provisioning host. The SSH private key is expected to be in the secret data under the "ssh-privatekey" key.
        /// </summary>
        [Input("libvirtSSHPrivateKeySecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterDeploymentSpecPlatformBaremetalLibvirtSSHPrivateKeySecretRefArgs> LibvirtSSHPrivateKeySecretRef { get; set; } = null!;

        public ClusterDeploymentSpecPlatformBaremetalArgs()
        {
        }
    }
}
