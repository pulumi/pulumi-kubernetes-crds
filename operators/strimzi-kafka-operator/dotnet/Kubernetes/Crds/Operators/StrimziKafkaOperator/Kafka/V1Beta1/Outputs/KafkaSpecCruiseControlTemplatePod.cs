// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1
{

    [OutputType]
    public sealed class KafkaSpecCruiseControlTemplatePod
    {
        /// <summary>
        /// The pod's affinity rules.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodAffinity Affinity;
        /// <summary>
        /// List of references to secrets in the same namespace to use for pulling any of the images used by this Pod. When the `STRIMZI_IMAGE_PULL_SECRETS` environment variable in Cluster Operator and the `imagePullSecrets` option are specified, only the `imagePullSecrets` variable is used and the `STRIMZI_IMAGE_PULL_SECRETS` variable is ignored.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodImagePullSecrets> ImagePullSecrets;
        /// <summary>
        /// Metadata applied to the resource.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodMetadata Metadata;
        /// <summary>
        /// The name of the priority class used to assign priority to the pods. For more information about priority classes, see {K8sPriorityClass}.
        /// </summary>
        public readonly string PriorityClassName;
        /// <summary>
        /// The name of the scheduler used to dispatch this `Pod`. If not specified, the default scheduler will be used.
        /// </summary>
        public readonly string SchedulerName;
        /// <summary>
        /// Configures pod-level security attributes and common container settings.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodSecurityContext SecurityContext;
        /// <summary>
        /// The grace period is the duration in seconds after the processes running in the pod are sent a termination signal, and the time when the processes are forcibly halted with a kill signal. Set this value to longer than the expected cleanup time for your process. Value must be a non-negative integer. A zero value indicates delete immediately. You might need to increase the grace period for very large Kafka clusters, so that the Kafka brokers have enough time to transfer their work to another broker before they are terminated. Defaults to 30 seconds.
        /// </summary>
        public readonly int TerminationGracePeriodSeconds;
        /// <summary>
        /// The pod's tolerations.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodTolerations> Tolerations;

        [OutputConstructor]
        private KafkaSpecCruiseControlTemplatePod(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodAffinity affinity,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodImagePullSecrets> imagePullSecrets,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodMetadata metadata,

            string priorityClassName,

            string schedulerName,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodSecurityContext securityContext,

            int terminationGracePeriodSeconds,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecCruiseControlTemplatePodTolerations> tolerations)
        {
            Affinity = affinity;
            ImagePullSecrets = imagePullSecrets;
            Metadata = metadata;
            PriorityClassName = priorityClassName;
            SchedulerName = schedulerName;
            SecurityContext = securityContext;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            Tolerations = tolerations;
        }
    }
}
