// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Operator.V1
{

    [OutputType]
    public sealed class ClusterManagerStatusRelatedResources
    {
        /// <summary>
        /// group is the group of the thing you're tracking
        /// </summary>
        public readonly string Group;
        /// <summary>
        /// name is the name of the thing you're tracking
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// namespace is where the thing you're tracking is
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// resource is the resource type of the thing you're tracking
        /// </summary>
        public readonly string Resource;
        /// <summary>
        /// version is the version of the thing you're tracking
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private ClusterManagerStatusRelatedResources(
            string group,

            string name,

            string @namespace,

            string resource,

            string version)
        {
            Group = group;
            Name = name;
            Namespace = @namespace;
            Resource = resource;
            Version = version;
        }
    }
}
