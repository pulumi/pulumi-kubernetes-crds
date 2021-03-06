// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1
{

    [OutputType]
    public sealed class StorageClusterSpecAutopilotProviders
    {
        /// <summary>
        /// Unique name of the data provider.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Map of key-value params for the provider.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Params;
        /// <summary>
        /// Type of the data provider. For instance - prometheus
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private StorageClusterSpecAutopilotProviders(
            string name,

            ImmutableDictionary<string, object> @params,

            string type)
        {
            Name = name;
            Params = @params;
            Type = type;
        }
    }
}
