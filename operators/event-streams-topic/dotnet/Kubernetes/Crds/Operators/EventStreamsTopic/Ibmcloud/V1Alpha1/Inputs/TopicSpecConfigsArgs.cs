// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1
{

    public class TopicSpecConfigsArgs : Pulumi.ResourceArgs
    {
        [Input("attributes")]
        private InputMap<object>? _attributes;

        /// <summary>
        /// A parameter may have attributes (e.g. message hub topic might have partitions)
        /// </summary>
        public InputMap<object> Attributes
        {
            get => _attributes ?? (_attributes = new InputMap<object>());
            set => _attributes = value;
        }

        /// <summary>
        /// Name representing the key.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Defaults to null.
        /// </summary>
        [Input("value")]
        public Input<object>? Value { get; set; }

        /// <summary>
        /// Source for the value. Cannot be used if value is not empty.
        /// </summary>
        [Input("valueFrom")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.TopicSpecConfigsValueFromArgs>? ValueFrom { get; set; }

        public TopicSpecConfigsArgs()
        {
        }
    }
}
