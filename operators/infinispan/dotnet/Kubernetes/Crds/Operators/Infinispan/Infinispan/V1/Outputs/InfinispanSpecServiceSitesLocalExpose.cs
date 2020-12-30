// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Infinispan.V1
{

    [OutputType]
    public sealed class InfinispanSpecServiceSitesLocalExpose
    {
        public readonly ImmutableDictionary<string, string> Annotations;
        public readonly string Host;
        public readonly int NodePort;
        /// <summary>
        /// Type specifies different exposition methods for data grid
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private InfinispanSpecServiceSitesLocalExpose(
            ImmutableDictionary<string, string> annotations,

            string host,

            int nodePort,

            string type)
        {
            Annotations = annotations;
            Host = host;
            NodePort = nodePort;
            Type = type;
        }
    }
}
