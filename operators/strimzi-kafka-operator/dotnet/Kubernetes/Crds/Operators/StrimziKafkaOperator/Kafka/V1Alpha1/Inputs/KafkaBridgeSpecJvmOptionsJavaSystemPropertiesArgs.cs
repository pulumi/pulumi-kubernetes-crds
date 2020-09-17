// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Kafka.V1Alpha1
{

    public class KafkaBridgeSpecJvmOptionsJavaSystemPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The system property name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The system property value.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public KafkaBridgeSpecJvmOptionsJavaSystemPropertiesArgs()
        {
        }
    }
}
