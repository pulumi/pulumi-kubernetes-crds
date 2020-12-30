// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1
{

    [OutputType]
    public sealed class DatadogAgentSpecAgentSecurityRuntime
    {
        /// <summary>
        /// Enables runtime security features
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// ConfigDir containing security policies
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSecurityRuntimePoliciesDir PoliciesDir;
        /// <summary>
        /// Syscall monitor configuration
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSecurityRuntimeSyscallMonitor SyscallMonitor;

        [OutputConstructor]
        private DatadogAgentSpecAgentSecurityRuntime(
            bool enabled,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSecurityRuntimePoliciesDir policiesDir,

            Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentSecurityRuntimeSyscallMonitor syscallMonitor)
        {
            Enabled = enabled;
            PoliciesDir = policiesDir;
            SyscallMonitor = syscallMonitor;
        }
    }
}