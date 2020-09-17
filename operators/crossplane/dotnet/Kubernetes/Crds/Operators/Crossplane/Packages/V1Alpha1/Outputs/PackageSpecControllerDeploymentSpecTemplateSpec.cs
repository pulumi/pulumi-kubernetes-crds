// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1
{

    [OutputType]
    public sealed class PackageSpecControllerDeploymentSpecTemplateSpec
    {
        public readonly int ActiveDeadlineSeconds;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecAffinity Affinity;
        public readonly bool AutomountServiceAccountToken;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecContainers> Containers;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecDnsConfig DnsConfig;
        public readonly string DnsPolicy;
        public readonly bool EnableServiceLinks;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecEphemeralContainers> EphemeralContainers;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecHostAliases> HostAliases;
        public readonly bool HostIPC;
        public readonly bool HostNetwork;
        public readonly bool HostPID;
        public readonly string Hostname;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecImagePullSecrets> ImagePullSecrets;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecInitContainers> InitContainers;
        public readonly string NodeName;
        public readonly ImmutableDictionary<string, string> NodeSelector;
        public readonly ImmutableDictionary<string, string> Overhead;
        public readonly string PreemptionPolicy;
        public readonly int Priority;
        public readonly string PriorityClassName;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecReadinessGates> ReadinessGates;
        public readonly string RestartPolicy;
        public readonly string RuntimeClassName;
        public readonly string SchedulerName;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecSecurityContext SecurityContext;
        public readonly string ServiceAccount;
        public readonly string ServiceAccountName;
        public readonly bool ShareProcessNamespace;
        public readonly string Subdomain;
        public readonly int TerminationGracePeriodSeconds;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecTolerations> Tolerations;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecTopologySpreadConstraints> TopologySpreadConstraints;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumes> Volumes;

        [OutputConstructor]
        private PackageSpecControllerDeploymentSpecTemplateSpec(
            int activeDeadlineSeconds,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecAffinity affinity,

            bool automountServiceAccountToken,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecContainers> containers,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecDnsConfig dnsConfig,

            string dnsPolicy,

            bool enableServiceLinks,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecEphemeralContainers> ephemeralContainers,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecHostAliases> hostAliases,

            bool hostIPC,

            bool hostNetwork,

            bool hostPID,

            string hostname,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecImagePullSecrets> imagePullSecrets,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecInitContainers> initContainers,

            string nodeName,

            ImmutableDictionary<string, string> nodeSelector,

            ImmutableDictionary<string, string> overhead,

            string preemptionPolicy,

            int priority,

            string priorityClassName,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecReadinessGates> readinessGates,

            string restartPolicy,

            string runtimeClassName,

            string schedulerName,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecSecurityContext securityContext,

            string serviceAccount,

            string serviceAccountName,

            bool shareProcessNamespace,

            string subdomain,

            int terminationGracePeriodSeconds,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecTolerations> tolerations,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecTopologySpreadConstraints> topologySpreadConstraints,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumes> volumes)
        {
            ActiveDeadlineSeconds = activeDeadlineSeconds;
            Affinity = affinity;
            AutomountServiceAccountToken = automountServiceAccountToken;
            Containers = containers;
            DnsConfig = dnsConfig;
            DnsPolicy = dnsPolicy;
            EnableServiceLinks = enableServiceLinks;
            EphemeralContainers = ephemeralContainers;
            HostAliases = hostAliases;
            HostIPC = hostIPC;
            HostNetwork = hostNetwork;
            HostPID = hostPID;
            Hostname = hostname;
            ImagePullSecrets = imagePullSecrets;
            InitContainers = initContainers;
            NodeName = nodeName;
            NodeSelector = nodeSelector;
            Overhead = overhead;
            PreemptionPolicy = preemptionPolicy;
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
            TopologySpreadConstraints = topologySpreadConstraints;
            Volumes = volumes;
        }
    }
}