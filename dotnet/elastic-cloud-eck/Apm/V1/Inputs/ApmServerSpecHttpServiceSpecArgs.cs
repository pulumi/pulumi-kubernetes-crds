// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apm.V1
{

    /// <summary>
    /// Spec is the specification of the service.
    /// </summary>
    public class ApmServerSpecHttpServiceSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// clusterIP is the IP address of the service and is usually assigned randomly by the master. If an address is specified manually and is not in use by others, it will be allocated to the service; otherwise, creation of the service will fail. This field can not be changed through updates. Valid values are "None", empty string (""), or a valid IP address. "None" can be specified for headless services when proxying is not required. Only applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if type is ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
        /// </summary>
        [Input("clusterIP")]
        public Input<string>? ClusterIP { get; set; }

        [Input("externalIPs")]
        private InputList<string>? _externalIPs;

        /// <summary>
        /// externalIPs is a list of IP addresses for which nodes in the cluster will also accept traffic for this service.  These IPs are not managed by Kubernetes.  The user is responsible for ensuring that traffic arrives at a node with this IP.  A common example is external load-balancers that are not part of the Kubernetes system.
        /// </summary>
        public InputList<string> ExternalIPs
        {
            get => _externalIPs ?? (_externalIPs = new InputList<string>());
            set => _externalIPs = value;
        }

        /// <summary>
        /// externalName is the external reference that kubedns or equivalent will return as a CNAME record for this service. No proxying will be involved. Must be a valid RFC-1123 hostname (https://tools.ietf.org/html/rfc1123) and requires Type to be ExternalName.
        /// </summary>
        [Input("externalName")]
        public Input<string>? ExternalName { get; set; }

        /// <summary>
        /// externalTrafficPolicy denotes if this Service desires to route external traffic to node-local or cluster-wide endpoints. "Local" preserves the client source IP and avoids a second hop for LoadBalancer and Nodeport type services, but risks potentially imbalanced traffic spreading. "Cluster" obscures the client source IP and may cause a second hop to another node, but should have good overall load-spreading.
        /// </summary>
        [Input("externalTrafficPolicy")]
        public Input<string>? ExternalTrafficPolicy { get; set; }

        /// <summary>
        /// healthCheckNodePort specifies the healthcheck nodePort for the service. If not specified, HealthCheckNodePort is created by the service api backend with the allocated nodePort. Will use user-specified nodePort value if specified by the client. Only effects when Type is set to LoadBalancer and ExternalTrafficPolicy is set to Local.
        /// </summary>
        [Input("healthCheckNodePort")]
        public Input<int>? HealthCheckNodePort { get; set; }

        /// <summary>
        /// ipFamily specifies whether this Service has a preference for a particular IP family (e.g. IPv4 vs. IPv6).  If a specific IP family is requested, the clusterIP field will be allocated from that family, if it is available in the cluster.  If no IP family is requested, the cluster's primary IP family will be used. Other IP fields (loadBalancerIP, loadBalancerSourceRanges, externalIPs) and controllers which allocate external load-balancers should use the same IP family.  Endpoints for this Service will be of this family.  This field is immutable after creation. Assigning a ServiceIPFamily not available in the cluster (e.g. IPv6 in IPv4 only cluster) is an error condition and will fail during clusterIP assignment.
        /// </summary>
        [Input("ipFamily")]
        public Input<string>? IpFamily { get; set; }

        /// <summary>
        /// Only applies to Service Type: LoadBalancer LoadBalancer will get created with the IP specified in this field. This feature depends on whether the underlying cloud-provider supports specifying the loadBalancerIP when a load balancer is created. This field will be ignored if the cloud-provider does not support the feature.
        /// </summary>
        [Input("loadBalancerIP")]
        public Input<string>? LoadBalancerIP { get; set; }

        [Input("loadBalancerSourceRanges")]
        private InputList<string>? _loadBalancerSourceRanges;

        /// <summary>
        /// If specified and supported by the platform, this will restrict traffic through the cloud-provider load-balancer will be restricted to the specified client IPs. This field will be ignored if the cloud-provider does not support the feature." More info: https://kubernetes.io/docs/tasks/access-application-cluster/configure-cloud-provider-firewall/
        /// </summary>
        public InputList<string> LoadBalancerSourceRanges
        {
            get => _loadBalancerSourceRanges ?? (_loadBalancerSourceRanges = new InputList<string>());
            set => _loadBalancerSourceRanges = value;
        }

        [Input("ports")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apm.V1.ApmServerSpecHttpServiceSpecPortsArgs>? _ports;

        /// <summary>
        /// The list of ports that are exposed by this service. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apm.V1.ApmServerSpecHttpServiceSpecPortsArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Pulumi.Kubernetes.Types.Inputs.Apm.V1.ApmServerSpecHttpServiceSpecPortsArgs>());
            set => _ports = value;
        }

        /// <summary>
        /// publishNotReadyAddresses, when set to true, indicates that DNS implementations must publish the notReadyAddresses of subsets for the Endpoints associated with the Service. The default value is false. The primary use case for setting this field is to use a StatefulSet's Headless Service to propagate SRV records for its Pods without respect to their readiness for purpose of peer discovery.
        /// </summary>
        [Input("publishNotReadyAddresses")]
        public Input<bool>? PublishNotReadyAddresses { get; set; }

        [Input("selector")]
        private InputMap<string>? _selector;

        /// <summary>
        /// Route service traffic to pods with label keys and values matching this selector. If empty or not present, the service is assumed to have an external process managing its endpoints, which Kubernetes will not modify. Only applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if type is ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/
        /// </summary>
        public InputMap<string> Selector
        {
            get => _selector ?? (_selector = new InputMap<string>());
            set => _selector = value;
        }

        /// <summary>
        /// Supports "ClientIP" and "None". Used to maintain session affinity. Enable client IP based session affinity. Must be ClientIP or None. Defaults to None. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
        /// </summary>
        [Input("sessionAffinity")]
        public Input<string>? SessionAffinity { get; set; }

        /// <summary>
        /// sessionAffinityConfig contains the configurations of session affinity.
        /// </summary>
        [Input("sessionAffinityConfig")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apm.V1.ApmServerSpecHttpServiceSpecSessionAffinityConfigArgs>? SessionAffinityConfig { get; set; }

        [Input("topologyKeys")]
        private InputList<string>? _topologyKeys;

        /// <summary>
        /// topologyKeys is a preference-order list of topology keys which implementations of services should use to preferentially sort endpoints when accessing this Service, it can not be used at the same time as externalTrafficPolicy=Local. Topology keys must be valid label keys and at most 16 keys may be specified. Endpoints are chosen based on the first topology key with available backends. If this field is specified and all entries have no backends that match the topology of the client, the service has no backends for that client and connections should fail. The special value "*" may be used to mean "any topology". This catch-all value, if used, only makes sense as the last value in the list. If this is not specified or empty, no topology constraints will be applied.
        /// </summary>
        public InputList<string> TopologyKeys
        {
            get => _topologyKeys ?? (_topologyKeys = new InputList<string>());
            set => _topologyKeys = value;
        }

        /// <summary>
        /// type determines how the Service is exposed. Defaults to ClusterIP. Valid options are ExternalName, ClusterIP, NodePort, and LoadBalancer. "ExternalName" maps to the specified externalName. "ClusterIP" allocates a cluster-internal IP address for load-balancing to endpoints. Endpoints are determined by the selector or if that is not specified, by manual construction of an Endpoints object. If clusterIP is "None", no virtual IP is allocated and the endpoints are published as a set of endpoints rather than a stable IP. "NodePort" builds on ClusterIP and allocates a port on every node which routes to the clusterIP. "LoadBalancer" builds on NodePort and creates an external load-balancer (if supported in the current cloud) which routes to the clusterIP. More info: https://kubernetes.io/docs/concepts/services-networking/service/#publishing-services-service-types
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public ApmServerSpecHttpServiceSpecArgs()
        {
        }
    }
}
