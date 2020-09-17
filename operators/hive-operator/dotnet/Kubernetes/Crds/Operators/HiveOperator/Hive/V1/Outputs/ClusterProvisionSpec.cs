// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class ClusterProvisionSpec
    {
        /// <summary>
        /// AdminKubeconfigSecretRef references the secret containing the admin kubeconfig for this cluster.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecAdminKubeconfigSecretRef AdminKubeconfigSecretRef;
        /// <summary>
        /// AdminPasswordSecretRef references the secret containing the admin username/password which can be used to login to this cluster.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecAdminPasswordSecretRef AdminPasswordSecretRef;
        /// <summary>
        /// Attempt is which attempt number of the cluster deployment that this ClusterProvision is
        /// </summary>
        public readonly int Attempt;
        /// <summary>
        /// ClusterDeploymentRef references the cluster deployment provisioned.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecClusterDeploymentRef ClusterDeploymentRef;
        /// <summary>
        /// ClusterID is a globally unique identifier for this cluster generated during installation. Used for reporting metrics among other places.
        /// </summary>
        public readonly string ClusterID;
        /// <summary>
        /// InfraID is an identifier for this cluster generated during installation and used for tagging/naming resources in cloud providers.
        /// </summary>
        public readonly string InfraID;
        /// <summary>
        /// InstallLog is the log from the installer.
        /// </summary>
        public readonly string InstallLog;
        /// <summary>
        /// Metadata is the metadata.json generated by the installer, providing metadata information about the cluster created.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Metadata;
        /// <summary>
        /// PodSpec is the spec to use for the installer pod.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpec PodSpec;
        /// <summary>
        /// PrevClusterID is the cluster ID of the previous failed provision attempt.
        /// </summary>
        public readonly string PrevClusterID;
        /// <summary>
        /// PrevInfraID is the infra ID of the previous failed provision attempt.
        /// </summary>
        public readonly string PrevInfraID;
        /// <summary>
        /// Stage is the stage of provisioning that the cluster deployment has reached.
        /// </summary>
        public readonly string Stage;

        [OutputConstructor]
        private ClusterProvisionSpec(
            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecAdminKubeconfigSecretRef adminKubeconfigSecretRef,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecAdminPasswordSecretRef adminPasswordSecretRef,

            int attempt,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecClusterDeploymentRef clusterDeploymentRef,

            string clusterID,

            string infraID,

            string installLog,

            ImmutableDictionary<string, object> metadata,

            Pulumi.Kubernetes.Types.Outputs.Hive.V1.ClusterProvisionSpecPodSpec podSpec,

            string prevClusterID,

            string prevInfraID,

            string stage)
        {
            AdminKubeconfigSecretRef = adminKubeconfigSecretRef;
            AdminPasswordSecretRef = adminPasswordSecretRef;
            Attempt = attempt;
            ClusterDeploymentRef = clusterDeploymentRef;
            ClusterID = clusterID;
            InfraID = infraID;
            InstallLog = installLog;
            Metadata = metadata;
            PodSpec = podSpec;
            PrevClusterID = prevClusterID;
            PrevInfraID = prevInfraID;
            Stage = stage;
        }
    }
}