// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1
{

    public class SeldonDeploymentSpecPredictorsComponentSpecsHpaSpecArgs : Pulumi.ResourceArgs
    {
        [Input("maxReplicas", required: true)]
        public Input<int> MaxReplicas { get; set; } = null!;

        [Input("metrics")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsHpaSpecMetricsArgs>? _metrics;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsHpaSpecMetricsArgs> Metrics
        {
            get => _metrics ?? (_metrics = new InputList<Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecsHpaSpecMetricsArgs>());
            set => _metrics = value;
        }

        [Input("minReplicas")]
        public Input<int>? MinReplicas { get; set; }

        public SeldonDeploymentSpecPredictorsComponentSpecsHpaSpecArgs()
        {
        }
    }
}
