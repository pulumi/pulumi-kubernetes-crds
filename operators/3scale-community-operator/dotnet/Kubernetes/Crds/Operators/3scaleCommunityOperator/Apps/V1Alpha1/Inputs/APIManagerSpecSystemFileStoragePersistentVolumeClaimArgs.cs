// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    /// <summary>
    /// Union type. Only one of the fields can be set.
    /// </summary>
    public class APIManagerSpecSystemFileStoragePersistentVolumeClaimArgs : Pulumi.ResourceArgs
    {
        [Input("storageClassName")]
        public Input<string>? StorageClassName { get; set; }

        public APIManagerSpecSystemFileStoragePersistentVolumeClaimArgs()
        {
        }
    }
}