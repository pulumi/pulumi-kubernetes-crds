// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1
{

    public class StorageClusterSpecAutopilotEnvValueFromArgs : Pulumi.ResourceArgs
    {
        [Input("configMapKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageClusterSpecAutopilotEnvValueFromConfigMapKeyRefArgs>? ConfigMapKeyRef { get; set; }

        [Input("fieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageClusterSpecAutopilotEnvValueFromFieldRefArgs>? FieldRef { get; set; }

        [Input("resourceFieldRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageClusterSpecAutopilotEnvValueFromResourceFieldRefArgs>? ResourceFieldRef { get; set; }

        [Input("secretKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageClusterSpecAutopilotEnvValueFromSecretKeyRefArgs>? SecretKeyRef { get; set; }

        public StorageClusterSpecAutopilotEnvValueFromArgs()
        {
        }
    }
}
