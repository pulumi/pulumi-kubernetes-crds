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
    /// ServiceAccountRef is the service account to be used to run the controllers associated with this configuration kubebuilder:default:="{Name: &amp;#34;default&amp;#34;}"
    /// </summary>
    public class ResourceLockerSpecServiceAccountRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ResourceLockerSpecServiceAccountRefArgs()
        {
        }
    }
}
