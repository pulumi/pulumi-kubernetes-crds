// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    /// <summary>
    /// Template for Cruise Control `Pods`.
    /// </summary>
    public class KafkaSpecCruiseControlTemplatePodArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The pod's affinity rules.
        /// </summary>
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodAffinityArgs>? Affinity { get; set; }

        [Input("hostAliases")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodHostAliasesArgs>? _hostAliases;

        /// <summary>
        /// The pod's HostAliases. HostAliases is an optional list of hosts and IPs that will be injected into the pod's hosts file if specified.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodHostAliasesArgs> HostAliases
        {
            get => _hostAliases ?? (_hostAliases = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodHostAliasesArgs>());
            set => _hostAliases = value;
        }

        [Input("imagePullSecrets")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodImagePullSecretsArgs>? _imagePullSecrets;

        /// <summary>
        /// List of references to secrets in the same namespace to use for pulling any of the images used by this Pod. When the `STRIMZI_IMAGE_PULL_SECRETS` environment variable in Cluster Operator and the `imagePullSecrets` option are specified, only the `imagePullSecrets` variable is used and the `STRIMZI_IMAGE_PULL_SECRETS` variable is ignored.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodImagePullSecretsArgs> ImagePullSecrets
        {
            get => _imagePullSecrets ?? (_imagePullSecrets = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodImagePullSecretsArgs>());
            set => _imagePullSecrets = value;
        }

        /// <summary>
        /// Metadata applied to the resource.
        /// </summary>
        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodMetadataArgs>? Metadata { get; set; }

        /// <summary>
        /// The name of the priority class used to assign priority to the pods. For more information about priority classes, see {K8sPriorityClass}.
        /// </summary>
        [Input("priorityClassName")]
        public Input<string>? PriorityClassName { get; set; }

        /// <summary>
        /// The name of the scheduler used to dispatch this `Pod`. If not specified, the default scheduler will be used.
        /// </summary>
        [Input("schedulerName")]
        public Input<string>? SchedulerName { get; set; }

        /// <summary>
        /// Configures pod-level security attributes and common container settings.
        /// </summary>
        [Input("securityContext")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodSecurityContextArgs>? SecurityContext { get; set; }

        /// <summary>
        /// The grace period is the duration in seconds after the processes running in the pod are sent a termination signal, and the time when the processes are forcibly halted with a kill signal. Set this value to longer than the expected cleanup time for your process. Value must be a non-negative integer. A zero value indicates delete immediately. You might need to increase the grace period for very large Kafka clusters, so that the Kafka brokers have enough time to transfer their work to another broker before they are terminated. Defaults to 30 seconds.
        /// </summary>
        [Input("terminationGracePeriodSeconds")]
        public Input<int>? TerminationGracePeriodSeconds { get; set; }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodTolerationsArgs>? _tolerations;

        /// <summary>
        /// The pod's tolerations.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodTolerationsArgs>());
            set => _tolerations = value;
        }

        public KafkaSpecCruiseControlTemplatePodArgs()
        {
        }
    }
}
