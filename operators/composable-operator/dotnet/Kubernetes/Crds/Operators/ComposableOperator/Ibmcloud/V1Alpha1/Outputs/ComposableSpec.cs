// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1
{

    [OutputType]
    public sealed class ComposableSpec
    {
        /// <summary>
        /// Template defines the underlying object
        /// </summary>
        public readonly ImmutableDictionary<string, object> Template;

        [OutputConstructor]
        private ComposableSpec(ImmutableDictionary<string, object> template)
        {
            Template = template;
        }
    }
}
