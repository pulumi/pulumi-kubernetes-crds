// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1
{

    [OutputType]
    public sealed class ClusterBuildStrategySpecBuildStepsSecurityContextWindowsOptions
    {
        /// <summary>
        /// GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field. This field is alpha-level and is only honored by servers that enable the WindowsGMSA feature flag.
        /// </summary>
        public readonly string GmsaCredentialSpec;
        /// <summary>
        /// GMSACredentialSpecName is the name of the GMSA credential spec to use. This field is alpha-level and is only honored by servers that enable the WindowsGMSA feature flag.
        /// </summary>
        public readonly string GmsaCredentialSpecName;
        /// <summary>
        /// The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. This field is alpha-level and it is only honored by servers that enable the WindowsRunAsUserName feature flag.
        /// </summary>
        public readonly string RunAsUserName;

        [OutputConstructor]
        private ClusterBuildStrategySpecBuildStepsSecurityContextWindowsOptions(
            string gmsaCredentialSpec,

            string gmsaCredentialSpecName,

            string runAsUserName)
        {
            GmsaCredentialSpec = gmsaCredentialSpec;
            GmsaCredentialSpecName = gmsaCredentialSpecName;
            RunAsUserName = runAsUserName;
        }
    }
}
