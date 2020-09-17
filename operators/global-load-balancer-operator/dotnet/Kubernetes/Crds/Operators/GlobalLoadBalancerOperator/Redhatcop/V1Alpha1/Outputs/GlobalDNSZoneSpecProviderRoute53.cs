// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1
{

    [OutputType]
    public sealed class GlobalDNSZoneSpecProviderRoute53
    {
        /// <summary>
        /// CredentialsSecretRef is a reference to a secret containing the credentials to access the AWS API //TODO (content and needed permissions) expected secret keys are "aws_access_key_id" and "aws_secret_access_key"
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalDNSZoneSpecProviderRoute53CredentialsSecretRef CredentialsSecretRef;
        /// <summary>
        /// ZoneID is the AWS route53 zone ID.
        /// </summary>
        public readonly string ZoneID;

        [OutputConstructor]
        private GlobalDNSZoneSpecProviderRoute53(
            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GlobalDNSZoneSpecProviderRoute53CredentialsSecretRef credentialsSecretRef,

            string zoneID)
        {
            CredentialsSecretRef = credentialsSecretRef;
            ZoneID = zoneID;
        }
    }
}