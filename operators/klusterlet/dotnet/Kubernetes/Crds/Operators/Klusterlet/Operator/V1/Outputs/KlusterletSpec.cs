// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Operator.V1
{

    [OutputType]
    public sealed class KlusterletSpec
    {
        /// <summary>
        /// ClusterName is the name of the managed cluster to be created on hub. The Klusterlet agent generates a random name if it is not set, or discovers the appropriate cluster name on openshift.
        /// </summary>
        public readonly string ClusterName;
        /// <summary>
        /// ExternalServerURLs represents the a list of apiserver urls and ca bundles that is accessible externally If it is set empty, managed cluster has no externally accessible url that hub cluster can visit.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Operator.V1.KlusterletSpecExternalServerURLs> ExternalServerURLs;
        /// <summary>
        /// Namespace is the namespace to deploy the agent. The namespace must have a prefix of "open-cluster-management-", and if it is not set, the namespace of "open-cluster-management-agent" is used to deploy agent.
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// RegistrationImagePullSpec represents the desired image configuration of registration agent.
        /// </summary>
        public readonly string RegistrationImagePullSpec;
        /// <summary>
        /// WorkImagePullSpec represents the desired image configuration of work agent.
        /// </summary>
        public readonly string WorkImagePullSpec;

        [OutputConstructor]
        private KlusterletSpec(
            string clusterName,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Operator.V1.KlusterletSpecExternalServerURLs> externalServerURLs,

            string @namespace,

            string registrationImagePullSpec,

            string workImagePullSpec)
        {
            ClusterName = clusterName;
            ExternalServerURLs = externalServerURLs;
            Namespace = @namespace;
            RegistrationImagePullSpec = registrationImagePullSpec;
            WorkImagePullSpec = workImagePullSpec;
        }
    }
}
