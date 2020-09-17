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
    /// ManageDNSConfig contains the domain being managed, and the cloud-specific details for accessing/managing the domain.
    /// </summary>
    public class HiveConfigSpecManagedDomainsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AWS contains AWS-specific settings for external DNS
        /// </summary>
        [Input("aws")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.HiveConfigSpecManagedDomainsAwsArgs>? Aws { get; set; }

        /// <summary>
        /// Azure contains Azure-specific settings for external DNS
        /// </summary>
        [Input("azure")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.HiveConfigSpecManagedDomainsAzureArgs>? Azure { get; set; }

        [Input("domains", required: true)]
        private InputList<string>? _domains;

        /// <summary>
        /// Domains is the list of domains that hive will be managing entries for with the provided credentials.
        /// </summary>
        public InputList<string> Domains
        {
            get => _domains ?? (_domains = new InputList<string>());
            set => _domains = value;
        }

        /// <summary>
        /// GCP contains GCP-specific settings for external DNS
        /// </summary>
        [Input("gcp")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.HiveConfigSpecManagedDomainsGcpArgs>? Gcp { get; set; }

        public HiveConfigSpecManagedDomainsArgs()
        {
        }
    }
}