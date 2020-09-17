// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2
{

    /// <summary>
    /// StandaloneSpec defines the desired state of a Splunk Enterprise standalone instances.
    /// </summary>
    public class StandaloneSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Kubernetes Affinity rules that control how pods are assigned to particular nodes.
        /// </summary>
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneSpecAffinityArgs>? Affinity { get; set; }

        /// <summary>
        /// Inline map of default.yml overrides used to initialize the environment
        /// </summary>
        [Input("defaults")]
        public Input<string>? Defaults { get; set; }

        /// <summary>
        /// Full path or URL for one or more default.yml files, separated by commas
        /// </summary>
        [Input("defaultsUrl")]
        public Input<string>? DefaultsUrl { get; set; }

        /// <summary>
        /// Storage capacity to request for /opt/splunk/etc persistent volume claims (default=”1Gi”)
        /// </summary>
        [Input("etcStorage")]
        public Input<string>? EtcStorage { get; set; }

        /// <summary>
        /// Image to use for Splunk pod containers (overrides RELATED_IMAGE_SPLUNK_ENTERPRISE environment variables)
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// Sets pull policy for all images (either “Always” or the default: “IfNotPresent”)
        /// </summary>
        [Input("imagePullPolicy")]
        public Input<string>? ImagePullPolicy { get; set; }

        /// <summary>
        /// IndexerClusterRef refers to a Splunk Enterprise indexer cluster managed by the operator within Kubernetes
        /// </summary>
        [Input("indexerClusterRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneSpecIndexerClusterRefArgs>? IndexerClusterRef { get; set; }

        /// <summary>
        /// LicenseMasterRef refers to a Splunk Enterprise license master managed by the operator within Kubernetes
        /// </summary>
        [Input("licenseMasterRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneSpecLicenseMasterRefArgs>? LicenseMasterRef { get; set; }

        /// <summary>
        /// Full path or URL for a Splunk Enterprise license file
        /// </summary>
        [Input("licenseUrl")]
        public Input<string>? LicenseUrl { get; set; }

        /// <summary>
        /// Number of standalone pods
        /// </summary>
        [Input("replicas")]
        public Input<int>? Replicas { get; set; }

        /// <summary>
        /// resource requirements for the pod containers
        /// </summary>
        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneSpecResourcesArgs>? Resources { get; set; }

        /// <summary>
        /// Name of Scheduler to use for pod placement (defaults to “default-scheduler”)
        /// </summary>
        [Input("schedulerName")]
        public Input<string>? SchedulerName { get; set; }

        /// <summary>
        /// ServiceTemplate is a template used to create Kubernetes services
        /// </summary>
        [Input("serviceTemplate")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneSpecServiceTemplateArgs>? ServiceTemplate { get; set; }

        /// <summary>
        /// Image to use for Spark pod containers (overrides RELATED_IMAGE_SPLUNK_SPARK environment variables)
        /// </summary>
        [Input("sparkImage")]
        public Input<string>? SparkImage { get; set; }

        /// <summary>
        /// SparkRef refers to a Spark cluster managed by the operator within Kubernetes When defined, Data Fabric Search (DFS) will be enabled and configured to use the Spark cluster.
        /// </summary>
        [Input("sparkRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneSpecSparkRefArgs>? SparkRef { get; set; }

        /// <summary>
        /// Name of StorageClass to use for persistent volume claims
        /// </summary>
        [Input("storageClassName")]
        public Input<string>? StorageClassName { get; set; }

        /// <summary>
        /// Storage capacity to request for /opt/splunk/var persistent volume claims (default=”50Gi”)
        /// </summary>
        [Input("varStorage")]
        public Input<string>? VarStorage { get; set; }

        [Input("volumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneSpecVolumesArgs>? _volumes;

        /// <summary>
        /// List of one or more Kubernetes volumes. These will be mounted in all pod containers as as /mnt/&lt;name&gt;
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneSpecVolumesArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.StandaloneSpecVolumesArgs>());
            set => _volumes = value;
        }

        public StandaloneSpecArgs()
        {
        }
    }
}
