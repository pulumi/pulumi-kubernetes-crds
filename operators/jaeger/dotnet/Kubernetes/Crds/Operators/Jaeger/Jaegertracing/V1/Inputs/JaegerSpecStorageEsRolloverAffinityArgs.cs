// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecStorageEsRolloverAffinityArgs : Pulumi.ResourceArgs
    {
        [Input("nodeAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverAffinityNodeAffinityArgs>? NodeAffinity { get; set; }

        [Input("podAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverAffinityPodAffinityArgs>? PodAffinity { get; set; }

        [Input("podAntiAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecStorageEsRolloverAffinityPodAntiAffinityArgs>? PodAntiAffinity { get; set; }

        public JaegerSpecStorageEsRolloverAffinityArgs()
        {
        }
    }
}
