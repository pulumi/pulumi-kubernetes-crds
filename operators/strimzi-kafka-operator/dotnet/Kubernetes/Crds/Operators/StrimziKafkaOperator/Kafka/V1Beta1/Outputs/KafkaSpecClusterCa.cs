// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1
{

    [OutputType]
    public sealed class KafkaSpecClusterCa
    {
        /// <summary>
        /// How should CA certificate expiration be handled when `generateCertificateAuthority=true`. The default is for a new CA certificate to be generated reusing the existing private key.
        /// </summary>
        public readonly string CertificateExpirationPolicy;
        /// <summary>
        /// If true then Certificate Authority certificates will be generated automatically. Otherwise the user will need to provide a Secret with the CA certificate. Default is true.
        /// </summary>
        public readonly bool GenerateCertificateAuthority;
        /// <summary>
        /// The number of days in the certificate renewal period. This is the number of days before the a certificate expires during which renewal actions may be performed. When `generateCertificateAuthority` is true, this will cause the generation of a new certificate. When `generateCertificateAuthority` is true, this will cause extra logging at WARN level about the pending certificate expiry. Default is 30.
        /// </summary>
        public readonly int RenewalDays;
        /// <summary>
        /// The number of days generated certificates should be valid for. The default is 365.
        /// </summary>
        public readonly int ValidityDays;

        [OutputConstructor]
        private KafkaSpecClusterCa(
            string certificateExpirationPolicy,

            bool generateCertificateAuthority,

            int renewalDays,

            int validityDays)
        {
            CertificateExpirationPolicy = certificateExpirationPolicy;
            GenerateCertificateAuthority = generateCertificateAuthority;
            RenewalDays = renewalDays;
            ValidityDays = validityDays;
        }
    }
}
