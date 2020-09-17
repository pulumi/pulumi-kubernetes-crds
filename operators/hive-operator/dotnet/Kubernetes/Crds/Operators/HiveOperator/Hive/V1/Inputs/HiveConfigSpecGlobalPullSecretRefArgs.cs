// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// GlobalPullSecretRef is used to specify a pull secret that will be used globally by all of the cluster deployments. For each cluster deployment, the contents of GlobalPullSecret will be merged with the specific pull secret for a cluster deployment(if specified), with precedence given to the contents of the pull secret for the cluster deployment. The global pull secret is assumed to be in the TargetNamespace.
    /// </summary>
    public class HiveConfigSpecGlobalPullSecretRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public HiveConfigSpecGlobalPullSecretRefArgs()
        {
        }
    }
}
