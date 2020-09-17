// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// TLS provides the ability to configure certificates and termination for the Route.
    /// </summary>
    public class ArgoCDSpecGrafanaRouteTlsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// caCertificate provides the cert authority certificate contents
        /// </summary>
        [Input("caCertificate")]
        public Input<string>? CaCertificate { get; set; }

        /// <summary>
        /// certificate provides certificate contents
        /// </summary>
        [Input("certificate")]
        public Input<string>? Certificate { get; set; }

        /// <summary>
        /// destinationCACertificate provides the contents of the ca certificate of the final destination.  When using reencrypt termination this file should be provided in order to have routers use it for health checks on the secure connection. If this field is not specified, the router may provide its own destination CA and perform hostname validation using the short service name (service.namespace.svc), which allows infrastructure generated certificates to automatically verify.
        /// </summary>
        [Input("destinationCACertificate")]
        public Input<string>? DestinationCACertificate { get; set; }

        /// <summary>
        /// insecureEdgeTerminationPolicy indicates the desired behavior for insecure connections to a route. While each router may make its own decisions on which ports to expose, this is normally port 80. 
        ///  * Allow - traffic is sent to the server on the insecure port (default) * Disable - no traffic is allowed on the insecure port. * Redirect - clients are redirected to the secure port.
        /// </summary>
        [Input("insecureEdgeTerminationPolicy")]
        public Input<string>? InsecureEdgeTerminationPolicy { get; set; }

        /// <summary>
        /// key provides key file contents
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// termination indicates termination type.
        /// </summary>
        [Input("termination", required: true)]
        public Input<string> Termination { get; set; } = null!;

        public ArgoCDSpecGrafanaRouteTlsArgs()
        {
        }
    }
}
