// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1
{

    public class StorageClusterSpecEnvArgs : Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        [Input("valueFrom")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.StorageClusterSpecEnvValueFromArgs>? ValueFrom { get; set; }

        public StorageClusterSpecEnvArgs()
        {
        }
    }
}
