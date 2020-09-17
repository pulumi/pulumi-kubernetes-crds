// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1
{

    [OutputType]
    public sealed class JaegerSpecAgentVolumes
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesAwsElasticBlockStore AwsElasticBlockStore;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesAzureDisk AzureDisk;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesAzureFile AzureFile;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesCephfs Cephfs;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesCinder Cinder;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesConfigMap ConfigMap;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesCsi Csi;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesDownwardAPI DownwardAPI;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesEmptyDir EmptyDir;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesFc Fc;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesFlexVolume FlexVolume;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesFlocker Flocker;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesGcePersistentDisk GcePersistentDisk;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesGitRepo GitRepo;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesGlusterfs Glusterfs;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesHostPath HostPath;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesIscsi Iscsi;
        public readonly string Name;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesNfs Nfs;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesPersistentVolumeClaim PersistentVolumeClaim;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesPhotonPersistentDisk PhotonPersistentDisk;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesPortworxVolume PortworxVolume;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesProjected Projected;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesQuobyte Quobyte;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesRbd Rbd;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesScaleIO ScaleIO;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesSecret Secret;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesStorageos Storageos;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesVsphereVolume VsphereVolume;

        [OutputConstructor]
        private JaegerSpecAgentVolumes(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesAwsElasticBlockStore awsElasticBlockStore,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesAzureDisk azureDisk,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesAzureFile azureFile,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesCephfs cephfs,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesCinder cinder,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesConfigMap configMap,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesCsi csi,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesDownwardAPI downwardAPI,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesEmptyDir emptyDir,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesFc fc,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesFlexVolume flexVolume,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesFlocker flocker,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesGcePersistentDisk gcePersistentDisk,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesGitRepo gitRepo,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesGlusterfs glusterfs,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesHostPath hostPath,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesIscsi iscsi,

            string name,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesNfs nfs,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesPersistentVolumeClaim persistentVolumeClaim,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesPhotonPersistentDisk photonPersistentDisk,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesPortworxVolume portworxVolume,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesProjected projected,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesQuobyte quobyte,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesRbd rbd,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesScaleIO scaleIO,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesSecret secret,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesStorageos storageos,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecAgentVolumesVsphereVolume vsphereVolume)
        {
            AwsElasticBlockStore = awsElasticBlockStore;
            AzureDisk = azureDisk;
            AzureFile = azureFile;
            Cephfs = cephfs;
            Cinder = cinder;
            ConfigMap = configMap;
            Csi = csi;
            DownwardAPI = downwardAPI;
            EmptyDir = emptyDir;
            Fc = fc;
            FlexVolume = flexVolume;
            Flocker = flocker;
            GcePersistentDisk = gcePersistentDisk;
            GitRepo = gitRepo;
            Glusterfs = glusterfs;
            HostPath = hostPath;
            Iscsi = iscsi;
            Name = name;
            Nfs = nfs;
            PersistentVolumeClaim = persistentVolumeClaim;
            PhotonPersistentDisk = photonPersistentDisk;
            PortworxVolume = portworxVolume;
            Projected = projected;
            Quobyte = quobyte;
            Rbd = rbd;
            ScaleIO = scaleIO;
            Secret = secret;
            Storageos = storageos;
            VsphereVolume = vsphereVolume;
        }
    }
}
