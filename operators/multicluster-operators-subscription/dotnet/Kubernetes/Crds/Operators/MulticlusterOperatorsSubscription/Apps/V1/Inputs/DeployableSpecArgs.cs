// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1
{

    /// <summary>
    /// DeployableSpec defines the desired state of Deployable
    /// </summary>
    public class DeployableSpecArgs : Pulumi.ResourceArgs
    {
        [Input("channels")]
        private InputList<string>? _channels;
        public InputList<string> Channels
        {
            get => _channels ?? (_channels = new InputList<string>());
            set => _channels = value;
        }

        [Input("dependencies")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.DeployableSpecDependenciesArgs>? _dependencies;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.DeployableSpecDependenciesArgs> Dependencies
        {
            get => _dependencies ?? (_dependencies = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.DeployableSpecDependenciesArgs>());
            set => _dependencies = value;
        }

        [Input("overrides")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.DeployableSpecOverridesArgs>? _overrides;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.DeployableSpecOverridesArgs> Overrides
        {
            get => _overrides ?? (_overrides = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.DeployableSpecOverridesArgs>());
            set => _overrides = value;
        }

        /// <summary>
        /// Placement field to be referenced in specs, align with Fedv2, add placementref
        /// </summary>
        [Input("placement")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1.DeployableSpecPlacementArgs>? Placement { get; set; }

        [Input("template", required: true)]
        private InputMap<object>? _template;
        public InputMap<object> Template
        {
            get => _template ?? (_template = new InputMap<object>());
            set => _template = value;
        }

        public DeployableSpecArgs()
        {
        }
    }
}