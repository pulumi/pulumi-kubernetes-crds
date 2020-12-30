// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Org.V1
{

    [OutputType]
    public sealed class CheClusterSpec
    {
        /// <summary>
        /// Configuration settings related to the Authentication used by the Che installation.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecAuth Auth;
        /// <summary>
        /// Configuration settings related to the database used by the Che installation.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecDatabase Database;
        /// <summary>
        /// Kubernetes Image Puller configuration
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecImagePuller ImagePuller;
        /// <summary>
        /// Configuration settings specific to Che installations made on upstream Kubernetes.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecK8s K8s;
        /// <summary>
        /// Configuration settings related to the metrics collection used by the Che installation.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecMetrics Metrics;
        /// <summary>
        /// General configuration settings related to the Che server and the plugin and devfile registries
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecServer Server;
        /// <summary>
        /// Configuration settings related to the persistent storage used by the Che installation.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecStorage Storage;

        [OutputConstructor]
        private CheClusterSpec(
            Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecAuth auth,

            Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecDatabase database,

            Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecImagePuller imagePuller,

            Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecK8s k8s,

            Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecMetrics metrics,

            Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecServer server,

            Pulumi.Kubernetes.Types.Outputs.Org.V1.CheClusterSpecStorage storage)
        {
            Auth = auth;
            Database = database;
            ImagePuller = imagePuller;
            K8s = k8s;
            Metrics = metrics;
            Server = server;
            Storage = storage;
        }
    }
}
