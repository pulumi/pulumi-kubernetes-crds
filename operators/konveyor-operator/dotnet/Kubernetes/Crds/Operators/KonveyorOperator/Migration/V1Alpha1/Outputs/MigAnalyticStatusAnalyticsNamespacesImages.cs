// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Migration.V1Alpha1
{

    [OutputType]
    public sealed class MigAnalyticStatusAnalyticsNamespacesImages
    {
        public readonly string Name;
        public readonly string Reference;
        public readonly string Size;

        [OutputConstructor]
        private MigAnalyticStatusAnalyticsNamespacesImages(
            string name,

            string reference,

            string size)
        {
            Name = name;
            Reference = reference;
            Size = size;
        }
    }
}
