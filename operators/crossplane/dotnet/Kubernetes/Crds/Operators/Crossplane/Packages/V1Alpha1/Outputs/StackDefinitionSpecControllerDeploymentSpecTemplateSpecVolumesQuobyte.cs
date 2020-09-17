// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1
{

    [OutputType]
    public sealed class StackDefinitionSpecControllerDeploymentSpecTemplateSpecVolumesQuobyte
    {
        public readonly string Group;
        public readonly bool ReadOnly;
        public readonly string Registry;
        public readonly string Tenant;
        public readonly string User;
        public readonly string Volume;

        [OutputConstructor]
        private StackDefinitionSpecControllerDeploymentSpecTemplateSpecVolumesQuobyte(
            string group,

            bool readOnly,

            string registry,

            string tenant,

            string user,

            string volume)
        {
            Group = group;
            ReadOnly = readOnly;
            Registry = registry;
            Tenant = tenant;
            User = user;
            Volume = volume;
        }
    }
}
