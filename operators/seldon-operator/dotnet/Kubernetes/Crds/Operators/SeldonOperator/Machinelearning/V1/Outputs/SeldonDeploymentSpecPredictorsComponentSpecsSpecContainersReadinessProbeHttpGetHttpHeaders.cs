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
    public sealed class SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersReadinessProbeHttpGetHttpHeaders
    {
        /// <summary>
        /// The header field name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The header field value
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersReadinessProbeHttpGetHttpHeaders(
            string name,

            string value)
        {
            Name = name;
            Value = value;
        }
    }
}
