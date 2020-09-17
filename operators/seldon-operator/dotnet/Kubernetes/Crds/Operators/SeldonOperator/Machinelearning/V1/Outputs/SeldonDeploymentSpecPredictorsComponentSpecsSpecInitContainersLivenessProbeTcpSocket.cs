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
    public sealed class SeldonDeploymentSpecPredictorsComponentSpecsSpecInitContainersLivenessProbeTcpSocket
    {
        /// <summary>
        /// Optional: Host name to connect to, defaults to the pod IP.
        /// </summary>
        public readonly string Host;
        /// <summary>
        /// Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
        /// </summary>
        public readonly Union<int, string> Port;

        [OutputConstructor]
        private SeldonDeploymentSpecPredictorsComponentSpecsSpecInitContainersLivenessProbeTcpSocket(
            string host,

            Union<int, string> port)
        {
            Host = host;
            Port = port;
        }
    }
}
