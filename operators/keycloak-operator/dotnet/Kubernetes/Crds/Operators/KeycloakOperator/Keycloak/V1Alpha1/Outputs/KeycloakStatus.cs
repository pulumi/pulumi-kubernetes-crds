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
    public sealed class KeycloakStatus
    {
        /// <summary>
        /// The secret where the admin credentials are to be found.
        /// </summary>
        public readonly string CredentialSecret;
        /// <summary>
        /// Service IP and Port for in-cluster access to the keycloak instance.
        /// </summary>
        public readonly string InternalURL;
        /// <summary>
        /// Human-readable message indicating details about current operator phase or error.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Current phase of the operator.
        /// </summary>
        public readonly string Phase;
        /// <summary>
        /// True if all resources are in a ready state and all work is done.
        /// </summary>
        public readonly bool Ready;
        /// <summary>
        /// A map of all the secondary resources types and names created for this CR. e.g "Deployment": [ "DeploymentName1", "DeploymentName2" ].
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableArray<string>> SecondaryResources;
        /// <summary>
        /// Version of Keycloak or RHSSO running on the cluster.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private KeycloakStatus(
            string credentialSecret,

            string internalURL,

            string message,

            string phase,

            bool ready,

            ImmutableDictionary<string, ImmutableArray<string>> secondaryResources,

            string version)
        {
            CredentialSecret = credentialSecret;
            InternalURL = internalURL;
            Message = message;
            Phase = phase;
            Ready = ready;
            SecondaryResources = secondaryResources;
            Version = version;
        }
    }
}
