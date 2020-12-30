// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecAddonsJaegerInstallStorageElasticsearchArgs : Pulumi.ResourceArgs
    {
        [Input("indexCleaner")]
        private InputMap<object>? _indexCleaner;
        public InputMap<object> IndexCleaner
        {
            get => _indexCleaner ?? (_indexCleaner = new InputMap<object>());
            set => _indexCleaner = value;
        }

        [Input("nodeCount")]
        public Input<int>? NodeCount { get; set; }

        [Input("redundancyPolicy")]
        public Input<string>? RedundancyPolicy { get; set; }

        [Input("storage")]
        private InputMap<object>? _storage;
        public InputMap<object> Storage
        {
            get => _storage ?? (_storage = new InputMap<object>());
            set => _storage = value;
        }

        public ServiceMeshControlPlaneStatusAppliedSpecAddonsJaegerInstallStorageElasticsearchArgs()
        {
        }
    }
}
