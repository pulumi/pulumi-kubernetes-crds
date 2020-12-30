// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Maistra.V2
{

    [OutputType]
    public sealed class ServiceMeshControlPlaneStatus
    {
        public readonly ImmutableDictionary<string, string> Annotations;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpec AppliedSpec;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedValues AppliedValues;
        public readonly string ChartVersion;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusComponents> Components;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusConditions> Conditions;
        public readonly int ObservedGeneration;
        public readonly string OperatorVersion;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusReadiness Readiness;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatus(
            ImmutableDictionary<string, string> annotations,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpec appliedSpec,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedValues appliedValues,

            string chartVersion,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusComponents> components,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusConditions> conditions,

            int observedGeneration,

            string operatorVersion,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusReadiness readiness)
        {
            Annotations = annotations;
            AppliedSpec = appliedSpec;
            AppliedValues = appliedValues;
            ChartVersion = chartVersion;
            Components = components;
            Conditions = conditions;
            ObservedGeneration = observedGeneration;
            OperatorVersion = operatorVersion;
            Readiness = readiness;
        }
    }
}
