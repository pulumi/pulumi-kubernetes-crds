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
    public sealed class StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStart
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartExec Exec;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGet HttpGet;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket TcpSocket;

        [OutputConstructor]
        private StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStart(
            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartExec exec,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGet httpGet,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket tcpSocket)
        {
            Exec = exec;
            HttpGet = httpGet;
            TcpSocket = tcpSocket;
        }
    }
}