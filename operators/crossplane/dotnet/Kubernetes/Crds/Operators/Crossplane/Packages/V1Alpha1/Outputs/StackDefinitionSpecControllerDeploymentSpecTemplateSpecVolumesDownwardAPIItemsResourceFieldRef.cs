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
    public sealed class StackDefinitionSpecControllerDeploymentSpecTemplateSpecVolumesDownwardAPIItemsResourceFieldRef
    {
        public readonly string ContainerName;
        public readonly string Divisor;
        public readonly string Resource;

        [OutputConstructor]
        private StackDefinitionSpecControllerDeploymentSpecTemplateSpecVolumesDownwardAPIItemsResourceFieldRef(
            string containerName,

            string divisor,

            string resource)
        {
            ContainerName = containerName;
            Divisor = divisor;
            Resource = resource;
        }
    }
}
