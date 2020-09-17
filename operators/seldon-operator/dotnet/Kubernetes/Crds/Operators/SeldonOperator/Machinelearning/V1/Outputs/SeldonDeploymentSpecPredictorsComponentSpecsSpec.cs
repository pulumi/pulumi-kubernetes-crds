// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1
{

    [OutputType]
    public sealed class SeldonDeploymentSpecPredictorsComponentSpecsSpec
    {
        /// <summary>
        /// Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer.
        /// </summary>
        public readonly int ActiveDeadlineSeconds;
        /// <summary>
        /// If specified, the pod's scheduling constraints
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecAffinity Affinity;
        /// <summary>
        /// AutomountServiceAccountToken indicates whether a service account token should be automatically mounted.
        /// </summary>
        public readonly bool AutomountServiceAccountToken;
        /// <summary>
        /// List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainers> Containers;
        /// <summary>
        /// Specifies the DNS parameters of a pod. Parameters specified here will be merged to the generated DNS configuration based on DNSPolicy.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecDnsConfig DnsConfig;
        /// <summary>
        /// Set DNS policy for the pod. Defaults to "ClusterFirst". Valid values are 'ClusterFirstWithHostNet', 'ClusterFirst', 'Default' or 'None'. DNS parameters given in DNSConfig will be merged with the policy selected with DNSPolicy. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to 'ClusterFirstWithHostNet'.
        /// </summary>
        public readonly string DnsPolicy;
        /// <summary>
        /// EnableServiceLinks indicates whether information about services should be injected into pod's environment variables, matching the syntax of Docker links. Optional: Defaults to true.
        /// </summary>
        public readonly bool EnableServiceLinks;
        /// <summary>
        /// HostAliases is an optional list of hosts and IPs that will be injected into the pod's hosts file if specified. This is only valid for non-hostNetwork pods.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecHostAliases> HostAliases;
        /// <summary>
        /// Use the host's ipc namespace. Optional: Default to false.
        /// </summary>
        public readonly bool HostIPC;
        /// <summary>
        /// Host networking requested for this pod. Use the host's network namespace. If this option is set, the ports that will be used must be specified. Default to false.
        /// </summary>
        public readonly bool HostNetwork;
        /// <summary>
        /// Use the host's pid namespace. Optional: Default to false.
        /// </summary>
        public readonly bool HostPID;
        /// <summary>
        /// Specifies the hostname of the Pod If not specified, the pod's hostname will be set to a system-defined value.
        /// </summary>
        public readonly string Hostname;
        /// <summary>
        /// ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. For example, in the case of docker, only DockerConfig type secrets are honored. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecImagePullSecrets> ImagePullSecrets;
        /// <summary>
        /// List of initialization containers belonging to the pod. Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, or Liveness probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecInitContainers> InitContainers;
        /// <summary>
        /// NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.
        /// </summary>
        public readonly string NodeName;
        /// <summary>
        /// NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        /// </summary>
        public readonly ImmutableDictionary<string, string> NodeSelector;
        /// <summary>
        /// The priority value. Various system components use this field to find the priority of the pod. When Priority Admission Controller is enabled, it prevents users from setting this field. The admission controller populates this field from PriorityClassName. The higher the value, the higher the priority.
        /// </summary>
        public readonly int Priority;
        /// <summary>
        /// If specified, indicates the pod's priority. "system-node-critical" and "system-cluster-critical" are two special keywords which indicate the highest priorities with the former being the highest priority. Any other name must be defined by creating a PriorityClass object with that name. If not specified, the pod priority will be default or zero if there is no default.
        /// </summary>
        public readonly string PriorityClassName;
        /// <summary>
        /// If specified, all readiness gates will be evaluated for pod readiness. A pod is ready when all its containers are ready AND all conditions specified in the readiness gates have status equal to "True" More info: https://git.k8s.io/enhancements/keps/sig-network/0007-pod-ready%2B%2B.md
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecReadinessGates> ReadinessGates;
        /// <summary>
        /// Restart policy for all containers within the pod. One of Always, OnFailure, Never. Default to Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy
        /// </summary>
        public readonly string RestartPolicy;
        /// <summary>
        /// RuntimeClassName refers to a RuntimeClass object in the node.k8s.io group, which should be used to run this pod.  If no RuntimeClass resource matches the named class, the pod will not be run. If unset or empty, the "legacy" RuntimeClass will be used, which is an implicit class with an empty definition that uses the default runtime handler. More info: https://git.k8s.io/enhancements/keps/sig-node/runtime-class.md This is an alpha feature and may change in the future.
        /// </summary>
        public readonly string RuntimeClassName;
        /// <summary>
        /// If specified, the pod will be dispatched by specified scheduler. If not specified, the pod will be dispatched by default scheduler.
        /// </summary>
        public readonly string SchedulerName;
        /// <summary>
        /// SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecSecurityContext SecurityContext;
        /// <summary>
        /// DeprecatedServiceAccount is a depreciated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead.
        /// </summary>
        public readonly string ServiceAccount;
        /// <summary>
        /// ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/
        /// </summary>
        public readonly string ServiceAccountName;
        /// <summary>
        /// Share a single process namespace between all of the containers in a pod. When this is set containers will be able to view and signal processes from other containers in the same pod, and the first process in each container will not be assigned PID 1. HostPID and ShareProcessNamespace cannot both be set. Optional: Default to false. This field is beta-level and may be disabled with the PodShareProcessNamespace feature.
        /// </summary>
        public readonly bool ShareProcessNamespace;
        /// <summary>
        /// If specified, the fully qualified Pod hostname will be "&lt;hostname&gt;.&lt;subdomain&gt;.&lt;pod namespace&gt;.svc.&lt;cluster domain&gt;". If not specified, the pod will not have a domainname at all.
        /// </summary>
        public readonly string Subdomain;
        /// <summary>
        /// Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.
        /// </summary>
        public readonly int TerminationGracePeriodSeconds;
        /// <summary>
        /// If specified, the pod's tolerations.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecTolerations> Tolerations;
        /// <summary>
        /// List of volumes that can be mounted by containers belonging to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes
        /// </summary>
        public readonly ImmutableArray<ImmutableDictionary<string, object>> Volumes;

        [OutputConstructor]
        private SeldonDeploymentSpecPredictorsComponentSpecsSpec(
            int activeDeadlineSeconds,

            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecAffinity affinity,

            bool automountServiceAccountToken,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainers> containers,

            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecDnsConfig dnsConfig,

            string dnsPolicy,

            bool enableServiceLinks,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecHostAliases> hostAliases,

            bool hostIPC,

            bool hostNetwork,

            bool hostPID,

            string hostname,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecImagePullSecrets> imagePullSecrets,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecInitContainers> initContainers,

            string nodeName,

            ImmutableDictionary<string, string> nodeSelector,

            int priority,

            string priorityClassName,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecReadinessGates> readinessGates,

            string restartPolicy,

            string runtimeClassName,

            string schedulerName,

            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecSecurityContext securityContext,

            string serviceAccount,

            string serviceAccountName,

            bool shareProcessNamespace,

            string subdomain,

            int terminationGracePeriodSeconds,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecTolerations> tolerations,

            ImmutableArray<ImmutableDictionary<string, object>> volumes)
        {
            ActiveDeadlineSeconds = activeDeadlineSeconds;
            Affinity = affinity;
            AutomountServiceAccountToken = automountServiceAccountToken;
            Containers = containers;
            DnsConfig = dnsConfig;
            DnsPolicy = dnsPolicy;
            EnableServiceLinks = enableServiceLinks;
            HostAliases = hostAliases;
            HostIPC = hostIPC;
            HostNetwork = hostNetwork;
            HostPID = hostPID;
            Hostname = hostname;
            ImagePullSecrets = imagePullSecrets;
            InitContainers = initContainers;
            NodeName = nodeName;
            NodeSelector = nodeSelector;
            Priority = priority;
            PriorityClassName = priorityClassName;
            ReadinessGates = readinessGates;
            RestartPolicy = restartPolicy;
            RuntimeClassName = runtimeClassName;
            SchedulerName = schedulerName;
            SecurityContext = securityContext;
            ServiceAccount = serviceAccount;
            ServiceAccountName = serviceAccountName;
            ShareProcessNamespace = shareProcessNamespace;
            Subdomain = subdomain;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            Tolerations = tolerations;
            Volumes = volumes;
        }
    }
}
