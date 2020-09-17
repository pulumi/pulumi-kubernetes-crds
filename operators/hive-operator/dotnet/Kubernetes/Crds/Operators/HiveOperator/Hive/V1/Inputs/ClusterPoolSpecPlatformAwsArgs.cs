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
    /// AWS is the configuration used when installing on AWS.
    /// </summary>
    public class ClusterPoolSpecPlatformAwsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CredentialsSecretRef refers to a secret that contains the AWS account access credentials.
        /// </summary>
        [Input("credentialsSecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterPoolSpecPlatformAwsCredentialsSecretRefArgs> CredentialsSecretRef { get; set; } = null!;

        /// <summary>
        /// Region specifies the AWS region where the cluster will be created.
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        [Input("userTags")]
        private InputMap<string>? _userTags;

        /// <summary>
        /// UserTags specifies additional tags for AWS resources created for the cluster.
        /// </summary>
        public InputMap<string> UserTags
        {
            get => _userTags ?? (_userTags = new InputMap<string>());
            set => _userTags = value;
        }

        public ClusterPoolSpecPlatformAwsArgs()
        {
        }
    }
}
