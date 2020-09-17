// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Storage.V1
{

    [OutputType]
    public sealed class CSIUnitySpec
    {
        /// <summary>
        /// Driver is the specification for the CSI Unity Driver
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIUnitySpecDriver Driver;

        [OutputConstructor]
        private CSIUnitySpec(Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIUnitySpecDriver driver)
        {
            Driver = driver;
        }
    }
}
