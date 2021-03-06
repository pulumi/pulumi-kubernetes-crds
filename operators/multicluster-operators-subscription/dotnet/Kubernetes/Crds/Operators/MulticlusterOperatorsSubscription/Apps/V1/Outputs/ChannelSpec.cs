// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1
{

    [OutputType]
    public sealed class ChannelSpec
    {
        /// <summary>
        /// Reference to a ConfigMap which contains additional settings for accessing the channel. For example, the `insecureSkipVerify` option for accessing HTTPS endpoints can be set in the ConfigMap to indicate a insecure connection.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1.ChannelSpecConfigMapRef ConfigMapRef;
        /// <summary>
        /// Criteria for promoting a Deployable from the sourceNamespaces to Channel.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1.ChannelSpecGates Gates;
        /// <summary>
        /// Skip server TLS certificate verification for Git or Helm channel.
        /// </summary>
        public readonly bool InsecureSkipVerify;
        /// <summary>
        /// For a `namespace` channel, pathname is the name of the namespace; For a `helmrepo` or `github` channel, pathname is the remote URL for the channel contents; For a `objectbucket` channel, pathname is the URL and name of the bucket.
        /// </summary>
        public readonly string Pathname;
        /// <summary>
        /// For a `github` channel or a `helmrepo` channel on github, this can be used to reference a Secret which contains the credentials for authentication, i.e. `user` and `accessToken`. For a `objectbucket` channel, this can be used to reference a Secret which contains the AWS credentials, i.e. `AccessKeyID` and `SecretAccessKey`.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1.ChannelSpecSecretRef SecretRef;
        /// <summary>
        /// A list of namespace names from which Deployables can be promoted.
        /// </summary>
        public readonly ImmutableArray<string> SourceNamespaces;
        /// <summary>
        /// ChannelType defines types of channel
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ChannelSpec(
            Pulumi.Kubernetes.Types.Outputs.Apps.V1.ChannelSpecConfigMapRef configMapRef,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1.ChannelSpecGates gates,

            bool insecureSkipVerify,

            string pathname,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1.ChannelSpecSecretRef secretRef,

            ImmutableArray<string> sourceNamespaces,

            string type)
        {
            ConfigMapRef = configMapRef;
            Gates = gates;
            InsecureSkipVerify = insecureSkipVerify;
            Pathname = pathname;
            SecretRef = secretRef;
            SourceNamespaces = sourceNamespaces;
            Type = type;
        }
    }
}
