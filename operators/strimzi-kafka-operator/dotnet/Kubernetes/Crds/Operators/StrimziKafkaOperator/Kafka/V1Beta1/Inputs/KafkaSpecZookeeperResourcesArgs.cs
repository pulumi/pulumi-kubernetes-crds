// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    /// <summary>
    /// CPU and memory resources to reserve.
    /// </summary>
    public class KafkaSpecZookeeperResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("limits")]
        private InputMap<object>? _limits;
        public InputMap<object> Limits
        {
            get => _limits ?? (_limits = new InputMap<object>());
            set => _limits = value;
        }

        [Input("requests")]
        private InputMap<object>? _requests;
        public InputMap<object> Requests
        {
            get => _requests ?? (_requests = new InputMap<object>());
            set => _requests = value;
        }

        public KafkaSpecZookeeperResourcesArgs()
        {
        }
    }
}
