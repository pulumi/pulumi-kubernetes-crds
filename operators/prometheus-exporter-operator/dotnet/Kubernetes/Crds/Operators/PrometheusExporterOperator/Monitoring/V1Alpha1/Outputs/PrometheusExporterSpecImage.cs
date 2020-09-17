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
    public sealed class PrometheusExporterSpecImage
    {
        /// <summary>
        /// Prometheus exporter image name (example prom/memcached-exporter)
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Prometheus exporter image version (example v0.6.0)
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private PrometheusExporterSpecImage(
            string name,

            string version)
        {
            Name = name;
            Version = version;
        }
    }
}