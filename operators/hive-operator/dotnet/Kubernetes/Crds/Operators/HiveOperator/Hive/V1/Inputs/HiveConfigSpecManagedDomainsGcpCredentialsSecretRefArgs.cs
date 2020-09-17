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
    /// CredentialsSecretRef references a secret in the TargetNamespace that will be used to authenticate with GCP DNS. It will need permission to manage entries in each of the managed domains for this cluster. listed in the parent ManageDNSConfig object. Secret should have a key named 'osServiceAccount.json'. The credentials must specify the project to use.
    /// </summary>
    public class HiveConfigSpecManagedDomainsGcpCredentialsSecretRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public HiveConfigSpecManagedDomainsGcpCredentialsSecretRefArgs()
        {
        }
    }
}