// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Elasticsearch.V1
{

    [OutputType]
    public sealed class ElasticsearchSpecHttpTlsSelfSignedCertificateSubjectAltNames
    {
        /// <summary>
        /// DNS is the DNS name of the subject.
        /// </summary>
        public readonly string Dns;
        /// <summary>
        /// IP is the IP address of the subject.
        /// </summary>
        public readonly string Ip;

        [OutputConstructor]
        private ElasticsearchSpecHttpTlsSelfSignedCertificateSubjectAltNames(
            string dns,

            string ip)
        {
            Dns = dns;
            Ip = ip;
        }
    }
}
