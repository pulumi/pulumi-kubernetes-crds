// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Workload.V1Alpha1
{

    [OutputType]
    public sealed class KubernetesApplicationSpecResourceTemplatesSpecTargetRef
    {
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private KubernetesApplicationSpecResourceTemplatesSpecTargetRef(string name)
        {
            Name = name;
        }
    }
}
