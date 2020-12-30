// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1
{

    [OutputType]
    public sealed class KeyVaultKeyStatus
    {
        public readonly string Completed;
        public readonly bool ContainsUpdate;
        public readonly bool FailedProvisioning;
        public readonly bool FlattenedSecrets;
        public readonly string Message;
        public readonly string Output;
        public readonly string PollingUrl;
        public readonly bool Provisioned;
        public readonly bool Provisioning;
        public readonly string Requested;
        public readonly string ResourceId;
        public readonly string SpecHash;
        public readonly string State;

        [OutputConstructor]
        private KeyVaultKeyStatus(
            string completed,

            bool containsUpdate,

            bool failedProvisioning,

            bool flattenedSecrets,

            string message,

            string output,

            string pollingUrl,

            bool provisioned,

            bool provisioning,

            string requested,

            string resourceId,

            string specHash,

            string state)
        {
            Completed = completed;
            ContainsUpdate = containsUpdate;
            FailedProvisioning = failedProvisioning;
            FlattenedSecrets = flattenedSecrets;
            Message = message;
            Output = output;
            PollingUrl = pollingUrl;
            Provisioned = provisioned;
            Provisioning = provisioning;
            Requested = requested;
            ResourceId = resourceId;
            SpecHash = specHash;
            State = state;
        }
    }
}
