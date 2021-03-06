// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1Alpha1
{

    [OutputType]
    public sealed class PrometheusExporterSpecExtraLabel
    {
        /// <summary>
        /// Add extra label key to all created resources (example tier)
        /// </summary>
        public readonly string Key;

        [OutputConstructor]
        private PrometheusExporterSpecExtraLabel(string key)
        {
            Key = key;
        }
    }
}
