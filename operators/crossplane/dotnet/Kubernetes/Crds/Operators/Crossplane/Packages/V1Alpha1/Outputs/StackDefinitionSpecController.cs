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
    public sealed class StackDefinitionSpecController
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeployment Deployment;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerServiceAccount ServiceAccount;

        [OutputConstructor]
        private StackDefinitionSpecController(
            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeployment deployment,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerServiceAccount serviceAccount)
        {
            Deployment = deployment;
            ServiceAccount = serviceAccount;
        }
    }
}
