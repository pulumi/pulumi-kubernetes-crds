// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1
{

    [OutputType]
    public sealed class TargetEndpointSpec
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.TargetEndpointSpecDeploy Deploy;
        public readonly string EndpointName;
        public readonly Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.TargetEndpointSpecEndpointSecurity EndpointSecurity;
        public readonly string Hostname;
        public readonly string Mode;
        public readonly int Port;
        public readonly string Protocol;
        public readonly int TargetPort;
        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book.kubebuilder.io/beyond_basics/generating_crd.html
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private TargetEndpointSpec(
            Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.TargetEndpointSpecDeploy deploy,

            string endpointName,

            Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.TargetEndpointSpecEndpointSecurity endpointSecurity,

            string hostname,

            string mode,

            int port,

            string protocol,

            int targetPort,

            string type)
        {
            Deploy = deploy;
            EndpointName = endpointName;
            EndpointSecurity = endpointSecurity;
            Hostname = hostname;
            Mode = mode;
            Port = port;
            Protocol = protocol;
            TargetPort = targetPort;
            Type = type;
        }
    }
}
