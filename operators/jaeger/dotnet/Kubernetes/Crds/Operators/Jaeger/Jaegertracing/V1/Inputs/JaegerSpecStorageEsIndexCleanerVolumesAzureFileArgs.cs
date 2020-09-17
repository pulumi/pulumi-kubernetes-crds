// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecStorageEsIndexCleanerVolumesAzureFileArgs : Pulumi.ResourceArgs
    {
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        [Input("secretName", required: true)]
        public Input<string> SecretName { get; set; } = null!;

        [Input("shareName", required: true)]
        public Input<string> ShareName { get; set; } = null!;

        public JaegerSpecStorageEsIndexCleanerVolumesAzureFileArgs()
        {
        }
    }
}
