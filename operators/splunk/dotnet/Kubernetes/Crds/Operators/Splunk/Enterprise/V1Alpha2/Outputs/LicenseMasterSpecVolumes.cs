// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2
{

    [OutputType]
    public sealed class LicenseMasterSpecVolumes
    {
        /// <summary>
        /// AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesAwsElasticBlockStore AwsElasticBlockStore;
        /// <summary>
        /// AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesAzureDisk AzureDisk;
        /// <summary>
        /// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesAzureFile AzureFile;
        /// <summary>
        /// CephFS represents a Ceph FS mount on the host that shares a pod's lifetime
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesCephfs Cephfs;
        /// <summary>
        /// Cinder represents a cinder volume attached and mounted on kubelets host machine. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesCinder Cinder;
        /// <summary>
        /// ConfigMap represents a configMap that should populate this volume
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesConfigMap ConfigMap;
        /// <summary>
        /// CSI (Container Storage Interface) represents storage that is handled by an external CSI driver (Alpha feature).
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesCsi Csi;
        /// <summary>
        /// DownwardAPI represents downward API about the pod that should populate this volume
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesDownwardAPI DownwardAPI;
        /// <summary>
        /// EmptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesEmptyDir EmptyDir;
        /// <summary>
        /// FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesFc Fc;
        /// <summary>
        /// FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesFlexVolume FlexVolume;
        /// <summary>
        /// Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesFlocker Flocker;
        /// <summary>
        /// GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesGcePersistentDisk GcePersistentDisk;
        /// <summary>
        /// GitRepo represents a git repository at a particular revision. DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesGitRepo GitRepo;
        /// <summary>
        /// Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/glusterfs/README.md
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesGlusterfs Glusterfs;
        /// <summary>
        /// HostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath --- TODO(jonesdl) We need to restrict who can use host directory mounts and who can/can not mount host directories as read/write.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesHostPath HostPath;
        /// <summary>
        /// ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://examples.k8s.io/volumes/iscsi/README.md
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesIscsi Iscsi;
        /// <summary>
        /// Volume's name. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// NFS represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesNfs Nfs;
        /// <summary>
        /// PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesPersistentVolumeClaim PersistentVolumeClaim;
        /// <summary>
        /// PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesPhotonPersistentDisk PhotonPersistentDisk;
        /// <summary>
        /// PortworxVolume represents a portworx volume attached and mounted on kubelets host machine
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesPortworxVolume PortworxVolume;
        /// <summary>
        /// Items for all in one resources secrets, configmaps, and downward API
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesProjected Projected;
        /// <summary>
        /// Quobyte represents a Quobyte mount on the host that shares a pod's lifetime
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesQuobyte Quobyte;
        /// <summary>
        /// RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/rbd/README.md
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesRbd Rbd;
        /// <summary>
        /// ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesScaleIO ScaleIO;
        /// <summary>
        /// Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesSecret Secret;
        /// <summary>
        /// StorageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesStorageos Storageos;
        /// <summary>
        /// VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesVsphereVolume VsphereVolume;

        [OutputConstructor]
        private LicenseMasterSpecVolumes(
            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesAwsElasticBlockStore awsElasticBlockStore,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesAzureDisk azureDisk,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesAzureFile azureFile,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesCephfs cephfs,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesCinder cinder,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesConfigMap configMap,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesCsi csi,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesDownwardAPI downwardAPI,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesEmptyDir emptyDir,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesFc fc,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesFlexVolume flexVolume,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesFlocker flocker,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesGcePersistentDisk gcePersistentDisk,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesGitRepo gitRepo,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesGlusterfs glusterfs,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesHostPath hostPath,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesIscsi iscsi,

            string name,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesNfs nfs,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesPersistentVolumeClaim persistentVolumeClaim,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesPhotonPersistentDisk photonPersistentDisk,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesPortworxVolume portworxVolume,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesProjected projected,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesQuobyte quobyte,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesRbd rbd,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesScaleIO scaleIO,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesSecret secret,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesStorageos storageos,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.LicenseMasterSpecVolumesVsphereVolume vsphereVolume)
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