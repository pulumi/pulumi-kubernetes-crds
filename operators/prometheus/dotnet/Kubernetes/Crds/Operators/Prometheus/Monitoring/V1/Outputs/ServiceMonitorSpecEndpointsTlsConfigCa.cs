// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class ServiceMonitorSpecEndpointsTlsConfigCa
    {
        /// <summary>
        /// ConfigMap containing data to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsTlsConfigCaConfigMap ConfigMap;
        /// <summary>
        /// Secret containing data to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsTlsConfigCaSecret Secret;

        [OutputConstructor]
        private ServiceMonitorSpecEndpointsTlsConfigCa(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsTlsConfigCaConfigMap configMap,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsTlsConfigCaSecret secret)
        {
            ConfigMap = configMap;
            Secret = secret;
        }
    }
}
