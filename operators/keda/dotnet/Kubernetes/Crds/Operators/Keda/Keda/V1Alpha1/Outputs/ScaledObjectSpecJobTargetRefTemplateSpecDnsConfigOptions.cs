// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Keda.V1Alpha1
{

    [OutputType]
    public sealed class ScaledObjectSpecJobTargetRefTemplateSpecDnsConfigOptions
    {
        /// <summary>
        /// Required.
        /// </summary>
        public readonly string Name;
        public readonly string Value;

        [OutputConstructor]
        private ScaledObjectSpecJobTargetRefTemplateSpecDnsConfigOptions(
            string name,

            string value)
        {
            Name = name;
            Value = value;
        }
    }
}
