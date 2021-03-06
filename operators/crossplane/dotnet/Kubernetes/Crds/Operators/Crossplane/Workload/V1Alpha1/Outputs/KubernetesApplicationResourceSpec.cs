// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1
{

    [OutputType]
    public sealed class KubernetesApplicationResourceSpec
    {
        /// <summary>
        /// Secrets upon which this application resource depends. These secrets will be propagated to the Kubernetes cluster to which this application is scheduled.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1.KubernetesApplicationResourceSpecSecrets> Secrets;
        /// <summary>
        /// Target to which this application has been scheduled.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1.KubernetesApplicationResourceSpecTargetRef TargetRef;
        /// <summary>
        /// A Template for a Kubernetes resource to be submitted to the KubernetesCluster to which this application resource is scheduled. The resource must be understood by the KubernetesCluster. Crossplane requires only that the resource contains standard Kubernetes type and object metadata.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Template;

        [OutputConstructor]
        private KubernetesApplicationResourceSpec(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1.KubernetesApplicationResourceSpecSecrets> secrets,

            Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1.KubernetesApplicationResourceSpecTargetRef targetRef,

            ImmutableDictionary<string, object> template)
        {
            Secrets = secrets;
            TargetRef = targetRef;
            Template = template;
        }
    }
}
