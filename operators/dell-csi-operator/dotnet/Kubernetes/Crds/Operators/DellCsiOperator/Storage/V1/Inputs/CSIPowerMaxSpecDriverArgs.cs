// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1
{

    /// <summary>
    /// Driver is the specification for the CSI PowerMax Driver
    /// </summary>
    public class CSIPowerMaxSpecDriverArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AuthSecret is the name of the credentials secret for the driver
        /// </summary>
        [Input("authSecret")]
        public Input<string>? AuthSecret { get; set; }

        /// <summary>
        /// Common is the common specification for both controller and node plugins
        /// </summary>
        [Input("common", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverCommonArgs> Common { get; set; } = null!;

        /// <summary>
        /// ConfigVersion is the configuration version of the driver
        /// </summary>
        [Input("configVersion", required: true)]
        public Input<string> ConfigVersion { get; set; } = null!;

        /// <summary>
        /// Controller is the specification for Controller plugin only
        /// </summary>
        [Input("controller")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverControllerArgs>? Controller { get; set; }

        /// <summary>
        /// ForceUpdate is the boolean flag used to force an update of the driver instance
        /// </summary>
        [Input("forceUpdate")]
        public Input<bool>? ForceUpdate { get; set; }

        /// <summary>
        /// Node is the specification for Node plugin only
        /// </summary>
        [Input("node")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverNodeArgs>? Node { get; set; }

        /// <summary>
        /// Replicas is the count of controllers for Controller plugin
        /// </summary>
        [Input("replicas", required: true)]
        public Input<int> Replicas { get; set; } = null!;

        [Input("sideCars")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverSideCarsArgs>? _sideCars;

        /// <summary>
        /// SideCars is the specification for CSI sidecar containers
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverSideCarsArgs> SideCars
        {
            get => _sideCars ?? (_sideCars = new InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverSideCarsArgs>());
            set => _sideCars = value;
        }

        [Input("snapshotClass")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverSnapshotClassArgs>? _snapshotClass;

        /// <summary>
        /// SnapshotClass is the specification for Snapshot Classes
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverSnapshotClassArgs> SnapshotClass
        {
            get => _snapshotClass ?? (_snapshotClass = new InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverSnapshotClassArgs>());
            set => _snapshotClass = value;
        }

        [Input("storageClass")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverStorageClassArgs>? _storageClass;

        /// <summary>
        /// StorageClass is the specification for Storage Classes
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverStorageClassArgs> StorageClass
        {
            get => _storageClass ?? (_storageClass = new InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxSpecDriverStorageClassArgs>());
            set => _storageClass = value;
        }

        /// <summary>
        /// TLSCertSecret is the name of the TLS Cert secret
        /// </summary>
        [Input("tlsCertSecret")]
        public Input<string>? TlsCertSecret { get; set; }

        public CSIPowerMaxSpecDriverArgs()
        {
        }
    }
}