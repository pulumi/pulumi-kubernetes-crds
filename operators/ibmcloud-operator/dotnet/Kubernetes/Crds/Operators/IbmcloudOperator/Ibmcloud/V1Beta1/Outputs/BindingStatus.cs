// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Beta1
{

    [OutputType]
    public sealed class BindingStatus
    {
        public readonly int Generation;
        /// <summary>
        /// InstanceID is the instance ID for the service
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// KeyInstanceID is the key instance ID for the credentials
        /// </summary>
        public readonly string KeyInstanceId;
        /// <summary>
        /// Message is a detailed message on current status
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// SecretName is the name of the generated secret with service credentials
        /// </summary>
        public readonly string SecretName;
        /// <summary>
        /// State is a short name for the current status
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private BindingStatus(
            int generation,

            string instanceId,

            string keyInstanceId,

            string message,

            string secretName,

            string state)
        {
            Generation = generation;
            InstanceId = instanceId;
            KeyInstanceId = keyInstanceId;
            Message = message;
            SecretName = secretName;
            State = state;
        }
    }
}
