// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecQueryVolumesArgs : Pulumi.ResourceArgs
    {
        [Input("awsElasticBlockStore")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesAwsElasticBlockStoreArgs>? AwsElasticBlockStore { get; set; }

        [Input("azureDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesAzureDiskArgs>? AzureDisk { get; set; }

        [Input("azureFile")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesAzureFileArgs>? AzureFile { get; set; }

        [Input("cephfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesCephfsArgs>? Cephfs { get; set; }

        [Input("cinder")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesCinderArgs>? Cinder { get; set; }

        [Input("configMap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesConfigMapArgs>? ConfigMap { get; set; }

        [Input("csi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesCsiArgs>? Csi { get; set; }

        [Input("downwardAPI")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesDownwardAPIArgs>? DownwardAPI { get; set; }

        [Input("emptyDir")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesEmptyDirArgs>? EmptyDir { get; set; }

        [Input("fc")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesFcArgs>? Fc { get; set; }

        [Input("flexVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesFlexVolumeArgs>? FlexVolume { get; set; }

        [Input("flocker")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesFlockerArgs>? Flocker { get; set; }

        [Input("gcePersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesGcePersistentDiskArgs>? GcePersistentDisk { get; set; }

        [Input("gitRepo")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesGitRepoArgs>? GitRepo { get; set; }

        [Input("glusterfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesGlusterfsArgs>? Glusterfs { get; set; }

        [Input("hostPath")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesHostPathArgs>? HostPath { get; set; }

        [Input("iscsi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesIscsiArgs>? Iscsi { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("nfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesNfsArgs>? Nfs { get; set; }

        [Input("persistentVolumeClaim")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesPersistentVolumeClaimArgs>? PersistentVolumeClaim { get; set; }

        [Input("photonPersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesPhotonPersistentDiskArgs>? PhotonPersistentDisk { get; set; }

        [Input("portworxVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesPortworxVolumeArgs>? PortworxVolume { get; set; }

        [Input("projected")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesProjectedArgs>? Projected { get; set; }

        [Input("quobyte")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesQuobyteArgs>? Quobyte { get; set; }

        [Input("rbd")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesRbdArgs>? Rbd { get; set; }

        [Input("scaleIO")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesScaleIOArgs>? ScaleIO { get; set; }

        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesSecretArgs>? Secret { get; set; }

        [Input("storageos")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesStorageosArgs>? Storageos { get; set; }

        [Input("vsphereVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecQueryVolumesVsphereVolumeArgs>? VsphereVolume { get; set; }

        public JaegerSpecQueryVolumesArgs()
        {
        }
    }
}
