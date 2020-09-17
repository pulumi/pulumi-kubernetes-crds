// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Keda.V1Alpha1
{

    [OutputType]
    public sealed class ScaledObjectSpecJobTargetRefTemplateSpecInitContainersEnvFromConfigMapRef
    {
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Specify whether the ConfigMap must be defined
        /// </summary>
        public readonly bool Optional;

        [OutputConstructor]
        private ScaledObjectSpecJobTargetRefTemplateSpecInitContainersEnvFromConfigMapRef(
            string name,

            bool optional)
        {
            Name = name;
            Optional = optional;
        }
    }
}