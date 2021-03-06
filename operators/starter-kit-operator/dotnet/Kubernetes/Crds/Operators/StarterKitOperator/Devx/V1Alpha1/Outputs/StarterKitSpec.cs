// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Devx.V1Alpha1
{

    [OutputType]
    public sealed class StarterKitSpec
    {
        public readonly ImmutableDictionary<string, object> Options;
        public readonly ImmutableDictionary<string, object> TemplateRepo;

        [OutputConstructor]
        private StarterKitSpec(
            ImmutableDictionary<string, object> options,

            ImmutableDictionary<string, object> templateRepo)
        {
            Options = options;
            TemplateRepo = templateRepo;
        }
    }
}
