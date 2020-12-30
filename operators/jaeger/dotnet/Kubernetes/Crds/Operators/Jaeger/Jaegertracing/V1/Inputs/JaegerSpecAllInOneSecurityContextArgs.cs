// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecAllInOneSecurityContextArgs : Pulumi.ResourceArgs
    {
        [Input("fsGroup")]
        public Input<int>? FsGroup { get; set; }

        [Input("fsGroupChangePolicy")]
        public Input<string>? FsGroupChangePolicy { get; set; }

        [Input("runAsGroup")]
        public Input<int>? RunAsGroup { get; set; }

        [Input("runAsNonRoot")]
        public Input<bool>? RunAsNonRoot { get; set; }

        [Input("runAsUser")]
        public Input<int>? RunAsUser { get; set; }

        [Input("seLinuxOptions")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneSecurityContextSeLinuxOptionsArgs>? SeLinuxOptions { get; set; }

        [Input("supplementalGroups")]
        private InputList<int>? _supplementalGroups;
        public InputList<int> SupplementalGroups
        {
            get => _supplementalGroups ?? (_supplementalGroups = new InputList<int>());
            set => _supplementalGroups = value;
        }

        [Input("sysctls")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneSecurityContextSysctlsArgs>? _sysctls;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneSecurityContextSysctlsArgs> Sysctls
        {
            get => _sysctls ?? (_sysctls = new InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneSecurityContextSysctlsArgs>());
            set => _sysctls = value;
        }

        [Input("windowsOptions")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneSecurityContextWindowsOptionsArgs>? WindowsOptions { get; set; }

        public JaegerSpecAllInOneSecurityContextArgs()
        {
        }
    }
}
