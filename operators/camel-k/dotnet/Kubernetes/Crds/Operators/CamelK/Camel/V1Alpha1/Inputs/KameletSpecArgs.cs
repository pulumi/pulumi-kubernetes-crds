// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Camel.V1Alpha1
{

    /// <summary>
    /// KameletSpec defines the desired state of Kamelet
    /// </summary>
    public class KameletSpecArgs : Pulumi.ResourceArgs
    {
        [Input("authorization")]
        private InputMap<object>? _authorization;

        /// <summary>
        /// AuthorizationSpec is TODO (oauth information)
        /// </summary>
        public InputMap<object> Authorization
        {
            get => _authorization ?? (_authorization = new InputMap<object>());
            set => _authorization = value;
        }

        /// <summary>
        /// JSONSchemaProps is a JSON-Schema definition.
        /// </summary>
        [Input("definition")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1Alpha1.KameletSpecDefinitionArgs>? Definition { get; set; }

        [Input("dependencies")]
        private InputList<string>? _dependencies;
        public InputList<string> Dependencies
        {
            get => _dependencies ?? (_dependencies = new InputList<string>());
            set => _dependencies = value;
        }

        [Input("flow")]
        private InputMap<object>? _flow;
        public InputMap<object> Flow
        {
            get => _flow ?? (_flow = new InputMap<object>());
            set => _flow = value;
        }

        [Input("sources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1Alpha1.KameletSpecSourcesArgs>? _sources;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1Alpha1.KameletSpecSourcesArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1Alpha1.KameletSpecSourcesArgs>());
            set => _sources = value;
        }

        [Input("types")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Camel.V1Alpha1.KameletSpecTypesArgs>? _types;
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Camel.V1Alpha1.KameletSpecTypesArgs> Types
        {
            get => _types ?? (_types = new InputMap<Pulumi.Kubernetes.Types.Inputs.Camel.V1Alpha1.KameletSpecTypesArgs>());
            set => _types = value;
        }

        public KameletSpecArgs()
        {
        }
    }
}
