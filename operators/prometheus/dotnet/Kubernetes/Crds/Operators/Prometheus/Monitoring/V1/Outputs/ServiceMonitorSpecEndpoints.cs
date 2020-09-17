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
    public sealed class ServiceMonitorSpecEndpoints
    {
        /// <summary>
        /// BasicAuth allow an endpoint to authenticate over basic authentication More info: https://prometheus.io/docs/operating/configuration/#endpoints
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsBasicAuth BasicAuth;
        /// <summary>
        /// File to read bearer token for scraping targets.
        /// </summary>
        public readonly string BearerTokenFile;
        /// <summary>
        /// Secret to mount to read bearer token for scraping targets. The secret needs to be in the same namespace as the service monitor and accessible by the Prometheus Operator.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsBearerTokenSecret BearerTokenSecret;
        /// <summary>
        /// HonorLabels chooses the metric's labels on collisions with target labels.
        /// </summary>
        public readonly bool HonorLabels;
        /// <summary>
        /// HonorTimestamps controls whether Prometheus respects the timestamps present in scraped data.
        /// </summary>
        public readonly bool HonorTimestamps;
        /// <summary>
        /// Interval at which metrics should be scraped
        /// </summary>
        public readonly string Interval;
        /// <summary>
        /// MetricRelabelConfigs to apply to samples before ingestion.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsMetricRelabelings> MetricRelabelings;
        /// <summary>
        /// Optional HTTP URL parameters
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableArray<string>> Params;
        /// <summary>
        /// HTTP path to scrape for metrics.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Name of the service port this endpoint refers to. Mutually exclusive with targetPort.
        /// </summary>
        public readonly string Port;
        /// <summary>
        /// ProxyURL eg http://proxyserver:2195 Directs scrapes to proxy through this endpoint.
        /// </summary>
        public readonly string ProxyUrl;
        /// <summary>
        /// RelabelConfigs to apply to samples before scraping. More info: https://prometheus.io/docs/prometheus/latest/configuration/configuration/#relabel_config
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsRelabelings> Relabelings;
        /// <summary>
        /// HTTP scheme to use for scraping.
        /// </summary>
        public readonly string Scheme;
        /// <summary>
        /// Timeout after which the scrape is ended
        /// </summary>
        public readonly string ScrapeTimeout;
        /// <summary>
        /// Name or number of the target port of the endpoint. Mutually exclusive with port.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsTargetPort TargetPort;
        /// <summary>
        /// TLS configuration to use when scraping the endpoint
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsTlsConfig TlsConfig;

        [OutputConstructor]
        private ServiceMonitorSpecEndpoints(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsBasicAuth basicAuth,

            string bearerTokenFile,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsBearerTokenSecret bearerTokenSecret,

            bool honorLabels,

            bool honorTimestamps,

            string interval,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsMetricRelabelings> metricRelabelings,

            ImmutableDictionary<string, ImmutableArray<string>> @params,

            string path,

            string port,

            string proxyUrl,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsRelabelings> relabelings,

            string scheme,

            string scrapeTimeout,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsTargetPort targetPort,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsTlsConfig tlsConfig)
        {
            BasicAuth = basicAuth;
            BearerTokenFile = bearerTokenFile;
            BearerTokenSecret = bearerTokenSecret;
            HonorLabels = honorLabels;
            HonorTimestamps = honorTimestamps;
            Interval = interval;
            MetricRelabelings = metricRelabelings;
            Params = @params;
            Path = path;
            Port = port;
            ProxyUrl = proxyUrl;
            Relabelings = relabelings;
            Scheme = scheme;
            ScrapeTimeout = scrapeTimeout;
            TargetPort = targetPort;
            TlsConfig = tlsConfig;
        }
    }
}
