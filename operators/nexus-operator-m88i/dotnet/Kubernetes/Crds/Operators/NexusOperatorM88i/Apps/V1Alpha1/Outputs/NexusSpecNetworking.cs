// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1
{

    [OutputType]
    public sealed class NexusSpecNetworking
    {
        /// <summary>
        /// Set to `true` to expose the Nexus application. Defaults to `false`.
        /// </summary>
        public readonly bool Expose;
        /// <summary>
        /// Type of networking exposure: NodePort, Route or Ingress. Defaults to Route on OpenShift and Ingress on Kubernetes. Routes are only available on Openshift and Ingresses are only available on Kubernetes.
        /// </summary>
        public readonly string ExposeAs;
        /// <summary>
        /// Host where the Nexus service is exposed. This attribute is required if the service is exposed via Ingress.
        /// </summary>
        public readonly string Host;
        /// <summary>
        /// NodePort defined in the exposed service. Required if exposed via NodePort.
        /// </summary>
        public readonly int NodePort;
        /// <summary>
        /// TLS/SSL-related configuration
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.NexusSpecNetworkingTls Tls;

        [OutputConstructor]
        private NexusSpecNetworking(
            bool expose,

            string exposeAs,

            string host,

            int nodePort,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.NexusSpecNetworkingTls tls)
        {
            Expose = expose;
            ExposeAs = exposeAs;
            Host = host;
            NodePort = nodePort;
            Tls = tls;
        }
    }
}
