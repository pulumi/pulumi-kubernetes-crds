// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta2
{

    [OutputType]
    public sealed class AddressSpacePlanSpec
    {
        public readonly ImmutableArray<string> AddressPlans;
        public readonly string AddressSpaceType;
        public readonly string DisplayName;
        public readonly int DisplayOrder;
        public readonly string InfraConfigRef;
        public readonly string LongDescription;
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta2.AddressSpacePlanSpecResourceLimits ResourceLimits;
        public readonly string ShortDescription;

        [OutputConstructor]
        private AddressSpacePlanSpec(
            ImmutableArray<string> addressPlans,

            string addressSpaceType,

            string displayName,

            int displayOrder,

            string infraConfigRef,

            string longDescription,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta2.AddressSpacePlanSpecResourceLimits resourceLimits,

            string shortDescription)
        {
            AddressPlans = addressPlans;
            AddressSpaceType = addressSpaceType;
            DisplayName = displayName;
            DisplayOrder = displayOrder;
            InfraConfigRef = infraConfigRef;
            LongDescription = longDescription;
            ResourceLimits = resourceLimits;
            ShortDescription = shortDescription;
        }
    }
}