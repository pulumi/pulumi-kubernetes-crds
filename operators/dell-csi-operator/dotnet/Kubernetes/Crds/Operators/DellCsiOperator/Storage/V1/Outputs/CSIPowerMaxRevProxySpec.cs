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
    public sealed class CSIPowerMaxRevProxySpec
    {
        /// <summary>
        /// RevProxyConfig represents the reverse proxy configuration
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxRevProxySpecConfig Config;
        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// PullPolicy describes a policy for if/when to pull a container image
        /// </summary>
        public readonly string ImagePullPolicy;
        public readonly string TlsSecret;

        [OutputConstructor]
        private CSIPowerMaxRevProxySpec(
            Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxRevProxySpecConfig config,

            string image,

            string imagePullPolicy,

            string tlsSecret)
        {
            Config = config;
            Image = image;
            ImagePullPolicy = imagePullPolicy;
            TlsSecret = tlsSecret;
        }
    }
}
