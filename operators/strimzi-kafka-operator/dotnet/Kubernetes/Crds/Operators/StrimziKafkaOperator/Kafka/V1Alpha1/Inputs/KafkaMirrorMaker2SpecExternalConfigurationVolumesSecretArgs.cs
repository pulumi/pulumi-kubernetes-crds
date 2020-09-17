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
    /// Reference to a key in a Secret. Exactly one Secret or ConfigMap has to be specified.
    /// </summary>
    public class KafkaMirrorMaker2SpecExternalConfigurationVolumesSecretArgs : Pulumi.ResourceArgs
    {
        [Input("defaultMode")]
        public Input<int>? DefaultMode { get; set; }

        [Input("items")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecExternalConfigurationVolumesSecretItemsArgs>? _items;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecExternalConfigurationVolumesSecretItemsArgs> Items
        {
            get => _items ?? (_items = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaMirrorMaker2SpecExternalConfigurationVolumesSecretItemsArgs>());
            set => _items = value;
        }

        [Input("optional")]
        public Input<bool>? Optional { get; set; }

        [Input("secretName")]
        public Input<string>? SecretName { get; set; }

        public KafkaMirrorMaker2SpecExternalConfigurationVolumesSecretArgs()
        {
        }
    }
}
