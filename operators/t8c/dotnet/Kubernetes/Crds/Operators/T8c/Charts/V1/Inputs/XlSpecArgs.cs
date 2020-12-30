// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Charts.V1
{

    public class XlSpecArgs : Pulumi.ResourceArgs
    {
        [Input("acims")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecAcimsArgs>? Acims { get; set; }

        [Input("action-orchestrator")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecAction-OrchestratorArgs>? Action-orchestrator { get; set; }

        [Input("actionscript")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecActionscriptArgs>? Actionscript { get; set; }

        [Input("aix")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecAixArgs>? Aix { get; set; }

        [Input("api")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecApiArgs>? Api { get; set; }

        [Input("apic")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecApicArgs>? Apic { get; set; }

        [Input("appdynamics")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecAppdynamicsArgs>? Appdynamics { get; set; }

        [Input("appinsights")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecAppinsightsArgs>? Appinsights { get; set; }

        [Input("arangodb")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecArangodbArgs>? Arangodb { get; set; }

        [Input("auth")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecAuthArgs>? Auth { get; set; }

        [Input("aws")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecAwsArgs>? Aws { get; set; }

        [Input("awslambda")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecAwslambdaArgs>? Awslambda { get; set; }

        [Input("azure")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecAzureArgs>? Azure { get; set; }

        [Input("baremetal")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecBaremetalArgs>? Baremetal { get; set; }

        [Input("chronograf")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecChronografArgs>? Chronograf { get; set; }

        [Input("cloudfoundry")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecCloudfoundryArgs>? Cloudfoundry { get; set; }

        [Input("clustermgr")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecClustermgrArgs>? Clustermgr { get; set; }

        [Input("compellent")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecCompellentArgs>? Compellent { get; set; }

        [Input("consul")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecConsulArgs>? Consul { get; set; }

        [Input("control")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecControlArgs>? Control { get; set; }

        [Input("cost")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecCostArgs>? Cost { get; set; }

        [Input("datacloud")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecDatacloudArgs>? Datacloud { get; set; }

        [Input("datadog")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecDatadogArgs>? Datadog { get; set; }

        [Input("db")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecDbArgs>? Db { get; set; }

        [Input("dynatrace")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecDynatraceArgs>? Dynatrace { get; set; }

        [Input("fluent-bit")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecFluent-BitArgs>? Fluent-bit { get; set; }

        [Input("gcp")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecGcpArgs>? Gcp { get; set; }

        /// <summary>
        /// Platform configuration options
        /// </summary>
        [Input("global")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecGlobalArgs>? Global { get; set; }

        [Input("grafana")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecGrafanaArgs>? Grafana { get; set; }

        [Input("group")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecGroupArgs>? Group { get; set; }

        [Input("hds")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecHdsArgs>? Hds { get; set; }

        [Input("history")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecHistoryArgs>? History { get; set; }

        [Input("horizon")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecHorizonArgs>? Horizon { get; set; }

        [Input("hpe3par")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecHpe3parArgs>? Hpe3par { get; set; }

        [Input("hyperflex")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecHyperflexArgs>? Hyperflex { get; set; }

        [Input("hyperv")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecHypervArgs>? Hyperv { get; set; }

        [Input("influxdb")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecInfluxdbArgs>? Influxdb { get; set; }

        [Input("intersight")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecIntersightArgs>? Intersight { get; set; }

        [Input("istio")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecIstioArgs>? Istio { get; set; }

        [Input("istioingress")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecIstioingressArgs>? Istioingress { get; set; }

        [Input("jaeger")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecJaegerArgs>? Jaeger { get; set; }

        [Input("kafka")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecKafkaArgs>? Kafka { get; set; }

        [Input("kubeturbo")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecKubeturboArgs>? Kubeturbo { get; set; }

        [Input("loki")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecLokiArgs>? Loki { get; set; }

        [Input("market")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMarketArgs>? Market { get; set; }

        [Input("mediation-acims")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AcimsArgs>? Mediation-acims { get; set; }

        [Input("mediation-actionscript")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-ActionscriptArgs>? Mediation-actionscript { get; set; }

        [Input("mediation-aix")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AixArgs>? Mediation-aix { get; set; }

        [Input("mediation-apic")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-ApicArgs>? Mediation-apic { get; set; }

        [Input("mediation-appdynamics")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AppdynamicsArgs>? Mediation-appdynamics { get; set; }

        [Input("mediation-appinsights")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AppinsightsArgs>? Mediation-appinsights { get; set; }

        [Input("mediation-aws")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AwsArgs>? Mediation-aws { get; set; }

        [Input("mediation-awsbilling")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AwsbillingArgs>? Mediation-awsbilling { get; set; }

        [Input("mediation-awscost")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AwscostArgs>? Mediation-awscost { get; set; }

        [Input("mediation-awslambda")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AwslambdaArgs>? Mediation-awslambda { get; set; }

        [Input("mediation-azure")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AzureArgs>? Mediation-azure { get; set; }

        [Input("mediation-azurecost")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AzurecostArgs>? Mediation-azurecost { get; set; }

        [Input("mediation-azureea")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AzureeaArgs>? Mediation-azureea { get; set; }

        [Input("mediation-azuresp")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AzurespArgs>? Mediation-azuresp { get; set; }

        [Input("mediation-azurevolumes")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-AzurevolumesArgs>? Mediation-azurevolumes { get; set; }

        [Input("mediation-baremetal")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-BaremetalArgs>? Mediation-baremetal { get; set; }

        [Input("mediation-cloudfoundry")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-CloudfoundryArgs>? Mediation-cloudfoundry { get; set; }

        [Input("mediation-compellent")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-CompellentArgs>? Mediation-compellent { get; set; }

        [Input("mediation-customdata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-CustomdataArgs>? Mediation-customdata { get; set; }

        [Input("mediation-datadog")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-DatadogArgs>? Mediation-datadog { get; set; }

        [Input("mediation-dynatrace")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-DynatraceArgs>? Mediation-dynatrace { get; set; }

        [Input("mediation-gcp")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-GcpArgs>? Mediation-gcp { get; set; }

        [Input("mediation-gcpcost")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-GcpcostArgs>? Mediation-gcpcost { get; set; }

        [Input("mediation-hds")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-HdsArgs>? Mediation-hds { get; set; }

        [Input("mediation-horizon")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-HorizonArgs>? Mediation-horizon { get; set; }

        [Input("mediation-hpe3par")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-Hpe3parArgs>? Mediation-hpe3par { get; set; }

        [Input("mediation-hyperflex")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-HyperflexArgs>? Mediation-hyperflex { get; set; }

        [Input("mediation-hyperv")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-HypervArgs>? Mediation-hyperv { get; set; }

        [Input("mediation-intersight")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-IntersightArgs>? Mediation-intersight { get; set; }

        [Input("mediation-intersighthyperflex")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-IntersighthyperflexArgs>? Mediation-intersighthyperflex { get; set; }

        [Input("mediation-intersightucs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-IntersightucsArgs>? Mediation-intersightucs { get; set; }

        [Input("mediation-istio")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-IstioArgs>? Mediation-istio { get; set; }

        [Input("mediation-mssql")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-MssqlArgs>? Mediation-mssql { get; set; }

        [Input("mediation-mysql")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-MysqlArgs>? Mediation-mysql { get; set; }

        [Input("mediation-netapp")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-NetappArgs>? Mediation-netapp { get; set; }

        [Input("mediation-netflow")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-NetflowArgs>? Mediation-netflow { get; set; }

        [Input("mediation-newrelic")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-NewrelicArgs>? Mediation-newrelic { get; set; }

        [Input("mediation-nutanix")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-NutanixArgs>? Mediation-nutanix { get; set; }

        [Input("mediation-oneview")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-OneviewArgs>? Mediation-oneview { get; set; }

        [Input("mediation-openstack")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-OpenstackArgs>? Mediation-openstack { get; set; }

        [Input("mediation-pivotal")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-PivotalArgs>? Mediation-pivotal { get; set; }

        [Input("mediation-pure")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-PureArgs>? Mediation-pure { get; set; }

        [Input("mediation-rhv")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-RhvArgs>? Mediation-rhv { get; set; }

        [Input("mediation-scaleio")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-ScaleioArgs>? Mediation-scaleio { get; set; }

        [Input("mediation-snmp")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-SnmpArgs>? Mediation-snmp { get; set; }

        [Input("mediation-terraform")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-TerraformArgs>? Mediation-terraform { get; set; }

        [Input("mediation-tetration")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-TetrationArgs>? Mediation-tetration { get; set; }

        [Input("mediation-tomcat")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-TomcatArgs>? Mediation-tomcat { get; set; }

        [Input("mediation-ucs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-UcsArgs>? Mediation-ucs { get; set; }

        [Input("mediation-ucsdirector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-UcsdirectorArgs>? Mediation-ucsdirector { get; set; }

        [Input("mediation-vcd")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-VcdArgs>? Mediation-vcd { get; set; }

        [Input("mediation-vcenter")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-VcenterArgs>? Mediation-vcenter { get; set; }

        [Input("mediation-vcenterbrowsing")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-VcenterbrowsingArgs>? Mediation-vcenterbrowsing { get; set; }

        [Input("mediation-vmax")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-VmaxArgs>? Mediation-vmax { get; set; }

        [Input("mediation-vmm")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-VmmArgs>? Mediation-vmm { get; set; }

        [Input("mediation-vplex")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-VplexArgs>? Mediation-vplex { get; set; }

        [Input("mediation-wmi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-WmiArgs>? Mediation-wmi { get; set; }

        [Input("mediation-xtremio")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMediation-XtremioArgs>? Mediation-xtremio { get; set; }

        [Input("metron")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMetronArgs>? Metron { get; set; }

        [Input("mssql")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMssqlArgs>? Mssql { get; set; }

        [Input("mysql")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecMysqlArgs>? Mysql { get; set; }

        [Input("netapp")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecNetappArgs>? Netapp { get; set; }

        [Input("netflow")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecNetflowArgs>? Netflow { get; set; }

        [Input("newrelic")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecNewrelicArgs>? Newrelic { get; set; }

        [Input("nginxingress")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecNginxingressArgs>? Nginxingress { get; set; }

        [Input("nutanix")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecNutanixArgs>? Nutanix { get; set; }

        [Input("oneview")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecOneviewArgs>? Oneview { get; set; }

        [Input("openshiftingress")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecOpenshiftingressArgs>? Openshiftingress { get; set; }

        [Input("openstack")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecOpenstackArgs>? Openstack { get; set; }

        [Input("pivotal")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecPivotalArgs>? Pivotal { get; set; }

        [Input("plan-orchestrator")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecPlan-OrchestratorArgs>? Plan-orchestrator { get; set; }

        [Input("platform")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecPlatformArgs>? Platform { get; set; }

        [Input("prometheus")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecPrometheusArgs>? Prometheus { get; set; }

        [Input("prometheus-mysql-exporter")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecPrometheus-Mysql-ExporterArgs>? Prometheus-mysql-exporter { get; set; }

        [Input("prometurbo")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecPrometurboArgs>? Prometurbo { get; set; }

        [Input("promtail")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecPromtailArgs>? Promtail { get; set; }

        /// <summary>
        /// Custom property overrides
        /// </summary>
        [Input("properties")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecPropertiesArgs>? Properties { get; set; }

        [Input("pure")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecPureArgs>? Pure { get; set; }

        [Input("repository")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecRepositoryArgs>? Repository { get; set; }

        [Input("rhv")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecRhvArgs>? Rhv { get; set; }

        [Input("rsyslog")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecRsyslogArgs>? Rsyslog { get; set; }

        [Input("scaleio")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecScaleioArgs>? Scaleio { get; set; }

        [Input("snmp")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecSnmpArgs>? Snmp { get; set; }

        [Input("terraform")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecTerraformArgs>? Terraform { get; set; }

        [Input("tetration")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecTetrationArgs>? Tetration { get; set; }

        [Input("timescaledb")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecTimescaledbArgs>? Timescaledb { get; set; }

        [Input("topology-processor")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecTopology-ProcessorArgs>? Topology-processor { get; set; }

        [Input("ucs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecUcsArgs>? Ucs { get; set; }

        [Input("ucsdirector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecUcsdirectorArgs>? Ucsdirector { get; set; }

        [Input("ui")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecUiArgs>? Ui { get; set; }

        [Input("vcd")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecVcdArgs>? Vcd { get; set; }

        [Input("vcenter")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecVcenterArgs>? Vcenter { get; set; }

        [Input("vmax")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecVmaxArgs>? Vmax { get; set; }

        [Input("vmm")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecVmmArgs>? Vmm { get; set; }

        [Input("vplex")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecVplexArgs>? Vplex { get; set; }

        [Input("wmi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecWmiArgs>? Wmi { get; set; }

        [Input("xtremio")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecXtremioArgs>? Xtremio { get; set; }

        [Input("zookeeper")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecZookeeperArgs>? Zookeeper { get; set; }

        public XlSpecArgs()
        {
        }
    }
}
