// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1
{

    [OutputType]
    public sealed class KafkaBridgeSpecJvmOptions
    {
        /// <summary>
        /// A map of -XX options to the JVM.
        /// </summary>
        public readonly ImmutableDictionary<string, object> -XX;
        /// <summary>
        /// -Xms option to to the JVM.
        /// </summary>
        public readonly string -Xms;
        /// <summary>
        /// -Xmx option to to the JVM.
        /// </summary>
        public readonly string -Xmx;
        /// <summary>
        /// Specifies whether the Garbage Collection logging is enabled. The default is false.
        /// </summary>
        public readonly bool GcLoggingEnabled;
        /// <summary>
        /// A map of additional system properties which will be passed using the `-D` option to the JVM.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecJvmOptionsJavaSystemProperties> JavaSystemProperties;

        [OutputConstructor]
        private KafkaBridgeSpecJvmOptions(
            ImmutableDictionary<string, object> -XX,

            string -Xms,

            string -Xmx,

            bool gcLoggingEnabled,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Alpha1.KafkaBridgeSpecJvmOptionsJavaSystemProperties> javaSystemProperties)
        {
            this.-XX = -XX;
            this.-Xms = -Xms;
            this.-Xmx = -Xmx;
            GcLoggingEnabled = gcLoggingEnabled;
            JavaSystemProperties = javaSystemProperties;
        }
    }
}
