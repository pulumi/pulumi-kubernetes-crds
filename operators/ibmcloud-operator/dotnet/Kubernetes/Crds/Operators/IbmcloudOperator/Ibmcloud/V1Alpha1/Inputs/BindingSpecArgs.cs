// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1
{

    public class BindingSpecArgs : Pulumi.ResourceArgs
    {
        [Input("alias")]
        public Input<string>? Alias { get; set; }

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.BindingSpecParametersArgs>? _parameters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.BindingSpecParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.BindingSpecParametersArgs>());
            set => _parameters = value;
        }

        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("secretName")]
        public Input<string>? SecretName { get; set; }

        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        [Input("serviceNamespace")]
        public Input<string>? ServiceNamespace { get; set; }

        public BindingSpecArgs()
        {
        }
    }
}