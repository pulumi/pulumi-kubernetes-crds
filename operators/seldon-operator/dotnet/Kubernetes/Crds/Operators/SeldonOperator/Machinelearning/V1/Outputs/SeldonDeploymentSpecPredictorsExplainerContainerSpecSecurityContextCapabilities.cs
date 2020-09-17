// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1
{

    [OutputType]
    public sealed class SeldonDeploymentSpecPredictorsExplainerContainerSpecSecurityContextCapabilities
    {
        /// <summary>
        /// Added capabilities
        /// </summary>
        public readonly ImmutableArray<string> Add;
        /// <summary>
        /// Removed capabilities
        /// </summary>
        public readonly ImmutableArray<string> Drop;

        [OutputConstructor]
        private SeldonDeploymentSpecPredictorsExplainerContainerSpecSecurityContextCapabilities(
            ImmutableArray<string> add,

            ImmutableArray<string> drop)
        {
            Add = add;
            Drop = drop;
        }
    }
}
