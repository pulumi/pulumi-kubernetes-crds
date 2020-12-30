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
    /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
    /// </summary>
    public class APIManagerRestoreSpecRestoreSourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Restore data soure configuration
        /// </summary>
        [Input("persistentVolumeClaim")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerRestoreSpecRestoreSourcePersistentVolumeClaimArgs>? PersistentVolumeClaim { get; set; }

        public APIManagerRestoreSpecRestoreSourceArgs()
        {
        }
    }
}
