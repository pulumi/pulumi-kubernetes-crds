// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecAllInOneVolumesArgs : Pulumi.ResourceArgs
    {
        [Input("awsElasticBlockStore")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesAwsElasticBlockStoreArgs>? AwsElasticBlockStore { get; set; }

        [Input("azureDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesAzureDiskArgs>? AzureDisk { get; set; }

        [Input("azureFile")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesAzureFileArgs>? AzureFile { get; set; }

        [Input("cephfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesCephfsArgs>? Cephfs { get; set; }

        [Input("cinder")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesCinderArgs>? Cinder { get; set; }

        [Input("configMap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesConfigMapArgs>? ConfigMap { get; set; }

        [Input("csi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesCsiArgs>? Csi { get; set; }

        [Input("downwardAPI")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesDownwardAPIArgs>? DownwardAPI { get; set; }

        [Input("emptyDir")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesEmptyDirArgs>? EmptyDir { get; set; }

        [Input("fc")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesFcArgs>? Fc { get; set; }

        [Input("flexVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesFlexVolumeArgs>? FlexVolume { get; set; }

        [Input("flocker")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesFlockerArgs>? Flocker { get; set; }

        [Input("gcePersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesGcePersistentDiskArgs>? GcePersistentDisk { get; set; }

        [Input("gitRepo")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesGitRepoArgs>? GitRepo { get; set; }

        [Input("glusterfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesGlusterfsArgs>? Glusterfs { get; set; }

        [Input("hostPath")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesHostPathArgs>? HostPath { get; set; }

        [Input("iscsi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesIscsiArgs>? Iscsi { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("nfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesNfsArgs>? Nfs { get; set; }

        [Input("persistentVolumeClaim")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesPersistentVolumeClaimArgs>? PersistentVolumeClaim { get; set; }

        [Input("photonPersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesPhotonPersistentDiskArgs>? PhotonPersistentDisk { get; set; }

        [Input("portworxVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesPortworxVolumeArgs>? PortworxVolume { get; set; }

        [Input("projected")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesProjectedArgs>? Projected { get; set; }

        [Input("quobyte")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesQuobyteArgs>? Quobyte { get; set; }

        [Input("rbd")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesRbdArgs>? Rbd { get; set; }

        [Input("scaleIO")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesScaleIOArgs>? ScaleIO { get; set; }

        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesSecretArgs>? Secret { get; set; }

        [Input("storageos")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesStorageosArgs>? Storageos { get; set; }

        [Input("vsphereVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesVsphereVolumeArgs>? VsphereVolume { get; set; }

        public JaegerSpecAllInOneVolumesArgs()
        {
        }
    }
}
