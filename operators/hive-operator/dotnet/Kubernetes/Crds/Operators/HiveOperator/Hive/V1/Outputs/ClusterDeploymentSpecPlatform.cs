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
    public sealed class ClusterDeploymentSpecPlatform
    {
        /// <summary>
        /// AWS is the configuration used when installing on AWS.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformAws Aws;
        /// <summary>
        /// Azure is the configuration used when installing on Azure.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformAzure Azure;
        /// <summary>
        /// BareMetal is the configuration used when installing on bare metal.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformBaremetal Baremetal;
        /// <summary>
        /// GCP is the configuration used when installing on Google Cloud Platform.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformGcp Gcp;
        /// <summary>
        /// OpenStack is the configuration used when installing on OpenStack
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformOpenstack Openstack;
        /// <summary>
        /// Ovirt is the configuration used when installing on oVirt
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformOvirt Ovirt;
        /// <summary>
        /// VSphere is the configuration used when installing on vSphere
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformVsphere Vsphere;

        [OutputConstructor]
        private ClusterDeploymentSpecPlatform(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformAws aws,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformAzure azure,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformBaremetal baremetal,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformGcp gcp,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformOpenstack openstack,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformOvirt ovirt,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeploymentSpecPlatformVsphere vsphere)
        {
            Aws = aws;
            Azure = azure;
            Baremetal = baremetal;
            Gcp = gcp;
            Openstack = openstack;
            Ovirt = ovirt;
            Vsphere = vsphere;
        }
    }
}