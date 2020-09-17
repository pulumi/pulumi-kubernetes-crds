// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1
{

    /// <summary>
    /// ResourceLockerSpec defines the desired state of ResourceLocker
    /// </summary>
    public class ResourceLockerSpecArgs : Pulumi.ResourceArgs
    {
        [Input("patches")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.ResourceLockerSpecPatchesArgs>? _patches;

        /// <summary>
        /// Patches is a list of patches that should be enforced at runtime.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.ResourceLockerSpecPatchesArgs> Patches
        {
            get => _patches ?? (_patches = new InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.ResourceLockerSpecPatchesArgs>());
            set => _patches = value;
        }

        [Input("resources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.ResourceLockerSpecResourcesArgs>? _resources;

        /// <summary>
        /// Resources is a list of resource manifests that should be locked into the specified configuration
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.ResourceLockerSpecResourcesArgs> Resources
        {
            get => _resources ?? (_resources = new InputList<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.ResourceLockerSpecResourcesArgs>());
            set => _resources = value;
        }

        /// <summary>
        /// ServiceAccountRef is the service account to be used to run the controllers associated with this configuration kubebuilder:default:="{Name: &amp;#34;default&amp;#34;}"
        /// </summary>
        [Input("serviceAccountRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Redhatcop.V1Alpha1.ResourceLockerSpecServiceAccountRefArgs>? ServiceAccountRef { get; set; }

        public ResourceLockerSpecArgs()
        {
        }
    }
}
