// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1
{

    public class JaegerSpecIngesterAffinityPodAffinityArgs : Pulumi.ResourceArgs
    {
        [Input("preferredDuringSchedulingIgnoredDuringExecution")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecIngesterAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs>? _preferredDuringSchedulingIgnoredDuringExecution;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecIngesterAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs> PreferredDuringSchedulingIgnoredDuringExecution
        {
            get => _preferredDuringSchedulingIgnoredDuringExecution ?? (_preferredDuringSchedulingIgnoredDuringExecution = new InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecIngesterAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs>());
            set => _preferredDuringSchedulingIgnoredDuringExecution = value;
        }

        [Input("requiredDuringSchedulingIgnoredDuringExecution")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecIngesterAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionArgs>? _requiredDuringSchedulingIgnoredDuringExecution;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecIngesterAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionArgs> RequiredDuringSchedulingIgnoredDuringExecution
        {
            get => _requiredDuringSchedulingIgnoredDuringExecution ?? (_requiredDuringSchedulingIgnoredDuringExecution = new InputList<Pulumi.Kubernetes.Types.Inputs.Jaegertracing.V1.JaegerSpecIngesterAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionArgs>());
            set => _requiredDuringSchedulingIgnoredDuringExecution = value;
        }

        public JaegerSpecIngesterAffinityPodAffinityArgs()
        {
        }
    }
}