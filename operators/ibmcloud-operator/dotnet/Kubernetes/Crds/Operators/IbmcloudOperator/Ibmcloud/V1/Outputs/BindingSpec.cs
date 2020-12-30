// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1
{

    [OutputType]
    public sealed class BindingSpec
    {
        /// <summary>
        /// Alias is the name for the credentials to be aliased
        /// </summary>
        public readonly string Alias;
        /// <summary>
        /// Parameters pass configuration to the service during creation
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1.BindingSpecParameters> Parameters;
        /// <summary>
        /// Role is the role for the credentials
        /// </summary>
        public readonly string Role;
        /// <summary>
        /// SecretName is the name of the secret where credentials will be stored
        /// </summary>
        public readonly string SecretName;
        /// <summary>
        /// ServiceClass is the name of the service resource to bind
        /// </summary>
        public readonly string ServiceName;
        /// <summary>
        /// ServiceNamespace is the namespace of the service resource to bind
        /// </summary>
        public readonly string ServiceNamespace;

        [OutputConstructor]
        private BindingSpec(
            string alias,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1.BindingSpecParameters> parameters,

            string role,

            string secretName,

            string serviceName,

            string serviceNamespace)
        {
            Alias = alias;
            Parameters = parameters;
            Role = role;
            SecretName = secretName;
            ServiceName = serviceName;
            ServiceNamespace = serviceNamespace;
        }
    }
}
