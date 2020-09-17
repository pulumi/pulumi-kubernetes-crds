// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1
{

    [OutputType]
    public sealed class BuildStrategySpecBuildStepsEnvFrom
    {
        /// <summary>
        /// The ConfigMap to select from
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildStrategySpecBuildStepsEnvFromConfigMapRef ConfigMapRef;
        /// <summary>
        /// An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.
        /// </summary>
        public readonly string Prefix;
        /// <summary>
        /// The Secret to select from
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildStrategySpecBuildStepsEnvFromSecretRef SecretRef;

        [OutputConstructor]
        private BuildStrategySpecBuildStepsEnvFrom(
            Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildStrategySpecBuildStepsEnvFromConfigMapRef configMapRef,

            string prefix,

            Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildStrategySpecBuildStepsEnvFromSecretRef secretRef)
        {
            ConfigMapRef = configMapRef;
            Prefix = prefix;
            SecretRef = secretRef;
        }
    }
}
