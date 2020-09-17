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
    /// SparkSpec defines the desired state of a Spark cluster
    /// </summary>
    public class SparkSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Kubernetes Affinity rules that control how pods are assigned to particular nodes.
        /// </summary>
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SparkSpecAffinityArgs>? Affinity { get; set; }

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
        /// Number of spark worker pods
        /// </summary>
        [Input("replicas")]
        public Input<int>? Replicas { get; set; }

        /// <summary>
        /// resource requirements for the pod containers
        /// </summary>
        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SparkSpecResourcesArgs>? Resources { get; set; }

        /// <summary>
        /// Name of Scheduler to use for pod placement (defaults to “default-scheduler”)
        /// </summary>
        [Input("schedulerName")]
        public Input<string>? SchedulerName { get; set; }

        /// <summary>
        /// ServiceTemplate is a template used to create Kubernetes services
        /// </summary>
        [Input("serviceTemplate")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Enterprise.V1Alpha2.SparkSpecServiceTemplateArgs>? ServiceTemplate { get; set; }

        public SparkSpecArgs()
        {
        }
    }
}