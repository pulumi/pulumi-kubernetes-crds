// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ArgoCDSpecPrometheusRoute
    {
        /// <summary>
        /// Annotations is the map of annotations to use for the Route resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Annotations;
        /// <summary>
        /// Enabled will toggle the creation of the OpenShift Route.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Path the router watches for, to route traffic for to the service.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// TLS provides the ability to configure certificates and termination for the Route.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecPrometheusRouteTls Tls;
        /// <summary>
        /// WildcardPolicy if any for the route. Currently only 'Subdomain' or 'None' is allowed.
        /// </summary>
        public readonly string WildcardPolicy;

        [OutputConstructor]
        private ArgoCDSpecPrometheusRoute(
            ImmutableDictionary<string, string> annotations,

            bool enabled,

            string path,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ArgoCDSpecPrometheusRouteTls tls,

            string wildcardPolicy)
        {
            Annotations = annotations;
            Enabled = enabled;
            Path = path;
            Tls = tls;
            WildcardPolicy = wildcardPolicy;
        }
    }
}