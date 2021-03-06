// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1
{

    [OutputType]
    public sealed class PrometheusExporterSpecGrafanaDashboard
    {
        /// <summary>
        /// Create (true) or not (false) GrafanaDashboard object
        /// </summary>
        public readonly bool Enabled;
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecGrafanaDashboardLabel Label;

        [OutputConstructor]
        private PrometheusExporterSpecGrafanaDashboard(
            bool enabled,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecGrafanaDashboardLabel label)
        {
            Enabled = enabled;
            Label = label;
        }
    }
}
