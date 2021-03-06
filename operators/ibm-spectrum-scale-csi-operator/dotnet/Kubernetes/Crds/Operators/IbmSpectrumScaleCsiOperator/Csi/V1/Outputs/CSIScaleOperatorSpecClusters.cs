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
    public sealed class CSIScaleOperatorSpecClusters
    {
        /// <summary>
        /// A string specifying a cacert resource name.
        /// </summary>
        public readonly string Cacert;
        /// <summary>
        /// The cluster id of the gpfs cluster specified (mandatory).
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The primary file system for the GPFS cluster.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecClustersPrimary Primary;
        /// <summary>
        /// A collection of targets for REST calls.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecClustersRestApi> RestApi;
        /// <summary>
        /// A string specifying a secret resource name.
        /// </summary>
        public readonly string Secrets;
        /// <summary>
        /// Require a secure SSL connection to connect to GPFS.
        /// </summary>
        public readonly bool SecureSslMode;

        [OutputConstructor]
        private CSIScaleOperatorSpecClusters(
            string cacert,

            string id,

            Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecClustersPrimary primary,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Csi.V1.CSIScaleOperatorSpecClustersRestApi> restApi,

            string secrets,

            bool secureSslMode)
        {
            Cacert = cacert;
            Id = id;
            Primary = primary;
            RestApi = restApi;
            Secrets = secrets;
            SecureSslMode = secureSslMode;
        }
    }
}
