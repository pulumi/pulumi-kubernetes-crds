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
    public sealed class IoTProjectStatus
    {
        /// <summary>
        /// The input accepted from the `.spec.configuration` section, split up into the different areas.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Iot.V1Alpha1.IoTProjectStatusAccepted Accepted;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Iot.V1Alpha1.IoTProjectStatusConditions> Conditions;
        public readonly string Message;
        public readonly string Phase;
        public readonly string TenantName;

        [OutputConstructor]
        private IoTProjectStatus(
            Pulumi.Kubernetes.Types.Outputs.Iot.V1Alpha1.IoTProjectStatusAccepted accepted,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Iot.V1Alpha1.IoTProjectStatusConditions> conditions,

            string message,

            string phase,

            string tenantName)
        {
            Accepted = accepted;
            Conditions = conditions;
            Message = message;
            Phase = phase;
            TenantName = tenantName;
        }
    }
}
