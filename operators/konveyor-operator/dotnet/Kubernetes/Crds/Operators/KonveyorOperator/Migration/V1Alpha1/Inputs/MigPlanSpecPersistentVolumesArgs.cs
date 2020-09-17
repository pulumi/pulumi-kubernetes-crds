// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1
{

    public class MigPlanSpecPersistentVolumesArgs : Pulumi.ResourceArgs
    {
        [Input("capacity")]
        public Input<string>? Capacity { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("pvc")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1.MigPlanSpecPersistentVolumesPvcArgs>? Pvc { get; set; }

        [Input("selection", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1.MigPlanSpecPersistentVolumesSelectionArgs> Selection { get; set; } = null!;

        [Input("storageClass")]
        public Input<string>? StorageClass { get; set; }

        [Input("supported", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1.MigPlanSpecPersistentVolumesSupportedArgs> Supported { get; set; } = null!;

        public MigPlanSpecPersistentVolumesArgs()
        {
        }
    }
}
