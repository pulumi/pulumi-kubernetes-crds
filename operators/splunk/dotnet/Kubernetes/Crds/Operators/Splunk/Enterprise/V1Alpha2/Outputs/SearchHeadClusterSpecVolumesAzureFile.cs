// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enterprise.V1Alpha2
{

    [OutputType]
    public sealed class SearchHeadClusterSpecVolumesAzureFile
    {
        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// the name of secret that contains Azure Storage Account Name and Key
        /// </summary>
        public readonly string SecretName;
        /// <summary>
        /// Share Name
        /// </summary>
        public readonly string ShareName;

        [OutputConstructor]
        private SearchHeadClusterSpecVolumesAzureFile(
            bool readOnly,

            string secretName,

            string shareName)
        {
            ReadOnly = readOnly;
            SecretName = secretName;
            ShareName = shareName;
        }
    }
}
