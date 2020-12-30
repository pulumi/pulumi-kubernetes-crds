// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Storage.V1
{

    [OutputType]
    public sealed class CSIVXFlexOSSpecDriverCommon
    {
        /// <summary>
        /// Args is the set of arguments for the container
        /// </summary>
        public readonly ImmutableArray<string> Args;
        /// <summary>
        /// Envs is the set of environment variables for the container
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIVXFlexOSSpecDriverCommonEnvs> Envs;
        /// <summary>
        /// Image is the image tag for the Container
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// ImagePullPolicy is the image pull policy for the image
        /// </summary>
        public readonly string ImagePullPolicy;
        /// <summary>
        /// Name is the name of Container
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node.
        /// </summary>
        public readonly ImmutableDictionary<string, string> NodeSelector;
        /// <summary>
        /// Tolerations is the list of tolerations for the driver pods
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIVXFlexOSSpecDriverCommonTolerations> Tolerations;

        [OutputConstructor]
        private CSIVXFlexOSSpecDriverCommon(
            ImmutableArray<string> args,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIVXFlexOSSpecDriverCommonEnvs> envs,

            string image,

            string imagePullPolicy,

            string name,

            ImmutableDictionary<string, string> nodeSelector,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIVXFlexOSSpecDriverCommonTolerations> tolerations)
        {
            Args = args;
            Envs = envs;
            Image = image;
            ImagePullPolicy = imagePullPolicy;
            Name = name;
            NodeSelector = nodeSelector;
            Tolerations = tolerations;
        }
    }
}
