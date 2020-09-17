// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Keda.V1Alpha1
{

    [OutputType]
    public sealed class ScaledObjectSpecTriggers
    {
        /// <summary>
        /// ScaledObjectAuthRef points to the TriggerAuthentication object that is used to authenticate the scaler with the environment
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Keda.V1Alpha1.ScaledObjectSpecTriggersAuthenticationRef AuthenticationRef;
        public readonly ImmutableDictionary<string, string> Metadata;
        public readonly string Name;
        public readonly string Type;

        [OutputConstructor]
        private ScaledObjectSpecTriggers(
            Pulumi.Kubernetes.Types.Outputs.Keda.V1Alpha1.ScaledObjectSpecTriggersAuthenticationRef authenticationRef,

            ImmutableDictionary<string, string> metadata,

            string name,

            string type)
        {
            AuthenticationRef = authenticationRef;
            Metadata = metadata;
            Name = name;
            Type = type;
        }
    }
}