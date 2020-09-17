// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apicur.V1Alpha1
{

    /// <summary>
    /// Affinity is a group of affinity scheduling rules.
    /// </summary>
    public class ApicurioRegistrySpecDeploymentAffinityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Describes node affinity scheduling rules for the pod.
        /// </summary>
        [Input("nodeAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apicur.V1Alpha1.ApicurioRegistrySpecDeploymentAffinityNodeAffinityArgs>? NodeAffinity { get; set; }

        /// <summary>
        /// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        [Input("podAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apicur.V1Alpha1.ApicurioRegistrySpecDeploymentAffinityPodAffinityArgs>? PodAffinity { get; set; }

        /// <summary>
        /// Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        [Input("podAntiAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apicur.V1Alpha1.ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityArgs>? PodAntiAffinity { get; set; }

        public ApicurioRegistrySpecDeploymentAffinityArgs()
        {
        }
    }
}
