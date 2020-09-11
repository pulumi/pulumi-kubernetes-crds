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
    public sealed class StorageClusterSpecEnvValueFromFieldRef
    {
        public readonly string ApiVersion;
        public readonly string FieldPath;

        [OutputConstructor]
        private StorageClusterSpecEnvValueFromFieldRef(
            string apiVersion,

            string fieldPath)
        {
            ApiVersion = apiVersion;
            FieldPath = fieldPath;
        }
    }
}
