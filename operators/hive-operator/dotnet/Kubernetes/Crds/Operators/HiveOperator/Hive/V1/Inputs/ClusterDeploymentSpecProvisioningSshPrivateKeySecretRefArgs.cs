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
    /// SSHPrivateKeySecretRef is the reference to the secret that contains the private SSH key to use for access to compute instances. This private key should correspond to the public key included in the InstallConfig. The private key is used by Hive to gather logs on the target cluster if there are install failures. The SSH private key is expected to be in the secret data under the "ssh-privatekey" key.
    /// </summary>
    public class ClusterDeploymentSpecProvisioningSshPrivateKeySecretRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ClusterDeploymentSpecProvisioningSshPrivateKeySecretRefArgs()
        {
        }
    }
}