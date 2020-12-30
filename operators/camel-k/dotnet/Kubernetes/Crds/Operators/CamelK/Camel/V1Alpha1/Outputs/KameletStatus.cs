// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Camel.V1Alpha1
{

    [OutputType]
    public sealed class KameletStatus
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1Alpha1.KameletStatusConditions> Conditions;
        public readonly string Phase;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1Alpha1.KameletStatusProperties> Properties;

        [OutputConstructor]
        private KameletStatus(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1Alpha1.KameletStatusConditions> conditions,

            string phase,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1Alpha1.KameletStatusProperties> properties)
        {
            Conditions = conditions;
            Phase = phase;
            Properties = properties;
        }
    }
}
