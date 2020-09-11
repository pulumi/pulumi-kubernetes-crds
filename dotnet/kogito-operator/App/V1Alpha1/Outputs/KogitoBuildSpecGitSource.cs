// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1
{

    [OutputType]
    public sealed class KogitoBuildSpecGitSource
    {
        /// <summary>
        /// Context/subdirectory where the code is located, relative to the repo root.
        /// </summary>
        public readonly string ContextDir;
        /// <summary>
        /// Branch to use in the Git repository.
        /// </summary>
        public readonly string Reference;
        /// <summary>
        /// Git URI for the s2i source.
        /// </summary>
        public readonly string Uri;

        [OutputConstructor]
        private KogitoBuildSpecGitSource(
            string contextDir,

            string reference,

            string uri)
        {
            ContextDir = contextDir;
            Reference = reference;
            Uri = uri;
        }
    }
}
