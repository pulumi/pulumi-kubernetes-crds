// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// The Windows specific settings applied to all containers. If unspecified, the options from the PodSecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
    /// </summary>
    public class PrometheusSpecContainersSecurityContextWindowsOptionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field. This field is alpha-level and is only honored by servers that enable the WindowsGMSA feature flag.
        /// </summary>
        [Input("gmsaCredentialSpec")]
        public Input<string>? GmsaCredentialSpec { get; set; }

        /// <summary>
        /// GMSACredentialSpecName is the name of the GMSA credential spec to use. This field is alpha-level and is only honored by servers that enable the WindowsGMSA feature flag.
        /// </summary>
        [Input("gmsaCredentialSpecName")]
        public Input<string>? GmsaCredentialSpecName { get; set; }

        /// <summary>
        /// The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. This field is beta-level and may be disabled with the WindowsRunAsUserName feature flag.
        /// </summary>
        [Input("runAsUserName")]
        public Input<string>? RunAsUserName { get; set; }

        public PrometheusSpecContainersSecurityContextWindowsOptionsArgs()
        {
        }
    }
}
