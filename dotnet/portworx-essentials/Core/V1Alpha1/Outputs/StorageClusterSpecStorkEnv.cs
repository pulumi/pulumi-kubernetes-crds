// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1
{

    [OutputType]
    public sealed class StorageClusterSpecStorkEnv
    {
        public readonly string Name;
        public readonly string Value;
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecStorkEnvValueFrom ValueFrom;

        [OutputConstructor]
        private StorageClusterSpecStorkEnv(
            string name,

            string value,

            Pulumi.Kubernetes.Types.Outputs.Core.V1Alpha1.StorageClusterSpecStorkEnvValueFrom valueFrom)
        {
            Name = name;
            Value = value;
            ValueFrom = valueFrom;
        }
    }
}
