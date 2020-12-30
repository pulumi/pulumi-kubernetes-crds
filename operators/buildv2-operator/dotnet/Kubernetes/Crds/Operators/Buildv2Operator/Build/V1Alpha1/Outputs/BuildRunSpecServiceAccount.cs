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
    public sealed class BuildRunSpecServiceAccount
    {
        /// <summary>
        /// If generates a new ServiceAccount for the build
        /// </summary>
        public readonly bool Generate;
        /// <summary>
        /// Name of the referent; More info: http://kubernetes.io/docs/user-guide/identifiers#names
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private BuildRunSpecServiceAccount(
            bool generate,

            string name)
        {
            Generate = generate;
            Name = name;
        }
    }
}
