// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopArgs : Pulumi.ResourceArgs
    {
        [Input("exec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopExecArgs>? Exec { get; set; }

        [Input("httpGet")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetArgs>? HttpGet { get; set; }

        [Input("tcpSocket")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocketArgs>? TcpSocket { get; set; }

        public StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopArgs()
        {
        }
    }
}
