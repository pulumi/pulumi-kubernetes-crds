// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecAllInOneArgs : Pulumi.ResourceArgs
    {
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneAffinityArgs>? Affinity { get; set; }

        [Input("annotations")]
        private InputMap<string>? _annotations;
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        [Input("config")]
        private InputMap<object>? _config;
        public InputMap<object> Config
        {
            get => _config ?? (_config = new InputMap<object>());
            set => _config = value;
        }

        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("options")]
        private InputMap<object>? _options;
        public InputMap<object> Options
        {
            get => _options ?? (_options = new InputMap<object>());
            set => _options = value;
        }

        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneResourcesArgs>? Resources { get; set; }

        [Input("securityContext")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneSecurityContextArgs>? SecurityContext { get; set; }

        [Input("serviceAccount")]
        public Input<string>? ServiceAccount { get; set; }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneTolerationsArgs>? _tolerations;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneTolerationsArgs>());
            set => _tolerations = value;
        }

        [Input("volumeMounts")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumeMountsArgs>? _volumeMounts;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumeMountsArgs> VolumeMounts
        {
            get => _volumeMounts ?? (_volumeMounts = new InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumeMountsArgs>());
            set => _volumeMounts = value;
        }

        [Input("volumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesArgs>? _volumes;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAllInOneVolumesArgs>());
            set => _volumes = value;
        }

        public JaegerSpecAllInOneArgs()
        {
        }
    }
}
