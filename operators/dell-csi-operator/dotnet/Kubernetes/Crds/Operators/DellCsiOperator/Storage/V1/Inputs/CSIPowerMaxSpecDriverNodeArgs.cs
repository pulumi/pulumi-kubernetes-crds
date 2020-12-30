// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1
{

    /// <summary>
    /// Node is the specification for Node plugin only
    /// </summary>
    public class CSIPowerMaxSpecDriverNodeArgs : Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// Args is the set of arguments for the container
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("envs")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverNodeEnvsArgs>? _envs;

        /// <summary>
        /// Envs is the set of environment variables for the container
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverNodeEnvsArgs> Envs
        {
            get => _envs ?? (_envs = new InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverNodeEnvsArgs>());
            set => _envs = value;
        }

        /// <summary>
        /// Image is the image tag for the Container
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// ImagePullPolicy is the image pull policy for the image
        /// </summary>
        [Input("imagePullPolicy")]
        public Input<string>? ImagePullPolicy { get; set; }

        /// <summary>
        /// Name is the name of Container
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("nodeSelector")]
        private InputMap<string>? _nodeSelector;

        /// <summary>
        /// NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node.
        /// </summary>
        public InputMap<string> NodeSelector
        {
            get => _nodeSelector ?? (_nodeSelector = new InputMap<string>());
            set => _nodeSelector = value;
        }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverNodeTolerationsArgs>? _tolerations;

        /// <summary>
        /// Tolerations is the list of tolerations for the driver pods
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverNodeTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverNodeTolerationsArgs>());
            set => _tolerations = value;
        }

        public CSIPowerMaxSpecDriverNodeArgs()
        {
        }
    }
}
