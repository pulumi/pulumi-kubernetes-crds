// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1
{

    [OutputType]
    public sealed class SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersLifecyclePostStart
    {
        /// <summary>
        /// One and only one of the following should be specified. Exec specifies the action to take.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersLifecyclePostStartExec Exec;
        /// <summary>
        /// HTTPGet specifies the http request to perform.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersLifecyclePostStartHttpGet HttpGet;
        /// <summary>
        /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported TODO: implement a realistic TCP lifecycle hook
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersLifecyclePostStartTcpSocket TcpSocket;

        [OutputConstructor]
        private SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersLifecyclePostStart(
            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersLifecyclePostStartExec exec,

            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersLifecyclePostStartHttpGet httpGet,

            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersLifecyclePostStartTcpSocket tcpSocket)
        {
            Exec = exec;
            HttpGet = httpGet;
            TcpSocket = tcpSocket;
        }
    }
}
