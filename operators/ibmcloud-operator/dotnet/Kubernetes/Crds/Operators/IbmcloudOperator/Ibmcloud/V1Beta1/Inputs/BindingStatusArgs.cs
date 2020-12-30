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
    /// BindingStatus defines the observed state of Binding
    /// </summary>
    public class BindingStatusArgs : Pulumi.ResourceArgs
    {
        [Input("generation")]
        public Input<int>? Generation { get; set; }

        /// <summary>
        /// InstanceID is the instance ID for the service
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// KeyInstanceID is the key instance ID for the credentials
        /// </summary>
        [Input("keyInstanceId")]
        public Input<string>? KeyInstanceId { get; set; }

        /// <summary>
        /// Message is a detailed message on current status
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// SecretName is the name of the generated secret with service credentials
        /// </summary>
        [Input("secretName")]
        public Input<string>? SecretName { get; set; }

        /// <summary>
        /// State is a short name for the current status
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        public BindingStatusArgs()
        {
        }
    }
}