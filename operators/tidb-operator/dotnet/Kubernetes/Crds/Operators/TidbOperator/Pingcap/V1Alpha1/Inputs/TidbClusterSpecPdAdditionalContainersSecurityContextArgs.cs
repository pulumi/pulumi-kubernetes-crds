// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecPdAdditionalContainersSecurityContextArgs : Pulumi.ResourceArgs
    {
        [Input("allowPrivilegeEscalation")]
        public Input<bool>? AllowPrivilegeEscalation { get; set; }

        [Input("capabilities")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPdAdditionalContainersSecurityContextCapabilitiesArgs>? Capabilities { get; set; }

        [Input("privileged")]
        public Input<bool>? Privileged { get; set; }

        [Input("procMount")]
        public Input<string>? ProcMount { get; set; }

        [Input("readOnlyRootFilesystem")]
        public Input<bool>? ReadOnlyRootFilesystem { get; set; }

        [Input("runAsGroup")]
        public Input<int>? RunAsGroup { get; set; }

        [Input("runAsNonRoot")]
        public Input<bool>? RunAsNonRoot { get; set; }

        [Input("runAsUser")]
        public Input<int>? RunAsUser { get; set; }

        [Input("seLinuxOptions")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPdAdditionalContainersSecurityContextSeLinuxOptionsArgs>? SeLinuxOptions { get; set; }

        [Input("windowsOptions")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPdAdditionalContainersSecurityContextWindowsOptionsArgs>? WindowsOptions { get; set; }

        public TidbClusterSpecPdAdditionalContainersSecurityContextArgs()
        {
        }
    }
}