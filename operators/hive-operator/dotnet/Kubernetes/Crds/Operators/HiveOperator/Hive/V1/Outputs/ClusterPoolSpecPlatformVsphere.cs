// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class ClusterPoolSpecPlatformVsphere
    {
        /// <summary>
        /// CertificatesSecretRef refers to a secret that contains the vSphere CA certificates necessary for communicating with the VCenter.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterPoolSpecPlatformVsphereCertificatesSecretRef CertificatesSecretRef;
        /// <summary>
        /// Cluster is the name of the cluster virtual machines will be cloned into.
        /// </summary>
        public readonly string Cluster;
        /// <summary>
        /// CredentialsSecretRef refers to a secret that contains the vSphere account access credentials: GOVC_USERNAME, GOVC_PASSWORD fields.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterPoolSpecPlatformVsphereCredentialsSecretRef CredentialsSecretRef;
        /// <summary>
        /// Datacenter is the name of the datacenter to use in the vCenter.
        /// </summary>
        public readonly string Datacenter;
        /// <summary>
        /// DefaultDatastore is the default datastore to use for provisioning volumes.
        /// </summary>
        public readonly string DefaultDatastore;
        /// <summary>
        /// Folder is the name of the folder that will be used and/or created for virtual machines.
        /// </summary>
        public readonly string Folder;
        /// <summary>
        /// Network specifies the name of the network to be used by the cluster.
        /// </summary>
        public readonly string Network;
        /// <summary>
        /// VCenter is the domain name or IP address of the vCenter.
        /// </summary>
        public readonly string VCenter;

        [OutputConstructor]
        private ClusterPoolSpecPlatformVsphere(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterPoolSpecPlatformVsphereCertificatesSecretRef certificatesSecretRef,

            string cluster,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterPoolSpecPlatformVsphereCredentialsSecretRef credentialsSecretRef,

            string datacenter,

            string defaultDatastore,

            string folder,

            string network,

            string vCenter)
        {
            CertificatesSecretRef = certificatesSecretRef;
            Cluster = cluster;
            CredentialsSecretRef = credentialsSecretRef;
            Datacenter = datacenter;
            DefaultDatastore = defaultDatastore;
            Folder = folder;
            Network = network;
            VCenter = vCenter;
        }
    }
}
