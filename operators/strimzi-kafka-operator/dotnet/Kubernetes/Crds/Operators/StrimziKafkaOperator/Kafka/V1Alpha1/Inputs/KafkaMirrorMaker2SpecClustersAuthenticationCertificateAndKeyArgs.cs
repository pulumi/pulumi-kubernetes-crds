// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1
{

    /// <summary>
    /// Reference to the `Secret` which holds the certificate and private key pair.
    /// </summary>
    public class KafkaMirrorMaker2SpecClustersAuthenticationCertificateAndKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the file certificate in the Secret.
        /// </summary>
        [Input("certificate", required: true)]
        public Input<string> Certificate { get; set; } = null!;

        /// <summary>
        /// The name of the private key in the Secret.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// The name of the Secret containing the certificate.
        /// </summary>
        [Input("secretName", required: true)]
        public Input<string> SecretName { get; set; } = null!;

        public KafkaMirrorMaker2SpecClustersAuthenticationCertificateAndKeyArgs()
        {
        }
    }
}
