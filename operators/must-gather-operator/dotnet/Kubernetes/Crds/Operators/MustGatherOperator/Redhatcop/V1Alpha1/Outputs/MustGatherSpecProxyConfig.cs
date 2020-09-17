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
    public sealed class MustGatherSpecProxyConfig
    {
        /// <summary>
        /// httpProxy is the URL of the proxy for HTTP requests.  Empty means unset and will not result in an env var.
        /// </summary>
        public readonly string HttpProxy;
        /// <summary>
        /// httpsProxy is the URL of the proxy for HTTPS requests.  Empty means unset and will not result in an env var.
        /// </summary>
        public readonly string HttpsProxy;
        /// <summary>
        /// noProxy is the list of domains for which the proxy should not be used.  Empty means unset and will not result in an env var.
        /// </summary>
        public readonly string NoProxy;

        [OutputConstructor]
        private MustGatherSpecProxyConfig(
            string httpProxy,

            string httpsProxy,

            string noProxy)
        {
            HttpProxy = httpProxy;
            HttpsProxy = httpsProxy;
            NoProxy = noProxy;
        }
    }
}
