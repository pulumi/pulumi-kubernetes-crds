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
    /// ConfigurationSpec --
    /// </summary>
    public class IntegrationStatusConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public IntegrationStatusConfigurationArgs()
        {
        }
    }
}