// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecTiflashAdditionalContainersEnvValueFromResourceFieldRefArgs : Pulumi.ResourceArgs
    {
        [Input("containerName")]
        public Input<string>? ContainerName { get; set; }

        [Input("divisor")]
        public Input<object>? Divisor { get; set; }

        [Input("resource", required: true)]
        public Input<string> Resource { get; set; } = null!;

        public TidbClusterSpecTiflashAdditionalContainersEnvValueFromResourceFieldRefArgs()
        {
        }
    }
}