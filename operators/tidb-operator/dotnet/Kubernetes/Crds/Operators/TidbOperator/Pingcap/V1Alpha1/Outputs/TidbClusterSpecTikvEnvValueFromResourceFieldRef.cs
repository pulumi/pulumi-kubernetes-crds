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
    public sealed class TidbClusterSpecTikvEnvValueFromResourceFieldRef
    {
        public readonly string ContainerName;
        public readonly object Divisor;
        public readonly string Resource;

        [OutputConstructor]
        private TidbClusterSpecTikvEnvValueFromResourceFieldRef(
            string containerName,

            object divisor,

            string resource)
        {
            ContainerName = containerName;
            Divisor = divisor;
            Resource = resource;
        }
    }
}
