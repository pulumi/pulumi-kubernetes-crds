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
    /// CredentialsSecretRef refers to a secret that contains the oVirt account access credentials with fields: ovirt_url, ovirt_username, ovirt_password, ovirt_ca_bundle
    /// </summary>
    public class ClusterDeploymentSpecPlatformOvirtCredentialsSecretRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ClusterDeploymentSpecPlatformOvirtCredentialsSecretRefArgs()
        {
        }
    }
}