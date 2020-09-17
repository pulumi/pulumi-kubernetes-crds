// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1Alpha1
{

    public class PrometheusExporterSpecResourcesLimitsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Override CPU limits (example 100m)
        /// </summary>
        [Input("cpu")]
        public Input<object>? Cpu { get; set; }

        /// <summary>
        /// Override Memory limits (example 256Mi)
        /// </summary>
        [Input("memory")]
        public Input<object>? Memory { get; set; }

        public PrometheusExporterSpecResourcesLimitsArgs()
        {
        }
    }
}
