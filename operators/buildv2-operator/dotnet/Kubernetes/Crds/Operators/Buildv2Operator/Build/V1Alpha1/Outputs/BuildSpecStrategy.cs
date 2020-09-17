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
    public sealed class BuildSpecStrategy
    {
        /// <summary>
        /// API version of the referent
        /// </summary>
        public readonly string ApiVersion;
        /// <summary>
        /// BuildStrategyKind indicates the kind of the buildstrategy, namespaced or cluster scoped.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Name of the referent; More info: http://kubernetes.io/docs/user-guide/identifiers#names
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private BuildSpecStrategy(
            string apiVersion,

            string kind,

            string name)
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Name = name;
        }
    }
}