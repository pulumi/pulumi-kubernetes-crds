// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Keycloak.V1Alpha1
{

    [OutputType]
    public sealed class KeycloakClientSpecClientProtocolMappers
    {
        /// <summary>
        /// Config options.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Config;
        /// <summary>
        /// True if Consent Screen is required.
        /// </summary>
        public readonly bool ConsentRequired;
        /// <summary>
        /// Text to use for displaying Consent Screen.
        /// </summary>
        public readonly string ConsentText;
        /// <summary>
        /// Protocol Mapper ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Protocol Mapper Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Protocol to use.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// Protocol Mapper to use
        /// </summary>
        public readonly string ProtocolMapper;

        [OutputConstructor]
        private KeycloakClientSpecClientProtocolMappers(
            ImmutableDictionary<string, string> config,

            bool consentRequired,

            string consentText,

            string id,

            string name,

            string protocol,

            string protocolMapper)
        {
            Config = config;
            ConsentRequired = consentRequired;
            ConsentText = consentText;
            Id = id;
            Name = name;
            Protocol = protocol;
            ProtocolMapper = protocolMapper;
        }
    }
}
