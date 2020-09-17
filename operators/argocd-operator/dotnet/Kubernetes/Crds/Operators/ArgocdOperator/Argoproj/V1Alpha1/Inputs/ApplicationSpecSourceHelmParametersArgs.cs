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
    /// HelmParameter is a parameter to a helm template
    /// </summary>
    public class ApplicationSpecSourceHelmParametersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ForceString determines whether to tell Helm to interpret booleans and numbers as strings
        /// </summary>
        [Input("forceString")]
        public Input<bool>? ForceString { get; set; }

        /// <summary>
        /// Name is the name of the helm parameter
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Value is the value for the helm parameter
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public ApplicationSpecSourceHelmParametersArgs()
        {
        }
    }
}
