// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1
{

    [OutputType]
    public sealed class StackDefinitionSpecControllerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
    {
        public readonly string Key;
        public readonly string Operator;
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private StackDefinitionSpecControllerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields(
            string key,

            string @operator,

            ImmutableArray<string> values)
        {
            Key = key;
            Operator = @operator;
            Values = values;
        }
    }
}
