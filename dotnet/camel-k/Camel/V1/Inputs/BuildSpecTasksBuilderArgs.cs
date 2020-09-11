// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Camel.V1
{

    /// <summary>
    /// BuilderTask --
    /// </summary>
    public class BuildSpecTasksBuilderArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Affinity is a group of affinity scheduling rules.
        /// </summary>
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderAffinityArgs>? Affinity { get; set; }

        [Input("baseImage")]
        public Input<string>? BaseImage { get; set; }

        [Input("buildDir")]
        public Input<string>? BuildDir { get; set; }

        [Input("dependencies")]
        private InputList<string>? _dependencies;
        public InputList<string> Dependencies
        {
            get => _dependencies ?? (_dependencies = new InputList<string>());
            set => _dependencies = value;
        }

        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// MavenSpec --
        /// </summary>
        [Input("maven")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderMavenArgs>? Maven { get; set; }

        [Input("meta")]
        private InputMap<object>? _meta;

        /// <summary>
        /// This is required until https://github.com/kubernetes-sigs/controller-tools/pull/395 gets merged
        /// </summary>
        public InputMap<object> Meta
        {
            get => _meta ?? (_meta = new InputMap<object>());
            set => _meta = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("properties")]
        private InputMap<string>? _properties;
        public InputMap<string> Properties
        {
            get => _properties ?? (_properties = new InputMap<string>());
            set => _properties = value;
        }

        [Input("resources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderResourcesArgs>? _resources;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderResourcesArgs> Resources
        {
            get => _resources ?? (_resources = new InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderResourcesArgs>());
            set => _resources = value;
        }

        /// <summary>
        /// RuntimeSpec --
        /// </summary>
        [Input("runtime")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderRuntimeArgs>? Runtime { get; set; }

        [Input("sources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderSourcesArgs>? _sources;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderSourcesArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderSourcesArgs>());
            set => _sources = value;
        }

        [Input("steps")]
        private InputList<string>? _steps;
        public InputList<string> Steps
        {
            get => _steps ?? (_steps = new InputList<string>());
            set => _steps = value;
        }

        [Input("timeout")]
        public Input<string>? Timeout { get; set; }

        [Input("volumeMounts")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderVolumeMountsArgs>? _volumeMounts;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderVolumeMountsArgs> VolumeMounts
        {
            get => _volumeMounts ?? (_volumeMounts = new InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderVolumeMountsArgs>());
            set => _volumeMounts = value;
        }

        [Input("volumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderVolumesArgs>? _volumes;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderVolumesArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Pulumi.Kubernetes.Types.Inputs.Camel.V1.BuildSpecTasksBuilderVolumesArgs>());
            set => _volumes = value;
        }

        public BuildSpecTasksBuilderArgs()
        {
        }
    }
}
