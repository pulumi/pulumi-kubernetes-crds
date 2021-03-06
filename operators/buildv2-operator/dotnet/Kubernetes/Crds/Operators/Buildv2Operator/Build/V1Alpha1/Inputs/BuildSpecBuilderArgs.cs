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
    /// BuilderImage refers to the image containing the build tools inside which the source code would be built.
    /// </summary>
    public class BuildSpecBuilderArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SecretRef is a reference to the Secret containing the credentials to push the image to the registry
        /// </summary>
        [Input("credentials")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1.BuildSpecBuilderCredentialsArgs>? Credentials { get; set; }

        /// <summary>
        /// ImageURL is the URL where the image will be pushed to.
        /// </summary>
        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        public BuildSpecBuilderArgs()
        {
        }
    }
}
