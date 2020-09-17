// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Cache.V1Alpha1
{

    /// <summary>
    /// RedisClusterSpec specifies the desired state of a RedisCluster.
    /// </summary>
    public class RedisClusterSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A ClassReference specifies a resource class that will be used to dynamically provision a managed resource when the resource claim is created.
        /// </summary>
        [Input("classRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Cache.V1Alpha1.RedisClusterSpecClassRefArgs>? ClassRef { get; set; }

        /// <summary>
        /// A ClassSelector specifies labels that will be used to select a resource class for this claim. If multiple classes match the labels one will be chosen at random.
        /// </summary>
        [Input("classSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Cache.V1Alpha1.RedisClusterSpecClassSelectorArgs>? ClassSelector { get; set; }

        /// <summary>
        /// EngineVersion specifies the desired Redis version.
        /// </summary>
        [Input("engineVersion")]
        public Input<string>? EngineVersion { get; set; }

        /// <summary>
        /// A ResourceReference specifies an existing managed resource, in any namespace, to which this resource claim should attempt to bind. Omit the resource reference to enable dynamic provisioning using a resource class; the resource reference will be automatically populated by Crossplane.
        /// </summary>
        [Input("resourceRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Cache.V1Alpha1.RedisClusterSpecResourceRefArgs>? ResourceRef { get; set; }

        /// <summary>
        /// WriteConnectionSecretToReference specifies the name of a Secret, in the same namespace as this resource claim, to which any connection details for this resource claim should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource bound to this resource claim.
        /// </summary>
        [Input("writeConnectionSecretToRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Cache.V1Alpha1.RedisClusterSpecWriteConnectionSecretToRefArgs>? WriteConnectionSecretToRef { get; set; }

        public RedisClusterSpecArgs()
        {
        }
    }
}