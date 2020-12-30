// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1
{

    [OutputType]
    public sealed class EventhubSpecAuthorizationRule
    {
        /// <summary>
        /// Name - Name of AuthorizationRule for eventhub
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Rights - Rights set on the AuthorizationRule
        /// </summary>
        public readonly ImmutableArray<string> Rights;

        [OutputConstructor]
        private EventhubSpecAuthorizationRule(
            string name,

            ImmutableArray<string> rights)
        {
            Name = name;
            Rights = rights;
        }
    }
}