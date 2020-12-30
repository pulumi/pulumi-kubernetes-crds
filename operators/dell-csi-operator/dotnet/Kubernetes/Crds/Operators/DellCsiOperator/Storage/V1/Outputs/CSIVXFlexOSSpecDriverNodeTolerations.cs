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
    public sealed class CSIVXFlexOSSpecDriverNodeTolerations
    {
        /// <summary>
        /// Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
        /// </summary>
        public readonly string Effect;
        /// <summary>
        /// Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Operator represents a key's relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.
        /// </summary>
        public readonly int TolerationSeconds;
        /// <summary>
        /// Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular string.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private CSIVXFlexOSSpecDriverNodeTolerations(
            string effect,

            string key,

            string @operator,

            int tolerationSeconds,

            string value)
        {
            Effect = effect;
            Key = key;
            Operator = @operator;
            TolerationSeconds = tolerationSeconds;
            Value = value;
        }
    }
}
