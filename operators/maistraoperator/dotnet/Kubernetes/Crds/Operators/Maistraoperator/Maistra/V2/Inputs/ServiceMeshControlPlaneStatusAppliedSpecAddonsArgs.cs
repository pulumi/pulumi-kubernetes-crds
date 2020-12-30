// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecAddonsArgs : Pulumi.ResourceArgs
    {
        [Input("3scale")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddons3scaleArgs>? 3scale { get; set; }

        [Input("grafana")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsGrafanaArgs>? Grafana { get; set; }

        [Input("jaeger")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsJaegerArgs>? Jaeger { get; set; }

        [Input("kiali")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsKialiArgs>? Kiali { get; set; }

        [Input("prometheus")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsPrometheusArgs>? Prometheus { get; set; }

        [Input("stackdriver")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsStackdriverArgs>? Stackdriver { get; set; }

        public ServiceMeshControlPlaneStatusAppliedSpecAddonsArgs()
        {
        }
    }
}
