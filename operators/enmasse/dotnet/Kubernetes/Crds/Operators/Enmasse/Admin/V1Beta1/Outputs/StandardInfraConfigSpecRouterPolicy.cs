// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1
{

    [OutputType]
    public sealed class StandardInfraConfigSpecRouterPolicy
    {
        public readonly int MaxConnections;
        public readonly int MaxConnectionsPerHost;
        public readonly int MaxConnectionsPerUser;
        public readonly int MaxReceiversPerConnection;
        public readonly int MaxSendersPerConnection;
        public readonly int MaxSessionsPerConnection;

        [OutputConstructor]
        private StandardInfraConfigSpecRouterPolicy(
            int maxConnections,

            int maxConnectionsPerHost,

            int maxConnectionsPerUser,

            int maxReceiversPerConnection,

            int maxSendersPerConnection,

            int maxSessionsPerConnection)
        {
            MaxConnections = maxConnections;
            MaxConnectionsPerHost = maxConnectionsPerHost;
            MaxConnectionsPerUser = maxConnectionsPerUser;
            MaxReceiversPerConnection = maxReceiversPerConnection;
            MaxSendersPerConnection = maxSendersPerConnection;
            MaxSessionsPerConnection = maxSessionsPerConnection;
        }
    }
}
