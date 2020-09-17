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
    public sealed class ClusterPoolSpecPlatformGcp
    {
        /// <summary>
        /// CredentialsSecretRef refers to a secret that contains the GCP account access credentials.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterPoolSpecPlatformGcpCredentialsSecretRef CredentialsSecretRef;
        /// <summary>
        /// Region specifies the GCP region where the cluster will be created.
        /// </summary>
        public readonly string Region;

        [OutputConstructor]
        private ClusterPoolSpecPlatformGcp(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterPoolSpecPlatformGcpCredentialsSecretRef credentialsSecretRef,

            string region)
        {
            CredentialsSecretRef = credentialsSecretRef;
            Region = region;
        }
    }
}