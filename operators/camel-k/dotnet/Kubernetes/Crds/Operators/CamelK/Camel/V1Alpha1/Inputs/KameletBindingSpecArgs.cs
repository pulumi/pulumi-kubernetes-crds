// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Camel.V1Alpha1
{

    /// <summary>
    /// KameletBindingSpec --
    /// </summary>
    public class KameletBindingSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Integration is an optional integration used to specify custom parameters
        /// </summary>
        [Input("integration")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1Alpha1.KameletBindingSpecIntegrationArgs>? Integration { get; set; }

        /// <summary>
        /// Sink is the destination of the integration defined by this binding
        /// </summary>
        [Input("sink")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1Alpha1.KameletBindingSpecSinkArgs>? Sink { get; set; }

        /// <summary>
        /// Source is the starting point of the integration defined by this binding
        /// </summary>
        [Input("source")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1Alpha1.KameletBindingSpecSourceArgs>? Source { get; set; }

        public KameletBindingSpecArgs()
        {
        }
    }
}
