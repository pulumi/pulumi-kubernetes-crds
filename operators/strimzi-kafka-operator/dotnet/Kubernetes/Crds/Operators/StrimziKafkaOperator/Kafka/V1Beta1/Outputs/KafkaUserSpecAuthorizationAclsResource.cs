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
    public sealed class KafkaUserSpecAuthorizationAclsResource
    {
        /// <summary>
        /// Name of resource for which given ACL rule applies. Can be combined with `patternType` field to use prefix pattern.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Describes the pattern used in the resource field. The supported types are `literal` and `prefix`. With `literal` pattern type, the resource field will be used as a definition of a full name. With `prefix` pattern type, the resource name will be used only as a prefix. Default value is `literal`.
        /// </summary>
        public readonly string PatternType;
        /// <summary>
        /// Resource type. The available resource types are `topic`, `group`, `cluster`, and `transactionalId`.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KafkaUserSpecAuthorizationAclsResource(
            string name,

            string patternType,

            string type)
        {
            Name = name;
            PatternType = patternType;
            Type = type;
        }
    }
}