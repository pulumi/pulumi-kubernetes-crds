// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1
{

    /// <summary>
    /// ControllerStatus is the status of Controller pods
    /// </summary>
    public class CSIIsilonStatusControllerStatusArgs : Pulumi.ResourceArgs
    {
        [Input("available")]
        private InputList<string>? _available;
        public InputList<string> Available
        {
            get => _available ?? (_available = new InputList<string>());
            set => _available = value;
        }

        [Input("ready")]
        private InputList<string>? _ready;
        public InputList<string> Ready
        {
            get => _ready ?? (_ready = new InputList<string>());
            set => _ready = value;
        }

        [Input("starting")]
        private InputList<string>? _starting;
        public InputList<string> Starting
        {
            get => _starting ?? (_starting = new InputList<string>());
            set => _starting = value;
        }

        [Input("stopped")]
        private InputList<string>? _stopped;
        public InputList<string> Stopped
        {
            get => _stopped ?? (_stopped = new InputList<string>());
            set => _stopped = value;
        }

        public CSIIsilonStatusControllerStatusArgs()
        {
        }
    }
}
