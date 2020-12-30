// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Charts.V1
{

    /// <summary>
    /// Certificate Manager configuration options
    /// </summary>
    public class XlSpecGlobalCertmanagerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If set to true, use cert-manager
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The name of the certification issuer
        /// </summary>
        [Input("issuer")]
        public Input<string>? Issuer { get; set; }

        public XlSpecGlobalCertmanagerArgs()
        {
        }
    }
}
