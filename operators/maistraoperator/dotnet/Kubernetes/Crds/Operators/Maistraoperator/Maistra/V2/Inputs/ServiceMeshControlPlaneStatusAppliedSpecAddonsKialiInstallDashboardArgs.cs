// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecAddonsKialiInstallDashboardArgs : Pulumi.ResourceArgs
    {
        [Input("enableGrafana")]
        public Input<bool>? EnableGrafana { get; set; }

        [Input("enablePrometheus")]
        public Input<bool>? EnablePrometheus { get; set; }

        [Input("enableTracing")]
        public Input<bool>? EnableTracing { get; set; }

        [Input("viewOnly")]
        public Input<bool>? ViewOnly { get; set; }

        public ServiceMeshControlPlaneStatusAppliedSpecAddonsKialiInstallDashboardArgs()
        {
        }
    }
}
