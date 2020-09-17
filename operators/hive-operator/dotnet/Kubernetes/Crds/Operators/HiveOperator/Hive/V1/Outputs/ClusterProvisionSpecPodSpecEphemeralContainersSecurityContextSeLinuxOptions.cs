// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class ClusterProvisionSpecPodSpecEphemeralContainersSecurityContextSeLinuxOptions
    {
        /// <summary>
        /// Level is SELinux level label that applies to the container.
        /// </summary>
        public readonly string Level;
        /// <summary>
        /// Role is a SELinux role label that applies to the container.
        /// </summary>
        public readonly string Role;
        /// <summary>
        /// Type is a SELinux type label that applies to the container.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// User is a SELinux user label that applies to the container.
        /// </summary>
        public readonly string User;

        [OutputConstructor]
        private ClusterProvisionSpecPodSpecEphemeralContainersSecurityContextSeLinuxOptions(
            string level,

            string role,

            string type,

            string user)
        {
            Level = level;
            Role = role;
            Type = type;
            User = user;
        }
    }
}
