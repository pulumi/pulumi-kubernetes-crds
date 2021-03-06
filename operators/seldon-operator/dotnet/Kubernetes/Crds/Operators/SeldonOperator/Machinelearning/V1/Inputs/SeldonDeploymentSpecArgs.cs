// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1
{

    /// <summary>
    /// SeldonDeploymentSpec defines the desired state of SeldonDeployment
    /// </summary>
    public class SeldonDeploymentSpecArgs : Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// Name is Deprecated will be removed in future
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("oauth_key")]
        public Input<string>? Oauth_key { get; set; }

        [Input("oauth_secret")]
        public Input<string>? Oauth_secret { get; set; }

        [Input("predictors", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsArgs>? _predictors;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsArgs> Predictors
        {
            get => _predictors ?? (_predictors = new InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsArgs>());
            set => _predictors = value;
        }

        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        [Input("replicas")]
        public Input<int>? Replicas { get; set; }

        [Input("serverType")]
        public Input<string>? ServerType { get; set; }

        [Input("transport")]
        public Input<string>? Transport { get; set; }

        public SeldonDeploymentSpecArgs()
        {
        }
    }
}
