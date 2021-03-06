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
    public sealed class PrometheusSpecAlertingAlertmanagersTlsConfigCa
    {
        /// <summary>
        /// ConfigMap containing data to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecAlertingAlertmanagersTlsConfigCaConfigMap ConfigMap;
        /// <summary>
        /// Secret containing data to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecAlertingAlertmanagersTlsConfigCaSecret Secret;

        [OutputConstructor]
        private PrometheusSpecAlertingAlertmanagersTlsConfigCa(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecAlertingAlertmanagersTlsConfigCaConfigMap configMap,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PrometheusSpecAlertingAlertmanagersTlsConfigCaSecret secret)
        {
            ConfigMap = configMap;
            Secret = secret;
        }
    }
}
