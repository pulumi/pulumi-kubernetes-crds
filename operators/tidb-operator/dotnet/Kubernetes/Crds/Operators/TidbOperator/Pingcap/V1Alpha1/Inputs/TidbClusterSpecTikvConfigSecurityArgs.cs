// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTikvConfigSecurityArgs : Pulumi.ResourceArgs
    {
        [Input("ca-path")]
        public Input<string>? Ca-path { get; set; }

        [Input("cert-path")]
        public Input<string>? Cert-path { get; set; }

        [Input("cipher-file")]
        public Input<string>? Cipher-file { get; set; }

        [Input("encryption")]
        public Input<object>? Encryption { get; set; }

        [Input("key-path")]
        public Input<string>? Key-path { get; set; }

        [Input("override-ssl-target")]
        public Input<string>? Override-ssl-target { get; set; }

        public TidbClusterSpecTikvConfigSecurityArgs()
        {
        }
    }
}