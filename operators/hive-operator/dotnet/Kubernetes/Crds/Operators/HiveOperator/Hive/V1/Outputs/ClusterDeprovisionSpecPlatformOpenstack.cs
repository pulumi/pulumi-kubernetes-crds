// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class ClusterDeprovisionSpecPlatformOpenstack
    {
        /// <summary>
        /// Cloud is the secion in the clouds.yaml secret below to use for auth/connectivity.
        /// </summary>
        public readonly string Cloud;
        /// <summary>
        /// CredentialsSecretRef is the OpenStack account credentials to use for deprovisioning the cluster
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeprovisionSpecPlatformOpenstackCredentialsSecretRef CredentialsSecretRef;

        [OutputConstructor]
        private ClusterDeprovisionSpecPlatformOpenstack(
            string cloud,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeprovisionSpecPlatformOpenstackCredentialsSecretRef credentialsSecretRef)
        {
            Cloud = cloud;
            CredentialsSecretRef = credentialsSecretRef;
        }
    }
}
