// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Infinispan.V2Alpha1
{

    [OutputType]
    public sealed class BackupSpec
    {
        public readonly string Cluster;
        /// <summary>
        /// InfinispanContainerSpec specify resource requirements per container
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Infinispan.V2Alpha1.BackupSpecContainer Container;
        public readonly Pulumi.Kubernetes.Types.Outputs.Infinispan.V2Alpha1.BackupSpecResources Resources;
        public readonly Pulumi.Kubernetes.Types.Outputs.Infinispan.V2Alpha1.BackupSpecVolume Volume;

        [OutputConstructor]
        private BackupSpec(
            string cluster,

            Pulumi.Kubernetes.Types.Outputs.Infinispan.V2Alpha1.BackupSpecContainer container,

            Pulumi.Kubernetes.Types.Outputs.Infinispan.V2Alpha1.BackupSpecResources resources,

            Pulumi.Kubernetes.Types.Outputs.Infinispan.V2Alpha1.BackupSpecVolume volume)
        {
            Cluster = cluster;
            Container = container;
            Resources = resources;
            Volume = volume;
        }
    }
}