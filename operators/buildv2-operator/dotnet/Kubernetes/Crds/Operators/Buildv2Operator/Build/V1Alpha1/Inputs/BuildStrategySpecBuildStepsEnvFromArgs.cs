// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1
{

    /// <summary>
    /// EnvFromSource represents the source of a set of ConfigMaps
    /// </summary>
    public class BuildStrategySpecBuildStepsEnvFromArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ConfigMap to select from
        /// </summary>
        [Input("configMapRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildStrategySpecBuildStepsEnvFromConfigMapRefArgs>? ConfigMapRef { get; set; }

        /// <summary>
        /// An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.
        /// </summary>
        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        /// <summary>
        /// The Secret to select from
        /// </summary>
        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildStrategySpecBuildStepsEnvFromSecretRefArgs>? SecretRef { get; set; }

        public BuildStrategySpecBuildStepsEnvFromArgs()
        {
        }
    }
}
