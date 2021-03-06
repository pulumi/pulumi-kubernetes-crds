// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1
{

    [OutputType]
    public sealed class StorageClusterSpecUpdateStrategy
    {
        /// <summary>
        /// Spec to control the desired behavior of storage cluster rolling update.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecUpdateStrategyRollingUpdate RollingUpdate;
        /// <summary>
        /// Type of storage cluster update. Can be RollingUpdate or OnDelete. Default is RollingUpdate.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private StorageClusterSpecUpdateStrategy(
            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecUpdateStrategyRollingUpdate rollingUpdate,

            string type)
        {
            RollingUpdate = rollingUpdate;
            Type = type;
        }
    }
}
