// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Infinispan.V1
{

    [OutputType]
    public sealed class InfinispanSpecServiceSitesLocations
    {
        public readonly string Name;
        public readonly string SecretName;
        public readonly string Url;

        [OutputConstructor]
        private InfinispanSpecServiceSitesLocations(
            string name,

            string secretName,

            string url)
        {
            Name = name;
            SecretName = secretName;
            Url = url;
        }
    }
}
