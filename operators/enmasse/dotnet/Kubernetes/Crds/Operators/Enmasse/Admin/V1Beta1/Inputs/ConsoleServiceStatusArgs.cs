// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1
{

    public class ConsoleServiceStatusArgs : Pulumi.ResourceArgs
    {
        [Input("caCertSecret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.ConsoleServiceStatusCaCertSecretArgs>? CaCertSecret { get; set; }

        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        public ConsoleServiceStatusArgs()
        {
        }
    }
}
