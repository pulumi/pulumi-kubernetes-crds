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
    /// JVM Options for pods.
    /// </summary>
    public class KafkaSpecKafkaJvmOptionsArgs : Pulumi.ResourceArgs
    {
        [Input("-XX")]
        private InputMap<object>? _-XX;

        /// <summary>
        /// A map of -XX options to the JVM.
        /// </summary>
        public InputMap<object> -XX
        {
            get => _-XX ?? (_-XX = new InputMap<object>());
            set => _-XX = value;
        }

        /// <summary>
        /// -Xms option to to the JVM.
        /// </summary>
        [Input("-Xms")]
        public Input<string>? -Xms { get; set; }

        /// <summary>
        /// -Xmx option to to the JVM.
        /// </summary>
        [Input("-Xmx")]
        public Input<string>? -Xmx { get; set; }

        /// <summary>
        /// Specifies whether the Garbage Collection logging is enabled. The default is false.
        /// </summary>
        [Input("gcLoggingEnabled")]
        public Input<bool>? GcLoggingEnabled { get; set; }

        [Input("javaSystemProperties")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaJvmOptionsJavaSystemPropertiesArgs>? _javaSystemProperties;

        /// <summary>
        /// A map of additional system properties which will be passed using the `-D` option to the JVM.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaJvmOptionsJavaSystemPropertiesArgs> JavaSystemProperties
        {
            get => _javaSystemProperties ?? (_javaSystemProperties = new InputList<Pulumi.Kubernetes.Types.Inputs.Kafka.V1Beta1.KafkaSpecKafkaJvmOptionsJavaSystemPropertiesArgs>());
            set => _javaSystemProperties = value;
        }

        public KafkaSpecKafkaJvmOptionsArgs()
        {
        }
    }
}
