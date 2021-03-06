// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2
{

    [OutputType]
    public sealed class ApplicationConfigurationSpec
    {
        /// <summary>
        /// Components of which this ApplicationConfiguration consists. Each component will be used to instantiate a workload.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ApplicationConfigurationSpecComponents> Components;

        [OutputConstructor]
        private ApplicationConfigurationSpec(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha2.ApplicationConfigurationSpecComponents> components)
        {
            Components = components;
        }
    }
}
