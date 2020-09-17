// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1
{

    public class MigStorageSpecBackupStorageConfigArgs : Pulumi.ResourceArgs
    {
        [Input("awsBucketName")]
        public Input<string>? AwsBucketName { get; set; }

        [Input("awsKmsKeyId")]
        public Input<string>? AwsKmsKeyId { get; set; }

        [Input("awsPublicUrl")]
        public Input<string>? AwsPublicUrl { get; set; }

        [Input("awsRegion")]
        public Input<string>? AwsRegion { get; set; }

        [Input("awsS3ForcePathStyle")]
        public Input<bool>? AwsS3ForcePathStyle { get; set; }

        [Input("awsS3Url")]
        public Input<string>? AwsS3Url { get; set; }

        [Input("awsSignatureVersion")]
        public Input<string>? AwsSignatureVersion { get; set; }

        [Input("azureResourceGroup")]
        public Input<string>? AzureResourceGroup { get; set; }

        [Input("azureStorageAccount")]
        public Input<string>? AzureStorageAccount { get; set; }

        [Input("azureStorageContainer")]
        public Input<string>? AzureStorageContainer { get; set; }

        [Input("credsSecretRef")]
        private InputMap<object>? _credsSecretRef;
        public InputMap<object> CredsSecretRef
        {
            get => _credsSecretRef ?? (_credsSecretRef = new InputMap<object>());
            set => _credsSecretRef = value;
        }

        [Input("gcpBucket")]
        public Input<string>? GcpBucket { get; set; }

        [Input("insecure")]
        public Input<bool>? Insecure { get; set; }

        [Input("s3CustomCABundle")]
        public Input<string>? S3CustomCABundle { get; set; }

        public MigStorageSpecBackupStorageConfigArgs()
        {
        }
    }
}
