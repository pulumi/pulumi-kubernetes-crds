// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Org.V1
{

    /// <summary>
    /// Che server ingress custom settings
    /// </summary>
    public class CheClusterSpecServerCheServerIngressArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Comma separated list of labels that can be used to organize and categorize (scope and select) objects.
        /// </summary>
        [Input("labels")]
        public Input<string>? Labels { get; set; }

        public CheClusterSpecServerCheServerIngressArgs()
        {
        }
    }
}
