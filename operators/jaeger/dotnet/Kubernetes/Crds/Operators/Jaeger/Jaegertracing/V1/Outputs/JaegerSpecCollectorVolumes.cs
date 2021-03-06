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
    public sealed class JaegerSpecCollectorVolumes
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesAwsElasticBlockStore AwsElasticBlockStore;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesAzureDisk AzureDisk;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesAzureFile AzureFile;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesCephfs Cephfs;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesCinder Cinder;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesConfigMap ConfigMap;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesCsi Csi;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesDownwardAPI DownwardAPI;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesEmptyDir EmptyDir;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesFc Fc;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesFlexVolume FlexVolume;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesFlocker Flocker;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesGcePersistentDisk GcePersistentDisk;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesGitRepo GitRepo;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesGlusterfs Glusterfs;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesHostPath HostPath;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesIscsi Iscsi;
        public readonly string Name;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesNfs Nfs;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesPersistentVolumeClaim PersistentVolumeClaim;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesPhotonPersistentDisk PhotonPersistentDisk;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesPortworxVolume PortworxVolume;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesProjected Projected;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesQuobyte Quobyte;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesRbd Rbd;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesScaleIO ScaleIO;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesSecret Secret;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesStorageos Storageos;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesVsphereVolume VsphereVolume;

        [OutputConstructor]
        private JaegerSpecCollectorVolumes(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesAwsElasticBlockStore awsElasticBlockStore,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesAzureDisk azureDisk,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesAzureFile azureFile,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesCephfs cephfs,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesCinder cinder,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesConfigMap configMap,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesCsi csi,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesDownwardAPI downwardAPI,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesEmptyDir emptyDir,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesFc fc,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesFlexVolume flexVolume,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesFlocker flocker,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesGcePersistentDisk gcePersistentDisk,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesGitRepo gitRepo,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesGlusterfs glusterfs,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesHostPath hostPath,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesIscsi iscsi,

            string name,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesNfs nfs,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesPersistentVolumeClaim persistentVolumeClaim,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesPhotonPersistentDisk photonPersistentDisk,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesPortworxVolume portworxVolume,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesProjected projected,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesQuobyte quobyte,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesRbd rbd,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesScaleIO scaleIO,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesSecret secret,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesStorageos storageos,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecCollectorVolumesVsphereVolume vsphereVolume)
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
