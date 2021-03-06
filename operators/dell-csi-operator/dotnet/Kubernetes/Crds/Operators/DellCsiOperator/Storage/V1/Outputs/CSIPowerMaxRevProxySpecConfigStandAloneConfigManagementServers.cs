// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Storage.V1
{

    [OutputType]
    public sealed class CSIPowerMaxRevProxySpecConfigStandAloneConfigManagementServers
    {
        public readonly string ArrayCredentialSecret;
        public readonly string CertSecret;
        /// <summary>
        /// ProxyLimits is used for storing the various types of limits applied for a particular proxy instance
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfigManagementServersLimits Limits;
        public readonly bool SkipCertificateValidation;
        public readonly string Url;

        [OutputConstructor]
        private CSIPowerMaxRevProxySpecConfigStandAloneConfigManagementServers(
            string arrayCredentialSecret,

            string certSecret,

            Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxRevProxySpecConfigStandAloneConfigManagementServersLimits limits,

            bool skipCertificateValidation,

            string url)
        {
            ArrayCredentialSecret = arrayCredentialSecret;
            CertSecret = certSecret;
            Limits = limits;
            SkipCertificateValidation = skipCertificateValidation;
            Url = url;
        }
    }
}
