// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecProxyLoggingArgs : Pulumi.ResourceArgs
    {
        [Input("componentLevels")]
        private InputMap<string>? _componentLevels;
        public InputMap<string> ComponentLevels
        {
            get => _componentLevels ?? (_componentLevels = new InputMap<string>());
            set => _componentLevels = value;
        }

        [Input("level")]
        public Input<string>? Level { get; set; }

        public ServiceMeshControlPlaneStatusAppliedSpecProxyLoggingArgs()
        {
        }
    }
}
