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
    /// CredentialsSecretRef references a secret that will be used to authenticate with GCP CloudDNS. It will need permission to create and manage CloudDNS Hosted Zones. Secret should have a key named 'osServiceAccount.json'. The credentials must specify the project to use.
    /// </summary>
    public class DNSZoneSpecGcpCredentialsSecretRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public DNSZoneSpecGcpCredentialsSecretRefArgs()
        {
        }
    }
}