// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Charts.V1
{

    [OutputType]
    public sealed class XlSpecMediation-RhvImage
    {
        /// <summary>
        /// component image pull policy
        /// </summary>
        public readonly string PullPolicy;
        /// <summary>
        /// component container registry and repository name
        /// </summary>
        public readonly string Repository;
        /// <summary>
        /// component serviceAccountName
        /// </summary>
        public readonly string ServiceAccountName;
        /// <summary>
        /// component container tag
        /// </summary>
        public readonly string Tag;

        [OutputConstructor]
        private XlSpecMediation-RhvImage(
            string pullPolicy,

            string repository,

            string serviceAccountName,

            string tag)
        {
            PullPolicy = pullPolicy;
            Repository = repository;
            ServiceAccountName = serviceAccountName;
            Tag = tag;
        }
    }
}
