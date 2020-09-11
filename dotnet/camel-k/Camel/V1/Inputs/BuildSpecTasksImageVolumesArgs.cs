// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Camel.V1
{

    /// <summary>
    /// Volume represents a named volume in a pod that may be accessed by any container in the pod.
    /// </summary>
    public class BuildSpecTasksImageVolumesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        [Input("awsElasticBlockStore")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesAwsElasticBlockStoreArgs>? AwsElasticBlockStore { get; set; }

        /// <summary>
        /// AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
        /// </summary>
        [Input("azureDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesAzureDiskArgs>? AzureDisk { get; set; }

        /// <summary>
        /// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
        /// </summary>
        [Input("azureFile")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesAzureFileArgs>? AzureFile { get; set; }

        /// <summary>
        /// CephFS represents a Ceph FS mount on the host that shares a pod's lifetime
        /// </summary>
        [Input("cephfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesCephfsArgs>? Cephfs { get; set; }

        /// <summary>
        /// Cinder represents a cinder volume attached and mounted on kubelets host machine. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        /// </summary>
        [Input("cinder")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesCinderArgs>? Cinder { get; set; }

        /// <summary>
        /// ConfigMap represents a configMap that should populate this volume
        /// </summary>
        [Input("configMap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesConfigMapArgs>? ConfigMap { get; set; }

        /// <summary>
        /// CSI (Container Storage Interface) represents storage that is handled by an external CSI driver (Alpha feature).
        /// </summary>
        [Input("csi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesCsiArgs>? Csi { get; set; }

        /// <summary>
        /// DownwardAPI represents downward API about the pod that should populate this volume
        /// </summary>
        [Input("downwardAPI")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesDownwardAPIArgs>? DownwardAPI { get; set; }

        /// <summary>
        /// EmptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
        /// </summary>
        [Input("emptyDir")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesEmptyDirArgs>? EmptyDir { get; set; }

        /// <summary>
        /// FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.
        /// </summary>
        [Input("fc")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesFcArgs>? Fc { get; set; }

        /// <summary>
        /// FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.
        /// </summary>
        [Input("flexVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesFlexVolumeArgs>? FlexVolume { get; set; }

        /// <summary>
        /// Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running
        /// </summary>
        [Input("flocker")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesFlockerArgs>? Flocker { get; set; }

        /// <summary>
        /// GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [Input("gcePersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesGcePersistentDiskArgs>? GcePersistentDisk { get; set; }

        /// <summary>
        /// GitRepo represents a git repository at a particular revision. DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.
        /// </summary>
        [Input("gitRepo")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesGitRepoArgs>? GitRepo { get; set; }

        /// <summary>
        /// Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/glusterfs/README.md
        /// </summary>
        [Input("glusterfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesGlusterfsArgs>? Glusterfs { get; set; }

        /// <summary>
        /// HostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath --- TODO(jonesdl) We need to restrict who can use host directory mounts and who can/can not mount host directories as read/write.
        /// </summary>
        [Input("hostPath")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesHostPathArgs>? HostPath { get; set; }

        /// <summary>
        /// ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://examples.k8s.io/volumes/iscsi/README.md
        /// </summary>
        [Input("iscsi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesIscsiArgs>? Iscsi { get; set; }

        /// <summary>
        /// Volume's name. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// NFS represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        [Input("nfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesNfsArgs>? Nfs { get; set; }

        /// <summary>
        /// PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        [Input("persistentVolumeClaim")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesPersistentVolumeClaimArgs>? PersistentVolumeClaim { get; set; }

        /// <summary>
        /// PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine
        /// </summary>
        [Input("photonPersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesPhotonPersistentDiskArgs>? PhotonPersistentDisk { get; set; }

        /// <summary>
        /// PortworxVolume represents a portworx volume attached and mounted on kubelets host machine
        /// </summary>
        [Input("portworxVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesPortworxVolumeArgs>? PortworxVolume { get; set; }

        /// <summary>
        /// Items for all in one resources secrets, configmaps, and downward API
        /// </summary>
        [Input("projected")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesProjectedArgs>? Projected { get; set; }

        /// <summary>
        /// Quobyte represents a Quobyte mount on the host that shares a pod's lifetime
        /// </summary>
        [Input("quobyte")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesQuobyteArgs>? Quobyte { get; set; }

        /// <summary>
        /// RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/rbd/README.md
        /// </summary>
        [Input("rbd")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesRbdArgs>? Rbd { get; set; }

        /// <summary>
        /// ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.
        /// </summary>
        [Input("scaleIO")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesScaleIOArgs>? ScaleIO { get; set; }

        /// <summary>
        /// Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
        /// </summary>
        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesSecretArgs>? Secret { get; set; }

        /// <summary>
        /// StorageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.
        /// </summary>
        [Input("storageos")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesStorageosArgs>? Storageos { get; set; }

        /// <summary>
        /// VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine
        /// </summary>
        [Input("vsphereVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksImageVolumesVsphereVolumeArgs>? VsphereVolume { get; set; }

        public BuildSpecTasksImageVolumesArgs()
        {
        }
    }
}
