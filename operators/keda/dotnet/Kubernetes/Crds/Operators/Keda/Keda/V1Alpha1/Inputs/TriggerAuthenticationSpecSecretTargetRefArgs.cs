// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Keda.V1Alpha1
{

    /// <summary>
    /// AuthSecretTargetRef is used to authenticate using a reference to a secret
    /// </summary>
    public class TriggerAuthenticationSpecSecretTargetRefArgs : Pulumi.ResourceArgs
    {
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("parameter", required: true)]
        public Input<string> Parameter { get; set; } = null!;

        public TriggerAuthenticationSpecSecretTargetRefArgs()
        {
        }
    }
}
