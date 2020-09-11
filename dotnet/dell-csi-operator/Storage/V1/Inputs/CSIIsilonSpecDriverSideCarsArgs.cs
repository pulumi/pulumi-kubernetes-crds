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
    /// ContainerTemplate - Structure representing a container
    /// </summary>
    public class CSIIsilonSpecDriverSideCarsArgs : Pulumi.ResourceArgs
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
        private InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIIsilonSpecDriverSideCarsEnvsArgs>? _envs;

        /// <summary>
        /// Envs is the set of environment variables for the container
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIIsilonSpecDriverSideCarsEnvsArgs> Envs
        {
            get => _envs ?? (_envs = new InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIIsilonSpecDriverSideCarsEnvsArgs>());
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

        public CSIIsilonSpecDriverSideCarsArgs()
        {
        }
    }
}
