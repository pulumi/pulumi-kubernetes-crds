// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Storage.V1
{

    [OutputType]
    public sealed class CSIPowerStoreSpecDriverStorageClassAllowedTopologiesMatchLabelExpressions
    {
        /// <summary>
        /// The label key that the selector applies to.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// An array of string values. One value must match the label to be selected. Each entry in Values is ORed.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private CSIPowerStoreSpecDriverStorageClassAllowedTopologiesMatchLabelExpressions(
            string key,

            ImmutableArray<string> values)
        {
            Key = key;
            Values = values;
        }
    }
}