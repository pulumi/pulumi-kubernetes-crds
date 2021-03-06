// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1
{

    /// <summary>
    /// BuildStrategySpec defines the desired state of BuildStrategy
    /// </summary>
    public class ClusterBuildStrategySpecArgs : Pulumi.ResourceArgs
    {
        [Input("buildSteps")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.ClusterBuildStrategySpecBuildStepsArgs>? _buildSteps;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.ClusterBuildStrategySpecBuildStepsArgs> BuildSteps
        {
            get => _buildSteps ?? (_buildSteps = new InputList<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.ClusterBuildStrategySpecBuildStepsArgs>());
            set => _buildSteps = value;
        }

        public ClusterBuildStrategySpecArgs()
        {
        }
    }
}
