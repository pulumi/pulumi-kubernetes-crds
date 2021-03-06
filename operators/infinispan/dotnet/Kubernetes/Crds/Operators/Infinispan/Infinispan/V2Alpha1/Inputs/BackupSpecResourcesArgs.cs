// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Infinispan.V2Alpha1
{

    public class BackupSpecResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("cacheConfigs")]
        private InputList<string>? _cacheConfigs;
        public InputList<string> CacheConfigs
        {
            get => _cacheConfigs ?? (_cacheConfigs = new InputList<string>());
            set => _cacheConfigs = value;
        }

        [Input("caches")]
        private InputList<string>? _caches;
        public InputList<string> Caches
        {
            get => _caches ?? (_caches = new InputList<string>());
            set => _caches = value;
        }

        [Input("counters")]
        private InputList<string>? _counters;
        public InputList<string> Counters
        {
            get => _counters ?? (_counters = new InputList<string>());
            set => _counters = value;
        }

        [Input("protoSchemas")]
        private InputList<string>? _protoSchemas;
        public InputList<string> ProtoSchemas
        {
            get => _protoSchemas ?? (_protoSchemas = new InputList<string>());
            set => _protoSchemas = value;
        }

        [Input("scripts")]
        private InputList<string>? _scripts;
        public InputList<string> Scripts
        {
            get => _scripts ?? (_scripts = new InputList<string>());
            set => _scripts = value;
        }

        public BackupSpecResourcesArgs()
        {
        }
    }
}
