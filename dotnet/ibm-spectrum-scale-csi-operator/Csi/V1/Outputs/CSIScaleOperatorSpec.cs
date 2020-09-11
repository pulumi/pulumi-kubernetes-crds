// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Csi.V1
{

    [OutputType]
    public sealed class CSIScaleOperatorSpec
    {
        /// <summary>
        /// Attacher image for csi (actually attaches to the storage).
        /// </summary>
        public readonly string Attacher;
        /// <summary>
        /// Node selector for attacher sidecar.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecAttacherNodeSelector> AttacherNodeSelector;
        /// <summary>
        /// A collection of gpfs cluster properties for the csi driver to mount.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecClusters> Clusters;
        /// <summary>
        /// Sidecar container image for the csi spectrum scale plugin pods.
        /// </summary>
        public readonly string DriverRegistrar;
        /// <summary>
        /// Mapping of K8s node with SpectrumScale node.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecNodeMapping> NodeMapping;
        /// <summary>
        /// Node selector for SpectrumScale CSI Plugin.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecPluginNodeSelector> PluginNodeSelector;
        /// <summary>
        /// Provisioner image for csi (actually issues provision requests).
        /// </summary>
        public readonly string Provisioner;
        /// <summary>
        /// Node selector for provisioner sidecar.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecProvisionerNodeSelector> ProvisionerNodeSelector;
        /// <summary>
        /// The path to the gpfs file system mounted on the host machine.
        /// </summary>
        public readonly string ScaleHostpath;
        /// <summary>
        /// An internal counter used by the operator to trigger reloads on secret change.
        /// </summary>
        public readonly int SecretCounter;
        /// <summary>
        /// Image name for the csi spectrum scale plugin container.
        /// </summary>
        public readonly string SpectrumScale;
        /// <summary>
        /// A generic trigger to be used in kickin off the ansible operator.
        /// </summary>
        public readonly string Trigger;

        [OutputConstructor]
        private CSIScaleOperatorSpec(
            string attacher,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecAttacherNodeSelector> attacherNodeSelector,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecClusters> clusters,

            string driverRegistrar,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecNodeMapping> nodeMapping,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecPluginNodeSelector> pluginNodeSelector,

            string provisioner,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecProvisionerNodeSelector> provisionerNodeSelector,

            string scaleHostpath,

            int secretCounter,

            string spectrumScale,

            string trigger)
        {
            Attacher = attacher;
            AttacherNodeSelector = attacherNodeSelector;
            Clusters = clusters;
            DriverRegistrar = driverRegistrar;
            NodeMapping = nodeMapping;
            PluginNodeSelector = pluginNodeSelector;
            Provisioner = provisioner;
            ProvisionerNodeSelector = provisionerNodeSelector;
            ScaleHostpath = scaleHostpath;
            SecretCounter = secretCounter;
            SpectrumScale = spectrumScale;
            Trigger = trigger;
        }
    }
}
