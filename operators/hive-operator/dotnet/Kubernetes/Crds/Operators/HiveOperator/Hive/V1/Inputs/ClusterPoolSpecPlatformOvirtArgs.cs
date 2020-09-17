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
    /// Ovirt is the configuration used when installing on oVirt
    /// </summary>
    public class ClusterPoolSpecPlatformOvirtArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CertificatesSecretRef refers to a secret that contains the oVirt CA certificates necessary for communicating with oVirt.
        /// </summary>
        [Input("certificatesSecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterPoolSpecPlatformOvirtCertificatesSecretRefArgs> CertificatesSecretRef { get; set; } = null!;

        /// <summary>
        /// CredentialsSecretRef refers to a secret that contains the oVirt account access credentials with fields: ovirt_url, ovirt_username, ovirt_password, ovirt_ca_bundle
        /// </summary>
        [Input("credentialsSecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterPoolSpecPlatformOvirtCredentialsSecretRefArgs> CredentialsSecretRef { get; set; } = null!;

        /// <summary>
        /// The target cluster under which all VMs will run
        /// </summary>
        [Input("ovirt_cluster_id", required: true)]
        public Input<string> Ovirt_cluster_id { get; set; } = null!;

        /// <summary>
        /// The target network of all the network interfaces of the nodes. Omitting defaults to ovirtmgmt network which is a default network for evert ovirt cluster.
        /// </summary>
        [Input("ovirt_network_name")]
        public Input<string>? Ovirt_network_name { get; set; }

        /// <summary>
        /// The target storage domain under which all VM disk would be created.
        /// </summary>
        [Input("storage_domain_id", required: true)]
        public Input<string> Storage_domain_id { get; set; } = null!;

        public ClusterPoolSpecPlatformOvirtArgs()
        {
        }
    }
}
