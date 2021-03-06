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
    public sealed class PrometheusExporterSpec
    {
        /// <summary>
        /// For cloudwatch exporter, the Secret name containing AWS IAM credentials (AWS_ACCESS_KEY_ID / AWS_SECRET_ACCESS_KEY)
        /// </summary>
        public readonly string AwsCredentialsSecretName;
        /// <summary>
        /// For cloudwatch exporter, the ConfigMap name containing Cloudwatch config.yml (Services, Dimensions, Tags used for autodiscovery...)
        /// </summary>
        public readonly string ConfigurationConfigmapName;
        /// <summary>
        /// For redis exporter, the optional redis keys to monitor (example: resque:queue:stats,resque:queue:priority,resque:queue:main,resque:failed)
        /// </summary>
        public readonly string DbCheckKeys;
        /// <summary>
        /// For mysql and postgresql exporters, the Secret name containing connection string definition (DSN)
        /// </summary>
        public readonly string DbConnectionStringSecretName;
        /// <summary>
        /// For redis, memcached, sphinx and es exporters, the db host to monitor
        /// </summary>
        public readonly string DbHost;
        /// <summary>
        /// For redis, memcached, sphinx and es exporters, the db port to monitor
        /// </summary>
        public readonly int DbPort;
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecExtraLabel ExtraLabel;
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecGrafanaDashboard GrafanaDashboard;
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecImage Image;
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecLivenessProbe LivenessProbe;
        /// <summary>
        /// Prometheus exporter port where metrics are available (example 9150)
        /// </summary>
        public readonly int Port;
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecReadinessProbe ReadinessProbe;
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecResources Resources;
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecServiceMonitor ServiceMonitor;
        /// <summary>
        /// Supported prometheus-exporter types: memcached, redis, mysql, postgresql, sphinx, es, cloudwatch
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private PrometheusExporterSpec(
            string awsCredentialsSecretName,

            string configurationConfigmapName,

            string dbCheckKeys,

            string dbConnectionStringSecretName,

            string dbHost,

            int dbPort,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecExtraLabel extraLabel,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecGrafanaDashboard grafanaDashboard,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecImage image,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecLivenessProbe livenessProbe,

            int port,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecReadinessProbe readinessProbe,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecResources resources,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1.PrometheusExporterSpecServiceMonitor serviceMonitor,

            string type)
        {
            AwsCredentialsSecretName = awsCredentialsSecretName;
            ConfigurationConfigmapName = configurationConfigmapName;
            DbCheckKeys = dbCheckKeys;
            DbConnectionStringSecretName = dbConnectionStringSecretName;
            DbHost = dbHost;
            DbPort = dbPort;
            ExtraLabel = extraLabel;
            GrafanaDashboard = grafanaDashboard;
            Image = image;
            LivenessProbe = livenessProbe;
            Port = port;
            ReadinessProbe = readinessProbe;
            Resources = resources;
            ServiceMonitor = serviceMonitor;
            Type = type;
        }
    }
}
