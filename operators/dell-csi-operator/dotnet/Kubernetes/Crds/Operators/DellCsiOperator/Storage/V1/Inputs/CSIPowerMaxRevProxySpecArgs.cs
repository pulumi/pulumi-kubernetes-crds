// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1
{

    /// <summary>
    /// CSIPowerMaxRevProxySpec defines the desired state of CSIPowerMaxRevProxy
    /// </summary>
    public class CSIPowerMaxRevProxySpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// RevProxyConfig represents the reverse proxy configuration
        /// </summary>
        [Input("config", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxRevProxySpecConfigArgs> Config { get; set; } = null!;

        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
        /// </summary>
        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        /// <summary>
        /// PullPolicy describes a policy for if/when to pull a container image
        /// </summary>
        [Input("imagePullPolicy")]
        public Input<string>? ImagePullPolicy { get; set; }

        [Input("tlsSecret", required: true)]
        public Input<string> TlsSecret { get; set; } = null!;

        public CSIPowerMaxRevProxySpecArgs()
        {
        }
    }
}
