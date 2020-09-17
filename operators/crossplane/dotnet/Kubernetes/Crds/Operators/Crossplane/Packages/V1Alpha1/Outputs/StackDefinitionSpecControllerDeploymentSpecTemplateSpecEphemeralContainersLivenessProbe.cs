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
    public sealed class StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbe
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeExec Exec;
        public readonly int FailureThreshold;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet HttpGet;
        public readonly int InitialDelaySeconds;
        public readonly int PeriodSeconds;
        public readonly int SuccessThreshold;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket TcpSocket;
        public readonly int TimeoutSeconds;

        [OutputConstructor]
        private StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbe(
            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeExec exec,

            int failureThreshold,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet httpGet,

            int initialDelaySeconds,

            int periodSeconds,

            int successThreshold,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket tcpSocket,

            int timeoutSeconds)
        {
            Exec = exec;
            FailureThreshold = failureThreshold;
            HttpGet = httpGet;
            InitialDelaySeconds = initialDelaySeconds;
            PeriodSeconds = periodSeconds;
            SuccessThreshold = successThreshold;
            TcpSocket = tcpSocket;
            TimeoutSeconds = timeoutSeconds;
        }
    }
}
