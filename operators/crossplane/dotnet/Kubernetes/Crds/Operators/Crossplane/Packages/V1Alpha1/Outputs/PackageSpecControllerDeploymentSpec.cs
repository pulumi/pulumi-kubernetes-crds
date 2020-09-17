// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1
{

    [OutputType]
    public sealed class PackageSpecControllerDeploymentSpec
    {
        public readonly int MinReadySeconds;
        public readonly bool Paused;
        public readonly int ProgressDeadlineSeconds;
        public readonly int Replicas;
        public readonly int RevisionHistoryLimit;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecSelector Selector;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecStrategy Strategy;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplate Template;

        [OutputConstructor]
        private PackageSpecControllerDeploymentSpec(
            int minReadySeconds,

            bool paused,

            int progressDeadlineSeconds,

            int replicas,

            int revisionHistoryLimit,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecSelector selector,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecStrategy strategy,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplate template)
        {
            MinReadySeconds = minReadySeconds;
            Paused = paused;
            ProgressDeadlineSeconds = progressDeadlineSeconds;
            Replicas = replicas;
            RevisionHistoryLimit = revisionHistoryLimit;
            Selector = selector;
            Strategy = strategy;
            Template = template;
        }
    }
}