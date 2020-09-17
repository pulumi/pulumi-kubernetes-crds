// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1
{

    [OutputType]
    public sealed class KeepalivedGroupSpec
    {
        public readonly string Image;
        public readonly string Interface;
        public readonly ImmutableDictionary<string, string> NodeSelector;
        public readonly ImmutableDictionary<string, string> VerbatimConfig;

        [OutputConstructor]
        private KeepalivedGroupSpec(
            string image,

            string @interface,

            ImmutableDictionary<string, string> nodeSelector,

            ImmutableDictionary<string, string> verbatimConfig)
        {
            Image = image;
            Interface = @interface;
            NodeSelector = nodeSelector;
            VerbatimConfig = verbatimConfig;
        }
    }
}