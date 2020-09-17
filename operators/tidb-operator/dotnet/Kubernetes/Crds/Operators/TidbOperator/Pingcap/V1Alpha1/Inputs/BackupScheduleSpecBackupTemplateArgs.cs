// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class BackupScheduleSpecBackupTemplateArgs : Pulumi.ResourceArgs
    {
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateAffinityArgs>? Affinity { get; set; }

        [Input("backupType")]
        public Input<string>? BackupType { get; set; }

        [Input("br")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateBrArgs>? Br { get; set; }

        [Input("cleanData")]
        public Input<bool>? CleanData { get; set; }

        [Input("dumpling")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateDumplingArgs>? Dumpling { get; set; }

        [Input("from")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateFromArgs>? From { get; set; }

        [Input("gcs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateGcsArgs>? Gcs { get; set; }

        [Input("imagePullSecrets")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateImagePullSecretsArgs>? _imagePullSecrets;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateImagePullSecretsArgs> ImagePullSecrets
        {
            get => _imagePullSecrets ?? (_imagePullSecrets = new InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateImagePullSecretsArgs>());
            set => _imagePullSecrets = value;
        }

        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateResourcesArgs>? Resources { get; set; }

        [Input("s3")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateS3Args>? S3 { get; set; }

        [Input("serviceAccount")]
        public Input<string>? ServiceAccount { get; set; }

        [Input("storageClassName")]
        public Input<string>? StorageClassName { get; set; }

        [Input("storageSize")]
        public Input<string>? StorageSize { get; set; }

        [Input("tikvGCLifeTime")]
        public Input<string>? TikvGCLifeTime { get; set; }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateTolerationsArgs>? _tolerations;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.BackupScheduleSpecBackupTemplateTolerationsArgs>());
            set => _tolerations = value;
        }

        [Input("useKMS")]
        public Input<bool>? UseKMS { get; set; }

        public BackupScheduleSpecBackupTemplateArgs()
        {
        }
    }
}