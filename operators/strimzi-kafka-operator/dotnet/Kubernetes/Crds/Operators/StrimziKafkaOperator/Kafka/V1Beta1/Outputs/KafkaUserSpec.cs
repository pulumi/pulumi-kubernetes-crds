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
    public sealed class KafkaUserSpec
    {
        /// <summary>
        /// Authentication mechanism enabled for this Kafka user.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaUserSpecAuthentication Authentication;
        /// <summary>
        /// Authorization rules for this Kafka user.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaUserSpecAuthorization Authorization;
        /// <summary>
        /// Quotas on requests to control the broker resources used by clients. Network bandwidth and request rate quotas can be enforced.Kafka documentation for Kafka User quotas can be found at http://kafka.apache.org/documentation/#design_quotas.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaUserSpecQuotas Quotas;
        /// <summary>
        /// Template to specify how Kafka User `Secrets` are generated.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaUserSpecTemplate Template;

        [OutputConstructor]
        private KafkaUserSpec(
            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaUserSpecAuthentication authentication,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaUserSpecAuthorization authorization,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaUserSpecQuotas quotas,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaUserSpecTemplate template)
        {
            Authentication = authentication;
            Authorization = authorization;
            Quotas = quotas;
            Template = template;
        }
    }
}