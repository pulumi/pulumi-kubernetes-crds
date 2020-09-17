// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// EnvVar represents an environment variable present in a Container.
    /// </summary>
    public class ClusterProvisionSpecPodSpecContainersEnvArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the environment variable. Must be a C_IDENTIFIER.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        /// <summary>
        /// Source for the environment variable's value. Cannot be used if value is not empty.
        /// </summary>
        [Input("valueFrom")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.ClusterProvisionSpecPodSpecContainersEnvValueFromArgs>? ValueFrom { get; set; }

        public ClusterProvisionSpecPodSpecContainersEnvArgs()
        {
        }
    }
}
