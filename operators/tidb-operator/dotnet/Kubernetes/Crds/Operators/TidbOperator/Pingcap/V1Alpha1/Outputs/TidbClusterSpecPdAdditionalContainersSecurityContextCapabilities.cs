// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1
{

    [OutputType]
    public sealed class TidbClusterSpecPdAdditionalContainersSecurityContextCapabilities
    {
        public readonly ImmutableArray<string> Add;
        public readonly ImmutableArray<string> Drop;

        [OutputConstructor]
        private TidbClusterSpecPdAdditionalContainersSecurityContextCapabilities(
            ImmutableArray<string> add,

            ImmutableArray<string> drop)
        {
            Add = add;
            Drop = drop;
        }
    }
}
