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
    public sealed class PackageSpecControllerDeploymentSpecTemplateSpecContainersLifecyclePreStop
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecContainersLifecyclePreStopExec Exec;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecContainersLifecyclePreStopHttpGet HttpGet;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecContainersLifecyclePreStopTcpSocket TcpSocket;

        [OutputConstructor]
        private PackageSpecControllerDeploymentSpecTemplateSpecContainersLifecyclePreStop(
            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecContainersLifecyclePreStopExec exec,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecContainersLifecyclePreStopHttpGet httpGet,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecControllerDeploymentSpecTemplateSpecContainersLifecyclePreStopTcpSocket tcpSocket)
        {
            Exec = exec;
            HttpGet = httpGet;
            TcpSocket = tcpSocket;
        }
    }
}
