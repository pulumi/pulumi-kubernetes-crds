// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1
{

    [OutputType]
    public sealed class DatadogAgentSpecAgentConfigVolumesFlocker
    {
        /// <summary>
        /// Name of the dataset stored as metadata -&gt; name on the dataset for Flocker should be considered as deprecated
        /// </summary>
        public readonly string DatasetName;
        /// <summary>
        /// UUID of the dataset. This is unique identifier of a Flocker dataset
        /// </summary>
        public readonly string DatasetUUID;

        [OutputConstructor]
        private DatadogAgentSpecAgentConfigVolumesFlocker(
            string datasetName,

            string datasetUUID)
        {
            DatasetName = datasetName;
            DatasetUUID = datasetUUID;
        }
    }
}
