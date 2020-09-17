// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1
{

    /// <summary>
    /// CephFS represents a Ceph FS mount on the host that shares a pod's lifetime
    /// </summary>
    public class DatadogAgentSpecAgentConfigVolumesCephfsArgs : Pulumi.ResourceArgs
    {
        [Input("monitors", required: true)]
        private InputList<string>? _monitors;

        /// <summary>
        /// Required: Monitors is a collection of Ceph monitors More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        public InputList<string> Monitors
        {
            get => _monitors ?? (_monitors = new InputList<string>());
            set => _monitors = value;
        }

        /// <summary>
        /// Optional: Used as the mounted root, rather than the full Ceph tree, default is /
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        /// <summary>
        /// Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [Input("secretFile")]
        public Input<string>? SecretFile { get; set; }

        /// <summary>
        /// Optional: SecretRef is reference to the authentication secret for User, default is empty. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1.DatadogAgentSpecAgentConfigVolumesCephfsSecretRefArgs>? SecretRef { get; set; }

        /// <summary>
        /// Optional: User is the rados user name, default is admin More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [Input("user")]
        public Input<string>? User { get; set; }

        public DatadogAgentSpecAgentConfigVolumesCephfsArgs()
        {
        }
    }
}