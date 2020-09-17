// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecStorageEsRolloverVolumesArgs : Pulumi.ResourceArgs
    {
        [Input("awsElasticBlockStore")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesAwsElasticBlockStoreArgs>? AwsElasticBlockStore { get; set; }

        [Input("azureDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesAzureDiskArgs>? AzureDisk { get; set; }

        [Input("azureFile")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesAzureFileArgs>? AzureFile { get; set; }

        [Input("cephfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesCephfsArgs>? Cephfs { get; set; }

        [Input("cinder")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesCinderArgs>? Cinder { get; set; }

        [Input("configMap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesConfigMapArgs>? ConfigMap { get; set; }

        [Input("csi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesCsiArgs>? Csi { get; set; }

        [Input("downwardAPI")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesDownwardAPIArgs>? DownwardAPI { get; set; }

        [Input("emptyDir")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesEmptyDirArgs>? EmptyDir { get; set; }

        [Input("fc")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesFcArgs>? Fc { get; set; }

        [Input("flexVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesFlexVolumeArgs>? FlexVolume { get; set; }

        [Input("flocker")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesFlockerArgs>? Flocker { get; set; }

        [Input("gcePersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesGcePersistentDiskArgs>? GcePersistentDisk { get; set; }

        [Input("gitRepo")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesGitRepoArgs>? GitRepo { get; set; }

        [Input("glusterfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesGlusterfsArgs>? Glusterfs { get; set; }

        [Input("hostPath")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesHostPathArgs>? HostPath { get; set; }

        [Input("iscsi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesIscsiArgs>? Iscsi { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("nfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesNfsArgs>? Nfs { get; set; }

        [Input("persistentVolumeClaim")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesPersistentVolumeClaimArgs>? PersistentVolumeClaim { get; set; }

        [Input("photonPersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesPhotonPersistentDiskArgs>? PhotonPersistentDisk { get; set; }

        [Input("portworxVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesPortworxVolumeArgs>? PortworxVolume { get; set; }

        [Input("projected")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesProjectedArgs>? Projected { get; set; }

        [Input("quobyte")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesQuobyteArgs>? Quobyte { get; set; }

        [Input("rbd")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesRbdArgs>? Rbd { get; set; }

        [Input("scaleIO")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesScaleIOArgs>? ScaleIO { get; set; }

        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesSecretArgs>? Secret { get; set; }

        [Input("storageos")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesStorageosArgs>? Storageos { get; set; }

        [Input("vsphereVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverVolumesVsphereVolumeArgs>? VsphereVolume { get; set; }

        public JaegerSpecStorageEsRolloverVolumesArgs()
        {
        }
    }
}