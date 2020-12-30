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
    public sealed class BuildRunStatusBuildSpecOutput
    {
        /// <summary>
        /// SecretRef is a reference to the Secret containing the credentials to push the image to the registry
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecOutputCredentials Credentials;
        /// <summary>
        /// ImageURL is the URL where the image will be pushed to.
        /// </summary>
        public readonly string Image;

        [OutputConstructor]
        private BuildRunStatusBuildSpecOutput(
            Pulumi.Kubernetes.Types.Outputs.Build.V1Alpha1.BuildRunStatusBuildSpecOutputCredentials credentials,

            string image)
        {
            Credentials = credentials;
            Image = image;
        }
    }
}
