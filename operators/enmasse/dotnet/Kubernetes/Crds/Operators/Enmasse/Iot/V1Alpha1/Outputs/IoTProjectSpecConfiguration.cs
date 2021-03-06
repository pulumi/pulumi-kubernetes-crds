// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Iot.V1Alpha1
{

    [OutputType]
    public sealed class IoTProjectSpecConfiguration
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Iot.V1Alpha1.IoTProjectSpecConfigurationAdapters Adapters;
        /// <summary>
        /// Defaults for properties defined on the tenant and device level.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Defaults;
        /// <summary>
        /// Allows to disable the use of the Tenant.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Allows arbitrary properties as extension to the ones specified by the Hono API.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Ext;
        /// <summary>
        /// The minimum message size in bytes. If set, then reported size of
        /// telemetry, event and command messages is calculated as the minimum multiple
        /// of the configured value that is greater than or equal to the messages
        /// payload size.
        /// </summary>
        public readonly int MinimumMessageSize;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Iot.V1Alpha1.IoTProjectSpecConfigurationTrustAnchors> TrustAnchors;

        [OutputConstructor]
        private IoTProjectSpecConfiguration(
            Pulumi.Kubernetes.Types.Outputs.Iot.V1Alpha1.IoTProjectSpecConfigurationAdapters adapters,

            ImmutableDictionary<string, object> defaults,

            bool enabled,

            ImmutableDictionary<string, object> ext,

            int minimumMessageSize,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Iot.V1Alpha1.IoTProjectSpecConfigurationTrustAnchors> trustAnchors)
        {
            Adapters = adapters;
            Defaults = defaults;
            Enabled = enabled;
            Ext = ext;
            MinimumMessageSize = minimumMessageSize;
            TrustAnchors = trustAnchors;
        }
    }
}
