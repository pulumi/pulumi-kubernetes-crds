// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2
{

    [OutputType]
    public sealed class SearchHeadClusterSpecServiceTemplateSpecPorts
    {
        /// <summary>
        /// The name of this port within the service. This must be a DNS_LABEL. All ports within a ServiceSpec must have unique names. When considering the endpoints for a Service, this must match the 'name' field in the EndpointPort. Optional if only one ServicePort is defined on this service.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The port on each node on which this service is exposed when type=NodePort or LoadBalancer. Usually assigned by the system. If specified, it will be allocated to the service if unused or else creation of the service will fail. Default is to auto-allocate a port if the ServiceType of this Service requires one. More info: https://kubernetes.io/docs/concepts/services-networking/service/#type-nodeport
        /// </summary>
        public readonly int NodePort;
        /// <summary>
        /// The port that will be exposed by this service.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// The IP protocol for this port. Supports "TCP", "UDP", and "SCTP". Default is TCP.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// Number or name of the port to access on the pods targeted by the service. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME. If this is a string, it will be looked up as a named port in the target Pod's container ports. If this is not specified, the value of the 'port' field is used (an identity map). This field is ignored for services with clusterIP=None, and should be omitted or set equal to the 'port' field. More info: https://kubernetes.io/docs/concepts/services-networking/service/#defining-a-service
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.SearchHeadClusterSpecServiceTemplateSpecPortsTargetPort TargetPort;

        [OutputConstructor]
        private SearchHeadClusterSpecServiceTemplateSpecPorts(
            string name,

            int nodePort,

            int port,

            string protocol,

            Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2.SearchHeadClusterSpecServiceTemplateSpecPortsTargetPort targetPort)
        {
            Name = name;
            NodePort = nodePort;
            Port = port;
            Protocol = protocol;
            TargetPort = targetPort;
        }
    }
}
