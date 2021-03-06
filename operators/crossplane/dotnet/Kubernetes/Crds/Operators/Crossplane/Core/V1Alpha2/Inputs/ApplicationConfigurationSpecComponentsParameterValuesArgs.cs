// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2
{

    /// <summary>
    /// A ComponentParameterValue specifies a value for a named parameter. The associated component must publish a parameter with this name.
    /// </summary>
    public class ApplicationConfigurationSpecComponentsParameterValuesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the component parameter to set.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Value to set.
        /// </summary>
        [Input("value", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2.ApplicationConfigurationSpecComponentsParameterValuesValueArgs> Value { get; set; } = null!;

        public ApplicationConfigurationSpecComponentsParameterValuesArgs()
        {
        }
    }
}
