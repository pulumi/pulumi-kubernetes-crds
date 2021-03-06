// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Operator.V1
{

    [OutputType]
    public sealed class KlusterletSpecExternalServerURLs
    {
        /// <summary>
        /// CABundle is the ca bundle to connect to apiserver of the managed cluster. System certs are used if it is not set.
        /// </summary>
        public readonly string CaBundle;
        /// <summary>
        /// URL is the url of apiserver endpoint of the managed cluster.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private KlusterletSpecExternalServerURLs(
            string caBundle,

            string url)
        {
            CaBundle = caBundle;
            Url = url;
        }
    }
}
