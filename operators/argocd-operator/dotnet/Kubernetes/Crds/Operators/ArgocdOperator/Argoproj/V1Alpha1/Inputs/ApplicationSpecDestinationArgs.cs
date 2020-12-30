// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// Destination overrides the kubernetes server and namespace defined in the environment ksonnet app.yaml
    /// </summary>
    public class ApplicationSpecDestinationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the destination cluster which can be used instead of server (url) field
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Namespace overrides the environment namespace value in the ksonnet app.yaml
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        /// <summary>
        /// Server overrides the environment server value in the ksonnet app.yaml
        /// </summary>
        [Input("server")]
        public Input<string>? Server { get; set; }

        public ApplicationSpecDestinationArgs()
        {
        }
    }
}
