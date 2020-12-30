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
    /// Output refers to the location where the generated image would be pushed to. It will overwrite the output image in build spec
    /// </summary>
    public class BuildRunSpecOutputArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SecretRef is a reference to the Secret containing the credentials to push the image to the registry
        /// </summary>
        [Input("credentials")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildRunSpecOutputCredentialsArgs>? Credentials { get; set; }

        /// <summary>
        /// ImageURL is the URL where the image will be pushed to.
        /// </summary>
        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        public BuildRunSpecOutputArgs()
        {
        }
    }
}