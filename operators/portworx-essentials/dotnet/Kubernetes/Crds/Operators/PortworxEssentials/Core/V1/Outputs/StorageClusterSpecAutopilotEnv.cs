// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1
{

    [OutputType]
    public sealed class StorageClusterSpecAutopilotEnv
    {
        public readonly string Name;
        public readonly string Value;
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1.StorageClusterSpecAutopilotEnvValueFrom ValueFrom;

        [OutputConstructor]
        private StorageClusterSpecAutopilotEnv(
            string name,

            string value,

            Pulumi.Kubernetes.Types.Outputs.Core.V1.StorageClusterSpecAutopilotEnvValueFrom valueFrom)
        {
            Name = name;
            Value = value;
            ValueFrom = valueFrom;
        }
    }
}