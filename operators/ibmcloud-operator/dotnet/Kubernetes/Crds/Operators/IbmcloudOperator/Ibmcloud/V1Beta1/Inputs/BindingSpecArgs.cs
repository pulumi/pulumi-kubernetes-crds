// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Beta1
{

    /// <summary>
    /// BindingSpec defines the desired state of Binding
    /// </summary>
    public class BindingSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alias is the name for the credentials to be aliased
        /// </summary>
        [Input("alias")]
        public Input<string>? Alias { get; set; }

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Beta1.BindingSpecParametersArgs>? _parameters;

        /// <summary>
        /// Parameters pass configuration to the service during creation
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Beta1.BindingSpecParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Beta1.BindingSpecParametersArgs>());
            set => _parameters = value;
        }

        /// <summary>
        /// Role is the role for the credentials
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        /// <summary>
        /// SecretName is the name of the secret where credentials will be stored
        /// </summary>
        [Input("secretName")]
        public Input<string>? SecretName { get; set; }

        /// <summary>
        /// ServiceClass is the name of the service resource to bind
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        /// <summary>
        /// ServiceNamespace is the namespace of the service resource to bind
        /// </summary>
        [Input("serviceNamespace")]
        public Input<string>? ServiceNamespace { get; set; }

        public BindingSpecArgs()
        {
        }
    }
}
