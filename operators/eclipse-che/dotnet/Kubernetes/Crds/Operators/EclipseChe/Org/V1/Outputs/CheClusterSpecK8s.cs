// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Org.V1
{

    [OutputType]
    public sealed class CheClusterSpecK8s
    {
        /// <summary>
        /// Ingress class that will define the which controler will manage ingresses. Defaults to `nginx`. NB: This drives the `is kubernetes.io/ingress.class` annotation on Che-related ingresses.
        /// </summary>
        public readonly string IngressClass;
        /// <summary>
        /// Global ingress domain for a K8S cluster. This MUST be explicitly specified: there are no defaults.
        /// </summary>
        public readonly string IngressDomain;
        /// <summary>
        /// Strategy for ingress creation. This can be `multi-host` (host is explicitly provided in ingress), `single-host` (host is provided, path-based rules) and `default-host.*`(no host is provided, path-based rules). Defaults to `"multi-host`
        /// </summary>
        public readonly string IngressStrategy;
        /// <summary>
        /// FSGroup the Che pod and Workspace pods containers should run in. Defaults to `1724`.
        /// </summary>
        public readonly string SecurityContextFsGroup;
        /// <summary>
        /// ID of the user the Che pod and Workspace pods containers should run as. Default to `1724`.
        /// </summary>
        public readonly string SecurityContextRunAsUser;
        /// <summary>
        /// Name of a secret that will be used to setup ingress TLS termination if TLS is enabled. See also the `tlsSupport` field.
        /// </summary>
        public readonly string TlsSecretName;

        [OutputConstructor]
        private CheClusterSpecK8s(
            string ingressClass,

            string ingressDomain,

            string ingressStrategy,

            string securityContextFsGroup,

            string securityContextRunAsUser,

            string tlsSecretName)
        {
            IngressClass = ingressClass;
            IngressDomain = ingressDomain;
            IngressStrategy = ingressStrategy;
            SecurityContextFsGroup = securityContextFsGroup;
            SecurityContextRunAsUser = securityContextRunAsUser;
            TlsSecretName = tlsSecretName;
        }
    }
}