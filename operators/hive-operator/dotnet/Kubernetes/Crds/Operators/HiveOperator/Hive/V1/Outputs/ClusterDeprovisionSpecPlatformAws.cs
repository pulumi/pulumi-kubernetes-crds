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
    public sealed class ClusterDeprovisionSpecPlatformAws
    {
        /// <summary>
        /// CredentialsSecretRef is the AWS account credentials to use for deprovisioning the cluster
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeprovisionSpecPlatformAwsCredentialsSecretRef CredentialsSecretRef;
        /// <summary>
        /// Region is the AWS region for this deprovisioning
        /// </summary>
        public readonly string Region;

        [OutputConstructor]
        private ClusterDeprovisionSpecPlatformAws(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterDeprovisionSpecPlatformAwsCredentialsSecretRef credentialsSecretRef,

            string region)
        {
            CredentialsSecretRef = credentialsSecretRef;
            Region = region;
        }
    }
}