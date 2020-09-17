// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1
{

    [OutputType]
    public sealed class FioSpecVolumeVolumeSource
    {
        /// <summary>
        /// AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceAwsElasticBlockStore AwsElasticBlockStore;
        /// <summary>
        /// AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceAzureDisk AzureDisk;
        /// <summary>
        /// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceAzureFile AzureFile;
        /// <summary>
        /// CephFS represents a Ceph FS mount on the host that shares a pod's lifetime
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceCephfs Cephfs;
        /// <summary>
        /// Cinder represents a cinder volume attached and mounted on kubelets host machine More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceCinder Cinder;
        /// <summary>
        /// ConfigMap represents a configMap that should populate this volume
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceConfigMap ConfigMap;
        /// <summary>
        /// CSI (Container Storage Interface) represents storage that is handled by an external CSI driver (Alpha feature).
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceCsi Csi;
        /// <summary>
        /// DownwardAPI represents downward API about the pod that should populate this volume
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceDownwardAPI DownwardAPI;
        /// <summary>
        /// EmptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceEmptyDir EmptyDir;
        /// <summary>
        /// FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceFc Fc;
        /// <summary>
        /// FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceFlexVolume FlexVolume;
        /// <summary>
        /// Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceFlocker Flocker;
        /// <summary>
        /// GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceGcePersistentDisk GcePersistentDisk;
        /// <summary>
        /// GitRepo represents a git repository at a particular revision. DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceGitRepo GitRepo;
        /// <summary>
        /// Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceGlusterfs Glusterfs;
        /// <summary>
        /// HostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath --- TODO(jonesdl) We need to restrict who can use host directory mounts and who can/can not mount host directories as read/write.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceHostPath HostPath;
        /// <summary>
        /// ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://releases.k8s.io/HEAD/examples/volumes/iscsi/README.md
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceIscsi Iscsi;
        /// <summary>
        /// NFS represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceNfs Nfs;
        /// <summary>
        /// PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourcePersistentVolumeClaim PersistentVolumeClaim;
        /// <summary>
        /// PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourcePhotonPersistentDisk PhotonPersistentDisk;
        /// <summary>
        /// PortworxVolume represents a portworx volume attached and mounted on kubelets host machine
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourcePortworxVolume PortworxVolume;
        /// <summary>
        /// Items for all in one resources secrets, configmaps, and downward API
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjected Projected;
        /// <summary>
        /// Quobyte represents a Quobyte mount on the host that shares a pod's lifetime
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceQuobyte Quobyte;
        /// <summary>
        /// RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceRbd Rbd;
        /// <summary>
        /// ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceScaleIO ScaleIO;
        /// <summary>
        /// Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceSecret Secret;
        /// <summary>
        /// StorageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceStorageos Storageos;
        /// <summary>
        /// VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceVsphereVolume VsphereVolume;

        [OutputConstructor]
        private FioSpecVolumeVolumeSource(
            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceAwsElasticBlockStore awsElasticBlockStore,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceAzureDisk azureDisk,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceAzureFile azureFile,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceCephfs cephfs,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceCinder cinder,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceConfigMap configMap,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceCsi csi,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceDownwardAPI downwardAPI,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceEmptyDir emptyDir,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceFc fc,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceFlexVolume flexVolume,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceFlocker flocker,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceGcePersistentDisk gcePersistentDisk,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceGitRepo gitRepo,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceGlusterfs glusterfs,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceHostPath hostPath,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceIscsi iscsi,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceNfs nfs,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourcePersistentVolumeClaim persistentVolumeClaim,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourcePhotonPersistentDisk photonPersistentDisk,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourcePortworxVolume portworxVolume,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjected projected,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceQuobyte quobyte,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceRbd rbd,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceScaleIO scaleIO,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceSecret secret,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceStorageos storageos,

            Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceVsphereVolume vsphereVolume)
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