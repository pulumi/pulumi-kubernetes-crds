// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Beat.V1Beta1
{

    /// <summary>
    /// ConfigRef contains a reference to an existing Kubernetes Secret holding the Beat configuration. Beat settings must be specified as yaml, under a single "beat.yml" entry. At most one of [`Config`, `ConfigRef`] can be specified.
    /// </summary>
    public class BeatSpecConfigRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SecretName is the name of the secret.
        /// </summary>
        [Input("secretName")]
        public Input<string>? SecretName { get; set; }

        public BeatSpecConfigRefArgs()
        {
        }
    }
}
