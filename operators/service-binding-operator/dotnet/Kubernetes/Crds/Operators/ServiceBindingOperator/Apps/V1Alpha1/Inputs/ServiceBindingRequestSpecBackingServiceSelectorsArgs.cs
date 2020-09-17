// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    /// <summary>
    /// BackingServiceSelector defines the selector based on resource name, version, and resource kind
    /// </summary>
    public class ServiceBindingRequestSpecBackingServiceSelectorsArgs : Pulumi.ResourceArgs
    {
        [Input("envVarPrefix")]
        public Input<string>? EnvVarPrefix { get; set; }

        [Input("group", required: true)]
        public Input<string> Group { get; set; } = null!;

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("kind", required: true)]
        public Input<string> Kind { get; set; } = null!;

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("resourceRef", required: true)]
        public Input<string> ResourceRef { get; set; } = null!;

        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public ServiceBindingRequestSpecBackingServiceSelectorsArgs()
        {
        }
    }
}