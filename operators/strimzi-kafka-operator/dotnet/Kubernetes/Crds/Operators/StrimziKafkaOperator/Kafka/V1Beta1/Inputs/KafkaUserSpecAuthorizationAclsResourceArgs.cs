// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1
{

    /// <summary>
    /// Indicates the resource for which given ACL rule applies.
    /// </summary>
    public class KafkaUserSpecAuthorizationAclsResourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of resource for which given ACL rule applies. Can be combined with `patternType` field to use prefix pattern.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Describes the pattern used in the resource field. The supported types are `literal` and `prefix`. With `literal` pattern type, the resource field will be used as a definition of a full name. With `prefix` pattern type, the resource name will be used only as a prefix. Default value is `literal`.
        /// </summary>
        [Input("patternType")]
        public Input<string>? PatternType { get; set; }

        /// <summary>
        /// Resource type. The available resource types are `topic`, `group`, `cluster`, and `transactionalId`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public KafkaUserSpecAuthorizationAclsResourceArgs()
        {
        }
    }
}