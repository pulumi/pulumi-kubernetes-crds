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
    public sealed class CSIIsilonSpec
    {
        /// <summary>
        /// Driver is the specification for the CSI Isilon Driver
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIIsilonSpecDriver Driver;

        [OutputConstructor]
        private CSIIsilonSpec(Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIIsilonSpecDriver driver)
        {
            Driver = driver;
        }
    }
}
