// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ApplicationStatusOperationStateSyncResultSourceKustomize
    {
        /// <summary>
        /// CommonLabels adds additional kustomize commonLabels
        /// </summary>
        public readonly ImmutableDictionary<string, string> CommonLabels;
        /// <summary>
        /// Images are kustomize image overrides
        /// </summary>
        public readonly ImmutableArray<string> Images;
        /// <summary>
        /// NamePrefix is a prefix appended to resources for kustomize apps
        /// </summary>
        public readonly string NamePrefix;
        /// <summary>
        /// NameSuffix is a suffix appended to resources for kustomize apps
        /// </summary>
        public readonly string NameSuffix;
        /// <summary>
        /// Version contains optional Kustomize version
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private ApplicationStatusOperationStateSyncResultSourceKustomize(
            ImmutableDictionary<string, string> commonLabels,

            ImmutableArray<string> images,

            string namePrefix,

            string nameSuffix,

            string version)
        {
            CommonLabels = commonLabels;
            Images = images;
            NamePrefix = namePrefix;
            NameSuffix = nameSuffix;
            Version = version;
        }
    }
}
