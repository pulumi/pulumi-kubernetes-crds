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
    /// Config dir containing compliance benchmarks
    /// </summary>
    public class DatadogAgentSpecAgentSecurityComplianceConfigDirArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ConfigMapName name of a ConfigMap used to mount a directory
        /// </summary>
        [Input("configMapName")]
        public Input<string>? ConfigMapName { get; set; }

        public DatadogAgentSpecAgentSecurityComplianceConfigDirArgs()
        {
        }
    }
}
