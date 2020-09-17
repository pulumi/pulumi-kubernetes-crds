// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class PackageSpecControllerDeploymentSpecTemplateSpecVolumesGcePersistentDiskArgs : Pulumi.ResourceArgs
    {
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        [Input("partition")]
        public Input<int>? Partition { get; set; }

        [Input("pdName", required: true)]
        public Input<string> PdName { get; set; } = null!;

        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        public PackageSpecControllerDeploymentSpecTemplateSpecVolumesGcePersistentDiskArgs()
        {
        }
    }
}
