// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hyperfoil.V1Alpha1
{

    /// <summary>
    /// Route to be used for external access to the Keycloak instance. When `external` is set to true, this will be used for internal access as well.
    /// </summary>
    public class HorreumSpecKeycloakRouteArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Hostname for external access.
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// Optional; Name of the secret hosting `tls.crt`, `tls.key` and optionally `ca.crt`
        /// </summary>
        [Input("tls")]
        public Input<string>? Tls { get; set; }

        public HorreumSpecKeycloakRouteArgs()
        {
        }
    }
}
