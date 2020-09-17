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
    public sealed class MachinePoolSpecPlatform
    {
        /// <summary>
        /// AWS is the configuration used when installing on AWS.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformAws Aws;
        /// <summary>
        /// Azure is the configuration used when installing on Azure.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformAzure Azure;
        /// <summary>
        /// GCP is the configuration used when installing on GCP.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformGcp Gcp;
        /// <summary>
        /// OpenStack is the configuration used when installing on OpenStack.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformOpenstack Openstack;
        /// <summary>
        /// Ovirt is the configuration used when installing on oVirt.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformOvirt Ovirt;
        /// <summary>
        /// VSphere is the configuration used when installing on vSphere
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformVsphere Vsphere;

        [OutputConstructor]
        private MachinePoolSpecPlatform(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformAws aws,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformAzure azure,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformGcp gcp,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformOpenstack openstack,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformOvirt ovirt,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformVsphere vsphere)
        {
            Aws = aws;
            Azure = azure;
            Gcp = gcp;
            Openstack = openstack;
            Ovirt = ovirt;
            Vsphere = vsphere;
        }
    }
}