// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecPumpArgs : Pulumi.ResourceArgs
    {
        [Input("additionalContainers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpAdditionalContainersArgs>? _additionalContainers;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpAdditionalContainersArgs> AdditionalContainers
        {
            get => _additionalContainers ?? (_additionalContainers = new InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpAdditionalContainersArgs>());
            set => _additionalContainers = value;
        }

        [Input("additionalVolumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpAdditionalVolumesArgs>? _additionalVolumes;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpAdditionalVolumesArgs> AdditionalVolumes
        {
            get => _additionalVolumes ?? (_additionalVolumes = new InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpAdditionalVolumesArgs>());
            set => _additionalVolumes = value;
        }

        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpAffinityArgs>? Affinity { get; set; }

        [Input("annotations")]
        private InputMap<object>? _annotations;
        public InputMap<object> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<object>());
            set => _annotations = value;
        }

        [Input("baseImage")]
        public Input<string>? BaseImage { get; set; }

        [Input("config")]
        private InputMap<object>? _config;
        public InputMap<object> Config
        {
            get => _config ?? (_config = new InputMap<object>());
            set => _config = value;
        }

        [Input("configUpdateStrategy")]
        public Input<string>? ConfigUpdateStrategy { get; set; }

        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpEnvArgs>? _env;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpEnvArgs>());
            set => _env = value;
        }

        [Input("hostNetwork")]
        public Input<bool>? HostNetwork { get; set; }

        [Input("imagePullPolicy")]
        public Input<string>? ImagePullPolicy { get; set; }

        [Input("imagePullSecrets")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpImagePullSecretsArgs>? _imagePullSecrets;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpImagePullSecretsArgs> ImagePullSecrets
        {
            get => _imagePullSecrets ?? (_imagePullSecrets = new InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpImagePullSecretsArgs>());
            set => _imagePullSecrets = value;
        }

        [Input("limits")]
        private InputMap<object>? _limits;
        public InputMap<object> Limits
        {
            get => _limits ?? (_limits = new InputMap<object>());
            set => _limits = value;
        }

        [Input("nodeSelector")]
        private InputMap<object>? _nodeSelector;
        public InputMap<object> NodeSelector
        {
            get => _nodeSelector ?? (_nodeSelector = new InputMap<object>());
            set => _nodeSelector = value;
        }

        [Input("podSecurityContext")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpPodSecurityContextArgs>? PodSecurityContext { get; set; }

        [Input("priorityClassName")]
        public Input<string>? PriorityClassName { get; set; }

        [Input("replicas", required: true)]
        public Input<int> Replicas { get; set; } = null!;

        [Input("requests")]
        private InputMap<object>? _requests;
        public InputMap<object> Requests
        {
            get => _requests ?? (_requests = new InputMap<object>());
            set => _requests = value;
        }

        [Input("schedulerName")]
        public Input<string>? SchedulerName { get; set; }

        [Input("storageClassName")]
        public Input<string>? StorageClassName { get; set; }

        [Input("terminationGracePeriodSeconds")]
        public Input<int>? TerminationGracePeriodSeconds { get; set; }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpTolerationsArgs>? _tolerations;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPumpTolerationsArgs>());
            set => _tolerations = value;
        }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public TidbClusterSpecPumpArgs()
        {
        }
    }
}