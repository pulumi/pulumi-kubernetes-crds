// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1
{

    /// <summary>
    /// Selects a key of a secret in the pod's namespace
    /// </summary>
    public class SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersEnvValueFromSecretKeyRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key of the secret to select from.  Must be a valid secret key.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specify whether the Secret or its key must be defined
        /// </summary>
        [Input("optional")]
        public Input<bool>? Optional { get; set; }

        public SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersEnvValueFromSecretKeyRefArgs()
        {
        }
    }
}
