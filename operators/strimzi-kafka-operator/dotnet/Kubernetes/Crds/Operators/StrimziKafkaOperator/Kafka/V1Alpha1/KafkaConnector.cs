// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.StrimziKafkaOperator.Kafka.V1Alpha1
{
    public partial class KafkaConnector : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// The specification of the Kafka Connector.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaConnectorSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// The status of the Kafka Connector.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaConnectorStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a KafkaConnector resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KafkaConnector(string name, Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaConnectorArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:kafka.strimzi.io/v1alpha1:KafkaConnector", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal KafkaConnector(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:kafka.strimzi.io/v1alpha1:KafkaConnector", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private KafkaConnector(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:kafka.strimzi.io/v1alpha1:KafkaConnector", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaConnectorArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaConnectorArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaConnectorArgs();
            args.ApiVersion = "kafka.strimzi.io/v1alpha1";
            args.Kind = "KafkaConnector";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing KafkaConnector resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KafkaConnector Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new KafkaConnector(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1
{

    public class KafkaConnectorArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// The specification of the Kafka Connector.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaConnectorSpecArgs>? Spec { get; set; }

        /// <summary>
        /// The status of the Kafka Connector.
        /// </summary>
        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1.KafkaConnectorStatusArgs>? Status { get; set; }

        public KafkaConnectorArgs()
        {
        }
    }
}
