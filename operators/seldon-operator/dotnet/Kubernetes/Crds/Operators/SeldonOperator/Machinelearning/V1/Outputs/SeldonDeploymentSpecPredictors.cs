// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1
{

    [OutputType]
    public sealed class SeldonDeploymentSpecPredictors
    {
        public readonly ImmutableDictionary<string, string> Annotations;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecs> ComponentSpecs;
        /// <summary>
        /// ResourceRequirements describes the compute resource requirements.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsEngineResources EngineResources;
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsExplainer Explainer;
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsGraph Graph;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly int Replicas;
        public readonly bool Shadow;
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsSsl Ssl;
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsSvcOrchSpec SvcOrchSpec;
        public readonly int Traffic;

        [OutputConstructor]
        private SeldonDeploymentSpecPredictors(
            ImmutableDictionary<string, string> annotations,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsComponentSpecs> componentSpecs,

            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsEngineResources engineResources,

            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsExplainer explainer,

            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsGraph graph,

            ImmutableDictionary<string, string> labels,

            string name,

            int replicas,

            bool shadow,

            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsSsl ssl,

            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsSvcOrchSpec svcOrchSpec,

            int traffic)
        {
            Annotations = annotations;
            ComponentSpecs = componentSpecs;
            EngineResources = engineResources;
            Explainer = explainer;
            Graph = graph;
            Labels = labels;
            Name = name;
            Replicas = replicas;
            Shadow = shadow;
            Ssl = ssl;
            SvcOrchSpec = svcOrchSpec;
            Traffic = traffic;
        }
    }
}
