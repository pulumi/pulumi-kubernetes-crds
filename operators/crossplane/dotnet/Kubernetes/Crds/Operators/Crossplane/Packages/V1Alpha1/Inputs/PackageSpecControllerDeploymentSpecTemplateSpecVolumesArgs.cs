// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class PackageSpecControllerDeploymentSpecTemplateSpecVolumesArgs : Pulumi.ResourceArgs
    {
        [Input("awsElasticBlockStore")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesAwsElasticBlockStoreArgs>? AwsElasticBlockStore { get; set; }

        [Input("azureDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesAzureDiskArgs>? AzureDisk { get; set; }

        [Input("azureFile")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesAzureFileArgs>? AzureFile { get; set; }

        [Input("cephfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesCephfsArgs>? Cephfs { get; set; }

        [Input("cinder")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesCinderArgs>? Cinder { get; set; }

        [Input("configMap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesConfigMapArgs>? ConfigMap { get; set; }

        [Input("csi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesCsiArgs>? Csi { get; set; }

        [Input("downwardAPI")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesDownwardAPIArgs>? DownwardAPI { get; set; }

        [Input("emptyDir")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesEmptyDirArgs>? EmptyDir { get; set; }

        [Input("fc")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesFcArgs>? Fc { get; set; }

        [Input("flexVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesFlexVolumeArgs>? FlexVolume { get; set; }

        [Input("flocker")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesFlockerArgs>? Flocker { get; set; }

        [Input("gcePersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesGcePersistentDiskArgs>? GcePersistentDisk { get; set; }

        [Input("gitRepo")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesGitRepoArgs>? GitRepo { get; set; }

        [Input("glusterfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesGlusterfsArgs>? Glusterfs { get; set; }

        [Input("hostPath")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesHostPathArgs>? HostPath { get; set; }

        [Input("iscsi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesIscsiArgs>? Iscsi { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("nfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesNfsArgs>? Nfs { get; set; }

        [Input("persistentVolumeClaim")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesPersistentVolumeClaimArgs>? PersistentVolumeClaim { get; set; }

        [Input("photonPersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesPhotonPersistentDiskArgs>? PhotonPersistentDisk { get; set; }

        [Input("portworxVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesPortworxVolumeArgs>? PortworxVolume { get; set; }

        [Input("projected")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesProjectedArgs>? Projected { get; set; }

        [Input("quobyte")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesQuobyteArgs>? Quobyte { get; set; }

        [Input("rbd")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesRbdArgs>? Rbd { get; set; }

        [Input("scaleIO")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesScaleIOArgs>? ScaleIO { get; set; }

        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesSecretArgs>? Secret { get; set; }

        [Input("storageos")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesStorageosArgs>? Storageos { get; set; }

        [Input("vsphereVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecVolumesVsphereVolumeArgs>? VsphereVolume { get; set; }

        public PackageSpecControllerDeploymentSpecTemplateSpecVolumesArgs()
        {
        }
    }
}
