// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// FailedProvisionAWSConfig contains AWS-specific info to upload log files.
    /// </summary>
    public class HiveConfigSpecFailedProvisionConfigAwsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bucket is the S3 bucket to store the logs in.
        /// </summary>
        [Input("bucket")]
        public Input<string>? Bucket { get; set; }

        /// <summary>
        /// CredentialsSecretRef references a secret in the TargetNamespace that will be used to authenticate with AWS S3. It will need permission to upload logs to S3. Secret should have keys named aws_access_key_id and aws_secret_access_key that contain the AWS credentials. Example Secret:   data:     aws_access_key_id: minio     aws_secret_access_key: minio123
        /// </summary>
        [Input("credentialsSecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.HiveConfigSpecFailedProvisionConfigAwsCredentialsSecretRefArgs> CredentialsSecretRef { get; set; } = null!;

        /// <summary>
        /// Region is the AWS region to use for S3 operations. This defaults to us-east-1. For AWS China, use cn-northwest-1.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// ServiceEndpoint is the url to connect to an S3 compatible provider.
        /// </summary>
        [Input("serviceEndpoint")]
        public Input<string>? ServiceEndpoint { get; set; }

        public HiveConfigSpecFailedProvisionConfigAwsArgs()
        {
        }
    }
}
