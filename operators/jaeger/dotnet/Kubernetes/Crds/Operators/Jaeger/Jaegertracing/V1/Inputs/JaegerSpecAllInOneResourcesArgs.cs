// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecAllInOneResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("limits")]
        private InputMap<string>? _limits;
        public InputMap<string> Limits
        {
            get => _limits ?? (_limits = new InputMap<string>());
            set => _limits = value;
        }

        [Input("requests")]
        private InputMap<string>? _requests;
        public InputMap<string> Requests
        {
            get => _requests ?? (_requests = new InputMap<string>());
            set => _requests = value;
        }

        public JaegerSpecAllInOneResourcesArgs()
        {
        }
    }
}