// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs : Pulumi.ResourceArgs
    {
        [Input("preference", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceArgs> Preference { get; set; } = null!;

        [Input("weight", required: true)]
        public Input<int> Weight { get; set; } = null!;

        public JaegerSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs()
        {
        }
    }
}
