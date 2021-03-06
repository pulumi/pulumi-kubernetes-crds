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
    /// ApmServerStatus defines the observed state of ApmServer
    /// </summary>
    public class ApmServerStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AvailableNodes is the number of available replicas in the deployment.
        /// </summary>
        [Input("availableNodes")]
        public Input<int>? AvailableNodes { get; set; }

        /// <summary>
        /// ElasticsearchAssociationStatus is the status of any auto-linking to Elasticsearch clusters.
        /// </summary>
        [Input("elasticsearchAssociationStatus")]
        public Input<string>? ElasticsearchAssociationStatus { get; set; }

        /// <summary>
        /// Health of the deployment.
        /// </summary>
        [Input("health")]
        public Input<string>? Health { get; set; }

        /// <summary>
        /// KibanaAssociationStatus is the status of any auto-linking to Kibana.
        /// </summary>
        [Input("kibanaAssociationStatus")]
        public Input<string>? KibanaAssociationStatus { get; set; }

        /// <summary>
        /// SecretTokenSecretName is the name of the Secret that contains the secret token
        /// </summary>
        [Input("secretTokenSecret")]
        public Input<string>? SecretTokenSecret { get; set; }

        /// <summary>
        /// ExternalService is the name of the service the agents should connect to.
        /// </summary>
        [Input("service")]
        public Input<string>? Service { get; set; }

        /// <summary>
        /// Version of the stack resource currently running. During version upgrades, multiple versions may run in parallel: this value specifies the lowest version currently running.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public ApmServerStatusArgs()
        {
        }
    }
}
