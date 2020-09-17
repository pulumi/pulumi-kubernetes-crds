// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2
{

    [OutputType]
    public sealed class ComponentStatus
    {
        /// <summary>
        /// Conditions of the resource.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ComponentStatusConditions> Conditions;

        [OutputConstructor]
        private ComponentStatus(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ComponentStatusConditions> conditions)
        {
            Conditions = conditions;
        }
    }
}
