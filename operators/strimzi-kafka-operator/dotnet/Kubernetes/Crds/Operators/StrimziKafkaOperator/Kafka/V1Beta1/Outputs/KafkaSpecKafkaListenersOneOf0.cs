// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1
{

    [OutputType]
    public sealed class KafkaSpecKafkaListenersOneOf0
    {
        /// <summary>
        /// Authentication configuration for this listener.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf0Authentication Authentication;
        /// <summary>
        /// Additional listener configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf0Configuration Configuration;
        /// <summary>
        /// Name of the listener. The name will be used to identify the listener and the related Kubernetes objects. The name has to be unique within given a Kafka cluster. The name can consist of lowercase characters and numbers and be up to 11 characters long.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// List of peers which should be able to connect to this listener. Peers in this list are combined using a logical OR operation. If this field is empty or missing, all connections will be allowed for this listener. If this field is present and contains at least one item, the listener only allows the traffic which matches at least one item in this list.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf0NetworkPolicyPeers> NetworkPolicyPeers;
        /// <summary>
        /// Port number used by the listener inside Kafka. The port number has to be unique within a given Kafka cluster. Allowed port numbers are 9092 and higher with the exception of ports 9404 and 9999, which are already used for Prometheus and JMX. Depending on the listener type, the port number might not be the same as the port number that connects Kafka clients.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// Enables TLS encryption on the listener. This is a required property.
        /// </summary>
        public readonly bool Tls;
        /// <summary>
        /// Type of the listener. Currently the supported types are `internal`, `route`, `loadbalancer`, `nodeport` and `ingress`. 
        /// 
        /// * `internal` type exposes Kafka internally only within the Kubernetes cluster.
        /// * `route` type uses OpenShift Routes to expose Kafka.
        /// * `loadbalancer` type uses LoadBalancer type services to expose Kafka.
        /// * `nodeport` type uses NodePort type services to expose Kafka.
        /// * `ingress` type uses Kubernetes Nginx Ingress to expose Kafka.
        /// .
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KafkaSpecKafkaListenersOneOf0(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf0Authentication authentication,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf0Configuration configuration,

            string name,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaListenersOneOf0NetworkPolicyPeers> networkPolicyPeers,

            int port,

            bool tls,

            string type)
        {
            Authentication = authentication;
            Configuration = configuration;
            Name = name;
            NetworkPolicyPeers = networkPolicyPeers;
            Port = port;
            Tls = tls;
            Type = type;
        }
    }
}
