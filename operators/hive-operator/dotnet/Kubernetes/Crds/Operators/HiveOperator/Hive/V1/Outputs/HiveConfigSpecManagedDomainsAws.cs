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
    public sealed class HiveConfigSpecManagedDomainsAws
    {
        /// <summary>
        /// CredentialsSecretRef references a secret in the TargetNamespace that will be used to authenticate with AWS Route53. It will need permission to manage entries for the domain listed in the parent ManageDNSConfig object. Secret should have AWS keys named 'aws_access_key_id' and 'aws_secret_access_key'.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.HiveConfigSpecManagedDomainsAwsCredentialsSecretRef CredentialsSecretRef;
        /// <summary>
        /// Region is the AWS region to use for route53 operations. This defaults to us-east-1. For AWS China, use cn-northwest-1.
        /// </summary>
        public readonly string Region;

        [OutputConstructor]
        private HiveConfigSpecManagedDomainsAws(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.HiveConfigSpecManagedDomainsAwsCredentialsSecretRef credentialsSecretRef,

            string region)
        {
            CredentialsSecretRef = credentialsSecretRef;
            Region = region;
        }
    }
}
