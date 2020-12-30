// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1
{

    /// <summary>
    /// Runtime security configuration
    /// </summary>
    public class DatadogAgentSpecAgentSecurityRuntimeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enables runtime security features
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// ConfigDir containing security policies
        /// </summary>
        [Input("policiesDir")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSecurityRuntimePoliciesDirArgs>? PoliciesDir { get; set; }

        /// <summary>
        /// Syscall monitor configuration
        /// </summary>
        [Input("syscallMonitor")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSecurityRuntimeSyscallMonitorArgs>? SyscallMonitor { get; set; }

        public DatadogAgentSpecAgentSecurityRuntimeArgs()
        {
        }
    }
}
