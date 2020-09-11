// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Csi.V1
{

    [OutputType]
    public sealed class IBMBlockCSISpecNode
    {
        /// <summary>
        /// Affinity is a group of affinity scheduling rules.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Csi.V1.IBMBlockCSISpecNodeAffinity Affinity;
        /// <summary>
        /// PullPolicy describes a policy for if/when to pull a container image
        /// </summary>
        public readonly string ImagePullPolicy;
        public readonly string Repository;
        public readonly string Tag;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.IBMBlockCSISpecNodeTolerations> Tolerations;

        [OutputConstructor]
        private IBMBlockCSISpecNode(
            Pulumi.Kubernetes.Types.Outputs.Csi.V1.IBMBlockCSISpecNodeAffinity affinity,

            string imagePullPolicy,

            string repository,

            string tag,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.IBMBlockCSISpecNodeTolerations> tolerations)
        {
            Affinity = affinity;
            ImagePullPolicy = imagePullPolicy;
            Repository = repository;
            Tag = tag;
            Tolerations = tolerations;
        }
    }
}
