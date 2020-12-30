// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1
{

    [OutputType]
    public sealed class StorageClusterSpecSecurity
    {
        /// <summary>
        /// Authorization configurations for a RBAC enabled storage cluster
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1.StorageClusterSpecSecurityAuth Auth;
        /// <summary>
        /// Flag indicating whether security features need to be enabled for the storage cluster.
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private StorageClusterSpecSecurity(
            Pulumi.Kubernetes.Types.Outputs.Core.V1.StorageClusterSpecSecurityAuth auth,

            bool enabled)
        {
            Auth = auth;
            Enabled = enabled;
        }
    }
}