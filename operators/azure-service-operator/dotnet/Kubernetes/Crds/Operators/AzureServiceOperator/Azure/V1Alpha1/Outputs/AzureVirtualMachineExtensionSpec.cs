// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1
{

    [OutputType]
    public sealed class AzureVirtualMachineExtensionSpec
    {
        public readonly bool AutoUpgradeMinorVersion;
        public readonly string ForceUpdateTag;
        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        public readonly string Location;
        public readonly string ProtectedSettings;
        public readonly string Publisher;
        public readonly string ResourceGroup;
        public readonly string Settings;
        public readonly string TypeHandlerVersion;
        public readonly string TypeName;
        public readonly string VmName;

        [OutputConstructor]
        private AzureVirtualMachineExtensionSpec(
            bool autoUpgradeMinorVersion,

            string forceUpdateTag,

            string location,

            string protectedSettings,

            string publisher,

            string resourceGroup,

            string settings,

            string typeHandlerVersion,

            string typeName,

            string vmName)
        {
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            ForceUpdateTag = forceUpdateTag;
            Location = location;
            ProtectedSettings = protectedSettings;
            Publisher = publisher;
            ResourceGroup = resourceGroup;
            Settings = settings;
            TypeHandlerVersion = typeHandlerVersion;
            TypeName = typeName;
            VmName = vmName;
        }
    }
}
