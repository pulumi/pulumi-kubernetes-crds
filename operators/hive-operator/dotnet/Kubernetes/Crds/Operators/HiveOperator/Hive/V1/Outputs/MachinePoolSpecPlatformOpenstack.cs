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
    public sealed class MachinePoolSpecPlatformOpenstack
    {
        /// <summary>
        /// Flavor defines the OpenStack Nova flavor. eg. m1.large The json key here differs from the installer which uses both "computeFlavor" and type "type" depending on which type you're looking at, and the resulting field on the MachineSet is "flavor". We are opting to stay consistent with the end result.
        /// </summary>
        public readonly string Flavor;
        /// <summary>
        /// RootVolume defines the root volume for instances in the machine pool. The instances use ephemeral disks if not set.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformOpenstackRootVolume RootVolume;

        [OutputConstructor]
        private MachinePoolSpecPlatformOpenstack(
            string flavor,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.MachinePoolSpecPlatformOpenstackRootVolume rootVolume)
        {
            Flavor = flavor;
            RootVolume = rootVolume;
        }
    }
}
